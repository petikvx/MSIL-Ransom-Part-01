using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class QueueExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralRole()
	{
	}
}
