using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AdapterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralCustomer()
	{
	}
}
