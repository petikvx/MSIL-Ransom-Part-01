using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamsOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ChangePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangePolicy()
	{
	}
}
