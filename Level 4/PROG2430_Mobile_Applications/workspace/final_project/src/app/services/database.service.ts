import { Injectable } from '@angular/core';
import {Note} from "../models/note.model";

declare function openDatabase (shortName, version, displayName, dbSize, dbCreateSuccess): any;

@Injectable({
  providedIn: 'root'
})
export class DatabaseService {

  private db: any =null;

  constructor() {

  }

  private static errorHandler(error) : any{
    console.error("Error: " + error);
  }

  private createDatabase(): void{
    let shortName = "BoardDB";
    let version = "1.0";
    let displayName = "DB for MINBU Board App";
    let dbSize = 2 * 1024 * 1024;

    this.db = openDatabase(shortName, version, displayName, dbSize, ()=>{
      console.log("Success: Database created successfully");
    } );
  }

  private createTables(): void{

    function txFunction(tx: any): void{
      var sql: string = "CREATE TABLE IF NOT EXISTS notes(" +
        " id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
        " name VARCHAR(20) NOT NULL," +
        " content VARCHAR(200));";
      var options = [];

      tx.executeSql(sql, options, ()=>{
        console.info("Success: create notes table successful");
      }, DatabaseService.errorHandler);

      var sql: string = "CREATE TABLE IF NOT EXISTS country( " +
        "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
        "name VARCHAR(20) NOT NULL);";
      var options = [];

      tx.executeSql(sql, options, ()=>{
        console.info("Success: create country table successful");
      }, DatabaseService.errorHandler);
    }

    this.getDatabase().transaction(txFunction, DatabaseService.errorHandler, ()=>{
      console.log("Success: Table creation transaction successful");
    });
  }

  public initDB() : void{
    if (this.db == null){
      try{
        //create database
        this.createDatabase();
        //create tables
        this.createTables();
      }
      catch (e){
        console.error("Error in initDB(): " + e);
      }
    }
  }

  getDatabase(): any{
    this.initDB();
    return this.db;
  }

  //crud operations
  public insert(note: Note, callback){
    function txFunction(tx: any){
      var sql: string = "INSERT INTO notes(name, content) VALUES(?,?);";
      var options = [note.name, note.content];

      tx.executeSql (sql, options, callback, DatabaseService.errorHandler);
    }

    this.getDatabase().transaction(txFunction, DatabaseService.errorHandler, ()=>{
      console.log("Success: insert transaction successful");
    });
  }

  public selectAll(): Promise<any>{
    let options = [];
    let notes : Note[] = [];

    return new Promise((resolve,reject)=>{

      function txFunction(tx){
        var sql = "SELECT * FROM notes;";
        tx.executeSql(sql, options, (tx, results)=>{
          if (results.rows.length > 0){
            for(let i=0; i< results.rows.length; i++){
              let row = results.rows[i];
              let b = new Note(row['name'], row['content']);
              b.id = row['id']
              notes.push(b);
            }
            resolve(notes);
          }
          else {
            reject("No notes found");
          }
        }, DatabaseService.errorHandler);
      }

      this.getDatabase().transaction(txFunction, DatabaseService.errorHandler, ()=>{
        console.log("Success: selectAll transaction successful");
      });
    });
  }

  public delete(note: Note, callback){
    function txFunction(tx:any){
      var sql: string = 'DELETE FROM notes WHERE id=?;';
      var options = [note.id];
      tx.executeSql(sql, options, callback, DatabaseService.errorHandler);
    }
    this.getDatabase().transaction(txFunction, DatabaseService.errorHandler, ()=>{
      console.log('Success: delete transaction successful');
    });
  }

  public update(note: Note, callback){
    function txFunction(tx:any){
      var sql: string = 'UPDATE notes SET name=?, content=? WHERE id=?;';
      var options = [note.name, note.content, note.id];
      tx.executeSql(sql, options, callback, DatabaseService.errorHandler);
    }
    this.getDatabase().transaction(txFunction, DatabaseService.errorHandler, ()=>{
      console.log('Success: update transaction successful');
    });
  }

  public select(id: number): Promise<any>{
    let options = [id];
    let note : Note[] = null;

    return new Promise((resolve,reject)=>{

      function txFunction(tx){
        let sql = "SELECT * FROM notes WHERE id=?;";
        tx.executeSql(sql, options, (tx, results)=>{
          if (results.rows.length > 0){
            // for(let i=0; i< results.rows.length; i++){
            let row = results.rows[0];
            let note = new Note(row['name'], row['content']);
            note.id = row['id']
            // note.push(b);
            // }
            resolve(note);
          }
          else {
            reject("No notes found");
          }
        }, DatabaseService.errorHandler);
      }

      this.getDatabase().transaction(txFunction, DatabaseService.errorHandler, ()=>{
        console.log("Success: select transaction successful");
      });
    });
  }

  private dropTables(): void{

    function txFunction(tx: any): void{
      var sql: string = "DROP TABLE IF EXISTS notes;";
      var options = [];

      tx.executeSql(sql, options, ()=>{
        console.info("Success: drop notes table successful");
      }, DatabaseService.errorHandler);

      var sql: string = "DROP TABLE IF EXISTS country;";
      var options = [];

      tx.executeSql(sql, options, ()=>{
        console.info("Success: drop country table successful");
      }, DatabaseService.errorHandler);
    }


    this.getDatabase().transaction(txFunction, DatabaseService.errorHandler, ()=>{
      console.log("Success: Table drop transaction successful");
    });
  }

  public clearDB(): void{
    let result = confirm("Do you really want to clear database?");
    if (result) {
      this.dropTables();
      this.db = null;
      alert("Database cleared");
    }
  }
}
