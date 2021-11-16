import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/Models/company';
import { CompanyService } from 'src/app/Services/company.service';

@Component({
  selector: 'app-add-company',
  templateUrl: './add-company.component.html',
  styleUrls: ['./add-company.component.css']
})
export class AddCompanyComponent implements OnInit {
company:Company;
  constructor(private company_service:CompanyService) { 
    this.company = new Company();
  }

  ngOnInit(): void {
  }
  AddCompany(){
    console.log(this.company);
    //this.company.sectorId=1;
    this.company_service.AddItem(this.company).subscribe(response=>{

    },error=>{
      console.log(error)
    })
  }

}
