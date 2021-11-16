import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCompanyComponent } from './Components/Admin/add-company/add-company.component';
import { ViewCompaniesComponent } from './Components/Admin/view-companies/view-companies.component';
import { ViewCompanyComponent } from './Components/Admin/view-company/view-company.component';

const routes: Routes = [
  {path:'view-companies',component:ViewCompaniesComponent},
  {path:'add-company',component:AddCompanyComponent},
  {path:'view-company',component:ViewCompanyComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
