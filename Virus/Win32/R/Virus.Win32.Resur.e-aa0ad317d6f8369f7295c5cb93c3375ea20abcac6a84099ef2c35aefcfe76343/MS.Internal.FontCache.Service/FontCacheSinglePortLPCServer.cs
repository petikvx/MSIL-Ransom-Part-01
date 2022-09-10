using System.Security;

namespace MS.Internal.FontCache.Service;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal class FontCacheSinglePortLPCServer : LPCServer
{
	internal FontCacheSinglePortLPCServer()
		: base("\\BaseNamedObjects\\FontCachePort3.0.0.0", FontCacheAdapter.GetServerInstanceCapacity(), FontCacheAdapter.GetMaxDataSize(), FontCacheAdapter.GetMaxMessageSize(), FontCacheAdapter.GetFontCacheSecurityDescriptor())
	{
	}

	protected override bool ShouldAccept(LPCMessage msg)
	{
		bool flag = FontCacheAdapter.ShouldAccept((LPCServer)(object)this, msg);
		bool result = ((LPCServer)this).ShouldAccept(msg);
		if (flag)
		{
			return result;
		}
		return false;
	}

	protected override LPCMessage ProcessRequestData(LPCMessage msg, ClientInfo clientInfo)
	{
		return FontCacheAdapter.ProcessRequestData((LPCServer)(object)this, msg, clientInfo);
	}

	protected override void ProcessDatagramData(LPCMessage msg, ClientInfo clientInfo)
	{
		FontCacheAdapter.ProcessRequestData((LPCServer)(object)this, msg, clientInfo);
	}
}
