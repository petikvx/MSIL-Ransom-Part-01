using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListDic()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralStub()
	{
	}
}
