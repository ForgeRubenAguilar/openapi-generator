# Pets.Api.PetTagApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPetAnyOfById**](PetTagApi.md#getpetanyofbyid) | **GET** /pet/{petId}/anyOf | Find pet by ID |
| [**GetPetOneOfById**](PetTagApi.md#getpetoneofbyid) | **GET** /pet/{petId}/oneOf | Find pet by ID |

<a id="getpetanyofbyid"></a>
# **GetPetAnyOfById**
> PetAnyOf GetPetAnyOfById (long petId)

Find pet by ID

Returns a single pet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Pets.Api;
using Pets.Client;
using Pets.Model;

namespace Example
{
    public class GetPetAnyOfByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetTagApi(httpClient, config, httpClientHandler);
            var petId = 789L;  // long | ID of pet to return

            try
            {
                // Find pet by ID
                PetAnyOf result = apiInstance.GetPetAnyOfById(petId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetTagApi.GetPetAnyOfById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPetAnyOfByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find pet by ID
    ApiResponse<PetAnyOf> response = apiInstance.GetPetAnyOfByIdWithHttpInfo(petId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetTagApi.GetPetAnyOfByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petId** | **long** | ID of pet to return |  |

### Return type

[**PetAnyOf**](PetAnyOf.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Invalid ID supplied |  -  |
| **404** | Pet not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpetoneofbyid"></a>
# **GetPetOneOfById**
> PetOneOf GetPetOneOfById (long petId)

Find pet by ID

Returns a single pet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Pets.Api;
using Pets.Client;
using Pets.Model;

namespace Example
{
    public class GetPetOneOfByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetTagApi(httpClient, config, httpClientHandler);
            var petId = 789L;  // long | ID of pet to return

            try
            {
                // Find pet by ID
                PetOneOf result = apiInstance.GetPetOneOfById(petId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetTagApi.GetPetOneOfById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPetOneOfByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find pet by ID
    ApiResponse<PetOneOf> response = apiInstance.GetPetOneOfByIdWithHttpInfo(petId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetTagApi.GetPetOneOfByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petId** | **long** | ID of pet to return |  |

### Return type

[**PetOneOf**](PetOneOf.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Invalid ID supplied |  -  |
| **404** | Pet not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

