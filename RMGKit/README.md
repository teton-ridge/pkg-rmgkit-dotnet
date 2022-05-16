# RMGKit.net

RMG API connection library.

## Usage Examples

### App Usage

Coming Soon 

### Web Usage

```
// endpoint version over rides
Dictionary<string, string> endpointOverrides =  new Dictionary<string, string>
{
	{ RMGKit.Requests.Navigation.Endpoints.get, "v7" }
};
			
// configure the connection
RMGKit.Service M_apiService = new RMGKit.Service();
M_apiService.Configure(
	"https://mapi.rfdtv.com",
	"rfdmobile",
	"U82312JM65SD7M5523SAXC81P9",
	"rfd",
	"Web 1.0",
	null,
	null,
	endpointOverrides);
	
// get the navigation data in an MVC controller 
public async Task<ActionResult> Index()
{
	ViewBag.SyncType = "Asynchronous";

	var getNavigation = M_apiService.Fetch<RMGKit.Models.Navigation.Navigation>(
		RMGKit.Requests.Navigation.Get());
	await Task.WhenAll(getNavigation);

	return View();
}
```