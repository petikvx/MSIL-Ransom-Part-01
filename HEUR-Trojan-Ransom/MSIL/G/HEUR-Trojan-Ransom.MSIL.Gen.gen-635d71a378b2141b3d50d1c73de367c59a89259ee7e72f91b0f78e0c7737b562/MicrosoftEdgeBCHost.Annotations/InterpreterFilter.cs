using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterpreterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatWatcher()
	{
	}
}
