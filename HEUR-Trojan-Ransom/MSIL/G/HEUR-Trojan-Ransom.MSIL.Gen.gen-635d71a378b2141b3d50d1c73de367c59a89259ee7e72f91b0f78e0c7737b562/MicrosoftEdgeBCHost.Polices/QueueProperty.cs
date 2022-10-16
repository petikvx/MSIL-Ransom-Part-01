using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class QueueProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueProperty()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceDecorator()
	{
	}
}
