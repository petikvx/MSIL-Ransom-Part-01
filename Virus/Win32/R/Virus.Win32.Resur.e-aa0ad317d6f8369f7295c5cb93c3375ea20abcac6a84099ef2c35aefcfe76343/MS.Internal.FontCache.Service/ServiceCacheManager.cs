using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using MS.Internal.IO.Packaging;

namespace MS.Internal.FontCache.Service;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal static class ServiceCacheManager
{
	private class CacheKeyComparer : IEqualityComparer
	{
		public unsafe int GetHashCode(object obj)
		{
			byte[] array = (byte[])obj;
			if (array.Length == 0)
			{
				return 0;
			}
			int num;
			fixed (byte* ptr = &array[0])
			{
				num = HashFn.HashMemory((void*)ptr, array.Length, 0);
			}
			return HashFn.HashScramble(num);
		}

		bool IEqualityComparer.Equals(object x, object y)
		{
			byte[] array = (byte[])x;
			byte[] array2 = (byte[])y;
			int num = array.Length;
			if (num != array2.Length)
			{
				return false;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < num)
				{
					if (array[num2] != array2[num2])
					{
						break;
					}
					num2++;
					continue;
				}
				return true;
			}
			return false;
		}
	}

	private const int MaximumPrefetchCacheSize = 16777216;

	private const int MaxCacheKeyTableSize = 1048576;

	private const int MinimumNumberOfMissReportsToCacheAnElement = 2;

	private const Environment.SpecialFolder ForceCreate = (Environment.SpecialFolder)32768;

	private const int SHGFP_TYPE_CURRENT = 0;

	private static object _currentCacheLock = new object();

	private static string _currentCacheName;

	private static volatile ElementCacher _currentCache;

	private static string _prefetchFileName;

	private static CacheKeyComparer _cacheKeyComparer = new CacheKeyComparer();

	private static Hashtable _cacheKeyTable = new Hashtable(_cacheKeyComparer);

	internal static void InitializeSharedCache()
	{
		_prefetchFileName = GetPrefetchFileName();
		try
		{
			StartPrefetchCache();
		}
		catch (FileNotFoundException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (FileFormatException)
		{
		}
		catch (ArgumentOutOfRangeException)
		{
		}
		ElementCacher currentCache = GetCurrentCache();
		try
		{
			AddFrequentlyUsedData(currentCache);
		}
		catch (FontCacheFullException)
		{
			RenewCache(currentCache);
		}
	}

	internal static void HandleMissReport(CheckedPointer key)
	{
		((CheckedPointer)(ref key)).get_Size();
		byte[] array = ((CheckedPointer)(ref key)).ToArray();
		lock (_cacheKeyTable)
		{
			if (_cacheKeyTable.Count >= 1048576 && !_cacheKeyTable.ContainsKey(array))
			{
				return;
			}
			object obj = _cacheKeyTable[array];
			if (obj == null)
			{
				_cacheKeyTable[array] = 1;
				return;
			}
			int num = ((obj != null) ? ((int)obj) : 0);
			num++;
			if ((num - 2) % 10 == 0)
			{
				ThreadPool.UnsafeQueueUserWorkItem(CreateElementFromKey, array);
			}
			_cacheKeyTable[array] = num;
		}
	}

	internal static string GetCacheName()
	{
		return _currentCacheName;
	}

	internal unsafe static void PersistCache()
	{
		string text = _prefetchFileName + '~';
		if (File.Exists(_prefetchFileName))
		{
			File.Delete(_prefetchFileName);
		}
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		ElementCacher currentCache = GetCurrentCache();
		byte[] array;
		lock (currentCache.get_Lock())
		{
			int currentSize = currentCache.get_CurrentSize();
			if (currentSize > 16777216)
			{
				return;
			}
			array = new byte[currentSize];
			Marshal.Copy((IntPtr)currentCache.get_Item(0), array, 0, currentSize);
		}
		FileStream fileStream = new FileStream(text, FileMode.Create);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
		File.Move(text, _prefetchFileName);
	}

	private static string GetNextCacheName()
	{
		return "Global\\Font Cache Mapping " + Guid.NewGuid();
	}

	private static ElementCacher GetCurrentCache()
	{
		ElementCacher val = _currentCache;
		if (val == null || val.IsObsolete())
		{
			val = RenewCache(val);
		}
		return val;
	}

	private static ElementCacher RenewCache(ElementCacher oldCache)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		lock (_currentCacheLock)
		{
			if (_currentCache != oldCache)
			{
				return _currentCache;
			}
			bool flag = false;
			int num;
			if (oldCache == null)
			{
				num = 4194304;
			}
			else
			{
				num = oldCache.get_MaxCacheSize() * 2;
				if (num > 67108864)
				{
					num = 67108864;
				}
				else
				{
					flag = true;
				}
			}
			FileMapping val = new FileMapping();
			string nextCacheName = GetNextCacheName();
			val.Create(nextCacheName, (long)num);
			ElementCacher val2 = new ElementCacher(val, true, true);
			if (flag)
			{
				val2.InitFromPreviousCache(oldCache, num);
			}
			Thread.MemoryBarrier();
			AddFrequentlyUsedData(val2);
			_currentCache = val2;
			_currentCacheName = nextCacheName;
			if (oldCache != null)
			{
				oldCache.MarkObsolete();
			}
			return val2;
		}
	}

	private unsafe static void StartPrefetchCache()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		string nextCacheName = GetNextCacheName();
		FileStream fileStream = new FileStream(_prefetchFileName, FileMode.Open, FileAccess.Read);
		int num = (int)fileStream.Length;
		if (num > 16777216)
		{
			fileStream.Close();
			return;
		}
		byte[] array = new byte[num];
		PackagingUtilities.ReliableRead((Stream)fileStream, array, 0, num);
		fileStream.Close();
		FileMapping val = new FileMapping();
		int num2 = Math.Max(num, 4194304);
		val.Create(nextCacheName, (long)num2);
		ElementCacher val2 = new ElementCacher(val, true, true);
		fixed (byte* ptr = array)
		{
			val2.InitFromCacheImage(new CheckedPointer((void*)ptr, num));
		}
		val2.set_MaxCacheSize(num2);
		if (!val2.VersionUpToDate())
		{
			((IDisposable)val).Dispose();
			return;
		}
		Thread.MemoryBarrier();
		_currentCache = val2;
		_currentCacheName = nextCacheName;
	}

	private static string GetFolderPath(Environment.SpecialFolder folder)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int errorCode = SHGetFolderPath(IntPtr.Zero, (int)folder, IntPtr.Zero, 0, stringBuilder);
		Marshal.ThrowExceptionForHR(errorCode);
		return stringBuilder.ToString();
	}

	private static string GetPrefetchFileName()
	{
		string folderPath = GetFolderPath((Environment.SpecialFolder)32796);
		return folderPath + "\\FontCache3.0.0.0.dat";
	}

	private static void ConstructElement(ElementCacher c, IFontCacheElement e)
	{
		try
		{
			c.LookupAndAdd(e);
			BaseGlyphElement val = (BaseGlyphElement)(object)((e is BaseGlyphElement) ? e : null);
			if (val != null)
			{
				ushort baseGlyph = val.GetBaseGlyph();
				ushort num = baseGlyph;
				while (num < baseGlyph + 128 && (val.IsGlyphCached(num) || val.AddGlyph(num)))
				{
					num = (ushort)(num + 1);
				}
			}
		}
		catch (FileFormatException)
		{
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (WebException)
		{
		}
		catch (ArgumentException)
		{
		}
		catch (UriFormatException)
		{
		}
		catch (OutOfMemoryException)
		{
		}
	}

	private unsafe static void CreateElementFromKey(object state)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			byte[] array = (byte[])state;
			if (array.Length == 0)
			{
				return;
			}
			IFontCacheElement val;
			try
			{
				fixed (byte* ptr = &array[0])
				{
					CheckedPointer key = default(CheckedPointer);
					((CheckedPointer)(ref key))._002Ector((void*)ptr, array.Length);
					val = CreateFromKey(key);
				}
			}
			finally
			{
			}
			if (val == null)
			{
				return;
			}
			ElementCacher currentCache = GetCurrentCache();
			try
			{
				ConstructElement(currentCache, val);
			}
			catch (FontCacheFullException)
			{
				currentCache = RenewCache(currentCache);
				try
				{
					ConstructElement(currentCache, val);
				}
				catch (FontCacheFullException)
				{
				}
			}
		}
		catch (OutOfMemoryException)
		{
		}
	}

	private unsafe static IFontCacheElement CreateFromKey(CheckedPointer key)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		int num = *(int*)((CheckedPointer)(ref key)).Probe(0, 4);
		key += 4;
		IFontCacheElement val = null;
		return ElementFactory.CreateElementFromKey(num, key);
	}

	private static void AddFrequentlyUsedData(ElementCacher c)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		FamilyCollection e = new FamilyCollection(Util.get_WindowsFontsUriObject(), true);
		ConstructElement(c, (IFontCacheElement)(object)e);
	}

	[DllImport("shfolder.dll", CharSet = CharSet.Auto)]
	private static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, int dwFlags, StringBuilder lpszPath);
}
