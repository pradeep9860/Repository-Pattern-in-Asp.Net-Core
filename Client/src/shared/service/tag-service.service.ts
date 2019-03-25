import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { map } from "rxjs/operators";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { APP_CONFIG } from "src/shared/service/app-config.service";

@Injectable({
  providedIn: "root"
})
export class TagServiceService {
  baseUrl: string;
  constructor(private http: HttpClient) {}

  getLocation(tagAddress: string): Observable<any> {
    let baseUrl = APP_CONFIG.apiBaseUrl;
    let url = `${baseUrl}/api/tag/getLocation/${tagAddress}`;
    url = url.replace(/[?&]$/, "");

    return this.http.get<any>(url).pipe(
      map(result => {
        if (result) {
          var data = result;
          const res: any = Object.assign({}, data);
          return res;
        }
      })
    );
  }

  flashTag(tagAddress: string): Observable<any> {
    debugger;
    let baseUrl = APP_CONFIG.apiBaseUrl;
    let url = `${baseUrl}/api/tag/flashRedTag/${tagAddress}`;
    url = url.replace(/[?&]$/, "");

    return this.http.get<any>(url).pipe(
      map(result => {
        if (result) {
          var data = result;
          const res: any = Object.assign({}, data);
          return res;
        }
      })
    );
  }

  stopFlash(tagAddress: string): Observable<any> {
    let baseUrl = APP_CONFIG.apiBaseUrl;
    let url = `${baseUrl}/api/tag/stopFlash/${tagAddress}`;
    url = url.replace(/[?&]$/, "");

    return this.http.get<any>(url).pipe(
      map(result => {
        if (result) {
          var data = result;
          const res: any = Object.assign({}, data);
          return res;
        }
      })
    );
  }
}
