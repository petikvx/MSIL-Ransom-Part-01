using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcessProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessProperty()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceTest()
	{
	}
}
