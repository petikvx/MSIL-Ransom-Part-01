using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class HelperAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralBridge()
	{
	}
}
