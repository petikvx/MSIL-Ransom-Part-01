using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralWrapper()
	{
	}
}
