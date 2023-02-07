import { Component, OnInit } from "@angular/core";
import { BsDropdownConfig } from "ngx-bootstrap/dropdown";

@Component({
  selector: "app-navbar",
  templateUrl: "./navbar.component.html",
  styleUrls: ["./navbar.component.css"],
  providers: [],
})
export class NavbarComponent implements OnInit {
  isCollapsed = false;

  ngOnInit(): void {}
}
