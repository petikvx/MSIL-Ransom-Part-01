using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConnectionExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralSetter()
	{
	}
}
