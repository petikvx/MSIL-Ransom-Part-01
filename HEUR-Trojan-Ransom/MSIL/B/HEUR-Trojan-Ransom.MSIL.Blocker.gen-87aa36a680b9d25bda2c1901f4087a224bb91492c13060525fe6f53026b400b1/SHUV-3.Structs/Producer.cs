namespace SHUV_002D3.Structs;

internal class Producer
{
	internal static Producer InvokeContext;

	internal void DisableProducer()
	{
	}

	internal void InvokeProducer()
	{
	}

	internal void ComputeProducer()
	{
	}

	internal void LoginProducer()
	{
	}

	internal void AssetProducer()
	{
	}

	internal static bool SelectContext()
	{
		return InvokeContext == null;
	}

	internal static Producer NewContext()
	{
		return InvokeContext;
	}
}
