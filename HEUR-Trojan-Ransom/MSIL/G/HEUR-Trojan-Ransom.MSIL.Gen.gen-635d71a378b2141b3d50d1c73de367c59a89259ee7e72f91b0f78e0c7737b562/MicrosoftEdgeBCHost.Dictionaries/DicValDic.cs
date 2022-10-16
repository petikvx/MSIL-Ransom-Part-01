using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DicValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicValDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralProduct()
	{
	}
}
