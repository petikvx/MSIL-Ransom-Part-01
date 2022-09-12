using System;

namespace Gecko.WebIDL;

public class MozNetworkStatsData : WebIDLBase
{
	public uint RxBytes => GetProperty<uint>("rxBytes");

	public uint TxBytes => GetProperty<uint>("txBytes");

	public IntPtr Date => GetProperty<IntPtr>("date");

	public MozNetworkStatsData(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
