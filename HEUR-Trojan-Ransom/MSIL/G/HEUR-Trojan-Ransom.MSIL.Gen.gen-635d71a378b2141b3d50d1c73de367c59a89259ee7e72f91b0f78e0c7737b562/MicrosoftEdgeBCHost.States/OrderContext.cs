using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class OrderContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderContext()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceWatcher()
	{
	}
}
