using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BaseFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralAttribute()
	{
	}
}
