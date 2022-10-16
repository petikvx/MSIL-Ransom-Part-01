using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InfoWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateState()
	{
	}
}
