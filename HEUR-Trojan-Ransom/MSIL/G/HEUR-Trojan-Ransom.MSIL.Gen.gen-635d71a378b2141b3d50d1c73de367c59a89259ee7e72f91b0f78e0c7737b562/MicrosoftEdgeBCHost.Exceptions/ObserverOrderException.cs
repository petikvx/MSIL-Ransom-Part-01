using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ObserverOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceParser()
	{
	}
}
