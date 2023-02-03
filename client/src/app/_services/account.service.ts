import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BehaviorSubject, map } from "rxjs";
import { Customer } from "src/_models/customer";

@Injectable({
  providedIn: "root",
})
export class AccountService {
  baseUrl = "https://localhost:5001/api/";
  private currentCustomerSource = new BehaviorSubject<Customer | null>(null);
  currentCustomer$ = this.currentCustomerSource.asObservable();

  constructor(private http: HttpClient) {}

  login(model: any) {
    return this.http.post<Customer>(this.baseUrl + "account/login", model).pipe(
      map((response: Customer) => {
        const customer = response;
        if (customer) {
          localStorage.setItem("customer", JSON.stringify(customer));
          this.currentCustomerSource.next(customer);
        }
      })
    );
  }

  setCurrentCustomer(customer: Customer) {
    this.currentCustomerSource.next(customer);
  }

  logout() {
    localStorage.removeItem("customer");
    this.currentCustomerSource.next(null);
  }
}
