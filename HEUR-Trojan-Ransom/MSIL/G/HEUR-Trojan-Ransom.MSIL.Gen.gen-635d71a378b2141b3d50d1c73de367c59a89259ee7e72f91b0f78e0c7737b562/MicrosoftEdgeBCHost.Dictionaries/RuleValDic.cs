using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RuleValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleValDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralStub()
	{
	}
}
