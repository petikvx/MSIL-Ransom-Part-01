using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcessAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralProxy()
	{
	}
}
