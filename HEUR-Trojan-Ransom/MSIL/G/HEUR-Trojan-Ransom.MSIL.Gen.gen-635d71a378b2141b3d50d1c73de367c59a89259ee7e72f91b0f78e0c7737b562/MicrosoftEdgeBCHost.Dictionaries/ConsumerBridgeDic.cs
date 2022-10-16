using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConsumerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterceptor()
	{
	}
}
