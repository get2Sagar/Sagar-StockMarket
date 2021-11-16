import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Company } from '../Models/company';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  company_url='http://localhost:28571/api/Company/'
  constructor(private http:HttpClient) { }
  GetAllItems():Observable<Company[]>
  {
    return this.http.get<Company[]>(this.company_url+'GetAll');
  }
  GetItem(comp:string):Observable<Company>
  {
    return this.http.get<Company>(this.company_url+'GetCompany/'+comp);
  }
  AddItem(company:Company):Observable<any>
  {
    return this.http.post(this.company_url+'AddCompany',company);
  }
}
