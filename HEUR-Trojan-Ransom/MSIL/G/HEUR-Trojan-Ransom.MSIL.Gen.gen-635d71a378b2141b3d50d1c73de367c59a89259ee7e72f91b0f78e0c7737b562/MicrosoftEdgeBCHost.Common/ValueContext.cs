using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValueContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueContext()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceInterpreter()
	{
	}
}
