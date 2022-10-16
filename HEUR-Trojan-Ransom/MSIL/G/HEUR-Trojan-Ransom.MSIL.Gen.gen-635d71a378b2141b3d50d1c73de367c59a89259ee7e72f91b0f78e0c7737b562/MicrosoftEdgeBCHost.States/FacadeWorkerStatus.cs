using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FacadeWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralUtils()
	{
	}
}
