using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RulesWorkerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesWorkerDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralMerchant()
	{
	}
}
