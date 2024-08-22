# Azure Service Bus in Action
<p>
  This is an example of Azure Service Bus in C#.  
</p>
<p>
  It is based on a Queue Messaging Architecture and the broker used is an Azure Service Bus.
  It has two projects, one is the sender and the other is the consumer. 
</p>

## Stack
- .NET 8;
- Console Applications: Sender and Consumer;
- Nugget Package: Azure Messaging Service Bus.

## How it Works?
<p>
  The Sender (AzureServiceBus.Sender) <b>sends</b> some messages to a specific Azure Service Bus in Azure Cloud.
  Once the message get the Queue in the Broker, The Consumer (AzureServiceBus.Consumer) will <b>consume</b> these messages and display them to the user.
</p>
<p>
  The Sender and Consumer <b>must have the same Service Bus Connection String</b> set in the code.
  Check the diagram below to a better understanding.
</p>

![AzureServiceBus drawio](https://github.com/user-attachments/assets/30d339ce-1821-4799-a83f-3ad6c5550d09)




