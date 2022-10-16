using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcessFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceConsumer()
	{
	}
}
