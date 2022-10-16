using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DispatcherOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceImporter()
	{
	}
}
