using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IteratorValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralStub()
	{
	}
}
