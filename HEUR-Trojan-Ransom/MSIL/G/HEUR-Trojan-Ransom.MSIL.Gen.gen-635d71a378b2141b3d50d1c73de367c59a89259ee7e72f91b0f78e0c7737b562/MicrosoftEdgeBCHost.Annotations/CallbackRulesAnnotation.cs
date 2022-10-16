using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CallbackRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ListInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInvocation()
	{
	}
}
