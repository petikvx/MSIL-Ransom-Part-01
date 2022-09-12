using System;
using Gecko.Net;

namespace Gecko.Observers;

public class BaseHttpRequestResponseObserver : NsSupportsBase, nsIObserver
{
	internal bool _isRegistered;

	void nsIObserver.Observe(nsISupports aSubject, string aTopic, string aData)
	{
		if (!(aTopic == "http-on-modify-request"))
		{
			if (!(aTopic == "http-on-examine-response"))
			{
				return;
			}
			using HttpChannel channel = HttpChannel.Create(aSubject);
			try
			{
				Response(channel);
				return;
			}
			catch (Exception)
			{
				Console.WriteLine("Exception in observer implementation");
				return;
			}
		}
		using HttpChannel channel2 = HttpChannel.Create(aSubject);
		try
		{
			Request(channel2);
		}
		catch (Exception)
		{
			Console.WriteLine("Exception in observer implementation");
		}
	}

	protected virtual void Request(HttpChannel channel)
	{
	}

	protected virtual void Response(HttpChannel channel)
	{
	}
}
