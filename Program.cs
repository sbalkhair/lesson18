using System;
using System.Collections.Generic;

namespace lesson18
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //polymorphisem

            var circle = new Circle();
            var recancle = new Recancle();
            var trincle = new Traincle();
            var listObj = new List<Shape>();

            listObj.Add(circle);
            listObj.Add(recancle);
            listObj.Add(trincle);

            var canves = new Canves();
            canves.DrawShape(listObj);


            Console.ReadKey();
        }

        // class Shape
        //{
        //    public virtual void Draw() { }

        //}

        abstract class Shape
        {
            public abstract void Draw();

        }

        sealed class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw from circle");
            }
        }

        class Recancle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw from recancle");
            }
        }

        class Traincle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("drw from tringle");
            }
        }



        class Canves
        {

            public void DrawShape(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {
                    shape.Draw();
                }
            }
        }
    }





}
