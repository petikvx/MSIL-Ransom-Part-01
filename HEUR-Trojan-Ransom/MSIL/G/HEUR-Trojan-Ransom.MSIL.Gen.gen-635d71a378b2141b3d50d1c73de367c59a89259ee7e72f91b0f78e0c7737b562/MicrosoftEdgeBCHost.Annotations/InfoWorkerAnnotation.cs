using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InfoWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralParam()
	{
	}
}
