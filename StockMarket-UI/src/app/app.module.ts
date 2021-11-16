import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { ViewCompaniesComponent } from './Components/Admin/view-companies/view-companies.component';
import { CompanyService } from './Services/company.service';
import { AddCompanyComponent } from './Components/Admin/add-company/add-company.component';
import { ViewCompanyComponent } from './Components/Admin/view-company/view-company.component';
@NgModule({
  declarations: [
    AppComponent,
    ViewCompaniesComponent,
    AddCompanyComponent,
    ViewCompanyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [CompanyService],
  bootstrap: [AppComponent]
})
export class AppModule { }
