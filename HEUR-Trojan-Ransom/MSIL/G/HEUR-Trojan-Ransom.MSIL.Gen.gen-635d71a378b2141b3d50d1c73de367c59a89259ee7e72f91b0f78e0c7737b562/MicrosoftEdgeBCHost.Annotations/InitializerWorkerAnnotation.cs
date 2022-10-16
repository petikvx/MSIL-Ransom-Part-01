using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InitializerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralContext()
	{
	}
}
