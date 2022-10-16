using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IndexerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralRequest()
	{
	}
}
