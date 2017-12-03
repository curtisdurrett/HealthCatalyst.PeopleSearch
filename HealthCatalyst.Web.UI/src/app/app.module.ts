import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { Injectable } from '@angular/core';
import { Http, HttpModule } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';

import { AppComponent } from './app.component';
import { SearchComponent } from './search/search.component';
import { SearchService } from './search/search.service';
import { HeaderComponent } from './layout/header.component';

@NgModule({
  declarations: [
    AppComponent,
    SearchComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    ReactiveFormsModule
  ],
  providers: [SearchService],
  bootstrap: [AppComponent]
})
export class AppModule { }
