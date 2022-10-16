using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Pool
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Pool()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeProccesor()
	{
	}
}
