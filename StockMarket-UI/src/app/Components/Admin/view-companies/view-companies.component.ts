import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/Models/company';
import { CompanyService } from 'src/app/Services/company.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-view-companies',
  templateUrl: './view-companies.component.html',
  styleUrls: ['./view-companies.component.css']
})
export class ViewCompaniesComponent implements OnInit {
companies:Company[]=[];
compa:Company;
  constructor(private company_service:CompanyService, private router:Router) { 
    company_service.GetAllItems().subscribe(response=>{
      this.companies=response
      console.log(this.companies);
    },error=>{
      console.log(error);
    })
  }

  ngOnInit(): void {
  }
  Getitem(item:string)
  {
    localStorage['localId'] = item;
    this.router.navigateByUrl("/view-company")
  }

}
