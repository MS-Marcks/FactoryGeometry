using System;
using System.Threading;

namespace FactoryGeometry
{
    public interface IDrawing
    {
        string Drawing();
        string Area(float b, float a);
    }
    abstract class Geometry{   
        public abstract IDrawing FactoryMethod();
        public string Drawing(){
            var figure=FactoryMethod();
            return figure.Drawing();
        }
         public string Area(float b, float a){
            var figure=FactoryMethod();
            return figure.Area(b,a);
        }
    }

    class DrawingSquare: Geometry
    {
        public override IDrawing FactoryMethod()
        {
            return new Square();
        }
    }
    class DrawingRectangle: Geometry
    {
        public override IDrawing FactoryMethod()
        {
            return new Rectangle();
        }
    }
     class DrawingTriangle: Geometry
    {
        public override IDrawing FactoryMethod()
        {
            return new Triangle();
        }
    }
    class Square: IDrawing
    {
        public string Drawing()
        {
            return @"DRAWING SQUARE
                    -------------------------------------
                    -                                   -
                    -                                   -
                    -                                   -
                    -                                   -
                    -                                   -
                    -                                   -
                    -                                   -
                    -                                   -
                    -                                   -
                    -------------------------------------";
        }
        public string Area(float b, float a){

            return "Area Square="+(b*a);
        }
    }
    class Rectangle: IDrawing
    {
        public string Drawing()
        {
            return @"DRAWING Rectangle
                    -----------------------------------------------------
                    -                                                   -
                    -                                                   -
                    -                                                   -
                    -                                                   -
                    -                                                   -
                    ----------------------------------------------------";
        }
        public string Area(float b, float a){

            return "Area Rectangle="+(b*a);
        }
    }


    class Triangle: IDrawing
    {
        public string Drawing()
        {
            return @"DRAWING Triangle
                                    -
                                -      -
                             -              -
                         -                     -
                     -                           -
                  -                                  -
                  ------------------------------------
                    ";
        }
        public string Area(float b, float a){

            return "Area Rectangle="+(b*a)/2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRUEBA # 1");
            Thread.Sleep(2000);
            Console.WriteLine("Dibujando Cuadrado");
            Thread.Sleep(2000);
            Drawing(new DrawingSquare());
            Area(new DrawingSquare(),10,10);
            Thread.Sleep(2000);
            Console.WriteLine("PRUEBA # 2");
            Thread.Sleep(2000);
            Console.WriteLine("Dibujando Rectangulo");
            Thread.Sleep(2000);
            Drawing(new DrawingRectangle());
            Area(new DrawingRectangle(),10,20);
            Thread.Sleep(2000);
            Console.WriteLine("PRUEBA # 3");
            Thread.Sleep(2000);
            Console.WriteLine("Dibujando Triangulo");
            Thread.Sleep(2000);
            Drawing(new DrawingTriangle());
            Area(new DrawingTriangle(),10,20);
            Thread.Sleep(2000);
            Console.WriteLine("Bien Hecho!!!!!!");
        }
        public static void Drawing(Geometry obj)
        {
            Console.WriteLine(obj.Drawing());
            
        }
        public static void Area(Geometry obj,float b,float a){
            Console.WriteLine(obj.Area(b,a));
        }
    }
}
