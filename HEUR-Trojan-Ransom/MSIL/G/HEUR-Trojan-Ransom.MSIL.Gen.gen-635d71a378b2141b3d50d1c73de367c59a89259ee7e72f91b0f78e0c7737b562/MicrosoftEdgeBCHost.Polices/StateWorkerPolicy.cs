using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StateWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceParser()
	{
	}
}
