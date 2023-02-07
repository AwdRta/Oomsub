import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";
import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { FormsModule } from "@angular/forms";
import { BsDropdownModule } from "ngx-bootstrap/dropdown";

import { NavbarComponent } from "./main/navbar/navbar.component";
import { HomeComponent } from "./main/home/home.component";
import { NewsComponent } from "./main/news/news.component";
import { CalculateComponent } from "./main/calculate/calculate.component";
import { AboutusComponent } from "./main/aboutus/aboutus.component";
import { ContactusComponent } from "./main/contactus/contactus.component";
import { FooterComponent } from "./main/footer/footer.component";
import { MnavbarComponent } from "./members/mnavbar/mnavbar.component";
import { MhomeComponent } from "./members/mhome/mhome.component";
import { MdetailComponent } from "./members/mdetail/mdetail.component";
import { MloginComponent } from "./members/mlogin/mlogin.component";
import { AloginComponent } from "./admin/alogin/alogin.component";
import { AnavbarComponent } from "./admin/anavbar/anavbar.component";
import { AdoctypeComponent } from "./admin/adoctype/adoctype.component";
import { AdocComponent } from "./admin/adoc/adoc.component";
import { AnewsComponent } from "./admin/anews/anews.component";
import { CollapseModule } from "ngx-bootstrap/collapse";
import { MregisterComponent } from './members/mregister/mregister.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    NewsComponent,
    CalculateComponent,
    AboutusComponent,
    ContactusComponent,
    FooterComponent,
    MnavbarComponent,
    MhomeComponent,
    MdetailComponent,
    MloginComponent,
    AloginComponent,
    AnavbarComponent,
    AdoctypeComponent,
    AdocComponent,
    AnewsComponent,
    MregisterComponent,
  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    BsDropdownModule.forRoot(),
    CollapseModule.forRoot(),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
