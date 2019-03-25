import { Component, OnInit } from "@angular/core";
import { MasterCompanyService } from "src/shared/service/master-company.service";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { CompanyService } from "src/shared/service/company.service";
import { finalize } from "rxjs/operators";
import { Router } from "@angular/router";

@Component({
  selector: "app-set-company",
  templateUrl: "./set-company.component.html",
  styleUrls: ["./set-company.component.css"]
})
export class SetCompanyComponent implements OnInit {
  allcompany: any = [];
  selectedItem: any = null;
  saving: boolean = false;

  form: FormGroup;
  constructor(
    private masterCompanyServie: MasterCompanyService,
    private companyService: CompanyService,
    private router: Router,
    private fb: FormBuilder
  ) {
    this.buildForm();
    this.companyService.checkCompany().subscribe(res => {
      if (res["result"]) {
        this.router.navigate(["/"]);
      }
    });
  }

  ngOnInit() {
    this.masterCompanyServie.getAll().subscribe(res => {
      this.allcompany = res;
    });
  }

  companySelected($event) {
    let itemIndex = $event.target.value;
    if (itemIndex < 0) {
      this.resetForm();
      return;
    }

    this.selectedItem = this.allcompany[itemIndex];
    this.patchForm();
  }

  buildForm() {
    this.form = this.fb.group({
      initial: ["1"],
      name: ["", Validators.required],
      address: [""],
      email: [""],
      fax: [""],
      fbdatE_BS: [""],
      fbdate: [""],
      fedatE_BS: [""],
      fedate: [""],
      isbranch: [""],
      phiscalID: [""],
      tela: [""],
      vat: [""],
      website: [""]
    });
  }

  patchForm() {
    if (this.selectedItem == undefined || this.selectedItem == null) {
      return;
    }
    this.form.patchValue({
      initial: "1",
      name: this.selectedItem.name,
      address: this.selectedItem.address,
      email: this.selectedItem.email,
      fax: this.selectedItem.fax,
      fbdatE_BS: this.selectedItem.fbdatE_BS,
      fbdate: this.selectedItem.fbdate,
      fedatE_BS: this.selectedItem.fedatE_BS,
      fedate: this.selectedItem.fedate,
      isbranch: this.selectedItem.isbranch,
      phiscalID: this.selectedItem.phiscalID,
      tela: this.selectedItem.tela,
      vat: this.selectedItem.vat,
      website: this.selectedItem.website
    });
  }

  resetForm() {
    this.form.patchValue({
      initial: "1",
      name: "",
      address: "",
      email: "",
      fax: "",
      fbdatE_BS: "",
      fbdate: "",
      fedatE_BS: "",
      fedate: "",
      isbranch: "",
      phiscalID: "",
      tela: "",
      vat: "",
      website: ""
    });
  }

  save() {
    if (this.form.valid) {
      var formData = Object.assign({}, {}, this.form.value);

      this.saving = true;

      this.companyService
        .create(formData)
        .pipe(
          finalize(() => {
            this.saving = false;
          })
        )
        .subscribe(res => {
          if (res) {
            this.router.navigate(["/"]);
          }
        });
    }
  }
}
