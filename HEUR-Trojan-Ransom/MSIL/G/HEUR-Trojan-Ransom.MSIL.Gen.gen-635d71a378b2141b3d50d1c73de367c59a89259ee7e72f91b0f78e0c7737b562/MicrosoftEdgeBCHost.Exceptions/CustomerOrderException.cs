using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CustomerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceDefinition()
	{
	}
}
