using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InvocationRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StartReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartReader()
	{
	}
}
