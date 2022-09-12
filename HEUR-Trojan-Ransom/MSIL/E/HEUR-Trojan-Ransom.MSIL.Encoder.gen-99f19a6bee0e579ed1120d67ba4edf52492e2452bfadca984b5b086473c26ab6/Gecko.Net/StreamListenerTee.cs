using System;
using Gecko.IO.Native;
using Gecko.Interop;

namespace Gecko.Net;

public class StreamListenerTee : IDisposable
{
	internal ComPtr<nsIStreamListenerTee> _streamListenerTee;

	private RequestObserver _requestObserver = new RequestObserver();

	private byte[] _capturedData;

	private NativeOutputStream _nativeOutputStream = new NativeOutputStream(1048576);

	public event EventHandler Completed;

	public StreamListenerTee()
	{
		_streamListenerTee = Xpcom.CreateInstance2<nsIStreamListenerTee>("@mozilla.org/network/stream-listener-tee;1");
		_requestObserver.Stopped += OnStopped;
	}

	~StreamListenerTee()
	{
		Xpcom.DisposeObject(ref _streamListenerTee);
	}

	public void Dispose()
	{
		Xpcom.DisposeObject(ref _streamListenerTee);
		GC.SuppressFinalize(this);
	}

	private void Close()
	{
		Xpcom.DisposeObject(ref _nativeOutputStream);
	}

	internal void IntInit(nsIStreamListener streamListener)
	{
		_streamListenerTee.Instance.Init(streamListener, _nativeOutputStream, _requestObserver);
	}

	private void OnStopped(object sender, EventArgs e)
	{
		EventHandler completed = this.Completed;
		_capturedData = _nativeOutputStream.ReadData();
		completed?.Invoke(this, EventArgs.Empty);
		Close();
	}

	public byte[] GetCapturedData()
	{
		return _capturedData;
	}
}
