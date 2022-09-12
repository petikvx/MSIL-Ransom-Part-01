using System;
using Gecko.Events;
using Gecko.Interop;

namespace Gecko;

public sealed class WebProgressListener : nsIWebProgressListener, nsIWebProgressListener2, nsISupportsWeakReference
{
	private bool _isListening = true;

	private Action<nsIWebProgress, nsIRequest, uint, int> _onStateChangeCallback;

	private Action<string> _onStatusChangeCallback;

	private Action<GeckoNavigatingEventArgs> _onNavigatingCallback;

	public bool IsListening
	{
		get
		{
			return _isListening;
		}
		set
		{
			_isListening = value;
		}
	}

	internal Action<nsIWebProgress, nsIRequest, uint, int> OnStateChangeCallback
	{
		get
		{
			return _onStateChangeCallback;
		}
		set
		{
			_onStateChangeCallback = value;
		}
	}

	internal Action<GeckoNavigatingEventArgs> OnNavigatingCallback
	{
		get
		{
			return _onNavigatingCallback;
		}
		set
		{
			_onNavigatingCallback = value;
		}
	}

	public Action<string> OnStatusChangeCallback
	{
		get
		{
			return _onStatusChangeCallback;
		}
		set
		{
			_onStatusChangeCallback = value;
		}
	}

	void nsIWebProgressListener.OnStateChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus)
	{
		OnStateChange(aWebProgress, aRequest, aStateFlags, aStatus);
	}

	void nsIWebProgressListener2.OnStateChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus)
	{
		OnStateChange(aWebProgress, aRequest, aStateFlags, aStatus);
	}

	private void OnStateChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus)
	{
		if (_isListening)
		{
			_onStateChangeCallback?.Invoke(aWebProgress, aRequest, aStateFlags, aStatus);
		}
	}

	void nsIWebProgressListener.OnProgressChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress)
	{
		OnProgressChange(aWebProgress, aRequest, aCurSelfProgress, aMaxSelfProgress, aCurTotalProgress, aMaxTotalProgress);
	}

	void nsIWebProgressListener2.OnProgressChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress)
	{
		OnProgressChange(aWebProgress, aRequest, aCurSelfProgress, aMaxSelfProgress, aCurTotalProgress, aMaxTotalProgress);
	}

	private void OnProgressChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress)
	{
		if (!_isListening)
		{
		}
	}

	void nsIWebProgressListener.OnLocationChange(nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation, uint aFlags)
	{
		OnLocationChange(aWebProgress, aRequest, aLocation, aFlags);
	}

	void nsIWebProgressListener2.OnLocationChange(nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation, uint aFlags)
	{
		OnLocationChange(aWebProgress, aRequest, aLocation, aFlags);
	}

	private void OnLocationChange(nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation, uint aFlags)
	{
		if (!_isListening)
		{
		}
	}

	void nsIWebProgressListener.OnStatusChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage)
	{
		OnStatusChange(aWebProgress, aRequest, aStatus, aMessage);
	}

	void nsIWebProgressListener2.OnStatusChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage)
	{
		OnStatusChange(aWebProgress, aRequest, aStatus, aMessage);
	}

	private void OnStatusChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage)
	{
		if (_isListening)
		{
			_onStatusChangeCallback?.Invoke(aMessage);
		}
	}

	void nsIWebProgressListener.OnSecurityChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState)
	{
		OnSecurityChange(aWebProgress, aRequest, aState);
	}

	void nsIWebProgressListener2.OnSecurityChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState)
	{
		OnSecurityChange(aWebProgress, aRequest, aState);
	}

	private void OnSecurityChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState)
	{
		if (!_isListening)
		{
		}
	}

	void nsIWebProgressListener2.OnProgressChange64(nsIWebProgress aWebProgress, nsIRequest aRequest, long aCurSelfProgress, long aMaxSelfProgress, long aCurTotalProgress, long aMaxTotalProgress)
	{
	}

	bool nsIWebProgressListener2.OnRefreshAttempted(nsIWebProgress aWebProgress, nsIURI aRefreshURI, int aMillis, bool aSameURI)
	{
		if (!_isListening)
		{
			return true;
		}
		Action<GeckoNavigatingEventArgs> onNavigatingCallback = _onNavigatingCallback;
		if (onNavigatingCallback == null)
		{
			return true;
		}
		Uri value = new Uri(nsString.Get(aRefreshURI.GetSpecAttribute));
		bool flag = false;
		using (GeckoWindow domWind = aWebProgress.GetDOMWindowAttribute().Wrap((nsIDOMWindow x) => new GeckoWindow(x)))
		{
			GeckoNavigatingEventArgs geckoNavigatingEventArgs = new GeckoNavigatingEventArgs(value, domWind);
			onNavigatingCallback(geckoNavigatingEventArgs);
			flag = geckoNavigatingEventArgs.Cancel;
		}
		return !flag;
	}

	public nsIWeakReference GetWeakReference()
	{
		return new nsWeakReference(this);
	}
}
