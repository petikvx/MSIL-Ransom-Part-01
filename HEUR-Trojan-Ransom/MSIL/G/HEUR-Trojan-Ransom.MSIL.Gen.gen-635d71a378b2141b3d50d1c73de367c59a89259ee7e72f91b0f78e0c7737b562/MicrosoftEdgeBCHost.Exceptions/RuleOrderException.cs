using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RuleOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceAdapter()
	{
	}
}
