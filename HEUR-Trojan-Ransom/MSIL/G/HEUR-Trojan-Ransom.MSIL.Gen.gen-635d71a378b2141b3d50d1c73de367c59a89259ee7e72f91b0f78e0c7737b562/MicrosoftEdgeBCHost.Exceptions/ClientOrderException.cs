using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClientOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfacePrinter()
	{
	}
}
