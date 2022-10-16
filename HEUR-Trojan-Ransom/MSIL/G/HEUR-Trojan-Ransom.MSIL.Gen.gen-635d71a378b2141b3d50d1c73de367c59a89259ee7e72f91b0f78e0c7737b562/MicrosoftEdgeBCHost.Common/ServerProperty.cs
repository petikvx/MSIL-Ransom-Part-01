using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceAlgo()
	{
	}
}
