using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GlobalContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalContext()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceWatcher()
	{
	}
}
