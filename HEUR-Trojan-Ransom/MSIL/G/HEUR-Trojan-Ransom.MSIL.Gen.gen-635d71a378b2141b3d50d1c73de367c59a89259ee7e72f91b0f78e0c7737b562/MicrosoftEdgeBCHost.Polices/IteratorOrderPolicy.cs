using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IteratorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralState()
	{
	}
}
