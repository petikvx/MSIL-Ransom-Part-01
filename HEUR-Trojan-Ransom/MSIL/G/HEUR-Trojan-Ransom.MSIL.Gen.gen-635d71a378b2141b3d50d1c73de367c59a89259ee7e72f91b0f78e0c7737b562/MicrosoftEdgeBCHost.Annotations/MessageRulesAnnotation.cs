using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MessageRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeConfig()
	{
	}
}
