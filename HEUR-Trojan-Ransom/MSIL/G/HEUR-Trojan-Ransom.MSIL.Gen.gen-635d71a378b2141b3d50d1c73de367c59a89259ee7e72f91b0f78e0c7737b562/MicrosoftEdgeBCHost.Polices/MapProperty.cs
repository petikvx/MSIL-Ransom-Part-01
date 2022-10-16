using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapProperty()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceBridge()
	{
	}
}
