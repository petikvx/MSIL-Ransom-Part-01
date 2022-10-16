using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionState()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceConfiguration()
	{
	}
}
