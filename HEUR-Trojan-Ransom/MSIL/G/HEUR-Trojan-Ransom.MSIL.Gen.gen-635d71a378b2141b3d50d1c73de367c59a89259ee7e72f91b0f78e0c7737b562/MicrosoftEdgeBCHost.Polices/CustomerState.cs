using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CustomerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerState()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceParam()
	{
	}
}
