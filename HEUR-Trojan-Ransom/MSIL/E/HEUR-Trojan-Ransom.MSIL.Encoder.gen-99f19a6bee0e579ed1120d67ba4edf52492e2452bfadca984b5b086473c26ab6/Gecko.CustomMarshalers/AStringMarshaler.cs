using System;
using System.Runtime.InteropServices;

namespace Gecko.CustomMarshalers;

public class AStringMarshaler : ICustomMarshaler
{
	public static readonly AStringMarshaler Instance = new AStringMarshaler();

	public void CleanUpManagedData(object ManagedObj)
	{
	}

	public void CleanUpNativeData(IntPtr pNativeData)
	{
	}

	public int GetNativeDataSize()
	{
		return -1;
	}

	public IntPtr MarshalManagedToNative(object ManagedObj)
	{
		if (!(ManagedObj is nsAStringBase nsAStringBase))
		{
			throw new MarshalDirectiveException();
		}
		return nsAStringBase.Container;
	}

	public object MarshalNativeToManaged(IntPtr pNativeData)
	{
		if (pNativeData == IntPtr.Zero)
		{
			return null;
		}
		return new nsAString(pNativeData);
	}

	private static ICustomMarshaler GetInstance(string pstrCookie)
	{
		return Instance;
	}
}
