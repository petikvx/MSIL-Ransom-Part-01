using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BaseOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralBridge()
	{
	}
}
