using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IssuerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralModel()
	{
	}
}
