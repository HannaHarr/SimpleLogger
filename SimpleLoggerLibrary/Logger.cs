using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLoggerLibrary
{
    public class Logger : ILogger
    {
        private IMessagePublisher messagePublisher;

        public Logger()
        {
            
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
