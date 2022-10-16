using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal sealed class Global
{
	internal static object m_Context;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Global()
	{
		WriterPropertyProducer.ResolveStub();
		FlushServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushServer()
	{
	}
}
