using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("29840822-5B84-11D0-BD3B-00A0C911CE86")]
internal interface Interface6
{
	[PreserveSig]
	int CreateClassEnumerator([In] ref Guid type, out IEnumMoniker enumMoniker, [In] int flags);
}
