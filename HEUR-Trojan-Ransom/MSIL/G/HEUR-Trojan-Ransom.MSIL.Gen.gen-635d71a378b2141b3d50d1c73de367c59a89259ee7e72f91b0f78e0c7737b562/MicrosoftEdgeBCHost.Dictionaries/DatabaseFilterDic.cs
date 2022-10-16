using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DatabaseFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralIndexer()
	{
	}
}
