using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FilterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralCode()
	{
	}
}
