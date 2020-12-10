using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Array : IArray
    {

        private int Size;

        public int[] Arr { get; set; }


        public Array(int size)
        {
            this.Size = size;
        }
    }
}
