using Azure.Messaging.ServiceBus;

const string SERVICE_BUS_CONN_STRING = "your_conn_string_here";
const string QUEUE_NAME = "az-queue-name";

ServiceBusClient client;
ServiceBusProcessor processor = default!;

async Task MessageHandler(ProcessMessageEventArgs processMessageEventArgs)
{
    string body = processMessageEventArgs.Message.Body.ToString();
    Console.WriteLine(body);

    await processMessageEventArgs.CompleteMessageAsync(processMessageEventArgs.Message);
}

Task ErrorHandler(ProcessErrorEventArgs processErrorEventArgs)
{
    Console.WriteLine(processErrorEventArgs.Exception.ToString());
    return Task.CompletedTask;
}

client = new ServiceBusClient(SERVICE_BUS_CONN_STRING);
processor = client.CreateProcessor(QUEUE_NAME, new ServiceBusProcessorOptions());

try
{
    processor.ProcessMessageAsync += MessageHandler;
    processor.ProcessErrorAsync += ErrorHandler;

    await processor.StartProcessingAsync();

    Console.WriteLine("Press any key to end the processing");
    Console.ReadKey();

    Console.WriteLine("\nStopping the receiver...");
    await processor.StopProcessingAsync();
    Console.WriteLine("\nStopped receiving messages");
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}
finally
{
    await processor.DisposeAsync();
    await client.DisposeAsync();
}