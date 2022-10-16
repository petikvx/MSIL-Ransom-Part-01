using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParamFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceBroadcaster()
	{
	}
}
