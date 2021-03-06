﻿using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Tests.Integration.Common.Commands.Model;

namespace FunctionMonkey.Tests.Integration.Common.Commands
{
    public class HttpHeaderNullableValueTypeBindingCommand : ICommand<SimpleResponse>
    {
        public int? Value { get; set; }
    }
}
