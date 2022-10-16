using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class VisitorRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterRules()
	{
	}
}
