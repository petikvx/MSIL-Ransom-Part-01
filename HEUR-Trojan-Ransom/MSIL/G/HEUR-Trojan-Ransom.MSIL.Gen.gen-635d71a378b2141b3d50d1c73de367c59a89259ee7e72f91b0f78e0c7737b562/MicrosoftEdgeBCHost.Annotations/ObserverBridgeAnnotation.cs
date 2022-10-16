using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObserverBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteProccesor()
	{
	}
}
