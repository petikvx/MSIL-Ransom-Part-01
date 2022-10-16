using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RecordOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceInterceptor()
	{
	}
}
