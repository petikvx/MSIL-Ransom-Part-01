using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FacadeAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralModel()
	{
	}
}
