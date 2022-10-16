using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RulesSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralGetter()
	{
	}
}
