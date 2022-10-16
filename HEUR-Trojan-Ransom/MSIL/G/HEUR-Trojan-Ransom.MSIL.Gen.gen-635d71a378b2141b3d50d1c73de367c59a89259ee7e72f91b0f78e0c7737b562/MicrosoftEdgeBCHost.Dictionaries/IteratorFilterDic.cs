using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IteratorFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralTest()
	{
	}
}
