using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdvisorFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralAttr()
	{
	}
}
