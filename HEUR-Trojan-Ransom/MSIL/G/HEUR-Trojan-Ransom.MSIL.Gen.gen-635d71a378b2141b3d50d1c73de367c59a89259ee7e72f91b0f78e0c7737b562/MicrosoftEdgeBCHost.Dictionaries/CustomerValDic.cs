using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CustomerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralTokenizer()
	{
	}
}
