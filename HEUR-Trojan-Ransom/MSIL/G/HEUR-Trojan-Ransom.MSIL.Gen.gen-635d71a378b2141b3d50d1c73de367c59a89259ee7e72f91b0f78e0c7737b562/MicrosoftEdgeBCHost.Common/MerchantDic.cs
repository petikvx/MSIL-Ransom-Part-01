using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MerchantDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralAnnotation()
	{
	}
}
