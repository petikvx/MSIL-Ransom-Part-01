using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralGetter()
	{
	}
}
