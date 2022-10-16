using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegistryGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceComposer()
	{
	}
}
