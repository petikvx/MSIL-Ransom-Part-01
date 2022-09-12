using System;

namespace Gecko.Net;

public sealed class RequestObserver : nsIRequestObserver
{
	public event EventHandler Started;

	public event EventHandler Stopped;

	void nsIRequestObserver.OnStartRequest(nsIRequest aRequest, nsISupports aContext)
	{
		this.Started?.Invoke(this, EventArgs.Empty);
	}

	void nsIRequestObserver.OnStopRequest(nsIRequest aRequest, nsISupports aContext, int aStatusCode)
	{
		this.Stopped?.Invoke(this, EventArgs.Empty);
	}
}
