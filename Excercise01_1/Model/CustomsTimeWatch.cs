using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_1.Model
{
    class CustomsTimeWatch
    {
        private TimeSpan _watch;

        public CustomsTimeWatch()
        {
            this._watch = new TimeSpan();
        }

        public void Start()
        {
            if (this._watch.Equals(TimeSpan.Zero))
                this._watch = DateTime.Now.TimeOfDay;
            else
            {
                throw new InvalidOperationException("Can't start again before stop");
            }
        }
        public void Stop()
        {
            if (!this._watch.Equals(TimeSpan.Zero))
            {
                Console.WriteLine(DateTime.Now.TimeOfDay - this._watch);
                this._watch = TimeSpan.Zero;
            }
        }

    }
}
