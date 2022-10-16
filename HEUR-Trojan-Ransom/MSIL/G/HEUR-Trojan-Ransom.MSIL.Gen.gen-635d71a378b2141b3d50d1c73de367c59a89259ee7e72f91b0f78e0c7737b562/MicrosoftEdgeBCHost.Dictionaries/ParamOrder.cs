using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamOrder()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteObserver()
	{
	}
}
