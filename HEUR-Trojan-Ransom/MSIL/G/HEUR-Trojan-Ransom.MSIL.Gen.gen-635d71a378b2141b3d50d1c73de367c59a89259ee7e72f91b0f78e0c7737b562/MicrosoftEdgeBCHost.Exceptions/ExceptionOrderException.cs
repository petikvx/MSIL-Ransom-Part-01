using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExceptionOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceIssuer()
	{
	}
}
