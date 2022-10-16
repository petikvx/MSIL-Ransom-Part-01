using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FactoryFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralIssuer()
	{
	}
}
