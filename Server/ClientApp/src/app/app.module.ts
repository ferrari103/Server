import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import {CreateEventComponent} from "./create-event/create-event.component";
import {CalendarComponent, ChunkPipe} from "./calendar/calendar.component";
import {NavMenuComponent} from "./nav-menu/nav-menu.component";



@NgModule({
  declarations: [
    AppComponent,
    CreateEventComponent,
    CalendarComponent,
    ChunkPipe,
    NavMenuComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule,
    RouterModule.forRoot([
      {path:'', component: CalendarComponent, pathMatch: 'full'},
      {path:'create-event', component:CreateEventComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
