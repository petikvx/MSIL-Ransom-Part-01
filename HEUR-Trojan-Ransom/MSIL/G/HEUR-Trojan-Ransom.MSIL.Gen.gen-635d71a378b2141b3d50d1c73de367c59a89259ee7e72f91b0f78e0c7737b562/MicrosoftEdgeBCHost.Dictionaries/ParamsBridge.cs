using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamsBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsBridge()
	{
		WriterPropertyProducer.ResolveStub();
		MapCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapCollection()
	{
	}
}
