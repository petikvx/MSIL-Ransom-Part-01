using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterpreterGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceIterator()
	{
	}
}
