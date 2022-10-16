using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConsumerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		AssetCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetCandidate()
	{
	}
}
