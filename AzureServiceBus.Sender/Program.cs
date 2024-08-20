using Azure.Messaging.ServiceBus;

const string SERVICE_BUS_CONN_STRING = "your_conn_string_here";
const string QUEUE_NAME = "az-queue-name";
const int MAX_NUMBER_OF_MESSAGES = 10;

ServiceBusClient client;
ServiceBusSender sender;

client = new ServiceBusClient(SERVICE_BUS_CONN_STRING);
sender = client.CreateSender(QUEUE_NAME);

using ServiceBusMessageBatch batch = await sender.CreateMessageBatchAsync();
for (int i = 0; i < MAX_NUMBER_OF_MESSAGES; i++)
{
    if (!batch.TryAddMessage(new ServiceBusMessage($"This is a message - {i}")))
    {
        Console.WriteLine($"Message - {i} was not added!");
    }
}

try
{
    await sender.SendMessagesAsync(batch);
    Console.WriteLine("Messages sent");
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
    throw;
}
finally
{
    await sender.DisposeAsync();
    await client.DisposeAsync();
}



