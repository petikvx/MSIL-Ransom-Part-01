using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WrapperWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SetupCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupCustomer()
	{
	}
}
