import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { SetCompanyRoutingModule } from "./set-company-routing.module";
import { SetCompanyComponent } from "./set-company.component";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    SetCompanyRoutingModule
  ],
  declarations: [SetCompanyComponent],
  bootstrap: [SetCompanyComponent]
})
export class SetCompanyModule {}
