using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FacadeState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeState()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceException()
	{
	}
}
