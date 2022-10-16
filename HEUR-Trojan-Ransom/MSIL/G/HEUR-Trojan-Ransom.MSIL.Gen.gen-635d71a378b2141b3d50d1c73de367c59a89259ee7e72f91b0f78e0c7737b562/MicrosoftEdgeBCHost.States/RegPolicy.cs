using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceField()
	{
	}
}
