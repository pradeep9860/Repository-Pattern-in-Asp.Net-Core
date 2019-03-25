import { BrowserModule } from "@angular/platform-browser";
import { NgModule, APP_INITIALIZER } from "@angular/core";

import { AppComponent } from "./app.component";
import { TagServiceService } from "../shared/service/tag-service.service";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { AppConfigService } from "src/shared/service/app-config.service";
import { JwtInterceptor, ErrorInterceptor } from "src/shared/helpers";
import { AuthGuard } from "src/shared/guards";
import { AlertService } from "src/shared/service";
import { AppRoutingModule } from "./app-routing.module";
import { MasterCompanyService } from "src/shared/service/master-company.service";
import { CompanyService } from "src/shared/service/company.service";

/**
 * Exported function so that it works with AOT
 * @param {AppConfigService} configService
 * @returns {Function}
 */
export function loadConfigService(configService: AppConfigService): Function {
  return () => {
    return configService.load();
  };
}

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [
    AuthGuard,
    AlertService,
    TagServiceService,
    MasterCompanyService,
    CompanyService,
    AppConfigService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    {
      provide: APP_INITIALIZER,
      useFactory: loadConfigService,
      deps: [AppConfigService],
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
