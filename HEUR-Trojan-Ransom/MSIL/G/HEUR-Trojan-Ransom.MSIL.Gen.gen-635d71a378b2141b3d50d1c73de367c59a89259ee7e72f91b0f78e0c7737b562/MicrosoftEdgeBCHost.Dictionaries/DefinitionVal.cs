using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionVal()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeContainer()
	{
	}
}
