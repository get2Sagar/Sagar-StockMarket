import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/Models/company';
import { CompanyService } from 'src/app/Services/company.service';

@Component({
  selector: 'app-view-company',
  templateUrl: './view-company.component.html',
  styleUrls: ['./view-company.component.css']
})
export class ViewCompanyComponent implements OnInit {
company:Company
  constructor(private item_service:CompanyService) { 
    let name = localStorage['localId'];
    this.item_service.GetItem(name).subscribe(response=>{
      this.company=response;
      console.log(this.company)
    })
  }

  ngOnInit(): void {
  }

}
