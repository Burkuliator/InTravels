﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTravels.BLL.Infrastructure
{
    public class OperationDetails
    {
        public OperationDetails() : base()
        { }

        public OperationDetails(bool succedeed, string message, string prop, IEnumerable<string> errors)
        {
            Succedeed = succedeed;
            Message = message;
            Property = prop;
            Errors = errors;
        }

        public bool Succedeed { get; private set; }
        public string Message { get; private set; }
        public string Property { get; private set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
