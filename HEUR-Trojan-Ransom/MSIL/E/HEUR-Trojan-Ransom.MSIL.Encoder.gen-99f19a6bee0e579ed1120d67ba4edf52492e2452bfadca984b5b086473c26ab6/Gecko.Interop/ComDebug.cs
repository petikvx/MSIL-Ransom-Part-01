#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gecko.Interop;

public static class ComDebug
{
	public sealed class XulObjectInfo
	{
		public int ID;

		public Type Type;

		public int RefCount;

		public int RcwCount;
	}

	private static Dictionary<int, XulObjectInfo> _xulObjects = new Dictionary<int, XulObjectInfo>();

	public static int GetRcwRefCount<T>(T xulrunnerObject) where T : class
	{
		if (!Marshal.IsComObject(xulrunnerObject))
		{
			return -1;
		}
		T val = null;
		try
		{
			val = Xpcom.QueryInterface<T>(xulrunnerObject);
		}
		catch (Exception)
		{
		}
		if (val == null)
		{
			return 0;
		}
		return Marshal.ReleaseComObject(val);
	}

	public static int GetComRefCount<T>(T xulrunnerObject) where T : class
	{
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(xulrunnerObject);
		if (iUnknownForObject == IntPtr.Zero)
		{
			return -1;
		}
		return Marshal.Release(iUnknownForObject);
	}

	public static void WriteComRefCount<T>(T xulrunnerObject) where T : class
	{
		int hashCode = xulrunnerObject.GetHashCode();
		int comRefCount = GetComRefCount(xulrunnerObject);
		Console.WriteLine("{0}({1}) - ref:{2}", hashCode, typeof(T), comRefCount);
	}

	public static void WriteDebugInfo<T>(T xulrunnerObject) where T : class
	{
		int hashCode = xulrunnerObject.GetHashCode();
		int comRefCount = GetComRefCount(xulrunnerObject);
		int rcwRefCount = GetRcwRefCount(xulrunnerObject);
		Debug.WriteLine($"{hashCode}({typeof(T)}) - ref:{comRefCount},rcw:{rcwRefCount}");
		XulObjectInfo value = null;
		if (_xulObjects.TryGetValue(hashCode, out value))
		{
			value.RefCount = comRefCount;
			value.RcwCount = rcwRefCount;
			return;
		}
		value = new XulObjectInfo();
		value.ID = hashCode;
		value.Type = typeof(T);
		value.RefCount = comRefCount;
		value.RcwCount = rcwRefCount;
		_xulObjects.Add(hashCode, value);
	}

	public static void DebugFreeComObject<T>(ref T obj) where T : class
	{
		T val = Interlocked.Exchange(ref obj, null);
		if (val == null)
		{
			return;
		}
		int hashCode = val.GetHashCode();
		int num = Marshal.ReleaseComObject(val);
		Console.WriteLine("ComRelease {0}({1}),rcw={2}", hashCode, typeof(T), num);
		XulObjectInfo value = null;
		if (_xulObjects.TryGetValue(hashCode, out value))
		{
			value.RcwCount = num;
			if (num == 0)
			{
				_xulObjects.Remove(hashCode);
			}
		}
		else
		{
			Console.WriteLine("Untraced object free");
		}
	}
}
