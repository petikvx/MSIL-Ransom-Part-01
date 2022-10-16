using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MockFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceStruct()
	{
	}
}
