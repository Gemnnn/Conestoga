import { Component, OnInit } from '@angular/core';
import {Note} from "../models/note.model";
import {DatabaseService} from "../services/database.service";
import {FormBuilder, FormGroup, Validators} from "@angular/forms";



@Component({
  selector: 'app-addpage',
  templateUrl: './addpage.component.html',
  styleUrls: ['./addpage.component.css']
})

export class AddpageComponent implements OnInit {
  addForm: FormGroup;
  submitted = false;
  note: Note = new Note();
  constructor(private database: DatabaseService,
              private builder : FormBuilder) { }


  ngOnInit(): void {
    this.addForm = this.builder.group({
      _name: ['', [ Validators.required, Validators.minLength(1), Validators.maxLength(20)]],
      _content: ['', [Validators.required, Validators.maxLength(200)]]
    });
  }



  btnAdd_click(){
    if(this.note.name === undefined || this.note.content === undefined || this.note.name === "" || this.note.content === ""){
      alert("Invalid input")
      return;
    }
    this.database.insert(this.note, ()=>{
      console.log("Note added successfully");
      alert("Note added successfully");
    });
  }
}
