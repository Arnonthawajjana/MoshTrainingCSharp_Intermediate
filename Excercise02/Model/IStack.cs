using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02.Model
{
    interface IStack
    {
        int Count();

        object Pop();

        bool Push<T>(T itemToPush);

        void Clear();
    }
}
