using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InfoFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralCustomer()
	{
	}
}
