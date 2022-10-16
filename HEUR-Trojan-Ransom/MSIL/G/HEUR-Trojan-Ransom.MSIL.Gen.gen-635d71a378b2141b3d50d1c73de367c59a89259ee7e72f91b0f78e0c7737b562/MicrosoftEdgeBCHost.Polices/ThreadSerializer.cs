using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ThreadSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralBridge()
	{
	}
}
