using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class VisitorValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralPredicate()
	{
	}
}
