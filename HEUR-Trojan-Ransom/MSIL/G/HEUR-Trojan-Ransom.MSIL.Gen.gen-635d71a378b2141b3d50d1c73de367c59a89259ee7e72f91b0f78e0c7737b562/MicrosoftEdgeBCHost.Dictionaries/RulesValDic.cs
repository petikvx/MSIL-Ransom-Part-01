using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RulesValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesValDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralOrder()
	{
	}
}
