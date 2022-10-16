using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralCallback()
	{
	}
}
