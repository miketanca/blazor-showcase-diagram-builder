using Microsoft.AspNetCore.Components.WebView.Maui;
using DiagramBuilderMAUI.Data;
using DiagramBuilderMAUI.Shared;
using Syncfusion.Blazor;

namespace DiagramBuilderMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkX1pFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSH9Vdk1nWn9bcnFRRA==;Mgo+DSMBPh8sVXJ0S0J+XE9AdVRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0RlWXdac3RQRGdeUw==;ORg4AjUWIQA/Gnt2VVhkQlFaclxJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRiX39WdHdVQ2JUV0Y=;OTQ4MDE0QDMyMzAyZTM0MmUzMGFjSXZwTnZtVVVYVC9MaHlkazFYNDYrdEVWRDFTNmlQeU9HVDFQclczVmM9;OTQ4MDE1QDMyMzAyZTM0MmUzMFRCQWhPcW5nRVlNMlZVVGk4dUJUWDk0dkZWbVR6WWR4dlRzRkdGa01GaUk9;NRAiBiAaIQQuGjN/V0Z+WE9EaFtBVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViWHleeHBWRmVfVEx0;OTQ4MDE3QDMyMzAyZTM0MmUzMFBxVWkySjF6QWZQNVVLbHlVQWRodklMc2tyYStRcllseEt3Y3RvdTRlRmc9;OTQ4MDE4QDMyMzAyZTM0MmUzMFNiU1BvaTE1WUtsL0I3eVlJQmtUYlR2QjRhZEM3WjV6NnV1ejZHZVhzeHM9;Mgo+DSMBMAY9C3t2VVhkQlFaclxJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRiX39WdHdVQ2VeWEY=;OTQ4MDIwQDMyMzAyZTM0MmUzMFBoRVUrSXVaQ05WZ1ZBUGM3VmU2dnRiaUd2RlJIS1l3WjJWSTgvaHQvV1E9;OTQ4MDIxQDMyMzAyZTM0MmUzMFBmM1ZtRExwMGVNNkV2Sk1vZ1I3YTFZZ1dCNVE5OTR0TUJiRjJlb0xJcWM9;OTQ4MDIyQDMyMzAyZTM0MmUzMFBxVWkySjF6QWZQNVVLbHlVQWRodklMc2tyYStRcllseEt3Y3RvdTRlRmc9");

        var builder = MauiApp.CreateBuilder();
		builder			
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = false; });
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        builder.Services.AddSingleton<SampleService>();
		return builder.Build();
	}
}
