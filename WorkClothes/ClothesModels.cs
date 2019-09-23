using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClothes
{
    class ClothesModels
    {
        public int id { get; set; }
        public string name { get; set; }
        public int size { get; set; }
        public int quantity { get; set; }
        public override string ToString()
        {
            return $"{id} {name} {size} {quantity}";
        }

    }
}
