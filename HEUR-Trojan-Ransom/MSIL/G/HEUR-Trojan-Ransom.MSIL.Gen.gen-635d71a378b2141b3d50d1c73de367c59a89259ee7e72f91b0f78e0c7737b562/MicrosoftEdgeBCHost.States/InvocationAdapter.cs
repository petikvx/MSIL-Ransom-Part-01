using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InvocationAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceInstance()
	{
	}
}
