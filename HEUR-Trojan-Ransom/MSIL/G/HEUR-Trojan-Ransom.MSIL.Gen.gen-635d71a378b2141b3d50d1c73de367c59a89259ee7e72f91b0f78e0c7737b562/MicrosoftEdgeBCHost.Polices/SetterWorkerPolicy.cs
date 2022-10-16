using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SetterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceAuthentication()
	{
	}
}
