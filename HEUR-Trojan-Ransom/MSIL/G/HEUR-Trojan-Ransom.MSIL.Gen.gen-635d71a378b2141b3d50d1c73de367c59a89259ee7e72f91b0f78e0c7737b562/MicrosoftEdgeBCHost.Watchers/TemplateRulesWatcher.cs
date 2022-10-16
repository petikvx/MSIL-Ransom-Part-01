using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TemplateRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptDefinition()
	{
	}
}
