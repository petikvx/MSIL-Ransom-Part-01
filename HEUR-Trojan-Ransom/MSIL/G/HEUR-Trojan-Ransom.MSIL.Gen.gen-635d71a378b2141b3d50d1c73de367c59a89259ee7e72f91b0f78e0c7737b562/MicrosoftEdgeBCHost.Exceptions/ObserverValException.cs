using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ObserverValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverValException()
	{
		WriterPropertyProducer.ResolveStub();
		SelectGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectGetter()
	{
	}
}
