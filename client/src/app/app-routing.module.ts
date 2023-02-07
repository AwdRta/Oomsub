import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AdocComponent } from "./admin/adoc/adoc.component";
import { AdoctypeComponent } from "./admin/adoctype/adoctype.component";
import { AloginComponent } from "./admin/alogin/alogin.component";
import { AnewsComponent } from "./admin/anews/anews.component";
import { AboutusComponent } from "./main/aboutus/aboutus.component";
import { CalculateComponent } from "./main/calculate/calculate.component";
import { ContactusComponent } from "./main/contactus/contactus.component";
import { HomeComponent } from "./main/home/home.component";
import { MdetailComponent } from "./members/mdetail/mdetail.component";
import { MhomeComponent } from "./members/mhome/mhome.component";
import { MloginComponent } from "./members/mlogin/mlogin.component";
import { MregisterComponent } from "./members/mregister/mregister.component";

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "login", component: MloginComponent },
  { path: "register", component: MregisterComponent },
  { path: "mhome", component: MhomeComponent },
  { path: "mdetail/:custCode", component: MdetailComponent },
  { path: "aboutus", component: AboutusComponent },
  { path: "contactus", component: ContactusComponent },
  { path: "calculate", component: CalculateComponent },
  { path: "alogin", component: AloginComponent },
  { path: "adoctype", component: AdoctypeComponent },
  { path: "adoc", component: AdocComponent },
  { path: "anew", component: AnewsComponent },
  { path: "**", component: HomeComponent, pathMatch: "full" },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
