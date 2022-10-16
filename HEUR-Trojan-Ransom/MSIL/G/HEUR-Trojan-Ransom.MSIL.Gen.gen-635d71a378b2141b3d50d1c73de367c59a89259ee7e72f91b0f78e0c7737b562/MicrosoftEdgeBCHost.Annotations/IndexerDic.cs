using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IndexerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerDic()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralProcess()
	{
	}
}
