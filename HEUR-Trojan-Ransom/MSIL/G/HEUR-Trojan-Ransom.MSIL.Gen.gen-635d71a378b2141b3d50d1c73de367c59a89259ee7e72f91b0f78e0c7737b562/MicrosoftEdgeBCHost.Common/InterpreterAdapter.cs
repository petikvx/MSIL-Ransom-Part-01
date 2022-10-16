using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterpreterAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceMapping()
	{
	}
}
