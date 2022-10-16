using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenizerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralProccesor()
	{
	}
}
