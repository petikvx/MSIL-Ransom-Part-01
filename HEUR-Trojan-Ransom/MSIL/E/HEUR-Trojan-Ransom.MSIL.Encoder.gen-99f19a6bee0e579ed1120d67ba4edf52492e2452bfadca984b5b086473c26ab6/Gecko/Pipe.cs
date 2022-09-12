using System;
using System.Threading;
using Gecko.IO;
using Gecko.Interop;

namespace Gecko;

public sealed class Pipe : IDisposable
{
	internal ComPtr<nsIPipe> _pipe;

	public InputStream InputStream => InputStream.Create(_pipe.Instance.GetInputStreamAttribute());

	public OutputStream OutputStream => OutputStream.Create(_pipe.Instance.GetOutputStreamAttribute());

	public Pipe()
	{
		_pipe = Xpcom.CreateInstance2<nsIPipe>("@mozilla.org/pipe;1");
		_pipe.Instance.Init(nonBlockingInput: true, nonBlockingOutput: true, 0u, 0u);
	}

	~Pipe()
	{
		Release();
	}

	public void Dispose()
	{
		Release();
		GC.SuppressFinalize(this);
	}

	private void Release()
	{
		if (_pipe != null)
		{
			ComPtr<nsIPipe> comPtr = Interlocked.Exchange(ref _pipe, null);
			comPtr.Dispose();
		}
	}
}
