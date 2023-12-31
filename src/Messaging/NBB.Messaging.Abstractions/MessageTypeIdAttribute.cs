﻿// Copyright (c) TotalSoft.
// This source code is licensed under the MIT license.

using System;

namespace NBB.Messaging.Abstractions
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MessageTypeIdAttribute : Attribute
    {
        public string MessageTypeId { get; }

        public MessageTypeIdAttribute(string messageTypeId)
        {
            MessageTypeId = messageTypeId;
        }
    }
}
