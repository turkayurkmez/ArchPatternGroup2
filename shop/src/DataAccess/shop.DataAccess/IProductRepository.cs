﻿using shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.DataAccess
{
    public interface IProductRepository : IRepository<Product>
    {
        void SearchByName();
    }
}
