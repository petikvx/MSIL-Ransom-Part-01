using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerState()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceRecord()
	{
	}
}
