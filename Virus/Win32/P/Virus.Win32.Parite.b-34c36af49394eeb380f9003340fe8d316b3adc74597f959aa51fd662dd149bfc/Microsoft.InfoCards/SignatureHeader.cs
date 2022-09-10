using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal struct SignatureHeader
{
	public const int IVSize = 16;

	public const int SignatureOffset = 4;

	public const int IVOffset = 20;

	public int SignatureSize;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
	public byte Signature;
}
