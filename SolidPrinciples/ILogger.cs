using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public interface ILogger
    {
        void Handle(string error);
    }

    public class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText("@c:\temp\temp.txt", error);
        }
    }

    public class EventLogger : ILogger
    {
        public void Handle(string error)
        {
            //implement later
        }
    }


    class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            //implement later
        }
    }
}
