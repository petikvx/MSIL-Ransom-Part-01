using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DecoratorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralField()
	{
	}
}
