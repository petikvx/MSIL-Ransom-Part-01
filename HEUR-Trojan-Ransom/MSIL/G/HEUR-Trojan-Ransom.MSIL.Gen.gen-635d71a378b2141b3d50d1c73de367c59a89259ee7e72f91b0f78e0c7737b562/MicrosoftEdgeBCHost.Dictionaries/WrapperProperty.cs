using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceEvent()
	{
	}
}
