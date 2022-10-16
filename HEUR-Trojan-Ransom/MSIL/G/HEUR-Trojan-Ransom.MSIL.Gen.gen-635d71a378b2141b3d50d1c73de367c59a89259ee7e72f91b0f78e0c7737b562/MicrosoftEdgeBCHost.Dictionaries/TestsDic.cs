using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal sealed class TestsDic
{
	internal static object ConnectServer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DeleteStub(object setup, object cont)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QueryServer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TestsDic AddServer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeServer()
	{
	}
}
