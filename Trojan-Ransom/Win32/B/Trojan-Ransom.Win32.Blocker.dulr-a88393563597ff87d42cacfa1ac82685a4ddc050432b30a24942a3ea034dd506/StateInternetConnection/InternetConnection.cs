using System.Runtime.InteropServices;

namespace StateInternetConnection;

public class InternetConnection
{
	public enum InternetConnectionState
	{

	}

	private bool isInternetConnected;

	public bool IsInternetConnected => isInternetConnected;

	[DllImport("WININET", CharSet = CharSet.Auto)]
	private static extern bool InternetGetConnectedState(ref InternetConnectionState lpdwFlags, int dwReserved);

	public void Init()
	{
		InternetConnectionState lpdwFlags = (InternetConnectionState)0;
		isInternetConnected = InternetGetConnectedState(ref lpdwFlags, 0);
	}
}
