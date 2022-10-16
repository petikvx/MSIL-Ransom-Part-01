using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RefPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralAdvisor()
	{
	}
}
