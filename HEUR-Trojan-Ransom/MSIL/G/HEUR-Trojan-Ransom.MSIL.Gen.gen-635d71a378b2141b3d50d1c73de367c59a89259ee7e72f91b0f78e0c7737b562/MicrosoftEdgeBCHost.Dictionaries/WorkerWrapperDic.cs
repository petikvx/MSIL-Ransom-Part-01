using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WorkerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		RateIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateIdentifier()
	{
	}
}
