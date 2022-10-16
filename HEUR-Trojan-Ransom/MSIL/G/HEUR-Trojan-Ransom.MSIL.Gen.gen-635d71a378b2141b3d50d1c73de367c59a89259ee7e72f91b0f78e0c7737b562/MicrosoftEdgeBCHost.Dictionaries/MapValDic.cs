using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapValDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralRules()
	{
	}
}
