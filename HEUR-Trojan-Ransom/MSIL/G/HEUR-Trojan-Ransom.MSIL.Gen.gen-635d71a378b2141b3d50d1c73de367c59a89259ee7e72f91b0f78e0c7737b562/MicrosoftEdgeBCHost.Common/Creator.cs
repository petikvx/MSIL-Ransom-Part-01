using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal sealed class Creator
{
	internal static object GetServer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PushStub(object def, object vis)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Creator()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AssetServer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Creator FillServer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateServer()
	{
	}
}
