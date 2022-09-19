# Azure Maps TimeZone client library for .NET

Azure Maps TimeZone is a library that allows users to get current, historical, and future time zone information for the specified given input such as a specified latitude-longitude pair, IANA time zone ID, etc.

  [Source code](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/timezone/Azure.Maps.TimeZone/src) | [Package (NuGet)](https://www.nuget.org/packages/Azure.Maps.TimeZone) | [API reference documentation](https://azure.github.io/azure-sdk-for-net) | [Product documentation](https://docs.microsoft.com/azure)

## Getting started

### Install the package

Install the client library for .NET with [NuGet](https://www.nuget.org/ ):

```dotnetcli
dotnet add package Azure.Maps.TimeZone --prerelease
```

### Prerequisites

> You must have an [Azure subscription](https://azure.microsoft.com/free/dotnet/) and [Azure Maps account](https://docs.microsoft.com/azure/azure-maps/quick-demo-map-app#create-an-azure-maps-account).

To create a new Azure Maps account, you can use the Azure Portal, Azure PowerShell, or the Azure CLI. Here's an example using the Azure CLI:

```powershell
az maps account create --kind "Gen2" --disable-local-auth true --account-name "myMapAccountName" --resource-group "<resource group>" --sku "G2" --accept-tos
```

### Authenticate the client

There are 2 ways to authenticate the client: Shared key authentication and Azure AD.

#### Shared Key authentication

* Go to Azure Maps account > Authentication tab
* Copy `Primary Key` or `Secondary Key` under **Shared Key authentication** section

```C# Snippet:InstantiateRouteClientViaSubscriptionKey
// Create a MapsTimeZoneClient that will authenticate through Subscription Key (Shared key)
AzureKeyCredential credential = new AzureKeyCredential("<My Subscription Key>");
MapsTimeZoneClient client = new MapsTimeZoneClient(credential);
```

#### Azure AD authentication

In order to interact with the Azure Maps service, you'll need to create an instance of the `MapsTimeZoneClient` class. The [Azure Identity library](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/identity/Azure.Identity/README.md) makes it easy to add Azure Active Directory support for authenticating Azure SDK clients with their corresponding Azure services.

To use AAD authentication, set the environment variables as described in the [Azure Identity README](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/identity/Azure.Identity/README.md) and create a `DefaultAzureCredential` instance to use with the `MapsTimeZoneClient`.

We also need an **Azure Maps Client ID** which can be found on the Azure Maps page > Authentication tab > "Client ID" in Azure Active Directory Authentication section.

![AzureMapsPortal](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/maps/Azure.Maps.Routing/images/azure-maps-portal.png?raw=true)

```C# Snippet:InstantiateRouteClientViaAAD
// Create a MapsTimeZoneClient that will authenticate through Active Directory
TokenCredential credential = new DefaultAzureCredential();
string clientId = "<Your Map ClientId>";
MapsTimeZoneClient client = new MapsTimeZoneClient(credential, clientId);
```

## Key concepts


### Thread safety

We guarantee that all client instance methods are thread-safe and independent of each other ([guideline](https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-service-methods-thread-safety)). This ensures that the recommendation of reusing client instances is always safe, even across threads.

### Additional concepts
<!-- CLIENT COMMON BAR -->
[Client options](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/README.md#configuring-service-clients-using-clientoptions) |
[Accessing the response](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/README.md#accessing-http-response-details-using-responset) |
[Long-running operations](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/README.md#consuming-long-running-operations-using-operationt) |
[Handling failures](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/README.md#reporting-errors-requestfailedexception) |
[Diagnostics](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/Diagnostics.md) |
[Mocking](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/README.md#mocking) |
[Client lifetime](https://devblogs.microsoft.com/azure-sdk/lifetime-management-and-thread-safety-guarantees-of-azure-sdk-net-clients/)
<!-- CLIENT COMMON BAR -->

## Examples

You can familiarize yourself with different APIs using [Samples](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/maps/Azure.Maps.TimeZone/samples).

Before calling route APIs, instantiate a `MapsTimeZoneClient` first. This example uses AAD to create the client instance:

```C# Snippet:InstantiateRouteClientViaAAD
// Create a MapsTimeZoneClient that will authenticate through Active Directory
TokenCredential credential = new DefaultAzureCredential();
string clientId = "<Your Map ClientId>";
MapsTimeZoneClient client = new MapsTimeZoneClient(credential, clientId);
```

### <scenario>

You can create a client and call the client's `<operation>` method.

```C# Snippet:Azure_Maps_TimeZone_Scenario
```

## Troubleshooting

When you interact with the Azure Maps services, errors returned by the Language service correspond to the same HTTP status codes returned for [REST API requests](https://docs.microsoft.com/rest/api/maps/geolocation).

For example, if you pass wrong IP address, an error is returned, indicating "Bad Request" (HTTP Status code: 400).

```C# Snippet:CatchTimeZoneException
try
{
    // An invalid IP address
    string inValidIpAddress = "xxx";

    Response<IpAddressToLocationResult> result = client.GetLocation(inValidIpAddress);
    // Do something with result ...
}
catch (RequestFailedException e)
{
    Console.WriteLine(e.ToString());
}
```

## Next steps

* For more context and additional scenarios, please see: [detailed samples](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/maps/Azure.Maps.TimeZone/samples)

## Contributing

See the [CONTRIBUTING.md](https://github.com/Azure/azure-sdk-for-net/blob/main/CONTRIBUTING.md) for details on building, testing, and contributing to this library.

This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit <cla.microsoft.com>.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact <opencode@microsoft.com> with any additional questions or comments.

![Impressions](https://azure-sdk-impressions.azurewebsites.net/api/impressions/azure-sdk-for-net/sdk/maps/Azure.Maps.TimeZone/README.png)
