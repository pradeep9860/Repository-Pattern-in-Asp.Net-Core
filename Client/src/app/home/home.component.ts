import { Component, OnInit } from "@angular/core";
import { CompanyService } from "src/shared/service/company.service";
import { Router } from "@angular/router";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  styleUrls: ["./home.component.css"]
})
export class HomeComponent implements OnInit {
  constructor(private companyService: CompanyService, private router: Router) {}

  ngOnInit() {
    this.companyService.checkCompany().subscribe(res => {
      if (!res["result"]) {
        this.router.navigate(["app/set-company"]);
      }
    });
  }
}
