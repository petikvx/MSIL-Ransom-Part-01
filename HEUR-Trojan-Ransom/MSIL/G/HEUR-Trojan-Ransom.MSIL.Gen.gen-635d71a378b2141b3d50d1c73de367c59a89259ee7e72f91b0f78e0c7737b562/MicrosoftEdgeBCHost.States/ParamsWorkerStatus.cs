using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamsWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralInvocation()
	{
	}
}
