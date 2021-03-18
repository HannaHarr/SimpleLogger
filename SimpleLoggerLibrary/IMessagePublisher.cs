using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLoggerLibrary
{
    public interface IMessagePublisher
    {
        public void Publish(string message);
    }
}
