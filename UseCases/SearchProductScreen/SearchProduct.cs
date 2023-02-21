using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PluginInterfaces.DataStore;

namespace UseCases.SearchProductScreen;

public class SearchProduct:ISearchProduct
{
    private readonly IProductRepository _productRepository;

    public SearchProduct(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IEnumerable<Product> Execute(string? filter)
    {
        return _productRepository.GetProducts(filter);
    }
}
