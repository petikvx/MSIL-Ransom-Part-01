using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExporterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceInvocation()
	{
	}
}
