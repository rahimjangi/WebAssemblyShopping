using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PluginInterfaces.DataStore;

namespace UseCases.SearchProductScreen;

public class ViewProduct:IViewProduct
{
    private readonly IProductRepository _productRepository;

    public ViewProduct(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public Product Execute(int id)
    {
        return _productRepository.GetProduct(id);
    }
}
