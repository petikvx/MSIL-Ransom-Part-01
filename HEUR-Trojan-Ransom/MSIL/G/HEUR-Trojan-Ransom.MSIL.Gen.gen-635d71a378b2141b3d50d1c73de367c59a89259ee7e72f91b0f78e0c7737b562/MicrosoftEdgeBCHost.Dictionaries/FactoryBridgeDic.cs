using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FactoryBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeHelper()
	{
	}
}
