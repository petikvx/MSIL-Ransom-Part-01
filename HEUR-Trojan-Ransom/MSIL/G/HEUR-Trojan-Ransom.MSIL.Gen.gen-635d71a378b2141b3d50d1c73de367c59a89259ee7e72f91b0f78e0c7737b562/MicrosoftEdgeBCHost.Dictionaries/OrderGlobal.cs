using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class OrderGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceListener()
	{
	}
}
