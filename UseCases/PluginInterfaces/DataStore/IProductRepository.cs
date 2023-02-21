using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.PluginInterfaces.DataStore;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts(string? filter);
    Product GetProduct(int id);
}
