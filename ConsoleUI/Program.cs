
using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System.Security.Cryptography.X509Certificates;
using DataAccess.Concrete.EntityFramework;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetByUnitPrice(40,100))
{
    Console.WriteLine(product.ProductName);
     
}
