using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProxyDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralSpecification()
	{
	}
}
