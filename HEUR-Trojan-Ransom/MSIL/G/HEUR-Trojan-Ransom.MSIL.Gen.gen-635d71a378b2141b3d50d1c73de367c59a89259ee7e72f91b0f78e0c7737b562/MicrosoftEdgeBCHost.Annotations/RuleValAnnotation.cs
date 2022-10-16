using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RuleValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceTokenizer()
	{
	}
}
