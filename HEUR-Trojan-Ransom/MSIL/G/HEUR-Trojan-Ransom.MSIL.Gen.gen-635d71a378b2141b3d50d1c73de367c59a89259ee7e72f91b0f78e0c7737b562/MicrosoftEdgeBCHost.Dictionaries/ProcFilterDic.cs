using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralInitializer()
	{
	}
}
