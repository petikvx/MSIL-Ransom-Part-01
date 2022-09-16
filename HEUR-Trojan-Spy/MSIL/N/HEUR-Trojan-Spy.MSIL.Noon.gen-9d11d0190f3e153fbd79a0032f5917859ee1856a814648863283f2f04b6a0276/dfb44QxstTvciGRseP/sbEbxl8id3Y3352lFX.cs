using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace dfb44QxstTvciGRseP;

public class sbEbxl8id3Y3352lFX : oPMer26JhO73WAJG4a
{
	private static readonly Regex nIai1tEbF;

	private ushort Y1Q6Z5NCn;

	private string kupNu8Dql;

	private IEnumerable<oPMer26JhO73WAJG4a> FQYmkQwiK;

	private int ejTkRFAjL;

	private DateTime vda8tKcxQ;

	private string tNNgUiVho;

	private string FnnVou6NJ;

	private EventLogEntryType JwfOhBSIP;

	private string IpVdDBOHQ;

	internal static sbEbxl8id3Y3352lFX k1nd2L3KUwW7MqXBKY;

	public EventLogEntryType Type => JwfOhBSIP;

	public DateTime GeneratedTime => vda8tKcxQ;

	public string Source => FnnVou6NJ;

	public int EventId => ejTkRFAjL;

	public string User => IpVdDBOHQ;

	public string Computer => kupNu8Dql;

	public string Message => tNNgUiVho;

	[SpecialName]
	public ushort ijqFYyeEd1()
	{
		return Y1Q6Z5NCn;
	}

	[SpecialName]
	public IEnumerable<oPMer26JhO73WAJG4a> YKnF3UFTWC()
	{
		return FQYmkQwiK;
	}

	[SpecialName]
	public void FmNFFCZXVt(IEnumerable<oPMer26JhO73WAJG4a> ienumerable_0)
	{
		FQYmkQwiK = ienumerable_0;
	}

	public bool zf4FAiJxZP(bleFS5jEcfDKItM0rC bleFS5jEcfDKItM0rC_0)
	{
		if (FnnVou6NJ.IndexOf(bleFS5jEcfDKItM0rC_0.Source) != -1 || tNNgUiVho.IndexOf(bleFS5jEcfDKItM0rC_0.Message) != -1)
		{
			return true;
		}
		return false;
	}

