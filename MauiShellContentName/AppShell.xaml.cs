namespace MauiShellContentName;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

	// public ShellContent MainPage => DeviceInfo.Platform == DevicePlatform.Android ? pageAndroid : pageiOS;
	// public ShellContent PageOne => DeviceInfo.Platform == DevicePlatform.Android ? page1Android : page1iOS;
}
