using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceHelper()
	{
	}
}
