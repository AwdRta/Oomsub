import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { AccountService } from "src/app/_services/account.service";

@Component({
  selector: "app-mhome",
  templateUrl: "./mhome.component.html",
  styleUrls: ["./mhome.component.css"],
})
export class MhomeComponent implements OnInit {
  model: any = {};
  constructor(private as: AccountService, private router: Router) {}
  ngOnInit(): void {}

  mainMember() {
    this.as.mainMember(this.model).subscribe({
      next: (response) => {
        console.log(response);
      },
      error: (error) => console.log(error),
    });
  }
}
