using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValueState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueState()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceConfiguration()
	{
	}
}
