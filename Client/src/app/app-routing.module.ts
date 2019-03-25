import { NgModule } from "@angular/core";
import { PreloadAllModules, RouterModule, Routes } from "@angular/router";
import { AppComponent } from "./app.component";

const routes: Routes = [
  // {
  //   path: "login",
  //   loadChildren: "app/pages/account/login/login.module#LoginModule"
  // },
  // {
  //   path: "register",
  //   loadChildren:
  //     "app/pages/custom-pages/register/register.module#RegisterModule"
  // },
  // {
  //   path: "forgot-password",
  //   loadChildren:
  //     "app/pages/custom-pages/forgot-password/forgot-password.module#ForgotPasswordModule"
  // },
  {
    path: "",
    component: AppComponent,
    // canActivate: [AuthGuard],
    children: [
      {
        path: "app/home",
        loadChildren: "./home/home.module#HomeModule",
        pathMatch: "full"
      },
      {
        path: "app/set-company",
        loadChildren: "./set-company/set-company.module#SetCompanyModule",
        pathMatch: "full"
      },
      { path: "**", redirectTo: "app/home" }
    ]
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      preloadingStrategy: PreloadAllModules
    })
  ],
  exports: [RouterModule],
  providers: []
})
export class AppRoutingModule {}
