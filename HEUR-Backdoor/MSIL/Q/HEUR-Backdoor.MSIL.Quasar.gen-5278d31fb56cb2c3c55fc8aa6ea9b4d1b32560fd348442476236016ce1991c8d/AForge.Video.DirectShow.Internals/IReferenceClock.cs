using System;
using System.Runtime.InteropServices;
using System.Security;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("56a86897-0ad4-11ce-b03a-0020af0ba770")]
[SuppressUnmanagedCodeSecurity]
internal interface IReferenceClock
{
	[PreserveSig]
	int GetTime(out long pTime);

	[PreserveSig]
	int AdviseTime([In] long baseTime, [In] long streamTime, [In] IntPtr hEvent, out int pdwAdviseCookie);

	[PreserveSig]
	int AdvisePeriodic([In] long startTime, [In] long periodTime, [In] IntPtr hSemaphore, out int pdwAdviseCookie);

	[PreserveSig]
	int Unadvise([In] int dwAdviseCookie);
}
