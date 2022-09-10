using System;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[Flags]
internal enum ClusterEnum : uint
{
	Node = 1u,
	ResType = 2u,
	Resource = 4u,
	Group = 8u,
	Network = 0x10u,
	NetInterface = 0x20u,
	InternalNetwork = 0x80000000u
}
