using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProducerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralDic()
	{
	}
}
