using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

/* Interface in kendisi public değildir operasyonlari publictir. */
/* Baska bir katman kullanilmak istenirse onu Add Reference ile eklemeliyiz (Burada Entites katmanindaki Product kullanilmak isteniyor) */
