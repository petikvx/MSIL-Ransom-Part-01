using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObserverFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralDic()
	{
	}
}
