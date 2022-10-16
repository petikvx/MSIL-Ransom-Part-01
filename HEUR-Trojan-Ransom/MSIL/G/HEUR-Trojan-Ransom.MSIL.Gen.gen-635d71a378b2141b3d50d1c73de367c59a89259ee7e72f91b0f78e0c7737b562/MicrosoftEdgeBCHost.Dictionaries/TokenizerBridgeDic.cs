using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenizerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertStruct()
	{
	}
}
