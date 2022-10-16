using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConsumerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceStub()
	{
	}
}
