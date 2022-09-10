using System.Runtime.InteropServices;

namespace OpenNETCF.Desktop.Communication;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("A7B88841-A812-11cf-8011-00A0C90A8F78")]
internal interface IDccMan
{
	[PreserveSig]
	int Advise([In][MarshalAs(UnmanagedType.Interface)] IDccManSink pDccSink, [MarshalAs(UnmanagedType.U4)] out int dwContext);

	void Unadvise([In][MarshalAs(UnmanagedType.U4)] int dwContext);

	void ShowCommSettings();

	void AutoconnectEnable();

	void AutoconnectDisable();

	void ConnectNow();

	void DisconnectNow();

	void SetIconDataTransferring();

	void SetIconNoDataTransferring();

	void SetIconError();
}
