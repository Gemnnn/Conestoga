import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {HomepageComponent} from "./homepage/homepage.component";
import {BoardpageComponent} from "./boardpage/boardpage.component";
import {AddpageComponent} from "./addpage/addpage.component";
import {ModifypageComponent} from "./modifypage/modifypage.component";
import {AboutpageComponent} from "./aboutpage/aboutpage.component";

const routes: Routes = [
  {path:'', component: HomepageComponent},
  {path:'home', component: HomepageComponent},
  {path:'board', component: BoardpageComponent},
  {path:'add', component: AddpageComponent},
  {path:'modify/:id', component: ModifypageComponent},
  {path:'about', component: AboutpageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
