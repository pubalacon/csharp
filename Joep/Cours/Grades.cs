using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Notions
{
    class Grades
    {
        public int Math { get; set; }
        public int Physics { get; set; }

        public Grades(int math, int physics)
        {
            Math = math;
            Physics = physics;
        }
    }
}
