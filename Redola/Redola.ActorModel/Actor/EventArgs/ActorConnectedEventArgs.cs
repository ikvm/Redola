﻿using System;

namespace Redola.ActorModel
{
    public class ActorConnectedEventArgs : EventArgs
    {
        public ActorConnectedEventArgs(string actorChannelIdentifier, ActorIdentity remoteActor)
        {
            if (string.IsNullOrEmpty(actorChannelIdentifier))
                throw new ArgumentNullException("actorChannelIdentifier");
            if (remoteActor == null)
                throw new ArgumentNullException("remoteActor");

            this.ActorChannelIdentifier = actorChannelIdentifier;
            this.RemoteActor = remoteActor;
        }

        public string ActorChannelIdentifier { get; private set; }
        public ActorIdentity RemoteActor { get; private set; }

        public override string ToString()
        {
            return string.Format("ActorChannelIdentifier[{0}], RemoteActor[{1}]", ActorChannelIdentifier, RemoteActor);
        }
    }
}
