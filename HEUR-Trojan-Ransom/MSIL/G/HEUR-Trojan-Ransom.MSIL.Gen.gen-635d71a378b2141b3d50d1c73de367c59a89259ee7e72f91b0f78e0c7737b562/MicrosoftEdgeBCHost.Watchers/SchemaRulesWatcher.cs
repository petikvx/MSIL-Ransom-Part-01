using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SchemaRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeAttr()
	{
	}
}
