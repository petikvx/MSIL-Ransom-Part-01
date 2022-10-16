using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AnnotationRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceIdentifier()
	{
	}
}
