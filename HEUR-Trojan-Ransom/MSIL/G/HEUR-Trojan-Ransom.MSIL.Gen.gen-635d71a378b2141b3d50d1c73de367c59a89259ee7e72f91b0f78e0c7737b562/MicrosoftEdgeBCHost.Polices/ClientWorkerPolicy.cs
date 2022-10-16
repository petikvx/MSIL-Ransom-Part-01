using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClientWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceInfo()
	{
	}
}
