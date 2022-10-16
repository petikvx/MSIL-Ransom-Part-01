using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExceptionReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionReponse()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceProc()
	{
	}
}
