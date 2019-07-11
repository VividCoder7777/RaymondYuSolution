import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-cms",
  templateUrl: "./cms.component.html",
  styleUrls: ["./cms.component.css"]
})
export class CmsComponent implements OnInit {
  constructor() {}

  ngOnInit() {}
}

/*
  1. Inject the proxy and dtos
  2. make the api calls
  3. update ui
  4. create permissions if needed
*/
