import { NgModule } from "@angular/core";
import { PreloadAllModules, RouterModule, Routes } from "@angular/router";
import { AuthGuard } from "src/shared/guards";
import { HomeComponent } from "./home.component";

const routes: Routes = [
  // {
  //   path: "login",
  //   loadChildren: "app/pages/account/login/login.module#LoginModule"
  // },
  {
    path: "",
    component: HomeComponent
    // canActivate: [AuthGuard],
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule {}
