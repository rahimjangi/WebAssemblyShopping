﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Models;

public class Product
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Name { get; set; }=string.Empty;
    public double Price { get; set; }
    public string ImageLink { get; set; }=string.Empty;
    public string Description { get; set; } = string.Empty;
}
