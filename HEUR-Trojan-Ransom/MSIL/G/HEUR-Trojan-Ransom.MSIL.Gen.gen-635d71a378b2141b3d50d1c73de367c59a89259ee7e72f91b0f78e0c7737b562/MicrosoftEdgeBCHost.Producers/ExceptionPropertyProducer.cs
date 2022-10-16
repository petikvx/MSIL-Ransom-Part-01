using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExceptionPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralFilter()
	{
	}
}
