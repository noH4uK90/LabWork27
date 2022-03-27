using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ShapeFactory
    {
        public IShape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }

            return null;
        }
    }
}
