using Gecko.Interop;

namespace Gecko.IO;

public sealed class MimeInputStream : InputStream
{
	private nsIMIMEInputStream _mimeInputStream;

	public bool AddContentLength
	{
		get
		{
			return _mimeInputStream.GetAddContentLengthAttribute();
		}
		set
		{
			_mimeInputStream.SetAddContentLengthAttribute(value);
		}
	}

	internal MimeInputStream(nsIMIMEInputStream stream)
		: base(stream)
	{
		_mimeInputStream = stream;
	}

	public void AddHeader(string name, string value)
	{
		_mimeInputStream.AddHeader(name, value);
	}

	public void SetData(InputStream stream)
	{
		_mimeInputStream.SetData(stream._inputStream);
	}

	public void SetData(string data)
	{
		using ComPtr<nsIStringInputStream> comPtr = Xpcom.CreateInstance2<nsIStringInputStream>("@mozilla.org/io/string-input-stream;1");
		comPtr.Instance.SetData(data, data.Length);
		_mimeInputStream.SetData(comPtr.Instance);
	}

	public static MimeInputStream Create()
	{
		nsIMIMEInputStream stream = Xpcom.CreateInstance<nsIMIMEInputStream>("@mozilla.org/network/mime-input-stream;1");
		return new MimeInputStream(stream);
	}
}
