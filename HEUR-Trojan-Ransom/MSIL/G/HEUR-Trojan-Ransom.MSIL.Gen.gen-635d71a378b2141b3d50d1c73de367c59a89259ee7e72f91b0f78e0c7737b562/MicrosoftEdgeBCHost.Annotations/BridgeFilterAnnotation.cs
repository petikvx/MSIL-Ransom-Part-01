using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BridgeFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResetProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetProc()
	{
	}
}
