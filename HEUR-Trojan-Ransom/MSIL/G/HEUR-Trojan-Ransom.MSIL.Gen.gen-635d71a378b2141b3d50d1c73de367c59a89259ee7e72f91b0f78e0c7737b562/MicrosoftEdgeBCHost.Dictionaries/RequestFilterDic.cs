using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RequestFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralMapping()
	{
	}
}
