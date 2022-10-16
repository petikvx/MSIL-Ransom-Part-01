using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class EventAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralMessage()
	{
	}
}
