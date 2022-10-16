using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PrintPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintPrototype()
	{
	}
}
