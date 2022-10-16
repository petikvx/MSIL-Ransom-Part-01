using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralResolver()
	{
	}
}
