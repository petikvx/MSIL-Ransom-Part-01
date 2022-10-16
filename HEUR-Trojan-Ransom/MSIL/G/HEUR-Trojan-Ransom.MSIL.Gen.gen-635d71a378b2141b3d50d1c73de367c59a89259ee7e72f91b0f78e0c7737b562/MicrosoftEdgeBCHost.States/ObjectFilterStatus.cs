using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObjectFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceMock()
	{
	}
}
