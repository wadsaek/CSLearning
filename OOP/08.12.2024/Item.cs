using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08._12._2024 {
    public class Item {
        string name;
        double pricePerEach;
        uint count;
        public Item(string name,double price_per_each, uint count) {
            this.name = name;
            this.pricePerEach = price_per_each;
            this.count = count;
        }
        public Item(Item item) {
            this.name = item.name;
            this.pricePerEach = item.pricePerEach;
            this.count = item.count;
        }
        public string GetName() {
            return this.name;
        }
        public double GetPricePerEach() {
            return this.pricePerEach;
        }
        public uint GetCount() {
            return this.count;
        }

        public void SetName(string name) {
            this.name = name;
        }
        public void SetCount(uint count) {
            if(count != 0) this.count = count;
        }
        public void SetPricePerEach(double pricePerEach) {
            if(this.pricePerEach > 0) this.pricePerEach = pricePerEach;
        }

        public override string ToString() {
            return $"Item {name}\nCount: {count}\nPrice: {pricePerEach}";
        }
    }
}
