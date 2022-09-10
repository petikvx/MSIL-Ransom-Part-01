using System.Runtime.InteropServices;

namespace OpenNETCF.Desktop.Communication;

[Guid("A7B88840-A812-11cf-8011-00A0C90A8F78")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IDccManSink
{
	[PreserveSig]
	int OnLogIpAddr([In] int dwIpAddr);

	[PreserveSig]
	int OnLogTerminated();

	[PreserveSig]
	int OnLogActive();

	[PreserveSig]
	int OnLogInactive();

	[PreserveSig]
	int OnLogAnswered();

	[PreserveSig]
	int OnLogListen();

	[PreserveSig]
	int OnLogDisconnection();

	[PreserveSig]
	int OnLogError();
}
