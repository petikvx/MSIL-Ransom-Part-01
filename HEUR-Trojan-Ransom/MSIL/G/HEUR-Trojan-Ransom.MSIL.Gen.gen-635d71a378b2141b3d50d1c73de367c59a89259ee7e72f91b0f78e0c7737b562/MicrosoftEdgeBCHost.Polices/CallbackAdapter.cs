using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceInstance()
	{
	}
}
