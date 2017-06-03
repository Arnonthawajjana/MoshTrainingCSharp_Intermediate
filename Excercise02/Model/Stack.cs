using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02.Model
{
    class NormalStack : AbstractStack
    {

        public sealed override int Count()
        {
            return ArrayList.Count;
        }

        public sealed override object Pop()
        {
            if (!ArrayList.Count.Equals(0))
            {
                var item = ArrayList[ArrayList.Count - 1];
                ArrayList.RemoveAt(ArrayList.Count - 1);
                return item;
            }
            return new object();
        }

        public sealed override bool Push<T>(T itemToPush)
        {
            if (!itemToPush.Equals(null))
            {
                ArrayList.Add(itemToPush);
                return true;
            }
            return false;
        }

        public sealed override void Clear()
        {
            ArrayList.Clear();
        }

    }
}
