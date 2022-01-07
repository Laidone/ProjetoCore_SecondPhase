using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Tools
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
