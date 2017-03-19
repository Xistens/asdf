using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Helpers
{
    public class AppTimer
    {
        
        private Double _timeSpan;

        public AppTimer()
        {
            _timeSpan = DateTime.Now.Millisecond;
        }

        public Double Test()
        {
            return _timeSpan;
        }

    }
}
