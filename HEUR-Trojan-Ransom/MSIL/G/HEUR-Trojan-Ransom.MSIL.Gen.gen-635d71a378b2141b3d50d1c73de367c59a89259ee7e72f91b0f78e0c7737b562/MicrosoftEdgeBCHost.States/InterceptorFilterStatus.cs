using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterceptorFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceSystem()
	{
	}
}
