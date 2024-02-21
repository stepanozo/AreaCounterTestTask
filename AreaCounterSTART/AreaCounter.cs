using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCounter
{
    public abstract class Shape
    {
        public double Area
        {
            get { return CountArea(); }
        }

        public Shape()
        {

        }

        /// <summary>
        /// Метод, вычисляющий площадь фигуры
        /// </summary>
        protected abstract double CountArea();
        //Данный абстрактный метод позволит посчитать площадь фигуры, даже если мы не знаем, какая конкретно перед нами фигура

    }

    public class Circle : Shape
    {
        double radius;

        public Circle(double radius) : base()
        {
            if (radius <= 0)
                throw new ArgumentException("Radius of a circle must be a positive number");
            this.radius = radius;
        }

        /// <summary>
        /// Метод, вычисляющий площадь круга
        /// </summary>
        protected override double CountArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
    }

    public class Triangle : Shape
    {
        double a;
        double b;
        double c;



        /// <summary>
        /// Задание треугольника по трём сторонам
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        public Triangle(double a, double b, double c) : base()
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All three legs of a triangle must be positive numbers");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Each leg of a triangle must have a shorter length than the sum of 2 other legs' lengths.");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Метод, вычисляющий площадь треугольника
        /// </summary>
        protected override double CountArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        /// <summary>
        /// Метод, проверяющий треугольник на наличие прямого угла
        /// </summary>
        public bool IsRectangular()
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
    }
}
