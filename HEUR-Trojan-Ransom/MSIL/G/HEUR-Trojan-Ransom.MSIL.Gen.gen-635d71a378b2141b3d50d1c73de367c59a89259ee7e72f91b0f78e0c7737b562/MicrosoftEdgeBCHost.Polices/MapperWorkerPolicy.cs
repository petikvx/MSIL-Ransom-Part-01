using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapperWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceStub()
	{
	}
}
