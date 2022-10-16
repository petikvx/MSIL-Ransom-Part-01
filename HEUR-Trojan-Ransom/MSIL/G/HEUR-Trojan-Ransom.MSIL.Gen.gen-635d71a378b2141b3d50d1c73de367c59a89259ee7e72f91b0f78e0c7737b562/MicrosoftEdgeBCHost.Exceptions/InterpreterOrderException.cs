using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InterpreterOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceInitializer()
	{
	}
}
