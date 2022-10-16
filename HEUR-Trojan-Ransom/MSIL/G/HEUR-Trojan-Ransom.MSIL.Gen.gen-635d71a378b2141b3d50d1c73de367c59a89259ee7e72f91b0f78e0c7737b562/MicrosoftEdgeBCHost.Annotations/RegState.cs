using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegState()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceProperty()
	{
	}
}
