using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class Mapping
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Mapping()
	{
		WriterPropertyProducer.ResolveStub();
		OrderMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderMapping()
	{
	}
}
