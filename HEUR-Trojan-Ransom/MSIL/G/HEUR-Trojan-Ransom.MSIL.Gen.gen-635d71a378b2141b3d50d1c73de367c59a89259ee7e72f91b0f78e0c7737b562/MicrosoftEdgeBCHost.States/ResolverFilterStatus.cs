using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ResolverFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceConsumer()
	{
	}
}
