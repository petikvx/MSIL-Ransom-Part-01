using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamsValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralPredicate()
	{
	}
}
