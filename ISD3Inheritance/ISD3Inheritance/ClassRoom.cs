using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class ClassRoom
    {
        public Pupil[] p;
        public ClassRoom(Pupil first, Pupil second, Pupil third, Pupil fourth)
        {
            p[0] = first;
            p[1] = second;
            p[2] = third;
            p[3] = fourth;
        }
        public ClassRoom(Pupil first, Pupil second) : this(first, second, null, null)
        {
        }

        public ClassRoom(Pupil first, Pupil second, Pupil third) : this(first, second, third, null)
        {
        }
    }
}
