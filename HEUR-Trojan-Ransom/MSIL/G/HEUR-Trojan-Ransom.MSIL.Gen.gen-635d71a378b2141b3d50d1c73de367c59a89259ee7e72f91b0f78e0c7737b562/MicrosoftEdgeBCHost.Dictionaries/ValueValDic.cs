using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValueValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralWrapper()
	{
	}
}
