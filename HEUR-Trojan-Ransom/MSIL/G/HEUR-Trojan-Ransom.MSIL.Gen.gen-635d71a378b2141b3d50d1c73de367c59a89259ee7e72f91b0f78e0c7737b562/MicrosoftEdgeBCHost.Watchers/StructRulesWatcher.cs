using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StructRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeSetter()
	{
	}
}
