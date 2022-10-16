using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ThreadObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadObject()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralTemplate()
	{
	}
}
