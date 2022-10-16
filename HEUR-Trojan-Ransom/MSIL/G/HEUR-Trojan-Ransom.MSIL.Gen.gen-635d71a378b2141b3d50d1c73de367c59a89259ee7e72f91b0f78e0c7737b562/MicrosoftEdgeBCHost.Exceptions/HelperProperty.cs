using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class HelperProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceAlgo()
	{
	}
}
