using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralAlgo()
	{
	}
}
