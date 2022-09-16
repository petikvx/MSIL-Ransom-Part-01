using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;

namespace _0xH0ammock;

public static class _0xHUn7ontra7ted
{
	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj", Justification = "There are no good alternatives.")]
	public static bool _0xHWat4rproof4r(object _0xHDebilitatin7, object _0xHJ0lt)
	{
		bool result = false;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		try
		{
			if (_0xHDebilitatin7 != null)
			{
				if (_0xHJ0lt != null)
				{
					intPtr = _0xHPyu8ia(_0xHDebilitatin7);
					intPtr2 = _0xHPyu8ia(_0xHJ0lt);
					return object.Equals(intPtr, intPtr2);
				}
				return result;
			}
			return result;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.Release(intPtr);
			}
			if (intPtr2 != IntPtr.Zero)
			{
				Marshal.Release(intPtr2);
			}
		}
	}

	internal static IntPtr _0xHPyu8ia(object _0xH2ictimhood)
	{
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			if (_0xH2ictimhood is IntPtr)
			{
				intPtr = (IntPtr)_0xH2ictimhood;
			}
			else
			{
				intPtr = Marshal.GetIUnknownForObject(_0xH2ictimhood);
				flag = true;
			}
			Guid iid = VSConstants.IID_IUnknown;
			ErrorHandler.ThrowOnFailure(Marshal.QueryInterface(intPtr, ref iid, out var ppv));
			return ppv;
		}
		finally
		{
			if (flag && intPtr != IntPtr.Zero)
			{
				Marshal.Release(intPtr);
			}
		}
	}
}
