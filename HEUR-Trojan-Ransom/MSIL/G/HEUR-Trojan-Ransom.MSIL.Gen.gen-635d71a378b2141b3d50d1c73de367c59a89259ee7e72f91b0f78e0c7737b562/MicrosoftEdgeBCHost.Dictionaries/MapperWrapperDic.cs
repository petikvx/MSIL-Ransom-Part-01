using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapperWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveRules()
	{
	}
}
