using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactoryFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceWrapper()
	{
	}
}
