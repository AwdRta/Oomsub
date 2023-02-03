import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Customer } from "src/_models/customer";
import { AccountService } from "../_services/account.service";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  styleUrls: ["./home.component.css"],
})
export class HomeComponent implements OnInit {
  customers: any;

  constructor(
    private http: HttpClient,
    private accountService: AccountService
  ) {}

  ngOnInit(): void {
    this.getCustomers();
    this.setCurrentCustomer();
  }

  getCustomers() {
    this.http.get("https://localhost:5001/api/customers").subscribe({
      next: (response) => (this.customers = response),
      error: (error) => console.log(error),
      complete: () => console.log("Request has completed"),
    });
  }

  setCurrentCustomer() {
    const customerString = localStorage.getItem("customer");
    if (!customerString) return;
    const customer: Customer = JSON.parse(customerString);
    this.accountService.setCurrentCustomer(customer);
  }
}
