using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions4HW
{
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
