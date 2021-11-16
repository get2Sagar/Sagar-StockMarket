using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.IO;
using OfficeOpenXml;
using StockMarket.Admin.Entities;

namespace StockMarket.Excel.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]

    [Produces("application/json")]
    [Route("api/Stock")]
    public class StockController : ControllerBase
    {
        StockMarketDBContext _db = new StockMarketDBContext();

        //public StockController(IHostingEnvironment hostingEnvironment, StockMarketDBContext db)
        //{
        //    //_hostingEnvironment = hostingEnvironment;
        //    //_db = db;
        //}


        [HttpGet]
        [Route("ImportStock/{*filePath}")]
        public IList<StockPrice> ImportStock(string filename)
        {
            string filePath = @"E:\Dotnet Trainings\Socgen\Project\Upload\" + filename;

            //  string rootFolder = _hostingEnvironment.WebRootPath;
            // string fileName = @"ImportCustomers.xlsx";
            //  FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

            FileInfo file = new FileInfo(filePath);
            string fileName = file.Name;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets["Sheet1"];
                int totalRows = workSheet.Dimension.Rows;

                List<StockPrice> stockPrices = new List<StockPrice>();

                for (int i = 2; i <= totalRows; i++)
                {
                    
                    stockPrices.Add(new StockPrice
                    {
                        CompanyCode = workSheet.Cells[i, 1].Value.ToString().Trim(),
                        StockExchange = workSheet.Cells[i, 2].Value.ToString().Trim(),
                        CurrentPrice = double.Parse(workSheet.Cells[i, 3].Value.ToString().Trim()),
                        Date = DateTime.ParseExact("22/11/2020", "dd/MM/yyyy", null),
                        Time = workSheet.Cells[i, 5].Value.ToString(),
                    });
                    

                    
                }

                _db.StockPrices.AddRange(stockPrices);
                _db.SaveChanges();

                return stockPrices;
            }
        }

        [HttpGet]
        [Route("ExportCustomer")]
        public string ExportCustomer()
        {
            //string rootFolder = _hostingEnvironment.WebRootPath;
            //string fileName = @"ExportCustomers.xlsx";

            //FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

            //using (ExcelPackage package = new ExcelPackage(file))
            //{

            //    IList<Customers> customerList = _db.Customers.ToList();

            //    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Customer");
            //    int totalRows = customerList.Count();

            //    worksheet.Cells[1, 1].Value = "Customer ID";
            //    worksheet.Cells[1, 2].Value = "Customer Name";
            //    worksheet.Cells[1, 3].Value = "Customer Email";
            //    worksheet.Cells[1, 4].Value = "customer Country";
            //    int i = 0;
            //    for (int row = 2; row <= totalRows + 1; row++)
            //    {
            //        worksheet.Cells[row, 1].Value = customerList[i].CustomerId;
            //        worksheet.Cells[row, 2].Value = customerList[i].CustomerName;
            //        worksheet.Cells[row, 3].Value = customerList[i].CustomerEmail;
            //        worksheet.Cells[row, 4].Value = customerList[i].CustomerCountry;
            //        i++;
            //    }

            //    package.Save(); 

            //}

            return " Customer list has been exported successfully";
        }

    }
}
