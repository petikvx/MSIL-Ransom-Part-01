using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterpreterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceVal()
	{
	}
}
