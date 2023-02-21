using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PluginInterfaces.DataStore;

namespace UseCases.SearchProductScreen;

public interface ISearchProduct
{
    IEnumerable<Product> Execute(string? filter);
}
