using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02.Model
{
    abstract class AbstractStack : IStack
    {
        private ArrayList _arrayList = new ArrayList();

        protected ArrayList ArrayList { get => _arrayList;}

        public abstract int Count();

        public abstract object Pop();

        public abstract bool Push<T>(T itemToPush);

        public abstract void Clear();
    }
}
