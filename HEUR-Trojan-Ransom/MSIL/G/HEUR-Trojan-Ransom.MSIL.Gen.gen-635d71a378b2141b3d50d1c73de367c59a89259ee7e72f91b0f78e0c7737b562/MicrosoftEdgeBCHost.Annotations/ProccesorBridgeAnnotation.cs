using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProccesorBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SearchTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchTest()
	{
	}
}
