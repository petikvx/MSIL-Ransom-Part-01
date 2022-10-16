using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Advisor
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Advisor()
	{
		WriterPropertyProducer.ResolveStub();
		CheckCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckCode()
	{
	}
}
