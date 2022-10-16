using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PublisherGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfacePage()
	{
	}
}
