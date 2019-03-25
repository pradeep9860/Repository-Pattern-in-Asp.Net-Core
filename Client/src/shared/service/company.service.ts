import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { map } from "rxjs/operators";

import { Observable } from "rxjs";
import {
  appCompany_GetAllUrl,
  appCompany_CheckCompany,
  appCompany_SaveUrl
} from "../helpers/url-helpers";
import { APP_CONFIG } from "./app-config.service";

@Injectable()
export class CompanyService {
  constructor(private http: HttpClient) {}

  getAll(): Observable<any[]> {
    let baseUrl = APP_CONFIG.apiBaseUrl;
    let url = `${baseUrl}${appCompany_GetAllUrl}`;
    url = url.replace(/[?&]$/, "");

    return this.http.get<any[]>(url).pipe(
      map(result => {
        if (result) {
          var data = result;
          const res: any[] = Object.assign({}, {}, data);
          return res;
        }
      })
    );
  }

  create(input: any): Observable<any> {
    let baseUrl = APP_CONFIG.apiBaseUrl;
    let url = `${baseUrl}${appCompany_SaveUrl}`;
    url = url.replace(/[?&]$/, "");

    return this.http.post<any>(url, input).pipe(
      map(result => {
        if (result) {
          var data = result;

          const res: any = Object.assign({}, {}, data);
          return res;
        }
      })
    );
  }

  checkCompany(): Observable<any> {
    let baseUrl = APP_CONFIG.apiBaseUrl;
    let url = `${baseUrl}${appCompany_CheckCompany}/`;
    url = url.replace(/[?&]$/, "");

    return this.http.get<any>(url).pipe(
      map(result => {
        if (result) {
          var data = result;

          const res: any = Object.assign({}, {}, data);
          return res;
        }
      })
    );
  }
}
