using System;
using Gecko.Interop;

namespace Gecko.Net;

public class Request : IDisposable
{
	private ComPtr<nsIRequest> _request;

	public nsIRequest NativeRequest => _request.Instance;

	public string Name => nsString.Get(_request.Instance.GetNameAttribute);

	public bool IsPending
	{
		get
		{
			try
			{
				return _request.Instance.IsPending();
			}
			catch (NotImplementedException)
			{
				return false;
			}
		}
	}

	public int Status
	{
		get
		{
			try
			{
				return _request.Instance.GetStatusAttribute();
			}
			catch (NotImplementedException)
			{
				return 0;
			}
		}
	}

	public LoadGroup LoadGroup
	{
		get
		{
			return _request.Instance.GetLoadGroupAttribute().Wrap((nsILoadGroup x) => new LoadGroup(x));
		}
		set
		{
			_request.Instance.SetLoadGroupAttribute(value?._loadGroup);
		}
	}

	public uint LoadFlags
	{
		get
		{
			return _request.Instance.GetLoadFlagsAttribute();
		}
		set
		{
			_request.Instance.SetLoadFlagsAttribute(value);
		}
	}

	protected Request(nsIRequest request)
	{
		_request = new ComPtr<nsIRequest>(request);
	}

	~Request()
	{
		Xpcom.DisposeObject(ref _request);
	}

	public void Dispose()
	{
		Xpcom.DisposeObject(ref _request);
		GC.SuppressFinalize(this);
	}

	public void Cancel(int aStatus)
	{
		_request.Instance.Cancel(aStatus);
	}

	public void Suspend()
	{
		_request.Instance.Suspend();
	}

	public void Resume()
	{
		_request.Instance.Resume();
	}

	public override int GetHashCode()
	{
		return _request.Instance.GetHashCode();
	}

	public static Request CreateRequest(nsIRequest request)
	{
		if (request is nsIChannel)
		{
			return Channel.CreateChannel((nsIChannel)request);
		}
		if (request is nsIAsyncStreamCopier)
		{
			return new AsyncStreamCopier((nsIAsyncStreamCopier)request);
		}
		if (request is nsILoadGroup)
		{
			return new LoadGroup((nsILoadGroup)request);
		}
		if (request is nsIIncrementalDownload)
		{
			return new IncrementalDownload((nsIIncrementalDownload)request);
		}
		if (request is imgIRequest)
		{
			return new ImgRequest((imgIRequest)request);
		}
		if (!(request is nsIInputStreamPump))
		{
		}
		return new Request(request);
	}
}
