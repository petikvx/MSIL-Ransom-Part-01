using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RepositoryFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralExporter()
	{
	}
}
