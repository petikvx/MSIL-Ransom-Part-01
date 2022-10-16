using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExceptionAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceWrapper()
	{
	}
}
