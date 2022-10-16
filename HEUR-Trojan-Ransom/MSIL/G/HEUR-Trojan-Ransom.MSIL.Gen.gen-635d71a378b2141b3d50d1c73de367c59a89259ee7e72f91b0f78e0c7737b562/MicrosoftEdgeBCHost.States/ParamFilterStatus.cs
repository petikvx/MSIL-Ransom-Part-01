using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceInterpreter()
	{
	}
}
