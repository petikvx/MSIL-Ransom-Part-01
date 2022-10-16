using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReaderOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralInterceptor()
	{
	}
}
