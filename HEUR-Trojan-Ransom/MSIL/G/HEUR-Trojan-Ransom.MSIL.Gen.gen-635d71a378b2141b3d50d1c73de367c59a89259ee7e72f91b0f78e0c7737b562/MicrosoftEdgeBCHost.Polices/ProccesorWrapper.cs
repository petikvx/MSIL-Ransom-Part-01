using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProccesorWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		StopRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopRole()
	{
	}
}
