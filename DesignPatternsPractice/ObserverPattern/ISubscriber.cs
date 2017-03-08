using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ObserverPattern
{
    interface ISubscriber
    {
        string ReadNews(string news);

        string AccountStatement(string statement);
    }
}
