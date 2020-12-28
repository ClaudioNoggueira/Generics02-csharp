using System;

namespace Entities {
    class Product : IComparable{
        public string _name { get; set; }
        public double _price { get; set; }

        public Product(string name, double price) {
            this._name = name;
            this._price = price;
        }

        public override string ToString() {
            return _name + ", " + _price.ToString("F2");
        }

        public int CompareTo(object obj) {
            if(!(obj is Product)) {
                throw new ArgumentException("Comparing error argument is not a product");
            }
            Product product = obj as Product;
            return _price.CompareTo(product._price);
        }
    }
}
