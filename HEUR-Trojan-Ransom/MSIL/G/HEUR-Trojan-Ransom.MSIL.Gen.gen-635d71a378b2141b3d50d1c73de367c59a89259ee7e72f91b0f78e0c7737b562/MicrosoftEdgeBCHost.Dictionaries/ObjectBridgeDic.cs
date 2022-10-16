using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObjectBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareRepository()
	{
	}
}
