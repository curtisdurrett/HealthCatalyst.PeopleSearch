import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import { of } from 'rxjs/observable/of';
import 'rxjs/add/operator/delay';
import 'rxjs/add/operator/map';
import { isNull } from 'util';

@Injectable()
export class SearchService {
  private _millisecondToDelay = 1000;
  private _options: RequestOptions = null;
  // TODO: Move this value to config
  private _personSearchByNameUrl = `http://localhost:5000/api/v1/person/searchByName/`;

  constructor(private _http: Http) {}

  public getPeopleByName(searchString: string): Observable<any> {
    const options = this.createAuthorizationHeader();
    return this._http
      .get(this._personSearchByNameUrl + `${searchString}`, options)
      .map((res: any) => res.json())
      .delay(this._millisecondToDelay);
  }

  private createAuthorizationHeader(): RequestOptions {
    // Just checking is this._options is null using lodash
    if (isNull(this._options)) {
      const headers = new Headers();
      headers.append('Content-Type', 'application/json; charset=utf-8');
      this._options = new RequestOptions({ headers: headers });
    }
    return this._options;
  }
}
