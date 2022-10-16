using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParameterRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectIndexer()
	{
	}
}
