using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InvocationFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceSystem()
	{
	}
}
