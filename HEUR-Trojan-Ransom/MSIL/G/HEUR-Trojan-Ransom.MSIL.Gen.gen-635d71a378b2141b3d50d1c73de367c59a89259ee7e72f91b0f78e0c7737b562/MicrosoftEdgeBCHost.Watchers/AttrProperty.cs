using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttrProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrProperty()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceDecorator()
	{
	}
}
