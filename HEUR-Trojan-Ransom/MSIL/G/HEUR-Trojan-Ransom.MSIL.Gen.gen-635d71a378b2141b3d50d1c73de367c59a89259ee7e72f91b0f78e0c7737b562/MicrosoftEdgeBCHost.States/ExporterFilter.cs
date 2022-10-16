using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExporterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		PatchRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchRules()
	{
	}
}
