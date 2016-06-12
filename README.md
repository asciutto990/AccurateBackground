# Accurate Background for .NET

Official API Documentation: https://developer.accuratebackground.com/#/apidoc

To use this .NET Accurate Background API, simply add your <b>Client Id</b> and <b>Client Secret</b> to your web.config

```xml
  <appSettings>
    <add key="AccurateBackgroundClientId" value="{{value here}}"/>
    <add key="AccurateBackgroundClientSecret" value="{{value here}}"/>
  </appSettings>
```

<b>GET Candidate</b><br/>
```C#
await AccurateBackgroundAPI.GetCandidateAsync(candidateId);
```
<b>GET Candidates</b><br/>
```C#
await AccurateBackgroundAPI.GetCandidatesAsync();
```

<b>POST Candidate</b><br/>
```C#
await AccurateBackgroundAPI.CreateCandidateAsync(input);
```
 
<b>PUT Candidate</b><br/>
```C#
await AccurateBackgroundAPI.UpdateCandidateAsync(candidateId, input);
```

<b>GET Order</b><br/>
```C#
await AccurateBackgroundAPI.GetOrderAsync(orderId);
```

<b>POST Order</b><br/>
```C#
await AccurateBackgroundAPI.PlaceOrderAsync(input);
```

<b>GET Product</b><br/>
```C#
AccurateBackgroundAPI.GetProduct(productType);
```

<b>GET Products</b><br/>
```C#
AccurateBackgroundAPI.GetProducts();
```

<b>Ping the API</b><br/>
```C#
await AccurateBackgroundAPI.AliveAsync();
```

<b>Error Handling</b><br/>
```C#
try
{
    await AccurateBackgroundAPI.PlaceOrderAsync(input);
}
catch (AccurateRequestException e)
{
   //handle error
}
```
