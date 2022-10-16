using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class HelperOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceReponse()
	{
	}
}
