using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[Guid("9797C15D-A428-4291-87B6-0995031A678D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IDtcNetworkAccessConfig
{
	void GetAnyNetworkAccess(ref bool anyNetworkAccess);

	void SetAnyNetworkAccess(bool anyNetworkAccess);

	void GetNetworkAdministrationAccess(ref bool networkAdministrationAccess);

	void SetNetworkAdministrationAccess(bool networkAdministrationAccess);

	void GetNetworkTransactionAccess(ref bool networkTransactionAccess);

	void SetNetworkTransactionAccess(bool networkTransactionAccess);

	void GetNetworkClientAccess(ref bool networkClientAccess);

	void SetNetworkClientAccess(bool networkClientAccess);

	void GetNetworkTipAccess(ref bool networkTipAccess);

	void SetNetworkTipAccess(bool networkTipAccess);

	void GetXAAccess(ref bool xaAccess);

	void SetXAAccess(bool xaAccess);

	[PreserveSig]
	int RestartDtcService();
}
