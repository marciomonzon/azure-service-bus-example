# Azure Service Bus in Action
<p>
  This is an example of Azure Service Bus in C#.  
</p>
<p>
  It is based on a publish-subscribe architecture and the broker used is an Azure Service bus.
  It has two projects, one is the sender and the other is the consumer. 
</p>

## Stack
- .NET 8;
- Console Applications: Sender and Consumer;
- Nugget Package: Azure Messaging Service Bus.

## How it Works?
<p>
  The Sender (AzureServiceBus.Sender) <b>publish</b> some messages to a specific Azure Service Bus in Azure Cloud.
  Once the message get the Queue in the Broker, The Consumer (AzureServiceBus.Consumer), that is <b>subscribed</b> to the same Queue, 
  get these message and display them to the user.
</p>
<p>
  As this is a Publish-Subscribe architecture, the Sender and Consumer <b>must have the same Service Bus Connection String</b> set in the code.
  Check the diagram below to a better understanding
</p>


