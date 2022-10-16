using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReaderRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeStrategy()
	{
	}
}
