using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttributeRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetPrinter()
	{
	}
}