	public static sbEbxl8id3Y3352lFX peHql9gAk(string string_0)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		string[] array = (string[])Wul5FiNYj1VTVH5t4y(string_0, new char[1] { ',' });
		int num = 0;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		sbEbxl8id3Y3352lFX sbEbxl8id3Y3352lFX2 = default(sbEbxl8id3Y3352lFX);
		while (true)
		{
			IL_012f:
			int num2;
			if (num < array.Length)
			{
				stringBuilder = new StringBuilder(array[num]);
				num2 = 0;
				if (uvc7cHL6wlk7VjSHrF() != null)
				{
					num2 = num3;
				}
				goto IL_00be;
			}
			num4 = 0;
			goto IL_0078;
			IL_00be:
			while (true)
			{
				switch (num2)
				{
				case 1:
					break;
				case 5:
					goto IL_0078;
				default:
					if (array[num].StartsWith("\""))
					{
						flag = !T6L1QhOOkZ3gYZ4IIs(array[num], "\"");
						num2 = 6;
						if (uvc7cHL6wlk7VjSHrF() == null)
						{
							continue;
						}
						goto IL_0078;
					}
					goto case 2;
				case 6:
					if (flag)
					{
						goto case 4;
					}
					goto case 2;
				case 4:
					do
					{
						num++;
						I0wR840K1DYZeGCmPu(stringBuilder, array[num]);
					}
					while (!array[num].Trim().EndsWith("\""));
					goto case 2;
				case 2:
					list.Add(stringBuilder.ToString());
					num++;
					goto IL_012f;
				case 3:
					goto end_IL_012f;
				}
				break;
			}
			goto IL_0044;
			IL_0044:
			list[num4] = (string)hXHgEuMjhoiRII6exy(list[num4], "<NL>", "\n");
			num4++;
			num2 = 1;
			if (uvc7cHL6wlk7VjSHrF() == null)
			{
				goto IL_0078;
			}
			goto IL_00be;
			IL_0078:
			if (num4 >= list.Count)
			{
				sbEbxl8id3Y3352lFX2 = new sbEbxl8id3Y3352lFX();
				sbEbxl8id3Y3352lFX2.kupNu8Dql = list[0];
				break;
			}
			goto IL_0044;
			continue;
			end_IL_012f:
			break;
		}
		sbEbxl8id3Y3352lFX2.JwfOhBSIP = R36QPWRC1(list[3]);
		sbEbxl8id3Y3352lFX2.IpVdDBOHQ = list[4];
		sbEbxl8id3Y3352lFX2.FnnVou6NJ = list[6];
		sbEbxl8id3Y3352lFX2.ejTkRFAjL = int.Parse(list[7]);
		sbEbxl8id3Y3352lFX2.tNNgUiVho = list[8];
		sbEbxl8id3Y3352lFX2.vda8tKcxQ = PLk3nXcx8(list[10]);
		return sbEbxl8id3Y3352lFX2;
	}

	private static DateTime PLk3nXcx8(string string_0)
	{
		Match match = nIai1tEbF.Match(string_0);
		int year = int.Parse(match.Groups["year"].Value);
		int month = int.Parse(match.Groups["month"].Value);
		int day = vwlulr6HuTxqFoV5KX(match.Groups["day"].Value);
		int hour = vwlulr6HuTxqFoV5KX(match.Groups["hour"].Value);
		int minute = vwlulr6HuTxqFoV5KX(match.Groups["minute"].Value);
		int num = 0;
		if (uvc7cHL6wlk7VjSHrF() != null)
		{
			goto IL_00d7;
		}
		goto IL_00db;
		IL_00db:
		int second = default(int);
		do
		{
			switch (num)
			{
			case 1:
			{
				int millisecond = vwlulr6HuTxqFoV5KX(((GroupCollection)oIRIh95amsml59so75(match))["millisecond"].Value);
				return new DateTime(year, month, day, hour, minute, second, millisecond);
			}
			}
			second = vwlulr6HuTxqFoV5KX(match.Groups["second"].Value);
			num = 1;
		}
		while (Mfamv3YuAX3CxQqHyX());
		goto IL_00d7;
		IL_00d7:
		int num2 = default(int);
		num = num2;
		goto IL_00db;
	}

	private static EventLogEntryType R36QPWRC1(string string_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (((string)GD6YV3oXB5egOd6GSB(string_0)).Contains("audit"))
		{
			if (((string)GD6YV3oXB5egOd6GSB(string_0)).Contains("success"))
			{
				return (EventLogEntryType)8;
			}
			bool flag = string_0.ToLower().Contains("failure");
			int num = 1;
			if (!Mfamv3YuAX3CxQqHyX())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				if (flag)
				{
					return (EventLogEntryType)16;
				}
				break;
			}
		}
		return (EventLogEntryType)Enum.Parse(typeof(EventLogEntryType), string_0, ignoreCase: true);
	}

	public sbEbxl8id3Y3352lFX()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		base._002Ector();
	}

	static sbEbxl8id3Y3352lFX()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		nIai1tEbF = new Regex("(?<year>\\d{4})(?<month>\\d{2})(?<day>\\d{2})(?<hour>\\d{2})(?<minute>\\d{2})(?<second>\\d{2})\\.(?<millisecond>\\d*)", RegexOptions.Compiled);
	}

	internal static bool Mfamv3YuAX3CxQqHyX()
	{
		return k1nd2L3KUwW7MqXBKY == null;
	}

	internal static sbEbxl8id3Y3352lFX uvc7cHL6wlk7VjSHrF()
	{
		return k1nd2L3KUwW7MqXBKY;
	}

	internal static object Wul5FiNYj1VTVH5t4y(object object_0, object object_1)
	{
		return ((string)object_0).Split((char[]?)object_1);
	}

	internal static bool T6L1QhOOkZ3gYZ4IIs(object object_0, object object_1)
	{
		return ((string)object_0).EndsWith((string)object_1);
	}

	internal static object I0wR840K1DYZeGCmPu(object object_0, object object_1)
	{
		return ((StringBuilder)object_0).Append((string?)object_1);
	}

	internal static object hXHgEuMjhoiRII6exy(object object_0, object object_1, object object_2)
	{
		return ((string)object_0).Replace((string)object_1, (string?)object_2);
	}

	internal static int vwlulr6HuTxqFoV5KX(object object_0)
	{
		return int.Parse((string)object_0);
	}

	internal static object oIRIh95amsml59so75(object object_0)
	{
		return ((Match)object_0).Groups;
	}

	internal static object GD6YV3oXB5egOd6GSB(object object_0)
	{
		return ((string)object_0).ToLower();
	}
}
