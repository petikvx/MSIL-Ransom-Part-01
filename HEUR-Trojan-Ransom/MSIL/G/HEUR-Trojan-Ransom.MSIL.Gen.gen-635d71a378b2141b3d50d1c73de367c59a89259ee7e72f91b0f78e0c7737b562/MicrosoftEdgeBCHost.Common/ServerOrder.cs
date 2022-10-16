using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CreatePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreatePool()
	{
	}
}
