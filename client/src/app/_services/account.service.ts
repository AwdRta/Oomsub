import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class AccountService {
  baseUrl = "https://localhost:5001/api/";

  constructor(private http: HttpClient) {}

  login(model: any) {
    return this.http.post(this.baseUrl + "account/login", model).pipe(
      map((response: any) => {
        const customer = response;
        if (customer) {
          localStorage.setItem("customer", JSON.stringify(customer));
        }
      })
    );
  }

  logout() {
    localStorage.removeItem("customer");
  }
}
