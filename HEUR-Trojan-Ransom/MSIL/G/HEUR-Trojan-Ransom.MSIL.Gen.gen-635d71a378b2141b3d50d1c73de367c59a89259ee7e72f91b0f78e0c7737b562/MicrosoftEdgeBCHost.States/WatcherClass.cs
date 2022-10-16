using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WatcherClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherClass()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceReg()
	{
	}
}
