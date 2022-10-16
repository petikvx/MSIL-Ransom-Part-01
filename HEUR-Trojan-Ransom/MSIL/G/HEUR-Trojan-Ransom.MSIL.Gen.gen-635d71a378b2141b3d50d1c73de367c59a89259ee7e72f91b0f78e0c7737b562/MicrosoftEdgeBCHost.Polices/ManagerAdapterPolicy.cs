using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ManagerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralWriter()
	{
	}
}
