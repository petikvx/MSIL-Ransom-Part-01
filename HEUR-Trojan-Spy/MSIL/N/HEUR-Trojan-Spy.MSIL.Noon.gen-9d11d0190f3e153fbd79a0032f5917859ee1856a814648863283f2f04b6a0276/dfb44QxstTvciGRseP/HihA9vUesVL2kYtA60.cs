using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace dfb44QxstTvciGRseP;

[DefaultMember("Item")]
public abstract class HihA9vUesVL2kYtA60
{
	public static readonly string TdapeaT5S8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Dictionary<string, string> s3FpGFrgS1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Dictionary<int, string> nhgpFNpwaX;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string yklp21bHQc;

	public readonly Encoding uUEpqGnV0N;

	private static HihA9vUesVL2kYtA60 VZigrLDbQZqTWxadNm5;

	[SpecialName]
	[CompilerGenerated]
	public Dictionary<string, string> MQ6pDWPXmp()
	{
		return s3FpGFrgS1;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void Y8FpBHd84u(Dictionary<string, string> dictionary_0)
	{
		s3FpGFrgS1 = dictionary_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Dictionary<int, string> mjRp1gPUlG()
	{
		return nhgpFNpwaX;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void bENpZkMjPh(Dictionary<int, string> dictionary_0)
	{
		nhgpFNpwaX = dictionary_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string UeGpcouvIq()
	{
		return yklp21bHQc;
	}

	[SpecialName]
	public bool C8ZpH3hYtQ()
	{
		return File.Exists(UeGpcouvIq());
	}

	[SpecialName]
	public string b1AplPpQaT(string string_0)
	{
		return MQ6pDWPXmp().ContainsKey(string_0) ? MQ6pDWPXmp()[string_0] : null;
	}

	[SpecialName]
	public void urZpJh4QJe(string string_0, string string_1)
	{
		MQ6pDWPXmp()[string_0] = string_1;
	}

	public HihA9vUesVL2kYtA60(string string_0, Encoding encoding_0 = null)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		s3FpGFrgS1 = new Dictionary<string, string>();
		nhgpFNpwaX = new Dictionary<int, string>();
		base._002Ector();
		yklp21bHQc = Path.Combine(TdapeaT5S8, string_0);
		uUEpqGnV0N = encoding_0 ?? Encoding.Unicode;
		if (C8ZpH3hYtQ())
		{
			Load();
		}
		wi83hJQtnP(bool_0: false);
		aBfpybnOUv();
	}

	public void RgHp9Ba8Xy()
	{
		MQ6pDWPXmp().Clear();
		mjRp1gPUlG().Clear();
	}

	public abstract void wi83hJQtnP(bool bool_0);

	public void Load()
	{
		int num = 3;
		string value = default(string);
		string value2 = default(string);
		string[] array = default(string[]);
		int num3 = default(int);
		while (true)
		{
			IL_0119:
			RgHp9Ba8Xy();
			int num2 = 1;
			if (q53LhRDt4Gtc9TGoKlR())
			{
				goto IL_00b2;
			}
			goto IL_00fe;
			IL_00fe:
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 1:
					goto IL_006f;
				case 2:
					goto IL_00b2;
				default:
					MQ6pDWPXmp()[value] = value2;
					num2 = 1;
					if (pajpqYDFA4B5qDBSLYE() == null)
					{
						continue;
					}
					goto IL_006f;
				case 3:
					goto IL_0119;
				}
				break;
			}
			goto IL_000e;
			IL_00b2:
			if (File.Exists(UeGpcouvIq()))
			{
				array = File.ReadAllLines(UeGpcouvIq(), uUEpqGnV0N);
				num3 = 0;
				goto IL_003e;
			}
			throw new FileNotFoundException((string?)RriS3sDWwfVTedQWbCy("Unable to find \"", UeGpcouvIq(), "\"."));
			IL_003e:
			if (num3 < array.Length)
			{
				num = 4;
				goto IL_000e;
			}
			break;
			IL_006f:
			num3++;
			goto IL_003e;
			IL_000e:
			string text = array[num3];
			Match match;
			if (string.IsNullOrWhiteSpace(text) || !(match = Regex.Match(text, "^(?![^\\r\\n=]*#)([^\\r\\n]+?)=([^\\r\\n]*)$")).Success)
			{
				if (num3 < array.Length - 1)
				{
					mjRp1gPUlG()[num3] = text;
				}
				goto IL_006f;
			}
			value = match.Groups[1].Value;
			value2 = (string)TYvXPODJpHm23XwU17G(match.Groups[2]);
			num2 = 0;
			if (pajpqYDFA4B5qDBSLYE() != null)
			{
				num2 = num;
			}
			goto IL_00fe;
		}
	}

	public void aBfpybnOUv()
	{
		string text = "";
		int num = fSSm5tD47NRPNGf6J1b(MQ6pDWPXmp()) + mjRp1gPUlG().Count;
		KeyValuePair<string, string>[] array = NgZpfmYiJ0(MQ6pDWPXmp()).ToArray();
		int num2 = 0;
		if (pajpqYDFA4B5qDBSLYE() != null)
		{
			goto IL_0051;
		}
		goto IL_0055;
		IL_0055:
		int i = default(int);
		do
		{
			switch (num2)
			{
			case 1:
			{
				int num3 = 0;
				for (; i < num; i++)
				{
					text = text + (mjRp1gPUlG().ContainsKey(i) ? mjRp1gPUlG()[i] : (array[num3].Key + "=" + array[num3++].Value)) + "\r\n";
				}
				Q36iGwDQQaiCrXygeP4(UeGpcouvIq(), text, uUEpqGnV0N);
				return;
			}
			}
			i = 0;
			num2 = 1;
		}
		while (pajpqYDFA4B5qDBSLYE() == null);
		goto IL_0051;
		IL_0051:
		int num4 = default(int);
		num2 = num4;
		goto IL_0055;
	}

	public static IEnumerable<KeyValuePair<OgOWqIbxRtrvaTlAKI, QtDbMSzgKC83F87YW3>> NgZpfmYiJ0<OgOWqIbxRtrvaTlAKI, QtDbMSzgKC83F87YW3>(Dictionary<OgOWqIbxRtrvaTlAKI, QtDbMSzgKC83F87YW3> dictionary_0)
	{
		int num;
		using (Dictionary<OgOWqIbxRtrvaTlAKI, QtDbMSzgKC83F87YW3>.Enumerator enumerator = dictionary_0.GetEnumerator())
		{
			int num2 = default(int);
			while (true)
			{
				if (!enumerator.MoveNext())
				{
					num = 3;
					if (_003CIterateDictionary_003Ed__23<OgOWqIbxRtrvaTlAKI, QtDbMSzgKC83F87YW3>.ekqmgNs6SyZF14xnewU() != null)
					{
						break;
					}
					goto IL_009a;
				}
				yield return enumerator.Current;
				goto IL_0075;
				IL_0075:
				num = 1;
				if (_003CIterateDictionary_003Ed__23<OgOWqIbxRtrvaTlAKI, QtDbMSzgKC83F87YW3>.ekqmgNs6SyZF14xnewU() != null)
				{
					num = num2;
				}
				goto IL_009a;
				IL_009a:
				switch (num)
				{
				case 3:
					break;
				case 2:
					goto IL_0075;
				case 1:
					continue;
				default:
					yield break;
				case 0:
					yield break;
				case 4:
					yield break;
				}
				break;
			}
		}
		num = 0;
		if (_003CIterateDictionary_003Ed__23<OgOWqIbxRtrvaTlAKI, QtDbMSzgKC83F87YW3>.ekqmgNs6SyZF14xnewU() != null)
		{
			yield break;
		}
		goto IL_009a;
	}

	static HihA9vUesVL2kYtA60()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		TdapeaT5S8 = Path.GetFullPath(Assembly.GetExecutingAssembly().CodeBase!.Replace("file:///", "").Replace('/', '\\') + "\\..");
	}

	internal static bool q53LhRDt4Gtc9TGoKlR()
	{
		return VZigrLDbQZqTWxadNm5 == null;
	}

	internal static HihA9vUesVL2kYtA60 pajpqYDFA4B5qDBSLYE()
	{
		return VZigrLDbQZqTWxadNm5;
	}

	internal static object RriS3sDWwfVTedQWbCy(object object_0, object object_1, object object_2)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2;
	}

	internal static object TYvXPODJpHm23XwU17G(object object_0)
	{
		return ((Capture)object_0).Value;
	}

	internal static int fSSm5tD47NRPNGf6J1b(object object_0)
	{
		return ((Dictionary<string, string>)object_0).Count;
	}

	internal static void Q36iGwDQQaiCrXygeP4(object object_0, object object_1, object object_2)
	{
		File.WriteAllText((string)object_0, (string?)object_1, (Encoding)object_2);
	}
}
