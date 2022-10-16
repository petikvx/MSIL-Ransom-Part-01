using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SystemSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralBridge()
	{
	}
}
