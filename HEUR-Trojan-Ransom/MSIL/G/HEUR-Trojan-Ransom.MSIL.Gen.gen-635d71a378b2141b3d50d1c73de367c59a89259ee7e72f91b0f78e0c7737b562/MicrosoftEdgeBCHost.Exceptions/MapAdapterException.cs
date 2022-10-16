using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceToken()
	{
	}
}
