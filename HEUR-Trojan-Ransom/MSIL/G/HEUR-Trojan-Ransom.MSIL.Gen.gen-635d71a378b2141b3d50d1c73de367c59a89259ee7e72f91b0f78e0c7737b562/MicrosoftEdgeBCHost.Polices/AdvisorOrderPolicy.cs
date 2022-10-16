using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdvisorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralExporter()
	{
	}
}
