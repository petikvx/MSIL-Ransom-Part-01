using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RuleWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralInterceptor()
	{
	}
}
