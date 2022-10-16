using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RepositoryDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralStub()
	{
	}
}
