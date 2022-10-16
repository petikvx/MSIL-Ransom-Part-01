using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObserverAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralSingleton()
	{
	}
}
