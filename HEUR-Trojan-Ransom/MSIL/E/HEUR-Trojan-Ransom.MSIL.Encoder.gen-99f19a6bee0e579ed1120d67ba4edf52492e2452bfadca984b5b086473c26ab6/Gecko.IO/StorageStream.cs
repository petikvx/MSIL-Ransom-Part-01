using Gecko.Interop;

namespace Gecko.IO;

public sealed class StorageStream
{
	private ComPtr<nsIStorageStream> _storageStream;

	public uint Length
	{
		get
		{
			return _storageStream.Instance.GetLengthAttribute();
		}
		set
		{
			_storageStream.Instance.SetLengthAttribute(value);
		}
	}

	public StorageStream()
	{
		_storageStream = Xpcom.CreateInstance2<nsIStorageStream>("@mozilla.org/storagestream;1");
		_storageStream.Instance.Init(32768u, 16777216u);
	}

	public OutputStream GetOutputStream(int position)
	{
		return OutputStream.Create(_storageStream.Instance.GetOutputStream(position));
	}

	public InputStream NewInputStream(int position)
	{
		return InputStream.Create(_storageStream.Instance.NewInputStream(position));
	}
}
