using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttrFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceInterpreter()
	{
	}
}
