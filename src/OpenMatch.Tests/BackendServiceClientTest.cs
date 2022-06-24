using System;
using Grpc.Net.Client;
using Xunit;

namespace OpenMatch.Tests
{
    public class BackendServiceClientTest
    {
        [Fact]
        public void CanCreateBackendServiceClient()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:6000");
            var omClient = new OpenMatch.BackendService.BackendServiceClient(channel);
        }
    }
}
