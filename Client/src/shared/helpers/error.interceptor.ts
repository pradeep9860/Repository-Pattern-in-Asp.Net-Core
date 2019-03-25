import { Injectable } from "@angular/core";
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { catchError } from "rxjs/operators";
import { AlertService } from "../service";

// import { AutheknticationService } from "../_services";

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
  constructor(
    private alertService: AlertService // private authenticationService: AuthenticationService
  ) {}

  intercept(
    request: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError(err => {
        let error = "";
        if (err.status === 401) {
          // auto logout if 401 response returned from api
          // this.authenticationService.logout();
          location.reload(true);
        }

        if (err.error && err.error.ResponseException) {
          error = err.error.ResponseException.ExceptionMessage;
          return throwError(error);
        }
        error = err.error.message || err.statusText;

        this.alertService.error(error);
        return throwError(error);
      })
    );
  }
}
