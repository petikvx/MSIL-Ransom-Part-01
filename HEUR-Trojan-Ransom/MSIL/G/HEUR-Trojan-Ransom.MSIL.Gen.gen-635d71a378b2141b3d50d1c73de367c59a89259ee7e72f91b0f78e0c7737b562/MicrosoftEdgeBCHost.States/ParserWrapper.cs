using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParserWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		AssetTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetTest()
	{
	}
}
