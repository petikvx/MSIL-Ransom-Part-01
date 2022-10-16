using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExporterAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceEvent()
	{
	}
}
