import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { SetCompanyComponent } from "./set-company.component";

const routes: Routes = [
  {
    path: "",
    component: SetCompanyComponent
    // canActivate: [AuthGuard],
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SetCompanyRoutingModule {}
