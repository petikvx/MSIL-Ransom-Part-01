using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PublisherRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceParams()
	{
	}
}
