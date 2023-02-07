import { Component, OnInit } from "@angular/core";
import { Route, Router } from "@angular/router";
import { AccountService } from "src/app/_services/account.service";

@Component({
  selector: "app-mlogin",
  templateUrl: "./mlogin.component.html",
  styleUrls: ["./mlogin.component.css"],
})
export class MloginComponent implements OnInit {
  model: any = {};
  loggedIn = false;
  constructor(private as: AccountService, private router: Router) {}

  ngOnInit(): void {}

  login() {
    this.as.login(this.model).subscribe({
      next: (response) => {
        console.log(response);
        this.loggedIn = true;
        this.router.navigateByUrl("/mhome/" + this.model.custCode);
      },
      error: (error) => console.log(error),
    });
  }
}
