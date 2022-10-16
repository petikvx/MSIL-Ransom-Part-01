using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceEvent()
	{
	}
}
