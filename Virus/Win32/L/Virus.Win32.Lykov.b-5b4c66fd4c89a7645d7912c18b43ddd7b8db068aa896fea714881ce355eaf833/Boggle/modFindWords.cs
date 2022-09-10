using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Boggle;

[StandardModule]
internal sealed class modFindWords
{
	public enum FindMode
	{
		AllWords,
		SpecWord
	}

	public static DataTable FindWords(FindMode Mode, string Word = "")
	{
		object[] array = new object[2];
		DataTable dataTable = new DataTable();
		string text = "((((";
		checked
		{
			string text3 = default(string);
			string text4 = default(string);
			string text5 = default(string);
			string text6 = default(string);
			string text7 = default(string);
			string text8 = default(string);
			string text9 = default(string);
			if (Mode == FindMode.SpecWord)
			{
				if (Strings.Len(Word) > 15)
				{
					array[0] = "Not Found";
					array[1] = "1111";
					dataTable.Rows.Add(array);
					return dataTable;
				}
				Word = Strings.UCase(Word);
				int num = Strings.Len(Strings.Replace(Word, "QU", "Q", 1, -1, (CompareMethod)0));
				for (int i = 1; i <= num; i++)
				{
					string text2 = Strings.Mid(Word, i, 1);
					if (StringType.StrCmp(text3, "", false) == 0)
					{
						if (StringType.StrCmp(text2, "Q", false) == 0)
						{
							Word = Strings.Replace(Word, "QU", "Q", 1, -1, (CompareMethod)0);
							text3 = text3 + "Where PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetter = 'QU' \r\n";
						}
						else
						{
							text3 = string.Concat(text3, "Where PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetter = '" + text2, "' \r\n");
						}
					}
					else if (StringType.StrCmp(text2, "Q", false) == 0)
					{
						Word = Strings.Replace(Word, "QU", "Q", 1, -1, (CompareMethod)0);
						text3 = text3 + "And PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetter = 'QU' \r\n";
					}
					else
					{
						text3 = string.Concat(text3, "And PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetter = '" + text2, "' \r\n");
					}
					if (i <= 5)
					{
						continue;
					}
					text += "(";
					if (StringType.StrCmp(text4, "", false) == 0)
					{
						text4 += ") ";
					}
					if (StringType.StrCmp(text5, "", false) == 0)
					{
						text5 += "+ ";
					}
					if (StringType.StrCmp(text6, "", false) == 0)
					{
						text6 += ",";
					}
					if (StringType.StrCmp(text7, "", false) == 0)
					{
						if (Strings.Len(Word) == i)
						{
							text8 = text8 + " & ',' & [BL" + StringType.FromInteger(i) + "] ";
							text9 = text9 + ", PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetterSquare ";
							text7 = text7 + ", PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetterSquare AS BL" + StringType.FromInteger(i) + " ";
						}
						else
						{
							text8 = text8 + " & ',' & [BL" + StringType.FromInteger(i) + "] " + "&" + " ";
							text9 = text9 + ", PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetterSquare , ";
							text7 = text7 + ", PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetterSquare AS BL" + StringType.FromInteger(i) + ", ";
						}
					}
					else if (i == Strings.Len(Word))
					{
						text8 = text8 + "',' & [BL" + StringType.FromInteger(i) + "]";
						text9 = text9 + " PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetterSquare  ";
						text7 = text7 + " PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetterSquare AS BL" + StringType.FromInteger(i) + " ";
					}
					else
					{
						text8 = text8 + "',' & [BL" + StringType.FromInteger(i) + "] " + "&" + " ";
						text9 = text9 + " PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetterSquare , ";
						text7 = text7 + " PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetterSquare AS BL" + StringType.FromInteger(i) + ", ";
					}
					if (i == Strings.Len(Word))
					{
						text6 = text6 + "BL" + StringType.FromInteger(i);
						text5 = text5 + "PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetter";
						text4 = string.Concat(text4, string.Concat("INNER JOIN      PossibleLetters AS PossibleLetters_" + StringType.FromInteger(i) + " ON              (PossibleLetters_" + StringType.FromInteger(i - 1) + ".FriendLetter=PossibleLetters_" + StringType.FromInteger(i), ".BaseLetter) AND             (PossibleLetters_", StringType.FromInteger(i - 1), ".FriendLetterSquare=PossibleLetters_", StringType.FromInteger(i)), ".BaseLetterSquare) \r\n");
					}
					else
					{
						text6 = text6 + "BL" + StringType.FromInteger(i) + ",";
						text5 = text5 + "PossibleLetters_" + StringType.FromInteger(i) + ".BaseLetter + ";
						text4 = string.Concat(text4, string.Concat("INNER JOIN      PossibleLetters AS PossibleLetters_" + StringType.FromInteger(i) + " ON              (PossibleLetters_" + StringType.FromInteger(i - 1) + ".FriendLetter=PossibleLetters_" + StringType.FromInteger(i), ".BaseLetter) AND             (PossibleLetters_", StringType.FromInteger(i - 1), ".FriendLetterSquare=PossibleLetters_", StringType.FromInteger(i)), ".BaseLetterSquare)) \r\n");
					}
				}
			}
			dataTable.Columns.Add("FoundWord");
			dataTable.Columns.Add("FoundWordSquares");
			modGlobal.cmdBog.set_CommandText("Delete From Words_5Letters1");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("Delete From Words_5Letters2");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("Delete From Words_4Letters");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("Delete From Words_3Letters");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("Delete From FoundWords");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText(string.Concat(string.Concat(string.Concat(string.Concat("Insert Into     Words_5Letters1 (Word,Bl1,Bl2,Bl3,Bl4,Bl5" + text6 + ") SELECT          PossibleLetters_1.BaseLetter +                 PossibleLetters_2.BaseLetter +                 PossibleLetters_3.BaseLetter +                 PossibleLetters_4.BaseLetter +                 PossibleLetters_5.BaseLetter " + text5, " AS Word,                 PossibleLetters_1.BaseLetterSquare AS BL1,                 PossibleLetters_2.BaseLetterSquare AS BL2,                 PossibleLetters_3.BaseLetterSquare AS BL3,                 PossibleLetters_4.BaseLetterSquare AS BL4,                 PossibleLetters_5.BaseLetterSquare AS BL5 ", text7, "FROM            ", text), "PossibleLetters INNER JOIN      PossibleLetters AS              PossibleLetters_1 ON              (PossibleLetters.FriendLetter=PossibleLetters_1.BaseLetter) AND             (PossibleLetters.FriendLetterSquare=PossibleLetters_1.BaseLetterSquare)) INNER JOIN      PossibleLetters AS PossibleLetters_2 ON              (PossibleLetters_1.FriendLetter=PossibleLetters_2.BaseLetter) AND             (PossibleLetters_1.FriendLetterSquare=PossibleLetters_2.BaseLetterSquare)) INNER JOIN      PossibleLetters AS PossibleLetters_3 ON              (PossibleLetters_2.FriendLetter=PossibleLetters_3.BaseLetter) AND             (PossibleLetters_2.FriendLetterSquare=PossibleLetters_3.BaseLetterSquare)) INNER JOIN      PossibleLetters AS PossibleLetters_4 ON              (PossibleLetters_3.FriendLetter=PossibleLetters_4.BaseLetter) AND             (PossibleLetters_3.FriendLetterSquare=PossibleLetters_4.BaseLetterSquare)) INNER JOIN      PossibleLetters AS PossibleLetters_5 ON              (PossibleLetters_4.FriendLetter=PossibleLetters_5.BaseLetter) AND             (PossibleLetters_4.FriendLetterSquare=PossibleLetters_5.BaseLetterSquare) ", text4, text3), "GROUP BY        PossibleLetters_1.BaseLetter +                 PossibleLetters_2.BaseLetter +                 PossibleLetters_3.BaseLetter +                 PossibleLetters_4.BaseLetter +                 PossibleLetters_5.BaseLetter ", text5), ",                 PossibleLetters_1.BaseLetterSquare,                 PossibleLetters_2.BaseLetterSquare,                 PossibleLetters_3.BaseLetterSquare,                 PossibleLetters_4.BaseLetterSquare,                 PossibleLetters_5.BaseLetterSquare", text9));
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Insert Into     Words_5Letters2 (Word,WordSquares) SELECT          Words_5Letters1.[Word],                 [BL1] & ',' & [BL2] & ',' & [BL3] &                 ',' & [BL4] & ',' & [BL5]" + text8 + " AS WordSquares FROM            (Words_5Letters1) WHERE           (((Words_5Letters1.BL1) Not In ([bl2],[bl3],[bl4],[bl5]" + text6, ")) AND             ((Words_5Letters1.BL2) Not In ([bl1],[bl3],[bl4],[bl5]", text6), ")) AND             ((Words_5Letters1.BL3) Not In ([bl1],[bl2],[bl4],[bl5]", text6), ")) AND             ((Words_5Letters1.BL4) Not In ([bl1],[bl2],[bl3],[bl5]", text6), ")) AND             ((Words_5Letters1.BL5) Not In ([bl1],[bl2],[bl3],[bl4]", text6), ")) AND             ((Words_5Letters1.BL6) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL6", "", 1, -1, (CompareMethod)0)), ")Or BL6 Is Null) AND             ((Words_5Letters1.BL7) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL7", "", 1, -1, (CompareMethod)0)), ")Or BL7 Is Null) AND             ((Words_5Letters1.BL8) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL8", "", 1, -1, (CompareMethod)0)), ")Or BL8 Is Null) AND             ((Words_5Letters1.BL9) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL9", "", 1, -1, (CompareMethod)0)), ")Or BL9 Is Null) AND             ((Words_5Letters1.BL10) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL10", "", 1, -1, (CompareMethod)0)), ")Or BL10 Is Null) AND             ((Words_5Letters1.BL11) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL11", "", 1, -1, (CompareMethod)0)), ")Or BL11 Is Null) AND             ((Words_5Letters1.BL12) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL12", "", 1, -1, (CompareMethod)0)), ")Or BL12 Is Null) AND             ((Words_5Letters1.BL13) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL13", "", 1, -1, (CompareMethod)0)), ")Or BL13 Is Null) AND             ((Words_5Letters1.BL14) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL14", "", 1, -1, (CompareMethod)0)), ")Or BL14 Is Null) AND             ((Words_5Letters1.BL15) Not In ([bl1],[bl2],[bl3],[bl4],[bl5]", Strings.Replace(text6, ",BL15", "", 1, -1, (CompareMethod)0), ")Or BL15 Is Null)) "));
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			OleDbDataReader val;
			if (Mode == FindMode.SpecWord)
			{
				if (Strings.InStr(Word, "Q", (CompareMethod)0) != 0)
				{
					Word = Strings.Replace(Word, "Q", "QU", 1, -1, (CompareMethod)0);
				}
				modGlobal.cmdBog.set_CommandText("Select         * From           Words_5Letters2 Where          Instr(Ucase(Word),'" + Word + "') <> 0");
				modGlobal.conBoggle.Open();
				val = modGlobal.cmdBog.ExecuteReader();
				while (val.Read())
				{
					if (StringType.StrCmp(Strings.UCase(Strings.Mid(StringType.FromObject(val.get_Item("Word")), 1, Strings.Len(Word))), Word, false) == 0)
					{
						array[0] = Strings.Mid(StringType.FromObject(val.get_Item("Word")), 1, Strings.Len(Word));
						array[1] = RuntimeHelpers.GetObjectValue(val.get_Item("WordSquares"));
					}
				}
				if (ObjectType.ObjTst(array[0], (object)"", false) == 0)
				{
					array[0] = "Not Found";
					array[1] = "11111";
				}
				dataTable.Rows.Add(array);
				val.Close();
				modGlobal.conBoggle.Close();
				return dataTable;
			}
			modGlobal.cmdBog.set_CommandText("Insert Into     Words_4Letters (Word4,WordSquares) SELECT          Left([Word],4) AS Word,                 WordSquares FROM            (Words_5Letters2) GROUP BY        Left([Word],4),WordSquares");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("Insert Into      Words_3Letters (Word3,WordSquares) SELECT          Left([Word],3) AS Word,                 WordSquares FROM            (Words_5Letters2) GROUP BY        Left([Word],3),WordSquares");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("INSERT INTO        FoundWords ( FoundWord, FoundWordSquares ) SELECT             BoggleWords.Word,                    Max(Words_3Letters.WordSquares) AS MaxOfWordSquares FROM               BoggleWords INNER JOIN         Words_3Letters ON                 BoggleWords.Word = Words_3Letters.Word3 GROUP BY           BoggleWords.Word");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("INSERT INTO        FoundWords ( FoundWord, FoundWordSquares ) SELECT             BoggleWords.Word,                    Max(Words_4Letters.WordSquares) AS MaxOfWordSquares FROM               BoggleWords INNER JOIN         Words_4Letters ON                 BoggleWords.Word = Words_4Letters.Word4 GROUP BY           BoggleWords.Word");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("INSERT INTO        FoundWords ( FoundWord, FoundWordSquares ) SELECT             BoggleWords.Word,                    Max(Words_5Letters2.WordSquares) AS MaxOfWordSquares FROM               BoggleWords INNER JOIN         Words_5Letters2 ON                 BoggleWords.Word = Words_5Letters2.Word GROUP BY           BoggleWords.Word");
			modGlobal.conBoggle.Open();
			modGlobal.cmdBog.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			modGlobal.cmdBog.set_CommandText("Select * From FoundWords Order By FoundWord");
			modGlobal.conBoggle.Open();
			val = modGlobal.cmdBog.ExecuteReader();
			while (val.Read())
			{
				array[0] = RuntimeHelpers.GetObjectValue(val.get_Item("FoundWord"));
				array[1] = RuntimeHelpers.GetObjectValue(val.get_Item("FoundWordSquares"));
				dataTable.Rows.Add(array);
			}
			val.Close();
			modGlobal.conBoggle.Close();
			return dataTable;
		}
	}

	public static string GetDef(string Word)
	{
		checked
		{
			string result = default(string);
			try
			{
				string requestUriString = "http://dictionary.reference.com/search?q=" + Word;
				WebRequest webRequest = WebRequest.Create(requestUriString);
				WebResponse response = webRequest.GetResponse();
				StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
				string text = streamReader.ReadToEnd();
				response.Close();
				streamReader.Close();
				long num = 1L;
				string text2 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ/\\-()?.,[]%! \r\n\t\r";
				string text4 = default(string);
				for (text = Strings.Mid(text, Strings.InStr(Strings.UCase(text), "<P><B>" + Strings.UCase(Word) + "</B></P>", (CompareMethod)0)); num != Strings.Len(text); num++)
				{
					string text3 = Strings.Mid(text, (int)num, 1);
					if (StringType.StrCmp(text3, "<", false) == 0)
					{
						while (StringType.StrCmp(text3, ">", false) != 0)
						{
							text4 += text3;
							num++;
							text3 = Strings.Mid(text, (int)num, 1);
						}
						text = Strings.Replace(text, text4 + ">", "", 1, -1, (CompareMethod)0);
						num = 0L;
						text4 = "";
					}
					if ((Strings.InStr(text2, Strings.UCase(text3), (CompareMethod)0) == 0) & (Strings.InStr("<>", text3, (CompareMethod)0) == 0))
					{
						text = Strings.Replace(text, text3, "", 1, -1, (CompareMethod)0);
						num = 0L;
					}
				}
				num = 1L;
				do
				{
					text = Strings.Replace(text, StringType.FromLong(num) + ". ", "\r\n" + StringType.FromLong(num) + ". ", 1, -1, (CompareMethod)0);
					text = Strings.Replace(text, StringType.FromLong(num) + ". \r\n", "", 1, -1, (CompareMethod)0);
					text = Strings.Replace(text, " " + StringType.FromLong(num) + " ", "\r\n" + StringType.FromLong(num) + ". ", 1, -1, (CompareMethod)0);
					num++;
				}
				while (num <= 500L);
				text = Strings.Mid(text, 1, Strings.InStr(Strings.UCase(text), "ADVERTISEMENT", (CompareMethod)0) - 1);
				result = text;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				int number = Information.Err().get_Number();
				if (number == 5)
				{
					result = "Boggle could not query this defenition from the internet. Make sure you are online and check your internet connection. To disable this option, uncheck \"Enable Defenition Search\" under the \"Options\" menu.";
					ProjectData.ClearProjectError();
					return result;
				}
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string ValidateWords(string Words)
	{
		Words += ",";
		checked
		{
			string text2 = default(string);
			while (StringType.StrCmp(Words, "", false) != 0)
			{
				string text = Strings.Mid(Words, 1, Strings.InStr(Words, ",", (CompareMethod)0) - 1);
				Words = Strings.Mid(Words, Strings.InStr(Words, ",", (CompareMethod)0) + 1);
				DataTable dataTable = FindWords(FindMode.SpecWord, text);
				if (ObjectType.ObjTst(dataTable.Rows[0][0], (object)"Not Found", false) == 0)
				{
					text2 = text2 + text + ",";
				}
			}
			return text2;
		}
	}
}
