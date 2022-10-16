using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BroadcasterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterContext()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceInterpreter()
	{
	}
}
