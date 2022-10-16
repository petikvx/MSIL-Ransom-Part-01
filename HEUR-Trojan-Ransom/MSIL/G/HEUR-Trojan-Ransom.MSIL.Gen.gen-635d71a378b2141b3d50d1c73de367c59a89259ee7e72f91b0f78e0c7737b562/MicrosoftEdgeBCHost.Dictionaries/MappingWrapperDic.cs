using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MappingWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapConfig()
	{
	}
}
