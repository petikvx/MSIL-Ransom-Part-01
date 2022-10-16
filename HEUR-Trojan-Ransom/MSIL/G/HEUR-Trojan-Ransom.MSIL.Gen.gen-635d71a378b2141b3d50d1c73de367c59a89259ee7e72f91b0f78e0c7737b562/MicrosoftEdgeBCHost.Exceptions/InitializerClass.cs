using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerClass()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceReg()
	{
	}
}
