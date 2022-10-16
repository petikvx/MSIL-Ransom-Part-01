using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConsumerWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralTokenizer()
	{
	}
}
