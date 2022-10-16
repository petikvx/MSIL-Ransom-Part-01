using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CollectionBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PopField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopField()
	{
	}
}
