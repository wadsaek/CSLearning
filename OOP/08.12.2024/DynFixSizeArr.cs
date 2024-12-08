using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._12._2024 {
    internal class DynFixSizeArr {
        int index;
        Item?[] arr;
        public DynFixSizeArr() {
            index = 0;
            arr = new Item[10];
        }
        public DynFixSizeArr(uint length) {
            index = 0;
            arr = new Item[length];
        }
        public void DeleteAt(int index) {
            if (!(index < arr.Length && index <= this.index)) {
                return;
            }

            arr[index] = null;
            for (int i = index; i < this.index; i++) {
                arr[i] = arr[i + 1];
            }
            arr[this.index] = null;
            index--;
        }
        public void Append(Item item) {
            if (index < arr.Length) {
                arr[++index] = new Item(item);
            }
        }

        public void UpdateAt(int index, Item updated) {
            arr[index] = new Item(updated);
        }

        public Item? GetAt(int index) {
            if (index < this.index) {
                return arr[index];
            }
            return null;
        }
        public override string ToString() {
            string str = "[";
            for (int i = 0; i < arr.Length; i++) {
                Item? item = arr[i];
                if (item != null)
                    str += $"\n{item},";
            }
            str += "\n]";
            return str;
        }
    }
}
