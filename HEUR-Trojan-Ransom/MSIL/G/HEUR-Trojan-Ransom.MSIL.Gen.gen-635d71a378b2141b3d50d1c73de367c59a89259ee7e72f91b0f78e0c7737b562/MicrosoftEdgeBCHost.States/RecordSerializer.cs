using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RecordSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralEvent()
	{
	}
}
