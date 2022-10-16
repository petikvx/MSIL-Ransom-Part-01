using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class QueueWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyBridge()
	{
	}
}
