using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralProducer()
	{
	}
}
