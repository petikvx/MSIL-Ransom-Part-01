using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PolicyRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterProperty()
	{
	}
}
