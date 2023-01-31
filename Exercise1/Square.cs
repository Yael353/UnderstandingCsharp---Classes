using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Square
    {
        public int area;
        public int lengthSide;

        public Square(int lengthSide)
        {
            this.lengthSide = lengthSide;
            CalcArea();
        }

        private void CalcArea()
        {
            area = lengthSide * lengthSide;
        }
        public int Area 
        { 
            get 
            { 
                return area; 
            } 
        }
        public int LeangthSide 
        { 
            get
            { 
                return lengthSide; 
            } 
        }
        

    }
}
