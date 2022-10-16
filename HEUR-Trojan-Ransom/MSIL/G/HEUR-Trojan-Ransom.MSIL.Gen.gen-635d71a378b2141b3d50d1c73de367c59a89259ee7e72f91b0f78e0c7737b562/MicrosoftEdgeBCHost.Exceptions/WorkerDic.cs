using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WorkerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralProducer()
	{
	}
}
