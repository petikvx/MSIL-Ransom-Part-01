using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegistryRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterpreter()
	{
	}
}
