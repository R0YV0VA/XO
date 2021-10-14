using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class Field
    {
        Field(int _complexity, int _pers)
        {
            complexity = _complexity;
            pers = _pers;
        }
        public int[,] field = new int[3, 3];
        private int complexity;
        private int pers;

    }
}
