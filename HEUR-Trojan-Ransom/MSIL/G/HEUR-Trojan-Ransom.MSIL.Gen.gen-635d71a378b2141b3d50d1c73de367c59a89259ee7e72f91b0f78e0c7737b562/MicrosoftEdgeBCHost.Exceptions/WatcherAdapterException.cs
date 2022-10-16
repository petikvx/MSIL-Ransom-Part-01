using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WatcherAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceFilter()
	{
	}
}
