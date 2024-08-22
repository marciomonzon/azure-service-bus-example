# Azure Service Bus in Action
<p>
  This is an example of Azure Service Bus in C#.  
</p>
<p>
  It is using the Queue feature of an Azure Service Bus.
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

<br>

## Azure Service Bus Queue
<p> This example is using Queue feature of Azure Service Bus when you can create queues to send and consume messages. Check the image below where you can see the feature and the queue created: </p>

![image](https://github.com/user-attachments/assets/4f2c2026-ef65-4974-ab18-4ae59ceea9b6)

<br>

## Azure Service Bus Connection String
<p>As mentioned before, the Sender and the Consumer must have the same connection string set. You can found it in the Settings / Shared Access Policies. Check the image below: </p>
![image](https://github.com/user-attachments/assets/71105648-330b-48b2-bfd0-0ec6be30f12e)

<p>
  In the example project, I used the Primary Connection String, which in my tests was set in the follow constant:
  <img width="391" alt="image" src="https://github.com/user-attachments/assets/3b60c94b-b00c-410c-ae04-db09e68d95d8">
</p>

<br>

##References:
- https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-queues-topics-subscriptions
- https://www.udemy.com/course/microsoft-azure-for-net-developers/?couponCode=SKILLS4SALEB






