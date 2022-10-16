using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class OrderValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceValue()
	{
	}
}
