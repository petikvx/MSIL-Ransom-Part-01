using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CustomerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralSingleton()
	{
	}
}
