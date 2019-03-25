import { BrowserModule } from "@angular/platform-browser";
import { NgModule, APP_INITIALIZER } from "@angular/core";

import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { AppConfigService } from "src/shared/service/app-config.service";
import { JwtInterceptor, ErrorInterceptor } from "src/shared/helpers";
import { AuthGuard } from "src/shared/guards";
import { AlertService } from "src/shared/service";
import { HomeComponent } from "./home.component";
import { HomeRoutingModule } from "./home-routing.module";

@NgModule({
  declarations: [HomeComponent],
  imports: [HomeRoutingModule],
  providers: [],
  bootstrap: [HomeComponent]
})
export class HomeModule {}
