using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class UtilsWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceParser()
	{
	}
}
