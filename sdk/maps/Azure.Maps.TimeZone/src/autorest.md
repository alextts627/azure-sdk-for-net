# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
input-file:
- https://raw.githubusercontent.com/Azure/azure-rest-api-specs/b749953e21e5c3f275d839862323920ef7bf716e/specification/maps/data-plane/Timezone/preview/1.0/timezone.json
title: MapsTimeZoneClient
openapi-type: data-plane
tag: 2.0
add-credentials: true
# at some point those credentials will move away to Swagger according to [this](https://github.com/Azure/autorest/issues/3718)
credential-default-policy-type: BearerTokenCredentialPolicy
credential-scopes: https://atlas.microsoft.com/.default
use-extension:
  "@autorest/modelerfour": "4.22.3"

generation1-convenience-client: true
model-namespace: false
sync-methods: None
license-header: MICROSOFT_MIT_NO_VERSION
namespace: Azure.Maps.TimeZone
public-clients: false
clear-output-folder: true
data-plane: true
skip-csproj: true
```

```yaml
directive:
- from: swagger-document
  where: $.securityDefinitions
  transform: |
    $["azure_auth"] = $["AADToken"];
    delete $["AADToken"];
- from: swagger-document
  where: '$.security[0]'
  transform: |
    $["azure_auth"] = $["AADToken"];
    delete $["AADToken"];
```
