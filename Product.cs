using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PocketGranny
{
    public class Product
    {
        private string _nameProduct;

        private float _weight;

        public string Name
        {
            get { return _nameProduct; }
            private set { _nameProduct = value; }
        }
        public float Weight
        {
            get { return _weight; }
            private set { _weight = value; }
        }
        public Product(string nameProduct, float weightProduct)
        {
            Name = nameProduct;
            Weight = weightProduct;
        }
    }
}
