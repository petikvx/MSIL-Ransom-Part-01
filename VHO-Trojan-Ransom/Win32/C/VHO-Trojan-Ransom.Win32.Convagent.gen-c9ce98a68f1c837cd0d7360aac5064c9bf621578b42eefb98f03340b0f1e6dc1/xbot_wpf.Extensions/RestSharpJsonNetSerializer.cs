using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace xbot_wpf.Extensions;

public class RestSharpJsonNetSerializer : ISerializer, IDeserializer
{
	private readonly JsonSerializer jsonSerializer_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	public static RestSharpJsonNetSerializer Default
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			JsonSerializer val = new JsonSerializer();
			val.set_MissingMemberHandling((MissingMemberHandling)0);
			val.set_NullValueHandling((NullValueHandling)0);
			val.set_DefaultValueHandling((DefaultValueHandling)0);
			return new RestSharpJsonNetSerializer(val);
		}
	}

	public string DateFormat
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string RootElement
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string Namespace
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public string ContentType
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public RestSharpJsonNetSerializer()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		ContentType = "application/json";
		JsonSerializer val = new JsonSerializer();
		val.set_MissingMemberHandling((MissingMemberHandling)0);
		val.set_NullValueHandling((NullValueHandling)0);
		val.set_DefaultValueHandling((DefaultValueHandling)0);
		jsonSerializer_0 = val;
	}

	public RestSharpJsonNetSerializer(JsonSerializer serializer)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		ContentType = "application/json";
		jsonSerializer_0 = serializer;
	}

	public string Serialize(object obj)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		using StringWriter stringWriter = new StringWriter();
		JsonTextWriter val = new JsonTextWriter((TextWriter)stringWriter);
		try
		{
			((JsonWriter)val).set_Formatting((Formatting)1);
			val.set_QuoteChar('"');
			jsonSerializer_0.Serialize((JsonWriter)(object)val, obj);
			return stringWriter.ToString();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public T Deserialize<T>(IRestResponse response)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		using StringReader stringReader = new StringReader(response.get_Content());
		JsonTextReader val = new JsonTextReader((TextReader)stringReader);
		try
		{
			return jsonSerializer_0.Deserialize<T>((JsonReader)(object)val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
