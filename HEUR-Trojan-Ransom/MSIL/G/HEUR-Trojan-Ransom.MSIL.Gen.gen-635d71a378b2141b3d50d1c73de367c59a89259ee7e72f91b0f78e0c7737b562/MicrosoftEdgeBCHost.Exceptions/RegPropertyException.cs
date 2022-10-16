using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RegPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralFacade()
	{
	}
}
