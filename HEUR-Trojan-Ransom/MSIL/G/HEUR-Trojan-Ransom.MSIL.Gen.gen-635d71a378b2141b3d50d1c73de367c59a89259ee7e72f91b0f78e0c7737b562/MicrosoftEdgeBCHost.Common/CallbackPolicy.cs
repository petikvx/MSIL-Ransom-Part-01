using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CallbackPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceField()
	{
	}
}
