using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wzorzec Fabryka oddziela kod, który tworzy konkretne obiekty od kodu, który faktycznie z nich korzysta
            //W ten sposób będzie nam o wiele łatwiej rozszerzać kod tworzący nowe obiekty bez konieczności ingerencji w resztę kodu
            var shapeFactory = new ShapeFactory();

            var circle = shapeFactory.CreateShape(ShapeType.Circle);
            circle.Render();

            var rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);
            rectangle.Render();

            var triangle = shapeFactory.CreateShape(ShapeType.Triangle);
            triangle.Render();
        }
    }
}
