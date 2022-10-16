using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralValue()
	{
	}
}
