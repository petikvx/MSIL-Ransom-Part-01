using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SetterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceCallback()
	{
	}
}
