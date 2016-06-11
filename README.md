# AccurateBackground

Official API Documentation: https://developer.accuratebackground.com/#/apidoc

To use this .NET Accurate Background API, simply add your <b>Client Id</b> and <b>Client Secret</b> to your web.config

key="AccurateBackgroundClientId" value="{{Client Id Here}}" <br/>
key="AccurateBackgroundClientSecret" value="{{Client Secret Here}}"

<b>GET Candidate</b><br/>
await AccurateBackgroundAPI.GetCandidateAsync(candidateId);

<b>GET Candidates</b><br/>
await AccurateBackgroundAPI.GetCandidatesAsync();

<b>POST Candidate</b><br/>
await AccurateBackgroundAPI.CreateCandidateAsync(input);
 
<b>PUT Candidate</b><br/>
await AccurateBackgroundAPI.UpdateCandidateAsync(candidateId, input);

<b>GET Order</b><br/>
await AccurateBackgroundAPI.GetOrderAsync(orderId);

<b>POST Order</b><br/>
await AccurateBackgroundAPI.PlaceOrderAsync(input);

<b>GET Product</b><br/>
AccurateBackgroundAPI.GetProduct(productType);

<b>GET Products</b><br/>
AccurateBackgroundAPI.GetProducts();

<b>Ping the API</b><br/>
await AccurateBackgroundAPI.AliveAsync();
