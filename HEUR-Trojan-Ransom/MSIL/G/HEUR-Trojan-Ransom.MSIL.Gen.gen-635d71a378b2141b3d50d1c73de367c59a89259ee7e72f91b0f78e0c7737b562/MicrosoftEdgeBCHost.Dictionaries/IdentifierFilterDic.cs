using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IdentifierFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralWorker()
	{
	}
}
