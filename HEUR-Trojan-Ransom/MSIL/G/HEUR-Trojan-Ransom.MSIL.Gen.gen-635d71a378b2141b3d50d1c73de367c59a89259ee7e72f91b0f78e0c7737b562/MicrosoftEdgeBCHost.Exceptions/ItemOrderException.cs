using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceListener()
	{
	}
}
