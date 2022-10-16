using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal sealed class Proxy
{
	internal static object m_Class;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Proxy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
