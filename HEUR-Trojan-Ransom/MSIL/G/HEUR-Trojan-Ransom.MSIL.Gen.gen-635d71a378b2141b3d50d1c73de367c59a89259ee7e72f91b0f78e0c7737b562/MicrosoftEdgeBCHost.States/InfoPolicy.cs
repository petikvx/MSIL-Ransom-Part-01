using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InfoPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceCallback()
	{
	}
}
