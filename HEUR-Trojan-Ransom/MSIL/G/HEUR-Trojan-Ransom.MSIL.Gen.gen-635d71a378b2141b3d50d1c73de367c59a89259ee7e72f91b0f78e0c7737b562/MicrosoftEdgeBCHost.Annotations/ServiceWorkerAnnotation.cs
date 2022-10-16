using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServiceWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralClient()
	{
	}
}
