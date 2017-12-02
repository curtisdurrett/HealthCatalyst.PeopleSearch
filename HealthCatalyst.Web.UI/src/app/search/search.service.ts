import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import { of } from 'rxjs/observable/of';
import 'rxjs/add/operator/delay';
import 'rxjs/add/operator/map';

import { Person } from './model/Person';
import { createTestPersons } from './testPersonsData';

@Injectable()
export class SearchService {
  private millisecondToDelay = 1000;

  constructor(private _http: Http) {}

  getPeopleByName(searchString: string): Observable<any> {
    return of(createTestPersons()).delay(this.millisecondToDelay);
  }
}
