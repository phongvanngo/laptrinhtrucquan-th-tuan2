using System;

namespace MyUtilityClasses
{
    namespace NShape
    {
        public abstract class Shape
        {
            float area;
            float perimeter;
            public float Area { get => area; set => area = value; }
            public float Perimeter { get => perimeter; set => perimeter = value; }
            public abstract float CalculateArea();
            public abstract float CalculatePerimeter();
            public abstract void Input();
        }

        public class Reactangle : Shape
        {

            float height;
            float width;

            public Reactangle(float height=0, float width=0)
            {
                this.height = height;
                this.width = width;
            }
            public float Height { get => height; set => height = value; }
            public float Width { get => width; set => width = value; }
            public override float CalculateArea()
            {
                return height * width;
            }
            public override float CalculatePerimeter()
            {
                return (width + height) * 2;
            }
            public override void Input()
            {
                Console.WriteLine("Rectangle: ");
                Console.Write("Width: ");
                width = float.Parse(Console.ReadLine());
                Console.Write("Height: ");
                height = float.Parse(Console.ReadLine());
            }
        }

    }
}
