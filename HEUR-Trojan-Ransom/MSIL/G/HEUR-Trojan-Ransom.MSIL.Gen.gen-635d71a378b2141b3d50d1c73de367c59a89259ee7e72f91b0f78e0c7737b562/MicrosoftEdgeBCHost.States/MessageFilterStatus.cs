using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MessageFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceVisitor()
	{
	}
}
