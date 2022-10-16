using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperWorkerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperWorkerDic()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralConsumer()
	{
	}
}
