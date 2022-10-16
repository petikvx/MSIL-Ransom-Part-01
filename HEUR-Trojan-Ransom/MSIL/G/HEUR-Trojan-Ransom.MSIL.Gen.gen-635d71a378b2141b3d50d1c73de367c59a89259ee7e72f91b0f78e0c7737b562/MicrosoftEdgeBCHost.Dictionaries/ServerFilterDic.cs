using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceConsumer()
	{
	}
}
