using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DispatcherOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherOrder()
	{
		WriterPropertyProducer.ResolveStub();
		FillClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillClass()
	{
	}
}
