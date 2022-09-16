using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml;

namespace dfb44QxstTvciGRseP;

public class MOpjhRQKt00jUh2Tbm : oPMer26JhO73WAJG4a
{
	private static readonly Regex HB3svpnHpL;

	private ushort BMss0llsuR;

	private string ufDsjVw42b;

	private IEnumerable<oPMer26JhO73WAJG4a> vy9sK1cT30;

	private int GqmsY2uyQX;

	private DateTime TEwszWX4fc;

	private string vdAhweyelL;

	private string rQXhs5wnTD;

	private EventLogEntryType BJehhyUuZg;

	private string h1AhL8xXXF;

	private static MOpjhRQKt00jUh2Tbm oN2mcBXCjDuZEI51TB1;

	public EventLogEntryType Type => BJehhyUuZg;

	public DateTime GeneratedTime => TEwszWX4fc;

	public string Source => rQXhs5wnTD;

	public int EventId => GqmsY2uyQX;

	public string User => h1AhL8xXXF;

	public string Computer => ufDsjVw42b;

	public string Message => vdAhweyelL;

	[SpecialName]
	public ushort ijqFYyeEd1()
	{
		return BMss0llsuR;
	}

	[SpecialName]
	public IEnumerable<oPMer26JhO73WAJG4a> YKnF3UFTWC()
	{
		return vy9sK1cT30;
	}

	[SpecialName]
	public void FmNFFCZXVt(IEnumerable<oPMer26JhO73WAJG4a> ienumerable_0)
	{
		vy9sK1cT30 = ienumerable_0;
	}

	public bool zf4FAiJxZP(bleFS5jEcfDKItM0rC bleFS5jEcfDKItM0rC_0)
	{
		bool result;
		if (rQXhs5wnTD.IndexOf(bleFS5jEcfDKItM0rC_0.Source) != -1 || OqL8txX3Rud6SkJdpqG(vdAhweyelL, bleFS5jEcfDKItM0rC_0.Message) != -1)
		{
			result = true;
		}
		else
		{
			result = false;
			int num = 0;
			if (ThycxVXqYnR3y46qCFK() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return result;
	}

	public static MOpjhRQKt00jUh2Tbm m6YsULGgtH(XmlNode xmlNode_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		MOpjhRQKt00jUh2Tbm mOpjhRQKt00jUh2Tbm = new MOpjhRQKt00jUh2Tbm();
		mOpjhRQKt00jUh2Tbm.ufDsjVw42b = xmlNode_0.SelectSingleNode("Computer")!.InnerText;
		mOpjhRQKt00jUh2Tbm.BJehhyUuZg = AODs4Oh2Nr((string)CK4EnkXYyZLWPI5EitY(xmlNode_0.SelectSingleNode("Type")));
		mOpjhRQKt00jUh2Tbm.h1AhL8xXXF = (string)CK4EnkXYyZLWPI5EitY(TnnY8RXLlqQXNFuWhgk(xmlNode_0, "User"));
		mOpjhRQKt00jUh2Tbm.rQXhs5wnTD = xmlNode_0.SelectSingleNode("Source")!.InnerText;
		mOpjhRQKt00jUh2Tbm.GqmsY2uyQX = int.Parse(xmlNode_0.SelectSingleNode("EventId")!.InnerText);
		mOpjhRQKt00jUh2Tbm.vdAhweyelL = xmlNode_0.SelectSingleNode("Message")!.InnerText;
		mOpjhRQKt00jUh2Tbm.TEwszWX4fc = iX0sxqy78n(xmlNode_0.SelectSingleNode("TimeGenerated")!.InnerText);
		int num = 0;
		if (ThycxVXqYnR3y46qCFK() == null)
		{
			goto IL_00c4;
		}
		goto IL_00d4;
		IL_00d4:
		switch (num)
		{
		case 1:
			goto IL_00e4;
		}
		goto IL_00c4;
		IL_00c4:
		MOpjhRQKt00jUh2Tbm result = mOpjhRQKt00jUh2Tbm;
		num = 1;
		if (ThycxVXqYnR3y46qCFK() != null)
		{
			goto IL_00d4;
		}
		goto IL_00e4;
		IL_00e4:
		return result;
	}

	private static DateTime iX0sxqy78n(string string_0)
	{
		int num = 2;
		int year = default(int);
		while (true)
		{
			Match match = (Match)ms5pZMXNdIU22TJwqfV(HB3svpnHpL, string_0);
			int num2 = 1;
			if (!WxvGIRXTrdt44i0BvXE())
			{
				goto IL_0035;
			}
			goto IL_0039;
			IL_0039:
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto IL_000b;
				case 2:
					break;
				default:
				{
					int month = int.Parse(match.Groups["month"].Value);
					int day = S5mcrNX0KRRu2YNartJ(match.Groups["day"].Value);
					int hour = int.Parse(match.Groups["hour"].Value);
					int minute = int.Parse(match.Groups["minute"].Value);
					int second = int.Parse(match.Groups["second"].Value);
					int millisecond = int.Parse((string)XXOubHX6neOmOtUdXG2(((GroupCollection)dmWSqlXMry7NfSJq6iM(match))["millisecond"]));
					return new DateTime(year, month, day, hour, minute, second, millisecond);
				}
				}
				break;
				IL_000b:
				year = int.Parse(((Capture)vUQlG3XO6K3UOvUEpm3(match.Groups, "year")).Value);
				num2 = 0;
				if (ThycxVXqYnR3y46qCFK() == null)
				{
					continue;
				}
				goto IL_0035;
			}
			continue;
			IL_0035:
			num2 = num;
			goto IL_0039;
		}
	}

