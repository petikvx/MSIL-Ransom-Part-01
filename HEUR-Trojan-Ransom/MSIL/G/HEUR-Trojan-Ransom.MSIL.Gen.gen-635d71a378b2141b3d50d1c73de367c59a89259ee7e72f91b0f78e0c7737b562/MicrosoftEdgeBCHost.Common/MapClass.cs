using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapClass()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfacePool()
	{
	}
}
