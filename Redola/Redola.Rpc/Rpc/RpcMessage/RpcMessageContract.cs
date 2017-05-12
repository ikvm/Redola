﻿using System;

namespace Redola.Rpc
{
    public abstract class RpcMessageContract
    {
        public RpcMessageContract()
        {
            this.IsAsyncPattern = true;
            this.IsOneWay = false;
        }

        public RpcMessageContract(Type messageType)
            : this()
        {
            this.MessageType = messageType;
        }

        public Type MessageType { get; protected set; }

        public bool IsOneWay { get; protected set; }

        public bool IsAsyncPattern { get; set; }

        public override string ToString()
        {
            return string.Format("MessageType[{0}], IsOneWay[{1}], IsAsyncPattern[{2}]",
                this.MessageType, this.IsOneWay, this.IsAsyncPattern);
        }

        public MessageHandleStrategy ToStrategy()
        {
            return new MessageHandleStrategy(this.MessageType)
            {
                IsOneWay = this.IsOneWay,
                IsAsyncPattern = this.IsAsyncPattern,
            };
        }
    }
}
