import { Component, OnInit } from '@angular/core';
import {Note} from "../models/note.model";
import {DatabaseService} from "../services/database.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-boardpage',
  templateUrl: './boardpage.component.html',
  styleUrls: ['./boardpage.component.css']
})
export class BoardpageComponent implements OnInit {
  notes: Note[] = [];
  constructor(private database: DatabaseService,
              private router: Router) {

  }

  ngOnInit(): void {
    this.database.selectAll()
      .then((data)=>{
        this.notes = data;
      })
      .catch(err=>{
        console.error(err);
      });
  }

  btnModify_click(note){
    this.router.navigate(['modify/' + note.id]);
  }

  btnDelete_click(note){
    this.database.delete(note, ()=>{
      alert("Note deleted");
    });
    this.ngOnInit();
  }
}
