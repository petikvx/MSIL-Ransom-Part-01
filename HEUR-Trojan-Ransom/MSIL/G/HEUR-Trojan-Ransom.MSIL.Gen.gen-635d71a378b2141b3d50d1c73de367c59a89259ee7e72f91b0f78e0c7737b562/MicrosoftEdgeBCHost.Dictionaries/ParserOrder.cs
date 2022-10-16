using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParserOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterceptor()
	{
	}
}
