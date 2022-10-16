using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcessBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupMap()
	{
	}
}
