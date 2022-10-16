using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProducerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralObject()
	{
	}
}
