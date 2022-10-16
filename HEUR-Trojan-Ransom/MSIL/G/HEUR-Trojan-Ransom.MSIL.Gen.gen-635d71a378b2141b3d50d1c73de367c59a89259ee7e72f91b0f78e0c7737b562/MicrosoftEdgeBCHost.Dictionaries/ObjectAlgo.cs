using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObjectAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralResolver()
	{
	}
}