	private static EventLogEntryType AODs4Oh2Nr(string string_0)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		while (true)
		{
			bool flag = string_0.ToLower().Contains("audit");
			int num2 = 1;
			if (ThycxVXqYnR3y46qCFK() != null)
			{
				goto IL_001c;
			}
			goto IL_0020;
			IL_0020:
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (flag)
					{
						goto IL_000f;
					}
					goto IL_0083;
				case 2:
					break;
				default:
					{
						if (((string)aPkVmoX5CO9GjFPgsJw(string_0)).Contains("success"))
						{
							return (EventLogEntryType)8;
						}
						if (((string)aPkVmoX5CO9GjFPgsJw(string_0)).Contains("failure"))
						{
							return (EventLogEntryType)16;
						}
						goto IL_0083;
					}
					IL_0083:
					return (EventLogEntryType)Enum.Parse(lUEO6nXo5LSaqXMhdkQ(typeof(EventLogEntryType).TypeHandle), string_0, ignoreCase: true);
				}
				break;
				IL_000f:
				num2 = 0;
				if (WxvGIRXTrdt44i0BvXE())
				{
					continue;
				}
				goto IL_001c;
			}
			continue;
			IL_001c:
			num2 = num;
			goto IL_0020;
		}
	}

	public MOpjhRQKt00jUh2Tbm()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		base._002Ector();
	}

	static MOpjhRQKt00jUh2Tbm()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		HB3svpnHpL = new Regex("(?<year>\\d{4})(?<month>\\d{2})(?<day>\\d{2})(?<hour>\\d{2})(?<minute>\\d{2})(?<second>\\d{2})\\.(?<millisecond>\\d*)", RegexOptions.Compiled);
	}

	internal static bool WxvGIRXTrdt44i0BvXE()
	{
		return oN2mcBXCjDuZEI51TB1 == null;
	}

	internal static MOpjhRQKt00jUh2Tbm ThycxVXqYnR3y46qCFK()
	{
		return oN2mcBXCjDuZEI51TB1;
	}

	internal static int OqL8txX3Rud6SkJdpqG(object object_0, object object_1)
	{
		return ((string)object_0).IndexOf((string)object_1);
	}

	internal static object CK4EnkXYyZLWPI5EitY(object object_0)
	{
		return ((XmlNode)object_0).InnerText;
	}

	internal static object TnnY8RXLlqQXNFuWhgk(object object_0, object object_1)
	{
		return ((XmlNode)object_0).SelectSingleNode((string)object_1);
	}

	internal static object ms5pZMXNdIU22TJwqfV(object object_0, object object_1)
	{
		return ((Regex)object_0).Match((string)object_1);
	}

	internal static object vUQlG3XO6K3UOvUEpm3(object object_0, object object_1)
	{
		return ((GroupCollection)object_0)[(string)object_1];
	}

	internal static int S5mcrNX0KRRu2YNartJ(object object_0)
	{
		return int.Parse((string)object_0);
	}

	internal static object dmWSqlXMry7NfSJq6iM(object object_0)
	{
		return ((Match)object_0).Groups;
	}

	internal static object XXOubHX6neOmOtUdXG2(object object_0)
	{
		return ((Capture)object_0).Value;
	}

	internal static object aPkVmoX5CO9GjFPgsJw(object object_0)
	{
		return ((string)object_0).ToLower();
	}

	internal static Type lUEO6nXo5LSaqXMhdkQ(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return System.Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
