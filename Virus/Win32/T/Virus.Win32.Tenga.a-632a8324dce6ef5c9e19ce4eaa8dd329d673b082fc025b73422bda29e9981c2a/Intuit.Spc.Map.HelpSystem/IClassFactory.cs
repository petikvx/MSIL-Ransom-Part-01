using System;
using System.Runtime.InteropServices;

namespace Intuit.Spc.Map.HelpSystem;

[ComImport]
[ComVisible(false)]
[Guid("00000001-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IClassFactory
{
	void CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject);

	void LockServer(bool fLock);
}
