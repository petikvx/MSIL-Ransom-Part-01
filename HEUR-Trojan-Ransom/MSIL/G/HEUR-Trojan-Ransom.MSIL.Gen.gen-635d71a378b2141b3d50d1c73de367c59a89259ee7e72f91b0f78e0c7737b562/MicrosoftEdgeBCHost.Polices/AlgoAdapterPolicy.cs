using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AlgoAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralParam()
	{
	}
}
