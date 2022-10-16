using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SpecificationRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteRef()
	{
	}
}
