using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConnectionPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralHelper()
	{
	}
}
