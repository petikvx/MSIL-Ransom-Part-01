using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParameterOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralQueue()
	{
	}
}
