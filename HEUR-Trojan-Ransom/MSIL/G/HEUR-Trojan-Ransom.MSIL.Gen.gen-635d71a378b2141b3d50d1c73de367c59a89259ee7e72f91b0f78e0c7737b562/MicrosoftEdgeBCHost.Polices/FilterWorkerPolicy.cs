using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FilterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceRole()
	{
	}
}
