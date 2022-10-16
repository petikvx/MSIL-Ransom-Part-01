using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ResolverValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverValDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralReponse()
	{
	}
}
