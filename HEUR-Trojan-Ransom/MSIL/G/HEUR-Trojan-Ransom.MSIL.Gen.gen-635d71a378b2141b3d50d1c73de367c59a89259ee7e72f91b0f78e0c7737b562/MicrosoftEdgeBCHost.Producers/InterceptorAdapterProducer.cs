using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterceptorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralResolver()
	{
	}
}
