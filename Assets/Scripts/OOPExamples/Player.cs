using System;
using System.Collections.Generic;

namespace OOPExamples {
    public class Player {
        private float health; // From 0 to 100;
        private readonly List<Item> items;

        public Player() {
            health = 100f;
            items = new List<Item> {
                new Potion(5, 10f),
                new Item("Lapin", 1),
                new Item("Épée", 1)
            };
        }
        
        public void DrinkPotion() {
            foreach (Item item in items) {
                if (item is Potion potion)
                    health += potion.HealingAmount;
            }
        }

        public void TakeDamage(float damage) {
            if (damage <= 0f) throw new Exception("Damage can't be negative ! (well it is, but not THAT way)");
            health -= damage;
        }
    }
}