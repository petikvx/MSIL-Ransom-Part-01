using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AlgoFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AddMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddMapping()
	{
	}
}
