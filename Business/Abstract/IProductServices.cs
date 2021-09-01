using Core.Utilities.Results;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductServices
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GellAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductsDetails();

        IDataResult<Product> GetById(int productId);
         
        IResult Add(Product product);
        IResult Update(Product product);

        IResult AddTransactionalTest(Product product);
    }
}
