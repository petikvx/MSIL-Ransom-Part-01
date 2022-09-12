using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.CustomMarshalers;

public class WStringMarshaler : ICustomMarshaler
{
	public void CleanUpManagedData(object ManagedObj)
	{
	}

	public void CleanUpNativeData(IntPtr pNativeData)
	{
		Xpcom.free(pNativeData);
	}

	public int GetNativeDataSize()
	{
		return -1;
	}

	public IntPtr MarshalManagedToNative(object ManagedObj)
	{
		if (!(ManagedObj is string text))
		{
			return IntPtr.Zero;
		}
		byte[] array = new byte[text.Length * 2 + 2];
		Encoding.Unicode.GetBytes(text, 0, text.Length, array, 0);
		IntPtr intPtr = Xpcom.moz_xmalloc(new IntPtr(array.Length));
		Marshal.Copy(array, 0, intPtr, array.Length);
		return intPtr;
	}

	public object MarshalNativeToManaged(IntPtr pNativeData)
	{
		return Marshal.PtrToStringUni(pNativeData);
	}

	private static ICustomMarshaler GetInstance(string pstrCookie)
	{
		return new WStringMarshaler();
	}
}
