using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExporterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SearchRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchRef()
	{
	}
}
