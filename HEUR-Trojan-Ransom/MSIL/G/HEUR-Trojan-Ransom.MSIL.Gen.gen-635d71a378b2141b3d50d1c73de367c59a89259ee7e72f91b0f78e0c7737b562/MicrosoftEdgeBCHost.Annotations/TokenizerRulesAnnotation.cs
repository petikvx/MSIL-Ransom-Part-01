using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenizerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ListSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListSingleton()
	{
	}
}
