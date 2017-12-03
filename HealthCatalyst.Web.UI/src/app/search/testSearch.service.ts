import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { of } from 'rxjs/observable/of';
import 'rxjs/add/operator/delay';
import 'rxjs/add/operator/map';
import { isNull } from 'util';

import { createTestPersons } from './testPersonsData';

@Injectable()
export class TestSearchService {
  private _millisecondToDelay = 1000;

  constructor() {}

  public getPeopleByName(searchString: string): Observable<any> {
    return of(createTestPersons()).delay(this._millisecondToDelay);
  }
}
