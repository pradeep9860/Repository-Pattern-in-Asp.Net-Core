import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { map } from "rxjs/operators";

import { Observable } from "rxjs";
import { appMasterCompany_GetAllUrl } from "../helpers/url-helpers";
import { APP_CONFIG } from "./app-config.service";

@Injectable()
export class MasterCompanyService {
  constructor(private http: HttpClient) {}

  getAll(): Observable<any[]> {
    let baseUrl = APP_CONFIG.apiBaseUrl;
    let url = `${baseUrl}${appMasterCompany_GetAllUrl}`;
    url = url.replace(/[?&]$/, "");

    return this.http.get<any[]>(url).pipe(
      map(result => {
        if (result) {
          var data = result;
          const res: any[] = data;
          return res;
        }
      })
    );
  }
}
