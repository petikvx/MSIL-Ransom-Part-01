using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IteratorPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralRules()
	{
	}
}
