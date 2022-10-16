using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdvisorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceGetter()
	{
	}
}
