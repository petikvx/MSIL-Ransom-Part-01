using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegistryRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeDecorator()
	{
	}
}
