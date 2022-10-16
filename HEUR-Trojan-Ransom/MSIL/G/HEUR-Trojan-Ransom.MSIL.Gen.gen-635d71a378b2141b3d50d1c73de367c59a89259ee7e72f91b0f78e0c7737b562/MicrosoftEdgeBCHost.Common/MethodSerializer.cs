using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MethodSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralState()
	{
	}
}
