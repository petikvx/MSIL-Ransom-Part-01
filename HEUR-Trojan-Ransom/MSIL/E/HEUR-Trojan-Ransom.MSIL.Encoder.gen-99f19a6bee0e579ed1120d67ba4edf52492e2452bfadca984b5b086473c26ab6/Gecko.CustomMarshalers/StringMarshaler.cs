using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.CustomMarshalers;

public class StringMarshaler : ICustomMarshaler
{
	private List<IntPtr> allocs = new List<IntPtr>(5);

	public object MarshalNativeToManaged(IntPtr pNativeData)
	{
		return Marshal.PtrToStringAnsi(pNativeData);
	}

	public IntPtr MarshalManagedToNative(object ManagedObj)
	{
		if (!(ManagedObj is string text))
		{
			return IntPtr.Zero;
		}
		byte[] array = new byte[text.Length + 1];
		Encoding.ASCII.GetBytes(text, 0, text.Length, array, 0);
		IntPtr intPtr = Xpcom.moz_xmalloc(new IntPtr(array.Length));
		allocs.Add(intPtr);
		Marshal.Copy(array, 0, intPtr, array.Length);
		return intPtr;
	}

	public void CleanUpNativeData(IntPtr pNativeData)
	{
		if (allocs.Contains(pNativeData))
		{
			allocs.Remove(pNativeData);
			Xpcom.free(pNativeData);
		}
	}

	public void CleanUpManagedData(object ManagedObj)
	{
	}

	public int GetNativeDataSize()
	{
		return -1;
	}

	private static ICustomMarshaler GetInstance(string pstrCookie)
	{
		return new StringMarshaler();
	}
}
