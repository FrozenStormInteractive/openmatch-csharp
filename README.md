# OpenMatch C# API

[![Nuget](https://img.shields.io/nuget/dt/OpenMatch.Api)](https://www.nuget.org/packages/OpenMatch.Api/) [![Azure Pipelines](https://dev.azure.com/FrozenStormInteractive/OpenMatch%20CSharp/_apis/build/status/FrozenStormInteractive.openmatch-csharp?branchName=master)](https://dev.azure.com/FrozenStormInteractive/OpenMatch%20CSharp/_build/latest?definitionId=5&branchName=master)

# Usage

```sh
dotnet add package OpenMatch.Api
```

## Getting started

### Client

```c#
// Create the grpc.
using var channel = GrpcChannel.ForAddress("https://localhost:5001");

var frontendClient  = new OpenMatch.FrontendService.FrontendServiceClient(channel);

await frontendClient.CreateTicketAsync(request); 
```

There is others services:
- `OpenMatch.FrontendService.FrontendServiceClient`
- `OpenMatch.BackendService.BackendServiceClient`
- `OpenMatch.EvaluatorService.EvaluatorServiceClient`
- `OpenMatch.MatchFunction.MatchFunctionServiceClient`
- `OpenMatch.QueryService.QueryServiceClient`


See [Open Match API References](https://open-match.dev/site/docs/reference/api/) for more informations.


## Contributing

Please see [CONTRIBUTING.md](CONTRIBUTING.md) for instructions on how to contribute.
