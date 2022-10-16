using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AccountFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralDic()
	{
	}
}
