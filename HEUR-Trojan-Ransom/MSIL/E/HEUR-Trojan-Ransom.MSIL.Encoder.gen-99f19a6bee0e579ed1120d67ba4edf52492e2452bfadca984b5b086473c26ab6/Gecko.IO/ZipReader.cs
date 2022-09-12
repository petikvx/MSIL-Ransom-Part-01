using System;
using System.Collections.Generic;
using Gecko.Collections;
using Gecko.Interop;

namespace Gecko.IO;

public sealed class ZipReader : IDisposable
{
	private ComPtr<nsIZipReader> _zipReader;

	public ZipReader()
	{
		_zipReader = Xpcom.CreateInstance2<nsIZipReader>("@mozilla.org/libjar/zip-reader;1");
	}

	~ZipReader()
	{
		Close();
	}

	public void Dispose()
	{
		Close();
		GC.SuppressFinalize(this);
	}

	public void Open(string fileName)
	{
		_zipReader.Instance.Open((nsIFile)Xpcom.NewNativeLocalFile(fileName));
	}

	public IEnumerable<string> FindEntries(nsAUTF8String pattern)
	{
		return new SimpleGeckoEnumerableCollection<string>(() => new Utf8StringEnumerator(_zipReader.Instance.FindEntries(pattern)));
	}

	public void Close()
	{
		Xpcom.DisposeObject(ref _zipReader);
	}

	public bool HasEntry(string entry)
	{
		return nsString.Pass(_zipReader.Instance.HasEntry, entry);
	}

	public bool Test(nsAUTF8String entry)
	{
		try
		{
			_zipReader.Instance.Test(entry);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
