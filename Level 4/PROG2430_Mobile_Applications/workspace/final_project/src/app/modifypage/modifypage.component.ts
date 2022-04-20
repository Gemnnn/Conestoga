import { Component, OnInit } from '@angular/core';
import {Note} from "../models/note.model";
import {ActivatedRoute} from "@angular/router";
import {DatabaseService} from "../services/database.service";
import {FormBuilder, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'app-modifypage',
  templateUrl: './modifypage.component.html',
  styleUrls: ['./modifypage.component.css']
})
export class ModifypageComponent implements OnInit {
  modifyForm: FormGroup;
  note: Note = new Note();

  constructor(private activatedRoute: ActivatedRoute,
              private database: DatabaseService,
              private builder : FormBuilder

  ) { }

  ngOnInit(): void {
    let id : number = Number(this.activatedRoute.snapshot.paramMap.get('id'));

    this.database.select(id)
      .then((data)=>{
        this.note = data;
      })
      .catch(()=>{});
    this.modifyForm = this.builder.group({
      _name: ['', [ Validators.required, Validators.minLength(1), Validators.maxLength(20)]],
      _content: ['', [Validators.required, Validators.maxLength(200)]]
    });
  }

  btnUpdate_click(){
    if(this.note.name === undefined || this.note.content === undefined || this.note.name === "" || this.note.content === ""){
      alert("Invalid input")
      return;
    }
    console.log(this.note);
    this.database.update(this.note, ()=>{
      alert("note updated successfully");
    });
  }
}
