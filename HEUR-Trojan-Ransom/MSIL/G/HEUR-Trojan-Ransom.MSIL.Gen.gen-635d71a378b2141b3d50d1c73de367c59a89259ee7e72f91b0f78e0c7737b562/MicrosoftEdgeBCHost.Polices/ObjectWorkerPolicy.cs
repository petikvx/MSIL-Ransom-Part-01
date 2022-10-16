using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObjectWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceMapper()
	{
	}
}
