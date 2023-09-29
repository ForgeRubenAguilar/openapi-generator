// See https://aka.ms/new-console-template for more information
using RichardSzalay.MockHttp;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Pets.Api;


var dataSets = new List<string> {
  // "Data/Pets-array.json",
  "Data/Pets-boolean.json",
  // "Data/Pets-enum.json",
  // "Data/Pets-float.json",
  // "Data/Pets-int.json",
  "Data/Pets-object.json",
  "Data/Pets-string.json",
};

foreach (var dataSet in dataSets)
{
  Console.WriteLine($"Testing {dataSet}");
  var jsonResponseString = System.IO.File.ReadAllText(dataSet);

  var mockHttp = new MockHttpMessageHandler();

  // Setup a response for the api
  mockHttp.When("http://localhost/pet/1111/oneOf")
          .Respond("application/json", jsonResponseString); // Respond with JSON
  mockHttp.When("http://localhost/pet/1111/anyOf")
          .Respond("application/json", jsonResponseString); // Respond with JSON

  var api = new PetTagApi(mockHttp.ToHttpClient());

  Console.WriteLine("Calling AnyOf");
  await api.GetPetAnyOfByIdAsync(1111);
  
  Console.WriteLine("Calling OneOf");
  await api.GetPetOneOfByIdAsync(1111);
}

