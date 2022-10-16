using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterceptorBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteConsumer()
	{
	}
}
