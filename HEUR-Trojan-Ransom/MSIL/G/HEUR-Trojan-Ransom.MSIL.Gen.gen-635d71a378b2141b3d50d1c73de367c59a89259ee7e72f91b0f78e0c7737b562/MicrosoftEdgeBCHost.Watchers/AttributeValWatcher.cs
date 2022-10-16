using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttributeValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceIterator()
	{
	}
}
