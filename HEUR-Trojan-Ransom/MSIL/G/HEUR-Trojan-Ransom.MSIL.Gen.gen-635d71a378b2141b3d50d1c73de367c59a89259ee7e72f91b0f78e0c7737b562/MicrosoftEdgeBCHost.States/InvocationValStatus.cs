using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InvocationValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralRecord()
	{
	}
}
