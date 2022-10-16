using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClientProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceTest()
	{
	}
}
