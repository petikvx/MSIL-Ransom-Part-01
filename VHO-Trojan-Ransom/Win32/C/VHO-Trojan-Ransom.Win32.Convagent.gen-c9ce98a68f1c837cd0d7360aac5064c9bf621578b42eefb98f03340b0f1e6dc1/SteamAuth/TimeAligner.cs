using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SteamAuth;

public class TimeAligner
{
	internal class Class12
	{
		internal class Class13
		{
			[CompilerGenerated]
			private long long_0;

			[JsonProperty("server_time")]
			public long Int64_0
			{
				[CompilerGenerated]
				get
				{
					return long_0;
				}
				[CompilerGenerated]
				set
				{
					long_0 = value;
				}
			}

			public Class13()
			{
				Class24.nhQmSIPz7n4eU();
				base._002Ector();
			}
		}

		[CompilerGenerated]
		private Class13 class13_0;

		[JsonProperty("response")]
		internal Class13 Class13_0
		{
			[CompilerGenerated]
			get
			{
				return class13_0;
			}
			[CompilerGenerated]
			set
			{
				class13_0 = value;
			}
		}

		public Class12()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private static bool bool_0;

	private static int int_0;

	public static long GetSteamTime()
	{
		if (!bool_0)
		{
			AlignTime();
		}
		return Util.GetSystemUnixTime() + int_0;
	}

	public static async Task<long> GetSteamTimeAsync()
	{
		if (!bool_0)
		{
			await AlignTimeAsync();
		}
		return Util.GetSystemUnixTime() + int_0;
	}

	public static void AlignTime()
	{
		long systemUnixTime = Util.GetSystemUnixTime();
		using WebClient webClient = new WebClient();
		try
		{
			int_0 = (int)(JsonConvert.DeserializeObject<Class12>(webClient.UploadString(APIEndpoints.TWO_FACTOR_TIME_QUERY, "steamid=0")).Class13_0.Int64_0 - systemUnixTime);
			bool_0 = true;
		}
		catch (WebException)
		{
		}
	}

	public static async Task AlignTimeAsync()
	{
		long currentTime = Util.GetSystemUnixTime();
		WebClient webClient = new WebClient();
		try
		{
			int_0 = (int)(JsonConvert.DeserializeObject<Class12>(await webClient.UploadStringTaskAsync(new Uri(APIEndpoints.TWO_FACTOR_TIME_QUERY), "steamid=0")).Class13_0.Int64_0 - currentTime);
			bool_0 = true;
		}
		catch (WebException)
		{
		}
	}

	public TimeAligner()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}

	static TimeAligner()
	{
		Class24.nhQmSIPz7n4eU();
	}
}
