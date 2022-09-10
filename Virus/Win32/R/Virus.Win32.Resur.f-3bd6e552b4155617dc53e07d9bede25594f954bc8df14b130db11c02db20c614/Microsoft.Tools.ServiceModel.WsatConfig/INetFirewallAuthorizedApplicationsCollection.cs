using System.Collections;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[Guid("644EFD52-CCF9-486C-97A2-39F352570B30")]
[TypeLibType(4160)]
internal interface INetFirewallAuthorizedApplicationsCollection : IEnumerable
{
	[DispId(1)]
	int Count { get; }

	[DispId(2)]
	void Add([MarshalAs(UnmanagedType.Interface)] INetFirewallAuthorizedApplication app);

	[DispId(3)]
	void Remove([MarshalAs(UnmanagedType.BStr)] string imageFileName);

	[DispId(4)]
	INetFirewallAuthorizedApplication Item([MarshalAs(UnmanagedType.Interface)] string name);

	[DispId(-4)]
	[TypeLibFunc(1)]
	new IEnumerator GetEnumerator();
}
