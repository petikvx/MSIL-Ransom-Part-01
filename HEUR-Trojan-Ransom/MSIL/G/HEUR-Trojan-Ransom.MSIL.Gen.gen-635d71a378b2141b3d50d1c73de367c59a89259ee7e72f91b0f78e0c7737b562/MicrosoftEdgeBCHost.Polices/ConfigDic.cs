using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigDic()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralRepository()
	{
	}
}
