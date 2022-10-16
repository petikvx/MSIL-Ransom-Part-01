using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceTest()
	{
	}
}
