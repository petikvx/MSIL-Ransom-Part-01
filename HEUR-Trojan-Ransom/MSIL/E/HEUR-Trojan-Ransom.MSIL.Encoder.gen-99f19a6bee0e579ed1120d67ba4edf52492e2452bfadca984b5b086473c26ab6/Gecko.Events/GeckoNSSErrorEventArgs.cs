using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Gecko.Certificates;
using Gecko.Interop;

namespace Gecko.Events;

public sealed class GeckoNSSErrorEventArgs : HandledEventArgs
{
	private int _statusCode;

	private Uri _uri;

	private SSLStatus _sslStatus;

	public Uri Uri => _uri;

	public int StatusCode => _statusCode;

	public NSSErrors ErrorCode => (NSSErrors)(-(_statusCode & 0xFFFF));

	public string Message
	{
		get
		{
			using ComPtr<nsINSSErrorsService> comPtr = Xpcom.GetService2<nsINSSErrorsService>("@mozilla.org/nss_errors_service;1");
			return nsString.Get(comPtr.Instance.GetErrorMessage, _statusCode);
		}
	}

	public int ErrorClass
	{
		get
		{
			ComPtr<nsINSSErrorsService> service = Xpcom.GetService2<nsINSSErrorsService>("@mozilla.org/nss_errors_service;1");
			try
			{
				return (int)service.Instance.GetErrorClass(_statusCode);
			}
			catch (COMException ex)
			{
				if (ex.ErrorCode != -2147418113)
				{
					throw;
				}
				return 1;
			}
			finally
			{
				((IDisposable)service).Dispose();
			}
		}
	}

	public SSLStatus SSLStatus => _sslStatus;

	public Certificate Certificate
	{
		get
		{
			if (_sslStatus != null)
			{
				return _sslStatus.ServerCert;
			}
			return null;
		}
	}

	public GeckoNSSErrorEventArgs(Uri uri, int status, SSLStatus sslStatus)
	{
		_statusCode = status;
		_uri = uri;
		_sslStatus = sslStatus;
	}
}
