using System;
using System.Collections.Generic;
using System.Text;

namespace MyUtilityClasses
{
    namespace NAnimal
    {
        public abstract class Cattle
        {
            protected int milk;

            public int Milk { get => milk; set => milk = value; }

            public abstract void ToSound();
            public abstract void ToMilk();
        }

        public class Cow : Cattle
        {
            private string CowSound = "Umbobooo";
            public override void ToSound()
            {
                Console.Write(CowSound + " ");
            }

            public override void ToMilk()
            {
                Milk = (new Random()).Next(0, 20);
            }
        }
        public class Sheep : Cattle
        {
            private string CowSound = "beeeeee";
            public override void ToSound()
            {
                Console.Write(CowSound + " ");
            }

            public override void ToMilk()
            {
                Milk = (new Random()).Next(0, 5);
            }
        }
        public class Goat : Cattle
        {
            private string CowSound = "goatgoat";
            public override void ToSound()
            {
                Console.Write(CowSound + " ");
            }

            public override void ToMilk()
            {
                Milk = (new Random()).Next(0, 10);
            }
        }
    }
}
