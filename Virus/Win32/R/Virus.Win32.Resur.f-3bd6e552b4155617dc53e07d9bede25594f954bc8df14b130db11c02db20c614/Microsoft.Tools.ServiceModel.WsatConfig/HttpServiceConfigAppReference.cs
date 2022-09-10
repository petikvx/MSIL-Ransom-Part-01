using System;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct HttpServiceConfigAppReference
{
	internal Guid AppGuid;

	[MarshalAs(UnmanagedType.LPWStr)]
	internal string AppFriendlyName;

	[MarshalAs(UnmanagedType.Bool)]
	internal bool IsLegacyreference;
}
