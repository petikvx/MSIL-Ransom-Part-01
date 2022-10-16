using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListenerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceRepository()
	{
	}
}
