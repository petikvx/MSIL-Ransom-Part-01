using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InitializerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotPage()
	{
	}
}
