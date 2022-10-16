using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DefinitionRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionRules()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectProxy()
	{
	}
}
