using System;

namespace OOPExamples {
    public class Potion : Item {
        public readonly float HealingAmount;

        public Potion(int initialQuantity, float healingAmount) : base("Potion", initialQuantity) {
            if (healingAmount < 0f) throw new Exception("Potions can't hurt you!");
            HealingAmount = healingAmount;
        }
    }
}