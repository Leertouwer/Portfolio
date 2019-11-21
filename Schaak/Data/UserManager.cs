using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;

namespace Schaak.Data
{
    class SampleLogger : ILogger<UserManager<IdentityUser>>
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel == LogLevel.Trace;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            Console.WriteLine($"Log: {logLevel}; exception = {exception}; ");
        }
    }

 

}
