using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProductFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CallDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallDic()
	{
	}
}
