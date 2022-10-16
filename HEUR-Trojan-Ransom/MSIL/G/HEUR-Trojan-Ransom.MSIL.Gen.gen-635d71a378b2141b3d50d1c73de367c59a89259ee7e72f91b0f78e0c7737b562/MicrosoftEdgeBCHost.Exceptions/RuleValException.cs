using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RuleValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleValException()
	{
		WriterPropertyProducer.ResolveStub();
		MoveGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveGetter()
	{
	}
}
