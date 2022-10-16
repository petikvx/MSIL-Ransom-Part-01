using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterpreterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatItem()
	{
	}
}
