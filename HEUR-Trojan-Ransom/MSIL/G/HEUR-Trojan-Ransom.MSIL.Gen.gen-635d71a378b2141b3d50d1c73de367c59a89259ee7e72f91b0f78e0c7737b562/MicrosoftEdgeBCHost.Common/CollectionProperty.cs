using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceDecorator()
	{
	}
}
