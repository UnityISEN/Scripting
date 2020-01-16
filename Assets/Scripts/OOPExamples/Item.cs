using System;

namespace OOPExamples {
    public class Item {
        public readonly string Name;
        private int quantity;

        public Item(string name, int initialQuantity) {
            if (initialQuantity < 0) throw new Exception("Initial quantity has to be positive!");

            Name = name;
            quantity = initialQuantity;
        }

        public void UseItem() {
            if (quantity > 0) quantity--;
            else throw new Exception("Can't use item");
        }
    }
}