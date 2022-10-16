using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SpecificationWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		AssetDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetDic()
	{
	}
}
