using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ImporterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterContext()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceContainer()
	{
	}
}
