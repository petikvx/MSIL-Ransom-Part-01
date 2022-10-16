using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrototypeAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceObject()
	{
	}
}
