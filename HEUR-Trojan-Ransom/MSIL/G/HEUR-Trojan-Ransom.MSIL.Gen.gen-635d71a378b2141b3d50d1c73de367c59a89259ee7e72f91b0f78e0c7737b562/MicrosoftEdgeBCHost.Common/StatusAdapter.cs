using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StatusAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceIssuer()
	{
	}
}
