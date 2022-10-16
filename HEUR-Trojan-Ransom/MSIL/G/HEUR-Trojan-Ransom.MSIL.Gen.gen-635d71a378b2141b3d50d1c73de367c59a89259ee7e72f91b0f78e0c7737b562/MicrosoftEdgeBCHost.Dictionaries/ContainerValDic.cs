using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContainerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralWriter()
	{
	}
}
