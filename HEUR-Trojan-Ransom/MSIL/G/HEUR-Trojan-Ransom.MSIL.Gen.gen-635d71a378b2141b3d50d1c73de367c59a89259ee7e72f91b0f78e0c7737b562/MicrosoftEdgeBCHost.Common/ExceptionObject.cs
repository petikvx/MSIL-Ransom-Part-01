using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExceptionObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionObject()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralListener()
	{
	}
}
