using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RulesValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceFactory()
	{
	}
}
