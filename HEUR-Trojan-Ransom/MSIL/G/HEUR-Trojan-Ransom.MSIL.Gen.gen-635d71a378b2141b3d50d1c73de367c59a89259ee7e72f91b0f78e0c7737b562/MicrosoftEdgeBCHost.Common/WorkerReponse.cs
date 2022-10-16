using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WorkerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceBase()
	{
	}
}
