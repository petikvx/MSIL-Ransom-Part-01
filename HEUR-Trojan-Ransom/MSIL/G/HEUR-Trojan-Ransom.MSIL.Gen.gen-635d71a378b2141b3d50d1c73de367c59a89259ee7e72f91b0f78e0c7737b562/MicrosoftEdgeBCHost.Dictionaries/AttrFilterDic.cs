using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttrFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralConnection()
	{
	}
}
