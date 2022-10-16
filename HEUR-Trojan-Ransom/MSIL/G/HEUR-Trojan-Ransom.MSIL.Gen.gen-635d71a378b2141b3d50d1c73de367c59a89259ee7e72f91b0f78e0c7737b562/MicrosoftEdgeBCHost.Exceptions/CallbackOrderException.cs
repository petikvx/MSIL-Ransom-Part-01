using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CallbackOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceRef()
	{
	}
}
