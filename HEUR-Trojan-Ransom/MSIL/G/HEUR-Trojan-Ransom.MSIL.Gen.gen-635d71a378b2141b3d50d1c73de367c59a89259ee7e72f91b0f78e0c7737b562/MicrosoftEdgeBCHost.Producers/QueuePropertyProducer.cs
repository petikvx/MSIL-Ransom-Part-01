using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class QueuePropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueuePropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralThread()
	{
	}
}
