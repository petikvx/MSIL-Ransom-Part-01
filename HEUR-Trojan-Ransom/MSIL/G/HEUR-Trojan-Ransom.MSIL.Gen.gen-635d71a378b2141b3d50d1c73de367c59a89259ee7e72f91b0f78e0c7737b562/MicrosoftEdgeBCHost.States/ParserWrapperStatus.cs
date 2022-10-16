using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal sealed class ParserWrapperStatus
{
	internal static object m_State;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
