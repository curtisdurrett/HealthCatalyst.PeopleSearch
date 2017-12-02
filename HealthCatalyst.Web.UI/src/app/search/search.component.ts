import { Component, OnInit } from "@angular/core";
import { FormControl, FormGroup } from "@angular/forms";
import { Observable, Subject } from "rxjs/Rx";

import { Person } from './model/Person';
import { SearchService } from "./search.service";

@Component({
  selector: "app-search",
  templateUrl: "./search.component.html",
  styleUrls: ["./search.component.css"]
})
export class SearchComponent {
  searchForm = new FormGroup({
    searchTerm: new FormControl()
  });

  public people = Array<Person>();

  public searchStream$: Observable<any> = new Subject<any>();

  constructor(private searchService: SearchService) {
    this.searchStream$.subscribe(v => {
      this.searchName();
    });
  }

  public searchName() {
    const formModel = this.searchForm.value;
    // clear prior to reloading search results
    this.people = null;

    // Get new results
    this.searchService
      .getPeopleByName(formModel.searchTerm)
      .subscribe(people => {
        this.people = people;
      });
  }
}
