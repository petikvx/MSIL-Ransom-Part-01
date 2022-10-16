using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProccesorContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorContext()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceRequest()
	{
	}
}
