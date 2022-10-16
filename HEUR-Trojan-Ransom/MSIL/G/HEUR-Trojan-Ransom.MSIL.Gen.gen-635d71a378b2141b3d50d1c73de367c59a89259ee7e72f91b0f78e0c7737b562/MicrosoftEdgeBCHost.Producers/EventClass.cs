using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class EventClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventClass()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceReg()
	{
	}
}
