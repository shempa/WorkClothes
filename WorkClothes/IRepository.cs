using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClothes
{
    interface IRepository
    {
        List<ClothesModels> GetClothes();
        List<ClothesModels> ThisClothes(string This);
        List<ClothesModels> SortFieldClothes(string SortField);
    }
}
