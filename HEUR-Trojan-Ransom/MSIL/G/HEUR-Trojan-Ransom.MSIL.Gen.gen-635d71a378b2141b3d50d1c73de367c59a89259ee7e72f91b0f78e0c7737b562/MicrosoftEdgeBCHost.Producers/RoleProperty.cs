using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RoleProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleProperty()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceTest()
	{
	}
}
