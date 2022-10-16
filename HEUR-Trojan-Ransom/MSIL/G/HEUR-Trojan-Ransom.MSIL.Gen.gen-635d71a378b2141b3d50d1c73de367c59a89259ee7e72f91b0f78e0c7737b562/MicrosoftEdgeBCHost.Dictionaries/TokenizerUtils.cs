using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenizerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceMapper()
	{
	}
}
