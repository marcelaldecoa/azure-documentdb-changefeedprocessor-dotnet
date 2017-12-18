﻿using System;

namespace Microsoft.Azure.Documents.ChangeFeedProcessor.Exceptions
{
    public class PartitionException : Exception
    {
        public string LastContinuation { get; }

        public PartitionException(string lastContinuation)
        {
            LastContinuation = lastContinuation;
        }
    }
}