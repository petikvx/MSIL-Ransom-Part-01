using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceMethod()
	{
	}
}
