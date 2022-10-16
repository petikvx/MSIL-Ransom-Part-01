using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterClass()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceInterceptor()
	{
	}
}
