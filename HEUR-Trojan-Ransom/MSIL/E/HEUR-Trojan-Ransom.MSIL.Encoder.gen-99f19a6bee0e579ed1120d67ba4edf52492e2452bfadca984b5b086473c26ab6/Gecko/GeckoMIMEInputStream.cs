using System;
using Gecko.Interop;

namespace Gecko;

[Obsolete("Use Gecko.IO.MimeInputStream", true)]
public class GeckoMIMEInputStream : IDisposable
{
	private ComPtr<nsIMIMEInputStream> _inputStream;

	public nsIMIMEInputStream InputStream => _inputStream.Instance;

	public bool AddContentLength
	{
		set
		{
			_inputStream.Instance.SetAddContentLengthAttribute(value);
		}
	}

	public GeckoMIMEInputStream()
	{
		_inputStream = Xpcom.CreateInstance2<nsIMIMEInputStream>("@mozilla.org/network/mime-input-stream;1");
	}

	public void Dispose()
	{
		if (_inputStream != null)
		{
			Xpcom.DisposeObject(ref _inputStream);
		}
		_inputStream = null;
		GC.SuppressFinalize(this);
	}

	public void AddHeader(string name, string value)
	{
		_inputStream.Instance.AddHeader(name, value);
	}

	public void SetData(string data)
	{
		using ComPtr<nsIStringInputStream> comPtr = Xpcom.CreateInstance2<nsIStringInputStream>("@mozilla.org/io/string-input-stream;1");
		comPtr.Instance.SetData(data, data.Length);
		_inputStream.Instance.SetData(comPtr.Instance);
	}
}
