using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObjectSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralMapping()
	{
	}
}
