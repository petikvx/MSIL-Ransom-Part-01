using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TagFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceFilter()
	{
	}
}
