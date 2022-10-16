using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class QueueFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceWatcher()
	{
	}
}
