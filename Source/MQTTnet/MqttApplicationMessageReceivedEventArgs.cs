using System;
using System.Collections.Generic;
using MQTTnet.Client.Publishing;
using MQTTnet.Packets;
using MQTTnet.Protocol;

namespace MQTTnet
{
    public class MqttApplicationMessageReceivedEventArgs : EventArgs
    {
        public MqttApplicationMessageReceivedEventArgs(string clientId, MqttApplicationMessage applicationMessage)
        {
            ClientId = clientId;
            ApplicationMessage = applicationMessage ?? throw new ArgumentNullException(nameof(applicationMessage));
        }

        public string ClientId { get; }

        public MqttApplicationMessage ApplicationMessage { get; }

        public MqttClientPublishResult Response { get; set; }

        public bool ProcessingFailed { get; set; }
    }
}
