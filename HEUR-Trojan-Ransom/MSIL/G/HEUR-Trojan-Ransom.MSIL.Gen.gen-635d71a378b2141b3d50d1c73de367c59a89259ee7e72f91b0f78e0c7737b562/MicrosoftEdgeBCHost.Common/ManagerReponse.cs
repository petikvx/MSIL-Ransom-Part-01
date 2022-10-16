using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ManagerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralInstance()
	{
	}
}
