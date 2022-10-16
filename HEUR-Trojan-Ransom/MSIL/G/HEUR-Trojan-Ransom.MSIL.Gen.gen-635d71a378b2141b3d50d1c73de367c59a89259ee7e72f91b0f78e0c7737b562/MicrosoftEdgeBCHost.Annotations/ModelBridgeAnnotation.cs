using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ModelBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AddBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddBridge()
	{
	}
}
