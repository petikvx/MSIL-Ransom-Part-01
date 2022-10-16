using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdvisorValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralOrder()
	{
	}
}
