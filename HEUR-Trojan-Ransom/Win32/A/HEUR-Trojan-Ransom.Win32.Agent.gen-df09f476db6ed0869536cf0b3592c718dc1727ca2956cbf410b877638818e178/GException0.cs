using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

[Serializable]
public class GException0 : Exception
{
	private int int_0;

	private string string_0;

	[SpecialName]
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	public string method_1()
	{
		return string_0;
	}

	public GException0()
	{
		Class51.smethod_0();
		base._002Ector();
	}

	public GException0(string string_1)
	{
		Class51.smethod_0();
		base._002Ector(string_1);
	}

	public GException0(int int_1, string string_1)
	{
		Class51.smethod_0();
		base._002Ector($"Error {int_1}: {string_1}");
		int_0 = int_1;
		string_0 = string_1;
	}

	public GException0(string string_1, Exception exception_0)
	{
		Class51.smethod_0();
		base._002Ector(string_1, exception_0);
	}

	protected GException0(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		Class51.smethod_0();
		base._002Ector(serializationInfo_0, streamingContext_0);
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		int_0 = info.GetInt32("errorCode");
		string_0 = info.GetString("errorText");
		base.GetObjectData(info, context);
	}
}
