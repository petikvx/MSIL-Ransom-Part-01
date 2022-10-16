using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RuleOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralVisitor()
	{
	}
}
