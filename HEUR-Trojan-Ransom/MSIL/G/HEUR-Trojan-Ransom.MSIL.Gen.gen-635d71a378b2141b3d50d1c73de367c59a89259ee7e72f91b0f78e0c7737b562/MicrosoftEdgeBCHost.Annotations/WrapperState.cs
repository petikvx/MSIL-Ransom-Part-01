using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WrapperState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperState()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceResolver()
	{
	}
}
