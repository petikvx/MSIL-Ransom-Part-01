using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class QueueAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceConnection()
	{
	}
}
