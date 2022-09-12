using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Zstandard.Net;

public sealed class ZstandardDictionary : IDisposable
{
	private byte[] dictionary;

	private IntPtr ddict;

	private Dictionary<int, IntPtr> cdicts = new Dictionary<int, IntPtr>();

	private object lockObject = new object();

	private bool isDisposed = false;

	public ZstandardDictionary(byte[] dictionary)
	{
		this.dictionary = dictionary;
	}

	public ZstandardDictionary(string dictionaryPath)
	{
		dictionary = File.ReadAllBytes(dictionaryPath);
	}

	public ZstandardDictionary(Stream dictionaryStream)
	{
		using MemoryStream memoryStream = new MemoryStream();
		dictionaryStream.CopyTo(memoryStream);
		dictionary = memoryStream.ToArray();
	}

	~ZstandardDictionary()
	{
		Dispose(dispose: false);
	}

	public void Dispose()
	{
		Dispose(dispose: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool dispose)
	{
		if (isDisposed)
		{
			return;
		}
		isDisposed = true;
		if (ddict != IntPtr.Zero)
		{
			ZstandardInterop.ZSTD_freeDDict(ddict);
			ddict = IntPtr.Zero;
		}
		foreach (KeyValuePair<int, IntPtr> item in cdicts.ToList())
		{
			ZstandardInterop.ZSTD_freeCDict(item.Value);
			cdicts.Remove(item.Key);
		}
	}

	internal IntPtr GetCompressionDictionary(int compressionLevel)
	{
		if (isDisposed)
		{
			throw new ObjectDisposedException("ZstandardDictionary");
		}
		lock (lockObject)
		{
			if (!cdicts.TryGetValue(compressionLevel, out var value))
			{
				value = (cdicts[compressionLevel] = CreateCompressionDictionary(compressionLevel));
			}
			return value;
		}
	}

	internal IntPtr GetDecompressionDictionary()
	{
		if (isDisposed)
		{
			throw new ObjectDisposedException("ZstandardDictionary");
		}
		lock (lockObject)
		{
			if (ddict == IntPtr.Zero)
			{
				ddict = CreateDecompressionDictionary();
			}
			return ddict;
		}
	}

	private IntPtr CreateCompressionDictionary(int compressionLevel)
	{
		GCHandle gCHandle = GCHandle.Alloc(dictionary, GCHandleType.Pinned);
		try
		{
			IntPtr dictBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)dictionary, 0);
			UIntPtr dictSize = new UIntPtr((uint)dictionary.Length);
			return ZstandardInterop.ZSTD_createCDict(dictBuffer, dictSize, compressionLevel);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	private IntPtr CreateDecompressionDictionary()
	{
		GCHandle gCHandle = GCHandle.Alloc(dictionary, GCHandleType.Pinned);
		try
		{
			IntPtr dictBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)dictionary, 0);
			UIntPtr dictSize = new UIntPtr((uint)dictionary.Length);
			return ZstandardInterop.ZSTD_createDDict(dictBuffer, dictSize);
		}
		finally
		{
			gCHandle.Free();
		}
	}
}
