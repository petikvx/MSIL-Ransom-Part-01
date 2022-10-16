using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PropertyGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceListener()
	{
	}
}
