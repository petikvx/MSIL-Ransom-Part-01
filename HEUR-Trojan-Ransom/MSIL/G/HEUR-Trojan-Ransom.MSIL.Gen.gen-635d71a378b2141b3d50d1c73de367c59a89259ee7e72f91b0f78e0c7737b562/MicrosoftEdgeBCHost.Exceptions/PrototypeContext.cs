using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrototypeContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeContext()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceUtils()
	{
	}
}
