using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class VisitorPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralInterceptor()
	{
	}
}
