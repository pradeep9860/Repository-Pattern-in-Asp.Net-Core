import { Component } from "@angular/core";
import { TagServiceService } from "../shared/service/tag-service.service";
import { Subscription, timer } from "rxjs";
import { APP_CONFIG } from "src/shared/service/app-config.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"]
})
export class AppComponent {
  constructor() {}
}
