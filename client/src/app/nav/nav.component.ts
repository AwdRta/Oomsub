import { Component, OnInit } from "@angular/core";
import { Observable, of } from "rxjs";
import { Customer } from "src/_models/customer";
import { AccountService } from "../_services/account.service";

@Component({
  selector: "app-nav",
  templateUrl: "./nav.component.html",
  styleUrls: ["./nav.component.css"],
})
export class NavComponent implements OnInit {
  model: any = {};
  currentCustomer$: Observable<Customer | null> = of(null);
  // loggedIn = false;

  constructor(public accountService: AccountService) {}

  ngOnInit(): void {
    this.currentCustomer$ = this.accountService.currentCustomer$;
  }

  login() {
    this.accountService.login(this.model).subscribe({
      next: (response) => {
        console.log(response);
      },
      error: (error) => console.log(error),
    });
  }

  logout() {
    this.accountService.logout();
  }
}
