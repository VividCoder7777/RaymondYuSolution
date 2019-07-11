import { Component, OnInit } from "@angular/core";
import {
  CMSServiceProxy,
  CMSDto
} from "@shared/service-proxies/service-proxies";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-cms",
  templateUrl: "./cms.component.html",
  styleUrls: ["./cms.component.css"]
})
export class CmsComponent implements OnInit {
  id: number;
  cmsDto: CMSDto;

  constructor(
    private cmsService: CMSServiceProxy,
    private route: ActivatedRoute
  ) {}

  async ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params["id"];

      this.cmsService.getCMSContent(this.id).subscribe(result => {
        this.cmsDto = result;
      });
    });
  }
}

/*
  1. Inject the proxy and dtos
  2. make the api calls
  3. update ui
  4. create permissions if needed
*/
