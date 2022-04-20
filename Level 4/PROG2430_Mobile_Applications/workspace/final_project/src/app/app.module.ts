import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomepageComponent } from './homepage/homepage.component';
import { NavComponent } from './nav/nav.component';
import { BoardpageComponent } from './boardpage/boardpage.component';
import { AddpageComponent } from './addpage/addpage.component';
import { ModifypageComponent } from './modifypage/modifypage.component';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import { AboutpageComponent } from './aboutpage/aboutpage.component';

@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent,
    NavComponent,
    BoardpageComponent,
    AddpageComponent,
    ModifypageComponent,
    AboutpageComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
