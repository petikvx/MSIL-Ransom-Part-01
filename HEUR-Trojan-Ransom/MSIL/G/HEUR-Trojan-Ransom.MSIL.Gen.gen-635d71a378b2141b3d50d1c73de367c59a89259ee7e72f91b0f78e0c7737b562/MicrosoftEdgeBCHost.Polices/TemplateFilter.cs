using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TemplateFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateFilter()
	{
		WriterPropertyProducer.ResolveStub();
		StopWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopWatcher()
	{
	}
}
