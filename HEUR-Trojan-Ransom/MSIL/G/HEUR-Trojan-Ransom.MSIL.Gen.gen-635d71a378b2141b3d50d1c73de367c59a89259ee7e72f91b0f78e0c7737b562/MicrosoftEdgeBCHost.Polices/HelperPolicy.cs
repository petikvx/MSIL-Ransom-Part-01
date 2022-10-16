using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class HelperPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceProcess()
	{
	}
}
