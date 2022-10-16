using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WrapperOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceDefinition()
	{
	}
}
