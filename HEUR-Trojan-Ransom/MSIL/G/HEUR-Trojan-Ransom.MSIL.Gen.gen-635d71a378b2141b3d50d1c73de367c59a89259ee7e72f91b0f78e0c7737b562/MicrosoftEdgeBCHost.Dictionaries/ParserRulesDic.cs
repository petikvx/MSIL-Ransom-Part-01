using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParserRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceRepository()
	{
	}
}
