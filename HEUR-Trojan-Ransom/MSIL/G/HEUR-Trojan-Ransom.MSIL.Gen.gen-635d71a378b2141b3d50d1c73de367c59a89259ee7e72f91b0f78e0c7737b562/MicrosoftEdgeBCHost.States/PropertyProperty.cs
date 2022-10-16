using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PropertyProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyProperty()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceProccesor()
	{
	}
}
