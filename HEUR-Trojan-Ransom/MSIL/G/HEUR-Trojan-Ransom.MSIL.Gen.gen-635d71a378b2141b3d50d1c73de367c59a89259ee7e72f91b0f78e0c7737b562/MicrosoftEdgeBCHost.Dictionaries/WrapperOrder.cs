using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperOrder()
	{
		WriterPropertyProducer.ResolveStub();
		NewFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewFilter()
	{
	}
}
