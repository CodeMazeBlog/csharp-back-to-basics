using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3ReferentType
{
    public class Pen
    {
        public Color Color { get; set; }

        public Pen(Color color)
        {
            this.Color = color;
        }
    }
}
