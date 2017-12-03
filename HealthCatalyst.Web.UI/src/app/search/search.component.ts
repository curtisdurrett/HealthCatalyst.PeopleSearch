import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observable, Subject } from 'rxjs/Rx';

import { PersonResult } from './model/PersonResult';
import { SearchService } from './search.service';
// TODO: Move TestService config
// import { TestSearchService } from './testSearch.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  public isBusy = false;
  public searchForm = new FormGroup({
    searchTerm: new FormControl()
  });
  public people = Array<PersonResult>();
  public searchStream$: Observable<any> = new Subject<any>();

  constructor(private searchService: SearchService) {
    this.searchStream$.subscribe(v => {
      this.searchName();
    });
  }

  public searchName() {
    this.isBusy = true;
    const formModel = this.searchForm.value;
    // clear prior to reloading search results
    this.people = null;

    // Get new results
    this.searchService
      .getPeopleByName(formModel.searchTerm)
      .subscribe(people => {
        this.people = people;
        this.isBusy = false;
      });
  }
}
