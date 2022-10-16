using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralEvent()
	{
	}
}
