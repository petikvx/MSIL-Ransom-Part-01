using System.Runtime.InteropServices;

namespace System.ServiceModel.Activation;

[StructLayout(LayoutKind.Auto)]
internal struct TransportType : Enum
{
	public _003F value__;

	public const _003F Unsupported = 0;

	public const _003F Tcp = -2006099524;

	public const _003F NamedPipe = 204508861;
}
