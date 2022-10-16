using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapperValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralClass()
	{
	}
}
