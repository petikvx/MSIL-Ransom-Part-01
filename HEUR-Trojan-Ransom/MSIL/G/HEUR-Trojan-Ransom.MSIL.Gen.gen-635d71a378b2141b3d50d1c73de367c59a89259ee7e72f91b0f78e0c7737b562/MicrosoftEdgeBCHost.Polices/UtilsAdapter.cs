using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class UtilsAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceMethod()
	{
	}
}
