using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExporterGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceFacade()
	{
	}
}
