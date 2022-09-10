using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Autodesk.ExpressTools.AliasEdit.Autodesk.ExpressTools.AliasEdit;

[StandardModule]
internal sealed class Main
{
	public static short nEdit;

	public static string sFileInMemory;

	public static string sFname;

	public static string sACADPGP;

	public static string sBackup;

	public static string sShells;

	public static string sAliases;

	public static string sAccels;

	public static string[] sAlias;

	public static string[] sUserDefAlias;

	public static string[] sRep;

	public static string[] sUserDefRep;

	public static string[] sShell;

	public static string[] sUserDefShell;

	public static string[] sCommand;

	public static string[] sUserDefCommand;

	public static string[] sFlag;

	public static string[] sUserDefFlag;

	public static string[] sPrompt;

	public static string[] sUserDefPrompt;

	public static string[] sCode;

	public static string[] sAccel;

	public static string[] sMenuRep;

	public static string[] sTagSeq;

	public static string[] sDescr;

	public static short nTotalShell;

	public static short nTotalAlias;

	public static short nTotalAccel;

	public static short nUserDefTotalShell;

	public static short nUserDefTotalAlias;

	public static short nStdRep;

	public static string sEditPrompt;

	public static string sEditAlias;

	public static string sEditRep;

	public static string sEditFlag;

	public static short nChange;

	public static short bEditCancel;

	public static string sSysAliases = "";

	private static ResourceManager resManager;

	public const string END_OF_LINE = "\r\n";

	public const string KEY_STRING = "key";

	public const string NO_ALIAS_STRING = "---";

	public const short ALIAS_TAB = 0;

	public const short SHELL_TAB = 1;

	public const short ACCEL_TAB = 2;

	public const string DEFAULT_PGP = "acad.pgp";

	public const string DEFAULT_MNU = "acad.mnu";

	[AccessedThroughProperty("pd")]
	private static PrintDocument _pd;

	public static short Index = 0;

	public static int y;

	public static int nPage;

	public static int linesPerPage;

	public static int count;

	public static int numCopiesPrinted;

	public static short nCopies;

	public static string sPrintLine;

	public static string[] sHeader1 = new string[2];

	public static string[] sHeader2 = new string[2];

	public static string[] sTitle = new string[2];

	public static string sSeparator;

	public static string sTextString;

	public const short NUM_SPACE = 30;

	public static Font printFont = new Font("Courier", 10f, (FontStyle)0);

	public static float yPos = 0f;

	[SpecialName]
	private static short _0024STATIC_0024BogusString_002401E10E_0024Length;

	public static PrintDocument pd
	{
		get
		{
			return _pd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pd = value;
		}
	} = new PrintDocument();


	public static void FindSectionBounds(string vsSect, ref string[] rsMNUFile, ref short rnBeginVar, ref short rnEndVar, short vnEnd)
	{
		rnBeginVar = -1;
		short num = vnEnd;
		short num2 = 1;
		checked
		{
			while (num2 <= num)
			{
				if (Operators.CompareString(rsMNUFile[num2], vsSect, false) != 0)
				{
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				rnBeginVar = num2;
				break;
			}
			rnEndVar = vnEnd;
			short num3 = (short)(rnBeginVar + 1);
			short num4 = vnEnd;
			num2 = num3;
			while (true)
			{
				if (num2 <= num4)
				{
					if (Operators.CompareString(Strings.Left(rsMNUFile[num2], 3), "***", false) == 0)
					{
						break;
					}
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				return;
			}
			rnEndVar = (short)(num2 - 1);
		}
	}

	public static void ParseMNU(ref object FileName)
	{
		((Control)frmAlias.DefInstance).Refresh();
		short num = checked((short)FileSystem.FreeFile());
		FileSystem.FileOpen((int)num, Conversions.ToString(FileName), (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
		short num2 = 0;
		string[] array = (string[])Utils.CopyArray((Array)array, (Array)new string[checked((int)Math.Round((double)FileSystem.FileLen(Conversions.ToString(FileName)) / 10.0) + 1)]);
		Cursor.set_Current(Cursors.get_WaitCursor());
		while (!FileSystem.EOF((int)num))
		{
			num2 = checked((short)(num2 + 1));
			array[num2] = FileSystem.LineInput((int)num);
		}
		short num3 = num2;
		checked
		{
			array = (string[])Utils.CopyArray((Array)array, (Array)new string[num2 + 1]);
			short rnBeginVar = default(short);
			short rnEndVar = default(short);
			FindSectionBounds("***ACCELERATORS", ref array, ref rnBeginVar, ref rnEndVar, num3);
			sAccel = (string[])Utils.CopyArray((Array)sAccel, (Array)new string[(short)unchecked(rnEndVar - rnBeginVar) + 1]);
			sMenuRep = (string[])Utils.CopyArray((Array)sMenuRep, (Array)new string[(short)unchecked(rnEndVar - rnBeginVar) + 1]);
			if (rnBeginVar == -1)
			{
				nTotalAccel = 0;
				return;
			}
			short rnBeginVar2 = default(short);
			short rnEndVar2 = default(short);
			FindSectionBounds("***HELPSTRINGS", ref array, ref rnBeginVar2, ref rnEndVar2, num3);
			short num4 = (short)unchecked(rnEndVar - rnBeginVar);
			short num5;
			for (num5 = 1; num5 <= num4; num5 = (short)unchecked(num5 + 1))
			{
				short num6 = (short)unchecked(rnBeginVar + num5);
				string text = Strings.LTrim(array[num6]);
				if (IsAlphaNumeric(text))
				{
					sMenuRep[num5] = Strings.Left(text, Strings.InStr(text, " ", (CompareMethod)0));
					sAccel[num5] = Strings.Right(text, Strings.Len(text) - (Strings.InStr(text, "[", (CompareMethod)0) - 1));
				}
				else if (Operators.CompareString(Strings.Left(text, 1), "[", false) == 0)
				{
					sAccel[num5] = Strings.Left(text, Strings.InStr(text, "]", (CompareMethod)0));
					sMenuRep[num5] = Strings.Right(text, Strings.Len(text) - Strings.InStr(text, "]", (CompareMethod)0));
				}
			}
			string text2 = "";
			short num7 = 0;
			num5 = 1;
			short num8 = num3;
			for (num5 = 1; num5 <= num8; num5 = (short)unchecked(num5 + 1))
			{
				if (Operators.CompareString(Strings.Left(array[num5], 3), "***", false) == 0)
				{
					text2 = Strings.Right(array[num5], Strings.Len(array[num5]) - 3);
				}
				if (Operators.CompareString(Strings.Left(text2, 3), "POP", false) == 0 && IsAlphaNumeric(array[num5]))
				{
					num7 = (short)(num7 + 1);
					sTagSeq = (string[])Utils.CopyArray((Array)sTagSeq, (Array)new string[num7 + 1]);
					sTagSeq[num7] = Strings.Left(array[num5], Strings.InStr(array[num5], " ", (CompareMethod)0));
					if (num7 == 233)
					{
					}
					if (Operators.CompareString(Strings.Trim(sTagSeq[num7]), "ID_Cal", false) != 0)
					{
					}
				}
			}
			short num9 = rnEndVar2;
			sDescr = (string[])Utils.CopyArray((Array)sDescr, (Array)new string[num7 + 1]);
			short num10 = num7;
			for (num5 = 1; num5 <= num10; num5 = (short)unchecked(num5 + 1))
			{
				short num11 = (short)(rnBeginVar2 + 1);
				if (Operators.CompareString(sTagSeq[num5], "ID_Cal", false) == 0)
				{
				}
				while (num11 <= num9)
				{
					if (Operators.CompareString(Strings.Left(array[num11], Strings.Len(sTagSeq[num5])), sTagSeq[num5], false) == 0)
					{
						sDescr[num5] = Strings.Right(array[num11], Strings.Len(array[num11]) - Strings.InStr(array[num11], "[", (CompareMethod)0) + 1);
						if (num11 < num9)
						{
							array[num11] = array[num9];
							num9 = (short)(num9 - 1);
						}
					}
					num11 = (short)(num11 + 1);
				}
			}
			short num12 = (short)Information.UBound((Array)sAccel, 1);
			for (num5 = 1; num5 <= num12; num5 = (short)unchecked(num5 + 1))
			{
				sMenuRep[num5] = FindAndReplace(sMenuRep[num5], "^C^C", "Ctrl +C, Ctrl +C");
				sMenuRep[num5] = FindAndReplace(sMenuRep[num5], "^", "Ctrl +");
				sAccel[num5] = FindAndReplace(sAccel[num5], "[", "");
				sAccel[num5] = FindAndReplace(sAccel[num5], "]", "");
				sAccel[num5] = FindAndReplace(sAccel[num5], "\"", "");
				sAccel[num5] = FindAndReplace(sAccel[num5], "\"", "");
				sAccel[num5] = FindAndReplace(sAccel[num5], "CONTROL", "Ctrl +");
				sAccel[num5] = FindAndReplace(sAccel[num5], "+", "");
				sAccel[num5] = FindAndReplace(sAccel[num5], "SHIFT", "Shft +");
			}
			Cursor.set_Current(Cursors.get_Default());
			nTotalAccel = (short)Information.UBound((Array)sAccel, 1);
		}
	}

	public static string FindAndReplace(string vsText, string vsFind, string vsRepl)
	{
		checked
		{
			while (true)
			{
				short num = (short)Strings.InStr(vsText, vsFind, (CompareMethod)0);
				if (num == 0)
				{
					break;
				}
				vsText = Strings.Left(vsText, num - 1) + vsRepl + Strings.Mid(vsText, num + Strings.Len(vsFind));
			}
			return vsText;
		}
	}

	public static void CheckForDuplicates(ref object WhichTab, ref bool Import)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num5 = default(short);
		ListView val = default(ListView);
		ListViewItemCollection items = default(ListViewItemCollection);
		short num6 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				ListViewItemCollection val2;
				short num7;
				ListViewItem oAliasToRemove;
				int Index;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 682:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						case 2:
							goto IL_0282;
						default:
							goto end_IL_0000;
						}
						goto IL_01ee;
					}
					IL_01ee:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0028;
					case 4:
						goto IL_0034;
					case 5:
						goto IL_0039;
					case 6:
						goto IL_0043;
					case 9:
						goto IL_004d;
					case 10:
						goto IL_009d;
					case 11:
						goto IL_00dc;
					case 13:
						goto IL_011c;
					case 14:
						goto IL_0120;
					case 15:
						goto IL_012c;
					case 12:
					case 16:
					case 17:
					case 18:
						goto IL_0135;
					case 7:
					case 8:
					case 19:
						goto IL_013e;
					case 20:
						goto IL_0150;
					case 21:
						goto IL_0160;
					default:
						goto end_IL_0000;
					case 26:
					case 27:
						goto IL_0270;
					case 24:
						goto IL_0282;
					case 0:
						goto end_IL_0000;
					case 22:
					case 23:
					case 25:
					case 28:
						goto end_IL_0000_2;
					}
					goto default;
					IL_0282:
					num = 24;
					if (Information.Err().get_Number() > 35599)
					{
						goto end_IL_0000_2;
					}
					goto IL_0270;
					IL_0270:
					num = 27;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_01ee;
					IL_0135:
					num = 18;
					num5 = checked((short)(num5 + 1));
					goto IL_013e;
					IL_0008:
					num = 2;
					val = (ListView)frmAlias.DefInstance.lvwAlias[Conversions.ToInteger(WhichTab)];
					goto IL_0028;
					IL_0028:
					num = 3;
					items = val.get_Items();
					goto IL_0034;
					IL_0034:
					num = 4;
					num5 = 0;
					goto IL_0039;
					IL_0039:
					num = 5;
					val.Sort();
					goto IL_0043;
					IL_0043:
					num = 6;
					num6 = 0;
					goto IL_013e;
					IL_013e:
					num = 8;
					if (num5 < checked(items.get_Count() - 2))
					{
						goto IL_004d;
					}
					goto IL_0150;
					IL_0150:
					num = 20;
					if (!(Import && num6 > 0))
					{
						goto end_IL_0000_2;
					}
					goto IL_0160;
					IL_0160:
					num = 21;
					Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_IMPORTDUP") + "\r\n\r\n" + frmAlias.DefInstance.resManager.GetString("STR_DUPREP") + "---" + frmAlias.DefInstance.resManager.GetString("STR_.")), (MsgBoxStyle)64, (object)frmAlias.DefInstance.resManager.GetString("STR_DUPTITLE"));
					goto end_IL_0000_2;
					IL_004d:
					num = 9;
					if ((Operators.CompareString(items.get_Item((int)num5).get_Text(), items.get_Item(checked(num5 + 1)).get_Text(), false) == 0) & ((Operators.CompareString(items.get_Item((int)num5).get_Text(), "---", false) != 0) | Import))
					{
						goto IL_009d;
					}
					goto IL_0135;
					IL_009d:
					num = 10;
					if (Operators.CompareString(items.get_Item((int)num5).get_SubItems().get_Item(1)
						.get_Text(), items.get_Item(checked(num5 + 1)).get_SubItems().get_Item(1)
						.get_Text(), false) == 0)
					{
						goto IL_00dc;
					}
					goto IL_011c;
					IL_00dc:
					num = 11;
					val2 = items;
					num7 = num5;
					oAliasToRemove = val2.get_Item((int)num7);
					Index = Conversions.ToInteger(WhichTab);
					RemoveAlias(ref oAliasToRemove, ref Index, removeFromFile: false, removeFromLV: true);
					WhichTab = Index;
					val2.set_Item((int)num7, oAliasToRemove);
					goto IL_0135;
					IL_011c:
					num = 13;
					goto IL_0120;
					IL_0120:
					num = 14;
					items.RemoveAt((int)num5);
					goto IL_012c;
					IL_012c:
					num = 15;
					num6 = checked((short)(num6 + 1));
					goto IL_0135;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 682;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static short CurrentTab()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		short num3;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					num3 = checked((short)frmAlias.DefInstance.tbsMain.get_SelectedIndex());
					goto end_IL_0000;
				case 30:
					num = -1;
					switch (num2)
					{
					case 2:
						num3 = 0;
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0054;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 30;
				continue;
			}
			break;
			IL_0054:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		short result = num3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void AppendAlias()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		short num = CurrentTab();
		ListViewItemCollection val = (ListViewItemCollection)NewLateBinding.LateGet(frmAlias.DefInstance.lvwAlias[num], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
		switch (num)
		{
		case 0:
		{
			frmNewAlias defInstance2 = frmNewAlias.DefInstance;
			text2 = defInstance2.txtAlias.get_Text();
			text3 = defInstance2.cmbRep.get_Text();
			text = "";
			defInstance2 = null;
			if ((Operators.CompareString(text2, "", false) == 0) | (Operators.CompareString(text3, "", false) == 0))
			{
				nEdit = 0;
				return;
			}
			break;
		}
		case 1:
		{
			frmNewShell defInstance = frmNewShell.DefInstance;
			text2 = defInstance.txtAlias.get_Text();
			text3 = defInstance.txtCommand.get_Text();
			text4 = defInstance.comboFlag.get_Text();
			text = defInstance.txtPrompt.get_Text();
			defInstance = null;
			if (Operators.CompareString(text2, "", false) == 0)
			{
				nEdit = 0;
				return;
			}
			break;
		}
		}
		checked
		{
			_ = (short)val.get_Count();
			ListViewItem val2 = new ListViewItem(Strings.Trim(Strings.UCase(text2)));
			val2.get_SubItems().Add(Strings.Trim(text3));
			nChange = 1;
			if (num == 1)
			{
				val2.get_SubItems().Add(text4);
				val2.get_SubItems().Add(text);
			}
			val.Add(val2);
			switch (num)
			{
			case 0:
				nUserDefTotalAlias++;
				sUserDefAlias = (string[])Utils.CopyArray((Array)sUserDefAlias, (Array)new string[nUserDefTotalAlias + 1]);
				sUserDefRep = (string[])Utils.CopyArray((Array)sUserDefRep, (Array)new string[nUserDefTotalAlias + 1]);
				sUserDefAlias[nUserDefTotalAlias] = Strings.Trim(Strings.UCase(text2));
				sUserDefRep[nUserDefTotalAlias] = Strings.Trim(text3);
				break;
			case 1:
				nUserDefTotalShell++;
				sUserDefShell = (string[])Utils.CopyArray((Array)sUserDefShell, (Array)new string[nUserDefTotalShell + 1]);
				sUserDefCommand = (string[])Utils.CopyArray((Array)sUserDefCommand, (Array)new string[nUserDefTotalShell + 1]);
				sUserDefFlag = (string[])Utils.CopyArray((Array)sUserDefFlag, (Array)new string[nUserDefTotalShell + 1]);
				sUserDefPrompt = (string[])Utils.CopyArray((Array)sUserDefPrompt, (Array)new string[nUserDefTotalShell + 1]);
				sUserDefShell[nUserDefTotalShell] = Strings.Trim(Strings.UCase(text2));
				sUserDefCommand[nUserDefTotalShell] = Strings.Trim(text3);
				sUserDefFlag[nUserDefTotalShell] = text4;
				sUserDefPrompt[nUserDefTotalShell] = text;
				break;
			}
			val2.EnsureVisible();
			SelectAListItem((short)val.IndexOf(val2), num);
			NewLateBinding.LateSetComplex(frmAlias.DefInstance.cmdRemove[num], (Type)null, "Enabled", new object[1] { true }, (string[])null, (Type[])null, false, true);
			ChkApply();
		}
	}

	public static string GetSaveFile(ref string Filter_Renamed, ref string StartFileName)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between Unknown and I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num6 = default(short);
		string text = default(string);
		DialogResult val2 = default(DialogResult);
		SaveFileDialog val3 = default(SaveFileDialog);
		short num7 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				ErrObject val;
				int errVal;
				short num5;
				string F;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 981:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						case 2:
							goto IL_039e;
						default:
							goto end_IL_0000;
						}
						goto IL_02bd;
					}
					IL_02bd:
					num4 = num2 + 1;
					goto IL_0170;
					IL_0170:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0017;
					case 4:
						goto IL_0023;
					case 5:
						goto IL_002e;
					case 6:
						goto IL_003a;
					case 7:
						goto IL_003d;
					case 8:
						goto IL_0046;
					case 9:
						goto IL_0066;
					case 10:
						goto IL_006c;
					case 11:
						goto IL_0084;
					case 12:
					case 13:
						goto IL_00f3;
					case 15:
					case 16:
						goto IL_0100;
					case 17:
						goto IL_0108;
					case 20:
						goto IL_0116;
					case 21:
						goto IL_011a;
					case 22:
						goto IL_012e;
					case 23:
						goto IL_0136;
					case 18:
					case 19:
					case 25:
					case 26:
					case 27:
						goto IL_0145;
					case 40:
					case 41:
						goto IL_015e;
					default:
						goto end_IL_0000;
					case 44:
					case 45:
						goto IL_0265;
					case 46:
						goto IL_02ad;
					case 36:
					case 38:
						goto IL_02c6;
					case 52:
					case 53:
						goto IL_02d4;
					case 35:
					case 39:
					case 42:
					case 43:
					case 47:
					case 48:
					case 51:
					case 54:
					case 55:
					case 56:
						goto IL_02f9;
					case 49:
					case 50:
						goto IL_030b;
					case 34:
						goto IL_0341;
					case 32:
					case 33:
						goto IL_0360;
					case 30:
						goto IL_0387;
					case 29:
						goto IL_039e;
					case 0:
					case 37:
						goto end_IL_0000;
					case 14:
					case 24:
					case 28:
					case 31:
					case 57:
						goto end_IL_0000_2;
					}
					goto default;
					IL_039e:
					num = 29;
					Cursor.set_Current(Cursors.get_Default());
					goto IL_0387;
					IL_0387:
					num = 30;
					if (Information.Err().get_Number() == 32755)
					{
						goto end_IL_0000_2;
					}
					goto IL_0360;
					IL_0360:
					num = 33;
					val = Information.Err();
					errVal = val.get_Number();
					num5 = ErrorHandler.FileErrors(ref errVal);
					val.set_Number(errVal);
					num6 = num5;
					goto IL_0341;
					IL_0341:
					num = 34;
					switch (num6)
					{
					case 1:
						break;
					case 2:
						goto IL_0265;
					case 0:
						goto IL_02c6;
					default:
						goto IL_02d4;
					case 3:
						goto IL_030b;
					}
					goto IL_015e;
					IL_030b:
					num = 50;
					Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_UNRECERR") + Conversions.ToString(Information.Err().get_Number())), (MsgBoxStyle)0, (object)null);
					goto IL_02f9;
					IL_02d4:
					num = 53;
					Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_INTERNALERROR"), (MsgBoxStyle)0, (object)null);
					ProjectData.EndApp();
					goto IL_02f9;
					IL_02c6:
					num = 38;
					text = GetSaveFile(ref Filter_Renamed, ref StartFileName);
					goto IL_02f9;
					IL_02f9:
					num = 56;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_02bd;
					IL_012e:
					num = 22;
					if ((int)val2 == 2)
					{
						goto IL_0136;
					}
					goto IL_0145;
					IL_0265:
					num = 45;
					Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_UNRERR1") + Conversions.ToString(Information.Err().get_Number()) + frmAlias.DefInstance.resManager.GetString("STR_UNRERR2")), (MsgBoxStyle)0, (object)null);
					goto IL_02ad;
					IL_02ad:
					num = 46;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_02bd;
					IL_011a:
					num = 21;
					val2 = ((CommonDialog)frmAlias.DefInstance.cdgSave).ShowDialog();
					goto IL_012e;
					IL_015e:
					num = 41;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num4 = num2;
						goto IL_0170;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_0136:
					num = 23;
					text = "";
					goto end_IL_0000_2;
					IL_0145:
					num = 27;
					text = ((FileDialog)frmAlias.DefInstance.cdgSave).get_FileName();
					goto end_IL_0000_2;
					IL_0008:
					num = 2;
					val3 = frmAlias.DefInstance.cdgSave;
					goto IL_0017;
					IL_0017:
					num = 3;
					((FileDialog)val3).set_Filter(Filter_Renamed);
					goto IL_0023;
					IL_0023:
					num = 4;
					((FileDialog)val3).set_FilterIndex(0);
					goto IL_002e;
					IL_002e:
					num = 5;
					((FileDialog)val3).set_FileName(StartFileName);
					goto IL_003a;
					IL_003a:
					val3 = null;
					goto IL_003d;
					IL_003d:
					num = 7;
					text = "";
					goto IL_0046;
					IL_0046:
					num = 8;
					F = ((FileDialog)frmAlias.DefInstance.cdgSave).get_FileName();
					if (Exist(ref F))
					{
						goto IL_0066;
					}
					goto IL_0116;
					IL_0066:
					num = 9;
					num7 = 7;
					goto IL_006c;
					IL_006c:
					num = 10;
					if ((int)frmAlias.DefInstance.chkConfirm.get_CheckState() > 0)
					{
						goto IL_0084;
					}
					goto IL_00f3;
					IL_0084:
					num = 11;
					num7 = checked((short)Interaction.MsgBox((object)(((FileDialog)frmAlias.DefInstance.cdgOpen).get_FileName() + "\r\n\r\n" + frmAlias.DefInstance.resManager.GetString("STR_CONFEXISTS")), (MsgBoxStyle)307, (object)(frmAlias.DefInstance.resManager.GetString("STR_OVERWRITE") + sFname + frmAlias.DefInstance.resManager.GetString("STR_?"))));
					goto IL_00f3;
					IL_00f3:
					num = 13;
					if (num7 == 2)
					{
						goto end_IL_0000_2;
					}
					goto IL_0100;
					IL_0100:
					num = 16;
					if (num7 == 7)
					{
						goto IL_0108;
					}
					goto IL_0145;
					IL_0108:
					num = 17;
					text = GetSaveFile(ref Filter_Renamed, ref StartFileName);
					goto IL_0145;
					IL_0116:
					num = 20;
					goto IL_011a;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 981;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string GetOpenFile(ref string Filter_Renamed, ref string StartFileName)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num = default(int);
		string text = default(string);
		int num2 = default(int);
		int num3 = default(int);
		short num6 = default(short);
		OpenFileDialog val2 = default(OpenFileDialog);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				ErrObject val;
				int errVal;
				short num5;
				string F;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					text = "";
					goto IL_0009;
				case 952:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						case 2:
						case 3:
							goto IL_0381;
						default:
							goto end_IL_0000;
						}
						goto IL_02a0;
					}
					IL_02a0:
					num4 = num2 + 1;
					goto IL_016b;
					IL_016b:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0009;
					case 3:
						goto IL_0017;
					case 4:
						goto IL_0022;
					case 5:
						goto IL_002c;
					case 6:
						goto IL_0037;
					case 7:
						goto IL_0039;
					case 8:
						goto IL_0041;
					case 9:
						goto IL_0054;
					case 10:
						goto IL_0069;
					case 11:
						goto IL_0077;
					case 14:
						goto IL_0084;
					case 15:
						goto IL_0088;
					case 13:
					case 16:
					case 17:
						goto IL_0090;
					case 18:
						goto IL_00b0;
					case 19:
						goto IL_0134;
					case 20:
					case 21:
						goto IL_0140;
					case 34:
					case 35:
						goto IL_0159;
					default:
						goto end_IL_0000;
					case 38:
					case 39:
						goto IL_0248;
					case 40:
						goto IL_0290;
					case 30:
					case 32:
						goto IL_02a9;
					case 46:
					case 47:
						goto IL_02b7;
					case 29:
					case 33:
					case 36:
					case 37:
					case 41:
					case 42:
					case 45:
					case 48:
					case 49:
					case 50:
						goto IL_02dc;
					case 43:
					case 44:
						goto IL_02ee;
					case 28:
						goto IL_0324;
					case 26:
					case 27:
						goto IL_0343;
					case 24:
						goto IL_036a;
					case 23:
						goto IL_0381;
					case 0:
					case 31:
						goto end_IL_0000;
					case 12:
					case 22:
					case 25:
					case 51:
						goto end_IL_0000_2;
					}
					goto default;
					IL_0381:
					num = 23;
					Cursor.set_Current(Cursors.get_Default());
					goto IL_036a;
					IL_036a:
					num = 24;
					if (Information.Err().get_Number() == 32755)
					{
						goto end_IL_0000_2;
					}
					goto IL_0343;
					IL_0343:
					num = 27;
					val = Information.Err();
					errVal = val.get_Number();
					num5 = ErrorHandler.FileErrors(ref errVal);
					val.set_Number(errVal);
					num6 = num5;
					goto IL_0324;
					IL_0324:
					num = 28;
					switch (num6)
					{
					case 1:
						break;
					case 2:
						goto IL_0248;
					case 0:
						goto IL_02a9;
					default:
						goto IL_02b7;
					case 3:
						goto IL_02ee;
					}
					goto IL_0159;
					IL_02ee:
					num = 44;
					Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_UNRECERR") + Conversions.ToString(Information.Err().get_Number())), (MsgBoxStyle)0, (object)null);
					goto IL_02dc;
					IL_02b7:
					num = 47;
					Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_INTERNALERROR"), (MsgBoxStyle)0, (object)null);
					ProjectData.EndApp();
					goto IL_02dc;
					IL_02a9:
					num = 32;
					text = GetOpenFile(ref Filter_Renamed, ref StartFileName);
					goto IL_02dc;
					IL_02dc:
					num = 50;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_02a0;
					IL_00b0:
					num = 18;
					Interaction.MsgBox((object)(((FileDialog)frmAlias.DefInstance.cdgOpen).get_FileName() + "\r\n" + frmAlias.DefInstance.resManager.GetString("STR_FILENOTFOUND") + "\r\n" + frmAlias.DefInstance.resManager.GetString("STR_CHECKPATH")), (MsgBoxStyle)48, (object)frmAlias.DefInstance.resManager.GetString("STR_FNFTITLE"));
					goto IL_0134;
					IL_0248:
					num = 39;
					Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_UNRERR1") + Conversions.ToString(Information.Err().get_Number()) + frmAlias.DefInstance.resManager.GetString("STR_UNRERR2")), (MsgBoxStyle)0, (object)null);
					goto IL_0290;
					IL_0290:
					num = 40;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_02a0;
					IL_0090:
					num = 17;
					F = ((FileDialog)frmAlias.DefInstance.cdgOpen).get_FileName();
					if (!Exist(ref F))
					{
						goto IL_00b0;
					}
					goto IL_0140;
					IL_0159:
					num = 35;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num4 = num2;
						goto IL_016b;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_0134:
					num = 19;
					text = GetOpenFile(ref Filter_Renamed, ref StartFileName);
					goto IL_0140;
					IL_0140:
					num = 21;
					text = ((FileDialog)frmAlias.DefInstance.cdgOpen).get_FileName();
					goto end_IL_0000_2;
					IL_0009:
					num = 2;
					val2 = frmAlias.DefInstance.cdgOpen;
					goto IL_0017;
					IL_0017:
					num = 3;
					((FileDialog)val2).set_Filter(Filter_Renamed);
					goto IL_0022;
					IL_0022:
					num = 4;
					((FileDialog)val2).set_FilterIndex(0);
					goto IL_002c;
					IL_002c:
					num = 5;
					((FileDialog)val2).set_FileName(StartFileName);
					goto IL_0037;
					IL_0037:
					val2 = null;
					goto IL_0039;
					IL_0039:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0041;
					IL_0041:
					num = 8;
					((CommonDialog)frmAlias.DefInstance.cdgOpen).ShowDialog();
					goto IL_0054;
					IL_0054:
					num = 9;
					if (Information.Err().get_Number() == 32755)
					{
						goto IL_0069;
					}
					goto IL_0084;
					IL_0069:
					num = 10;
					Information.Err().Clear();
					goto IL_0077;
					IL_0077:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto end_IL_0000_2;
					IL_0084:
					num = 14;
					goto IL_0088;
					IL_0088:
					ProjectData.ClearProjectError();
					num3 = 3;
					goto IL_0090;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 952;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void SelectAListItem(short iItemToSelect, short nTab)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		object? obj = frmAlias.DefInstance.lvwAlias[nTab];
		object[] array = new object[1] { iItemToSelect };
		bool[] array2 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Items", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			iItemToSelect = (short)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(short));
		}
		ListViewItem val = (ListViewItem)obj2;
		val.set_Selected(true);
	}

	public static void ChkApply()
	{
		if ((nChange > 0) | ((Operators.CompareString(Strings.LCase(sFileInMemory), Strings.LCase(sACADPGP), false) != 0) & (Operators.CompareString(sACADPGP, "c:", false) != 0)))
		{
			frmAlias defInstance = frmAlias.DefInstance;
			((Control)defInstance.cmdApply).set_Enabled(true);
			defInstance.mnuFileSave.set_Enabled(true);
			defInstance = null;
		}
		else
		{
			frmAlias defInstance2 = frmAlias.DefInstance;
			((Control)defInstance2.cmdApply).set_Enabled(false);
			defInstance2.mnuFileSave.set_Enabled(false);
			defInstance2 = null;
		}
		if (nChange == 0)
		{
			((ButtonBase)frmAlias.DefInstance.cmdCancel).set_Text(frmAlias.DefInstance.resManager.GetString("BUT_CLOSE"));
		}
		else
		{
			((ButtonBase)frmAlias.DefInstance.cmdCancel).set_Text(frmAlias.DefInstance.resManager.GetString("BUT_CANCEL"));
		}
	}

	public static bool Exist(ref string F)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 97:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_001c;
						case 6:
							goto IL_0023;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 8:
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0023:
					num = 6;
					break;
					IL_0007:
					num = 2;
					num5 = checked((int)FileSystem.FileLen(F));
					goto IL_0013;
					IL_0013:
					num = 3;
					if (num5 != 0)
					{
						goto IL_001c;
					}
					goto IL_0023;
					IL_001c:
					num = 4;
					flag = true;
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 7;
				flag = false;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 97;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void FindBounds(string vsSect, ref string[] rsMNUFile, ref short rnBeginVar, ref short rnEndVar, short vnEnd)
	{
		rnBeginVar = -1;
		short num = vnEnd;
		short num2 = 1;
		checked
		{
			while (num2 <= num)
			{
				if (Operators.CompareString(rsMNUFile[num2], vsSect, false) != 0)
				{
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				rnBeginVar = num2;
				break;
			}
			rnEndVar = vnEnd;
			short num3 = (short)(rnBeginVar + 1);
			short num4 = vnEnd;
			num2 = num3;
			while (true)
			{
				if (num2 <= num4)
				{
					if (Operators.CompareString(Strings.Left(rsMNUFile[num2], 3), "***", false) == 0)
					{
						break;
					}
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				return;
			}
			rnEndVar = (short)(num2 - 1);
		}
	}

	public static string GetPath()
	{
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num6 = default(short);
		string text = default(string);
		string path = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				ErrObject val;
				int errVal;
				short num5;
				string keypath;
				string name;
				object def;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 638:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						case 2:
							goto IL_0232;
						default:
							goto end_IL_0000;
						}
						goto IL_0194;
					}
					IL_0194:
					num4 = num2 + 1;
					goto IL_00a3;
					IL_00a3:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0011;
					case 4:
						goto IL_002a;
					case 5:
						goto IL_0039;
					case 6:
						goto IL_004d;
					case 7:
						goto IL_005c;
					case 8:
						goto IL_007d;
					case 17:
					case 18:
						goto IL_0091;
					default:
						goto end_IL_0000;
					case 21:
					case 22:
						goto IL_013c;
					case 23:
						goto IL_0184;
					case 13:
					case 15:
						goto IL_019d;
					case 29:
					case 30:
						goto IL_01a9;
					case 12:
					case 16:
					case 19:
					case 20:
					case 24:
					case 25:
					case 28:
					case 31:
					case 32:
					case 33:
						goto IL_01ce;
					case 26:
					case 27:
						goto IL_01dd;
					case 11:
						goto IL_0213;
					case 10:
						goto IL_0232;
					case 0:
					case 14:
						goto end_IL_0000;
					case 9:
					case 34:
						goto end_IL_0000_2;
					}
					goto default;
					IL_0232:
					num = 10;
					val = Information.Err();
					errVal = val.get_Number();
					num5 = ErrorHandler.FileErrors(ref errVal);
					val.set_Number(errVal);
					num6 = num5;
					goto IL_0213;
					IL_0213:
					num = 11;
					switch (num6)
					{
					case 1:
						break;
					case 2:
						goto IL_013c;
					case 0:
						goto IL_019d;
					default:
						goto IL_01a9;
					case 3:
						goto IL_01dd;
					}
					goto IL_0091;
					IL_01dd:
					num = 27;
					Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_UNRECERR") + Conversions.ToString(Information.Err().get_Number())), (MsgBoxStyle)0, (object)null);
					goto IL_01ce;
					IL_01a9:
					num = 30;
					Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_INTERNALERROR"), (MsgBoxStyle)0, (object)null);
					ProjectData.EndApp();
					goto IL_01ce;
					IL_019d:
					num = 15;
					GetPath();
					goto IL_01ce;
					IL_01ce:
					num = 33;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_0194;
					IL_004d:
					num = 6;
					text += "\\General";
					goto IL_005c;
					IL_013c:
					num = 22;
					Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_UNRERR1") + Conversions.ToString(Information.Err().get_Number()) + frmAlias.DefInstance.resManager.GetString("STR_UNRERR2")), (MsgBoxStyle)0, (object)null);
					goto IL_0184;
					IL_0184:
					num = 23;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_0194;
					IL_0039:
					num = 5;
					text = text + "\\" + BnsReg.GetCurrentAcadProfile();
					goto IL_004d;
					IL_0091:
					num = 18;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num4 = num2;
						goto IL_00a3;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_005c:
					num = 7;
					keypath = text;
					name = "ACAD";
					def = "";
					path = Conversions.ToString(BnsReg.acet_RegistryRead(keypath, ref name, ref def));
					goto IL_007d;
					IL_007d:
					num = 8;
					text2 = BnsStr.FindFile("acad.pgp", path);
					goto end_IL_0000_2;
					IL_0008:
					num = 2;
					text = "HKEY_CURRENT_USER\\SOFTWARE\\Autodesk\\AutoCAD\\";
					goto IL_0011;
					IL_0011:
					num = 3;
					text = text + BnsReg.acadcurver() + "\\" + BnsReg.acadcurvercookie();
					goto IL_002a;
					IL_002a:
					num = 4;
					text += "\\Profiles";
					goto IL_0039;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 638;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool FindDuplicateCmd(ref string NewString, ref ComboBox listCmds)
	{
		short num = checked((short)(listCmds.get_Items().get_Count() - 1));
		short num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				string text = Strings.LCase(NewString);
				Type typeFromHandle = typeof(Strings);
				object[] array = new object[1];
				ObjectCollection items = listCmds.get_Items();
				short num3 = num2;
				array[0] = RuntimeHelpers.GetObjectValue(items.get_Item((int)num3));
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "LCase", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					items.set_Item((int)num3, RuntimeHelpers.GetObjectValue(array2[0]));
				}
				if (Operators.ConditionalCompareObjectEqual((object)text, obj, false))
				{
					break;
				}
				checked
				{
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
			}
			return false;
		}
		return true;
	}

	public static ListViewItem FindDuplicate(ref string NewString)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num2 = default(int);
		ListViewItem val;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					val = null;
					ListViewItem val2 = null;
					short index = CurrentTab();
					ListViewItem val3 = null;
					ListView val4 = (ListView)frmAlias.DefInstance.lvwAlias[index];
					IEnumerator enumerator = val4.get_Items().GetEnumerator();
					while (enumerator.MoveNext())
					{
						val3 = (ListViewItem)enumerator.Current;
						if (Operators.CompareString(Strings.LCase(NewString), Strings.LCase(val3.get_Text()), false) == 0)
						{
							val2 = val3;
							break;
						}
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					if (val2 != null)
					{
						val = val3;
					}
					goto end_IL_0000;
				}
				case 149:
					num = -1;
					switch (num2)
					{
					case 2:
						val = null;
						goto end_IL_0000;
					}
					break;
				}
				goto IL_00cf;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 149;
				continue;
			}
			break;
			IL_00cf:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		ListViewItem result = val;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void PrintOneLine(ref string line, Font font, ref float yPos, ref int count, ref PrintPageEventArgs ev)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		yPos = (float)ev.get_MarginBounds().Top + (float)count * font.GetHeight(ev.get_Graphics());
		ev.get_Graphics().DrawString(line, font, Brushes.get_Black(), (float)ev.get_MarginBounds().Left, yPos, new StringFormat());
		checked
		{
			count++;
		}
	}

	public static string GetSpaceString(short num)
	{
		string text = "";
		checked
		{
			short num2 = (short)unchecked(30 - num);
			for (short num3 = 0; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				text += " ";
			}
			return text;
		}
	}

	public static void PrintPage(ref PrintPageEventArgs ev)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		printFont = new Font("Courier New", 10f, (FontStyle)1);
		string line = sTitle[Index] + ", Page " + Conversions.ToString(nPage);
		PrintOneLine(ref line, printFont, ref yPos, ref count, ref ev);
		line = frmAlias.DefInstance.resManager.GetString("PRINT_FILENAME") + sFileInMemory;
		PrintOneLine(ref line, printFont, ref yPos, ref count, ref ev);
		checked
		{
			short num = (short)numCopiesPrinted;
			short copies = pd.get_PrinterSettings().get_Copies();
			for (nCopies = num; nCopies <= copies; nCopies = (short)unchecked(nCopies + 1))
			{
				while (Index < 2)
				{
					ListViewItemCollection val = (ListViewItemCollection)NewLateBinding.LateGet(frmAlias.DefInstance.lvwAlias[Index], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
					line = "";
					PrintOneLine(ref line, printFont, ref yPos, ref count, ref ev);
					line = "";
					PrintOneLine(ref line, printFont, ref yPos, ref count, ref ev);
					printFont = new Font("Courier New", 10f);
					PrintOneLine(ref sSeparator, printFont, ref yPos, ref count, ref ev);
					printFont = new Font("Courier New", 10f, (FontStyle)1);
					line = sHeader1[Index] + GetSpaceString((short)Strings.Len(sHeader1[Index])) + sHeader2[Index];
					PrintOneLine(ref line, printFont, ref yPos, ref count, ref ev);
					printFont = new Font("Courier New", 10f);
					PrintOneLine(ref sSeparator, printFont, ref yPos, ref count, ref ev);
					line = "";
					PrintOneLine(ref line, printFont, ref yPos, ref count, ref ev);
					while (y < val.get_Count())
					{
						line = val.get_Item(y).get_Text() + GetSpaceString((short)Strings.Len(val.get_Item(y).get_Text())) + val.get_Item(y).get_SubItems().get_Item(1)
							.get_Text();
						PrintOneLine(ref line, printFont, ref yPos, ref count, ref ev);
						y++;
						if (unchecked(count % linesPerPage) == 0)
						{
							return;
						}
					}
					Index++;
					y = 0;
				}
				numCopiesPrinted = nCopies;
			}
			Cursor.set_Current(Cursors.get_Default());
		}
	}

	public static void PrintMe(object sender, PrintPageEventArgs e)
	{
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num6 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num4;
					ErrObject val;
					int errVal;
					short num5;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_0008;
					case 806:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							case 2:
								goto IL_02d8;
							default:
								goto end_IL_0000;
							}
							goto IL_0165;
						}
						IL_0165:
						num4 = unchecked(num2 + 1);
						goto IL_017d;
						IL_017d:
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0038;
						case 4:
							goto IL_0056;
						case 5:
							goto IL_0074;
						case 6:
							goto IL_0092;
						case 7:
							goto IL_00b0;
						case 8:
							goto IL_00ce;
						case 9:
							goto IL_00ec;
						case 10:
							goto IL_0113;
						case 11:
							goto IL_011e;
						case 12:
							goto IL_012a;
						case 14:
							goto IL_0137;
						case 15:
							goto IL_013b;
						case 13:
						case 16:
						case 17:
							goto IL_0146;
						case 18:
							goto IL_0150;
						case 28:
						case 29:
							goto IL_016b;
						default:
							goto end_IL_0000;
						case 24:
						case 26:
							goto IL_0246;
						case 39:
						case 40:
							goto IL_0258;
						case 23:
						case 27:
						case 30:
						case 31:
						case 35:
						case 38:
						case 41:
						case 42:
						case 43:
							goto IL_027d;
						case 36:
						case 37:
							goto IL_028f;
						case 22:
							goto IL_029a;
						case 21:
							goto IL_02b6;
						case 20:
							goto IL_02d8;
						case 0:
						case 25:
							goto end_IL_0000;
						case 32:
						case 33:
							goto end_IL_0000_2;
						case 19:
						case 34:
						case 44:
						case 45:
						case 46:
							goto end_IL_0000_3;
						}
						goto default;
						IL_02d8:
						num = 20;
						Cursor.set_Current(Cursors.get_Default());
						goto IL_02b6;
						IL_02b6:
						num = 21;
						val = Information.Err();
						errVal = val.get_Number();
						num5 = ErrorHandler.FileErrors(ref errVal);
						val.set_Number(errVal);
						num6 = num5;
						goto IL_029a;
						IL_029a:
						num = 22;
						switch (num6)
						{
						case 1:
							break;
						case 0:
							goto IL_0246;
						default:
							goto IL_0258;
						case 3:
							goto IL_028f;
						case 2:
							goto end_IL_0000_2;
						}
						goto IL_016b;
						IL_028f:
						num = 37;
						ErrorHandler.ShowError();
						goto IL_027d;
						IL_0258:
						num = 40;
						Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_INTERNALERROR"), (MsgBoxStyle)0, (object)null);
						ProjectData.EndApp();
						goto IL_027d;
						IL_0246:
						num = 26;
						PrintMe(RuntimeHelpers.GetObjectValue(sender), e);
						goto IL_027d;
						IL_027d:
						num = 43;
						ProjectData.ClearProjectError();
						if (num2 == 0)
						{
							throw ProjectData.CreateProjectError(-2146828268);
						}
						goto IL_0165;
						IL_013b:
						num = 15;
						e.set_HasMorePages(true);
						goto IL_0146;
						IL_016b:
						num = 29;
						ProjectData.ClearProjectError();
						if (num2 != 0)
						{
							num4 = num2;
							goto IL_017d;
						}
						throw ProjectData.CreateProjectError(-2146828268);
						IL_0146:
						num = 17;
						count = 0;
						goto IL_0150;
						IL_0150:
						num = 18;
						nPage++;
						goto end_IL_0000_3;
						IL_0008:
						num = 2;
						linesPerPage = (int)Math.Round((float)e.get_MarginBounds().Height / printFont.GetHeight(e.get_Graphics()));
						goto IL_0038;
						IL_0038:
						num = 3;
						sHeader1[0] = frmAlias.DefInstance.resManager.GetString("PRINT_KEYA");
						goto IL_0056;
						IL_0056:
						num = 4;
						sHeader2[0] = frmAlias.DefInstance.resManager.GetString("PRINT_ACADC");
						goto IL_0074;
						IL_0074:
						num = 5;
						sHeader1[1] = frmAlias.DefInstance.resManager.GetString("PRINT_KEYA");
						goto IL_0092;
						IL_0092:
						num = 6;
						sHeader2[1] = frmAlias.DefInstance.resManager.GetString("PRINT_SHELLC");
						goto IL_00b0;
						IL_00b0:
						num = 7;
						sTitle[0] = frmAlias.DefInstance.resManager.GetString("PRINT_ACADCA");
						goto IL_00ce;
						IL_00ce:
						num = 8;
						sTitle[1] = frmAlias.DefInstance.resManager.GetString("PRINT_SHELLCA");
						goto IL_00ec;
						IL_00ec:
						num = 9;
						sSeparator = frmAlias.DefInstance.resManager.GetString("PRINT_SEP") + "\r\n";
						goto IL_0113;
						IL_0113:
						num = 10;
						PrintPage(ref e);
						goto IL_011e;
						IL_011e:
						num = 11;
						if (Index == 2)
						{
							goto IL_012a;
						}
						goto IL_0137;
						IL_012a:
						num = 12;
						e.set_HasMorePages(false);
						goto IL_0146;
						IL_0137:
						num = 14;
						goto IL_013b;
						end_IL_0000_2:
						break;
					}
					num = 33;
					Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("PRINT_ERR"), (MsgBoxStyle)0, (object)null);
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 806;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static bool NoCommandAddedOK()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		string @string = frmAlias.DefInstance.resManager.GetString("STR_ERRBLANK");
		@string = ((nEdit != 1) ? (@string + frmAlias.DefInstance.resManager.GetString("STR_NOADDED")) : (@string + frmAlias.DefInstance.resManager.GetString("STR_NOCHANGE")));
		string string2 = frmAlias.DefInstance.resManager.GetString("STR_AINV");
		checked
		{
			_ = (short)Interaction.MsgBox((object)@string, (MsgBoxStyle)48, (object)string2);
			return false;
		}
	}

	public static void ReInit(ref bool Suppress)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					Cursor.set_Current(Cursors.get_WaitCursor());
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject((string)null, "Autocad.Application"));
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "activedocument", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetVariable", new object[2] { "RE-INIT", 16 }, (string[])null, (Type[])null, (bool[])null, true);
					Cursor.set_Current(Cursors.get_Default());
					if (!Suppress)
					{
						Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_UPDATED"), (MsgBoxStyle)64, (object)null);
					}
					goto end_IL_0000;
				}
				case 361:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor.set_Current(Cursors.get_Default());
						if (Information.Err().get_Number() == 429)
						{
							Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_NEXTSESS"), (MsgBoxStyle)64, (object)null);
						}
						else if (!Suppress)
						{
							Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_UPDATEERR1") + "\r\n\r\n" + frmAlias.DefInstance.resManager.GetString("STR_UPDATEERR2") + "\r\n" + frmAlias.DefInstance.resManager.GetString("STR_ERR") + Conversions.ToString(Information.Err().get_Number()) + "), " + Information.Err().get_Description()), (MsgBoxStyle)48, (object)null);
						}
						goto end_IL_0000;
					}
					break;
				}
				goto IL_01a1;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 361;
				continue;
			}
			break;
			IL_01a1:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ParseLineForCommand(ref string line, ref string str1, ref string str2, ref string str3, ref string str4)
	{
		int num = Strings.InStr(1, line, ",", (CompareMethod)0);
		int num2;
		int num3;
		int num4;
		checked
		{
			if (num == 0)
			{
				string x = "$";
				str1 = BogusString(ref x);
				str2 = line;
				nTotalAlias++;
				return;
			}
			if (num == Strings.Len(line))
			{
				str1 = line;
				string x = "?";
				str2 = BogusString(ref x);
				nTotalAlias++;
				return;
			}
			num2 = Strings.InStr(num + 1, line, ",", (CompareMethod)0);
			if (num2 == 0)
			{
				nTotalAlias++;
				str1 = Strings.Trim(Strings.Left(line, num - 1));
				str2 = Strings.Trim(Strings.Right(line, Strings.Len(line) - num)).Replace("*", "");
				return;
			}
			nTotalShell++;
			sShell = (string[])Utils.CopyArray((Array)sShell, (Array)new string[nTotalShell + 1]);
			sCommand = (string[])Utils.CopyArray((Array)sCommand, (Array)new string[nTotalShell + 1]);
			sFlag = (string[])Utils.CopyArray((Array)sFlag, (Array)new string[nTotalShell + 1]);
			sPrompt = (string[])Utils.CopyArray((Array)sPrompt, (Array)new string[nTotalShell + 1]);
			sCode = (string[])Utils.CopyArray((Array)sCode, (Array)new string[nTotalShell + 1]);
			num3 = Strings.InStr(num2 + 1, line, ",", (CompareMethod)0);
			num4 = Strings.InStr(num3 + 1, line, ",", (CompareMethod)0);
			str1 = Strings.Trim(Strings.Left(line, num - 1));
			if (num2 == 1 + num)
			{
				str2 = "";
			}
			else
			{
				str2 = Strings.Trim(Strings.Mid(line, num + 1, num2 - (num + 1)));
			}
		}
		if (num3 == checked(1 + num2) || num2 == 0)
		{
			str3 = "";
		}
		else
		{
			str3 = Strings.Trim(checked(Strings.Mid(line, num2 + 1, num3 - (num2 + 1))));
		}
		if (num4 == checked(1 + num3) || num3 == 0)
		{
			str4 = "";
			return;
		}
		checked
		{
			str4 = Strings.Trim(Strings.Mid(line, num3 + 1, num4 - (num3 + 1)));
			if (Operators.CompareString(Strings.Left(str4, 1), "*", false) == 0)
			{
				str4 = Strings.Trim(Strings.Right(str4, Strings.Len(str4) - 1));
			}
		}
	}

	public static void RefreshDefaults(ref int Index, ListViewItem oAliasToRemove)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		StringReader stringReader = new StringReader(sSysAliases);
		string line = stringReader.ReadLine();
		ListViewItem val = null;
		string str = "";
		string str2 = "";
		string str3 = "";
		string str4 = "";
		switch (Index)
		{
		case 0:
			while (!Information.IsNothing((object)line))
			{
				if (line.Length > 0 && ((Operators.CompareString(line.Substring(0, 1), ";", false) != 0) & (line.IndexOf(oAliasToRemove.get_Text() + ", ") >= 0)))
				{
					sSysAliases.IndexOf(line);
					ParseLineForCommand(ref line, ref str, ref str2, ref str3, ref str4);
					val = new ListViewItem(str);
					val.get_SubItems().Add(str2);
				}
				line = stringReader.ReadLine();
			}
			break;
		case 1:
			while (!Information.IsNothing((object)line))
			{
				if (line.Length > 0 && ((Operators.CompareString(line.Substring(0, 1), ";", false) != 0) & (line.IndexOf(oAliasToRemove.get_Text() + ", ") >= 0)))
				{
					sSysAliases.IndexOf(line);
					ParseLineForCommand(ref line, ref str, ref str2, ref str3, ref str4);
					val = new ListViewItem(str);
					val.get_SubItems().Add(str2);
					val.get_SubItems().Add(str3);
					val.get_SubItems().Add(str4);
				}
				line = stringReader.ReadLine();
			}
			break;
		}
		if (!Information.IsNothing((object)val))
		{
			object obj = NewLateBinding.LateGet(frmAlias.DefInstance.lvwAlias[Index], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { val };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "Add", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				val = (ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(ListViewItem));
			}
			NewLateBinding.LateCall(frmAlias.DefInstance.lvwAlias[Index], (Type)null, "Sort", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_RESTOREDDEF1") + str), (MsgBoxStyle)64, (object)frmAlias.DefInstance.resManager.GetString("STR_RESTOREDDEF2"));
		}
	}

	public static void RemoveAlias(ref ListViewItem oAliasToRemove, ref int Index, bool removeFromFile, bool removeFromLV)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num = default(int);
		ListViewItemCollection val = default(ListViewItemCollection);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		ArrayList arrayList = default(ArrayList);
		int num6 = default(int);
		ArrayList arrayList2 = default(ArrayList);
		ArrayList arrayList3 = default(ArrayList);
		ArrayList arrayList4 = default(ArrayList);
		StringReader stringReader = default(StringReader);
		string text = default(string);
		int num7 = default(int);
		StringReader stringReader2 = default(StringReader);
		string text2 = default(string);
		int num8 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						val = (ListViewItemCollection)NewLateBinding.LateGet(frmAlias.DefInstance.lvwAlias[Index], (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
						goto IL_002e;
					case 1730:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_002e;
							case 3:
								goto IL_003a;
							case 4:
								goto IL_0060;
							case 5:
								goto IL_0065;
							case 6:
								goto IL_006b;
							case 8:
							case 10:
								goto IL_0082;
							case 11:
								goto IL_0097;
							case 12:
								goto IL_00a6;
							case 13:
							case 14:
								goto IL_00b9;
							case 15:
								goto IL_00c5;
							case 16:
								goto IL_00d1;
							case 17:
								goto IL_00e0;
							case 18:
								goto IL_00ec;
							case 19:
								goto IL_00f8;
							case 20:
								goto IL_0116;
							case 21:
								goto IL_0134;
							case 23:
								goto IL_014a;
							case 24:
								goto IL_0154;
							case 25:
								goto IL_0164;
							case 28:
								goto IL_0176;
							case 29:
								goto IL_0187;
							case 30:
								goto IL_01dc;
							case 33:
								goto IL_01f0;
							case 31:
							case 32:
							case 34:
								goto IL_020c;
							case 35:
								goto IL_022d;
							case 36:
								goto IL_0239;
							case 37:
							case 38:
							case 39:
							case 40:
								goto IL_0253;
							case 26:
							case 27:
							case 41:
								goto IL_0260;
							case 44:
							case 45:
								goto IL_0275;
							case 46:
								goto IL_028a;
							case 47:
								goto IL_0299;
							case 48:
							case 49:
								goto IL_02ac;
							case 50:
								goto IL_02b8;
							case 51:
								goto IL_02c4;
							case 52:
								goto IL_02d3;
							case 53:
								goto IL_02e3;
							case 54:
								goto IL_02f3;
							case 55:
								goto IL_02ff;
							case 56:
								goto IL_030b;
							case 57:
								goto IL_0318;
							case 58:
								goto IL_0325;
							case 59:
								goto IL_0343;
							case 60:
								goto IL_0361;
							case 61:
								goto IL_0380;
							case 62:
								goto IL_039f;
							case 64:
								goto IL_03b5;
							case 65:
								goto IL_03bf;
							case 66:
								goto IL_03cf;
							case 69:
								goto IL_03e1;
							case 70:
								goto IL_03f2;
							case 71:
								goto IL_0487;
							case 74:
								goto IL_049b;
							case 72:
							case 73:
							case 75:
								goto IL_04b7;
							case 76:
								goto IL_04d8;
							case 77:
								goto IL_04e4;
							case 78:
							case 79:
							case 80:
							case 81:
								goto IL_04fe;
							case 67:
							case 68:
							case 82:
								goto IL_050b;
							case 7:
							case 22:
							case 42:
							case 43:
							case 63:
							case 83:
							case 84:
							case 85:
							case 86:
								goto IL_051b;
							case 87:
								goto IL_0522;
							case 88:
							case 89:
								goto IL_052d;
							case 90:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 91:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_052d:
						ProjectData.ClearProjectError();
						num3 = 1;
						break;
						IL_002e:
						num = 2;
						num5 = val.IndexOf(oAliasToRemove);
						goto IL_003a;
						IL_003a:
						num = 3;
						if (unchecked(Operators.CompareString(sSysAliases, "", false) != 0 && num5 >= 0))
						{
							goto IL_0060;
						}
						goto IL_051b;
						IL_0060:
						num = 4;
						arrayList = null;
						goto IL_0065;
						IL_0065:
						num = 5;
						num6 = -1;
						goto IL_006b;
						IL_006b:
						num = 6;
						switch (Index)
						{
						case 0:
							break;
						case 1:
							goto IL_0275;
						default:
							goto IL_051b;
						}
						goto IL_0082;
						IL_0275:
						num = 45;
						if (unchecked(!Information.IsNothing((object)sUserDefShell) && removeFromFile))
						{
							goto IL_028a;
						}
						goto IL_02ac;
						IL_028a:
						num = 46;
						arrayList = new ArrayList(sUserDefShell);
						goto IL_0299;
						IL_0299:
						num = 47;
						num6 = arrayList.IndexOf(oAliasToRemove.get_Text());
						goto IL_02ac;
						IL_02ac:
						num = 49;
						if (num6 >= 0)
						{
							goto IL_02b8;
						}
						goto IL_03b5;
						IL_02b8:
						num = 50;
						RefreshDefaults(ref Index, oAliasToRemove);
						goto IL_02c4;
						IL_02c4:
						num = 51;
						arrayList2 = new ArrayList(sUserDefCommand);
						goto IL_02d3;
						IL_02d3:
						num = 52;
						arrayList3 = new ArrayList(sUserDefFlag);
						goto IL_02e3;
						IL_02e3:
						num = 53;
						arrayList4 = new ArrayList(sUserDefPrompt);
						goto IL_02f3;
						IL_02f3:
						num = 54;
						arrayList.RemoveAt(num6);
						goto IL_02ff;
						IL_02ff:
						num = 55;
						arrayList2.RemoveAt(num6);
						goto IL_030b;
						IL_030b:
						num = 56;
						arrayList3.RemoveAt(num6);
						goto IL_0318;
						IL_0318:
						num = 57;
						arrayList4.RemoveAt(num6);
						goto IL_0325;
						IL_0325:
						num = 58;
						sUserDefShell = (string[])arrayList.ToArray(typeof(string));
						goto IL_0343;
						IL_0343:
						num = 59;
						sUserDefCommand = (string[])arrayList2.ToArray(typeof(string));
						goto IL_0361;
						IL_0361:
						num = 60;
						sUserDefFlag = (string[])arrayList3.ToArray(typeof(string));
						goto IL_0380;
						IL_0380:
						num = 61;
						sUserDefPrompt = (string[])arrayList4.ToArray(typeof(string));
						goto IL_039f;
						IL_039f:
						num = 62;
						nUserDefTotalShell--;
						goto IL_051b;
						IL_03b5:
						num = 64;
						if (removeFromFile)
						{
							goto IL_03bf;
						}
						goto IL_051b;
						IL_03bf:
						num = 65;
						stringReader = new StringReader(sSysAliases);
						goto IL_03cf;
						IL_03cf:
						num = 66;
						text = stringReader.ReadLine();
						goto IL_050b;
						IL_050b:
						num = 68;
						if (!Information.IsNothing((object)text))
						{
							goto IL_03e1;
						}
						goto IL_051b;
						IL_03e1:
						num = 69;
						if (text.Length > 0)
						{
							goto IL_03f2;
						}
						goto IL_04fe;
						IL_03f2:
						num = 70;
						if ((Operators.CompareString(text.Substring(0, 1), ";", false) != 0) & (text.IndexOf(oAliasToRemove.get_Text()) >= 0) & (text.IndexOf(oAliasToRemove.get_SubItems().get_Item(1).get_Text()) >= 0) & (text.IndexOf(oAliasToRemove.get_SubItems().get_Item(2).get_Text()) >= 0) & (text.IndexOf(oAliasToRemove.get_SubItems().get_Item(3).get_Text()) >= 0))
						{
							goto IL_0487;
						}
						goto IL_04fe;
						IL_0487:
						num = 71;
						num7 = sSysAliases.IndexOf(text);
						goto IL_04b7;
						IL_04b7:
						num = 73;
						if (Operators.CompareString(sSysAliases.Substring(num7 - 1, 1), ";", false) == 0)
						{
							goto IL_049b;
						}
						goto IL_04d8;
						IL_04d8:
						num = 76;
						if (nEdit != 1)
						{
							goto IL_04e4;
						}
						goto IL_04fe;
						IL_04e4:
						num = 77;
						sSysAliases = sSysAliases.Insert(num7, ";;;");
						goto IL_04fe;
						IL_049b:
						num = 74;
						num7 = sSysAliases.IndexOf(text, num7 + text.Length);
						goto IL_04b7;
						IL_04fe:
						num = 81;
						text = stringReader.ReadLine();
						goto IL_050b;
						IL_0082:
						num = 10;
						if (unchecked(!Information.IsNothing((object)sUserDefAlias) && removeFromFile))
						{
							goto IL_0097;
						}
						goto IL_00b9;
						IL_0097:
						num = 11;
						arrayList = new ArrayList(sUserDefAlias);
						goto IL_00a6;
						IL_00a6:
						num = 12;
						num6 = arrayList.IndexOf(oAliasToRemove.get_Text());
						goto IL_00b9;
						IL_00b9:
						num = 14;
						if (num6 >= 0)
						{
							goto IL_00c5;
						}
						goto IL_014a;
						IL_00c5:
						num = 15;
						RefreshDefaults(ref Index, oAliasToRemove);
						goto IL_00d1;
						IL_00d1:
						num = 16;
						arrayList2 = new ArrayList(sUserDefRep);
						goto IL_00e0;
						IL_00e0:
						num = 17;
						arrayList.RemoveAt(num6);
						goto IL_00ec;
						IL_00ec:
						num = 18;
						arrayList2.RemoveAt(num6);
						goto IL_00f8;
						IL_00f8:
						num = 19;
						sUserDefAlias = (string[])arrayList.ToArray(typeof(string));
						goto IL_0116;
						IL_0116:
						num = 20;
						sUserDefRep = (string[])arrayList2.ToArray(typeof(string));
						goto IL_0134;
						IL_0134:
						num = 21;
						nUserDefTotalAlias--;
						goto IL_051b;
						IL_014a:
						num = 23;
						if (removeFromFile)
						{
							goto IL_0154;
						}
						goto IL_051b;
						IL_0154:
						num = 24;
						stringReader2 = new StringReader(sSysAliases);
						goto IL_0164;
						IL_0164:
						num = 25;
						text2 = stringReader2.ReadLine();
						goto IL_0260;
						IL_0260:
						num = 27;
						if (!Information.IsNothing((object)text2))
						{
							goto IL_0176;
						}
						goto IL_051b;
						IL_0176:
						num = 28;
						if (text2.Length > 0)
						{
							goto IL_0187;
						}
						goto IL_0253;
						IL_0187:
						num = 29;
						if ((Operators.CompareString(text2.Substring(0, 1), ";", false) != 0) & (text2.IndexOf(oAliasToRemove.get_Text()) >= 0) & (text2.IndexOf(oAliasToRemove.get_SubItems().get_Item(1).get_Text()) >= 0))
						{
							goto IL_01dc;
						}
						goto IL_0253;
						IL_01dc:
						num = 30;
						num8 = sSysAliases.IndexOf(text2);
						goto IL_020c;
						IL_020c:
						num = 32;
						if (Operators.CompareString(sSysAliases.Substring(num8 - 1, 1), ";", false) == 0)
						{
							goto IL_01f0;
						}
						goto IL_022d;
						IL_022d:
						num = 35;
						if (nEdit != 1)
						{
							goto IL_0239;
						}
						goto IL_0253;
						IL_0239:
						num = 36;
						sSysAliases = sSysAliases.Insert(num8, ";;;");
						goto IL_0253;
						IL_01f0:
						num = 33;
						num8 = sSysAliases.IndexOf(text2, num8 + text2.Length);
						goto IL_020c;
						IL_0253:
						num = 40;
						text2 = stringReader2.ReadLine();
						goto IL_0260;
						IL_051b:
						num = 86;
						if (removeFromLV)
						{
							goto IL_0522;
						}
						goto IL_052d;
						IL_0522:
						num = 87;
						val.RemoveAt(num5);
						goto IL_052d;
						end_IL_0000_2:
						break;
					}
					num = 90;
					nChange = 1;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1730;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static object KeyNumber(ref string keystring)
	{
		return Strings.Right(keystring, checked(Strings.Len(keystring) - Strings.Len("key")));
	}

	public static void SavePGP(ref string sFilePath, ref string sFileName, ref bool Suppress)
	{
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Invalid comparison between Unknown and I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num6 = default(short);
		bool flag = default(bool);
		string text = default(string);
		string text2 = default(string);
		int num7 = default(int);
		short num8 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				ErrObject val;
				int errVal;
				short num5;
				string sFileName2;
				short WhichTab;
				string sFilePath2;
				object WS;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 1552:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						case 2:
							goto IL_05e4;
						default:
							goto end_IL_0000;
						}
						goto IL_03e3;
					}
					IL_03e3:
					num4 = num2 + 1;
					goto IL_03fb;
					IL_03fb:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_000e;
					case 4:
						goto IL_001b;
					case 5:
						goto IL_0028;
					case 6:
						goto IL_003a;
					case 7:
						goto IL_004c;
					case 8:
						goto IL_0065;
					case 10:
						goto IL_0181;
					case 11:
						goto IL_0185;
					case 9:
					case 12:
					case 13:
						goto IL_0257;
					case 14:
						goto IL_027d;
					case 15:
						goto IL_0299;
					case 16:
						goto IL_02b7;
					case 17:
						goto IL_02cb;
					case 18:
						goto IL_02d3;
					case 19:
						goto IL_02e9;
					case 21:
						goto IL_02fd;
					case 22:
						goto IL_0301;
					case 20:
					case 23:
					case 24:
						goto IL_0322;
					case 26:
						goto IL_034f;
					case 27:
						goto IL_0353;
					case 25:
					case 28:
					case 29:
					case 30:
						goto IL_0383;
					case 31:
						goto IL_039a;
					case 32:
						goto IL_03a5;
					case 33:
						goto IL_03b0;
					case 34:
						goto IL_03ba;
					case 35:
						goto IL_03c3;
					case 36:
						goto IL_03cc;
					case 37:
						goto IL_03d4;
					case 49:
					case 50:
						goto IL_03e9;
					default:
						goto end_IL_0000;
					case 44:
					case 46:
						goto IL_0510;
					case 47:
						goto IL_0524;
					case 60:
					case 61:
						goto IL_0556;
					case 43:
					case 48:
					case 51:
					case 52:
					case 55:
					case 59:
					case 62:
					case 63:
					case 64:
						goto IL_057b;
					case 58:
						goto IL_058d;
					case 56:
					case 57:
						goto IL_0598;
					case 42:
						goto IL_05a1;
					case 41:
						goto IL_05bd;
					case 40:
						goto IL_05e4;
					case 0:
					case 45:
						goto end_IL_0000;
					case 38:
					case 39:
					case 53:
					case 54:
					case 65:
						goto end_IL_0000_2;
					}
					goto default;
					IL_05e4:
					num = 40;
					Cursor.set_Current(Cursors.get_Default());
					goto IL_05bd;
					IL_05bd:
					num = 41;
					val = Information.Err();
					errVal = val.get_Number();
					num5 = ErrorHandler.FileErrors(ref errVal);
					val.set_Number(errVal);
					num6 = num5;
					goto IL_05a1;
					IL_05a1:
					num = 42;
					switch (num6)
					{
					case 1:
						break;
					case 0:
						goto IL_0510;
					default:
						goto IL_0556;
					case 3:
						goto IL_0598;
					case 2:
						goto end_IL_0000_2;
					}
					goto IL_03e9;
					IL_0598:
					num = 57;
					flag = false;
					goto IL_058d;
					IL_058d:
					num = 58;
					ErrorHandler.ShowError();
					goto IL_057b;
					IL_0556:
					num = 61;
					Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_INTERNALERROR"), (MsgBoxStyle)0, (object)null);
					ProjectData.EndApp();
					goto IL_057b;
					IL_0510:
					num = 46;
					((CommonDialog)frmAlias.DefInstance.cdgSave).ShowDialog();
					goto IL_0524;
					IL_0524:
					num = 47;
					sFilePath2 = ((FileDialog)frmAlias.DefInstance.cdgSave).get_FileName();
					sFileName2 = ((FileDialog)frmAlias.DefInstance.cdgSave).get_Title();
					SavePGP(ref sFilePath2, ref sFileName2, ref Suppress);
					goto IL_057b;
					IL_057b:
					num = 64;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_03e3;
					IL_03c3:
					num = 35;
					ChkApply();
					goto IL_03cc;
					IL_03e9:
					num = 50;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num4 = num2;
						goto IL_03fb;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_03cc:
					num = 36;
					if (!flag)
					{
						goto end_IL_0000_2;
					}
					goto IL_03d4;
					IL_03d4:
					num = 37;
					ReInit(ref Suppress);
					goto end_IL_0000_2;
					IL_0008:
					num = 2;
					flag = true;
					goto IL_000e;
					IL_000e:
					num = 3;
					sAliases = "";
					goto IL_001b;
					IL_001b:
					num = 4;
					sShells = "";
					goto IL_0028;
					IL_0028:
					num = 5;
					WhichTab = 0;
					sAliases = PGPString(ref WhichTab);
					goto IL_003a;
					IL_003a:
					num = 6;
					WhichTab = 1;
					sShells = PGPString(ref WhichTab);
					goto IL_004c;
					IL_004c:
					num = 7;
					if (Operators.CompareString(sSysAliases, "", false) == 0)
					{
						goto IL_0065;
					}
					goto IL_0181;
					IL_0065:
					num = 8;
					text = frmAlias.DefInstance.resManager.GetString("SAVE_HEADER1") + "\r\n" + frmAlias.DefInstance.resManager.GetString("SAVE_HEADER2") + DateAndTime.get_Today().ToShortDateString() + frmAlias.DefInstance.resManager.GetString("SAVE_HEADER3") + DateAndTime.get_TimeOfDay().ToShortTimeString() + "\r\n\r\n" + frmAlias.DefInstance.resManager.GetString("SAVE_HEADER4") + "\r\n\r\n" + frmAlias.DefInstance.resManager.GetString("SAVE_HEADER5") + "\r\n\r\n" + sShells + "\r\n\r\n" + frmAlias.DefInstance.resManager.GetString("SAVE_HEADER6") + "\r\n\r\n" + sAliases;
					goto IL_0257;
					IL_0181:
					num = 10;
					goto IL_0185;
					IL_0185:
					num = 11;
					text = frmAlias.DefInstance.resManager.GetString("SAVE_HEADER1") + "\r\n" + frmAlias.DefInstance.resManager.GetString("SAVE_HEADER2") + DateAndTime.get_Today().ToShortDateString() + frmAlias.DefInstance.resManager.GetString("SAVE_HEADER3") + DateAndTime.get_TimeOfDay().ToShortTimeString() + "\r\n\r\n" + frmAlias.DefInstance.resManager.GetString("SAVE_HEADER4") + "\r\n\r\n" + sAliases + "\r\n\r\n" + sShells;
					goto IL_0257;
					IL_0257:
					num = 13;
					if ((frmAlias.DefInstance.chkConfirm.get_CheckState() & (0 - (Exist(ref sFilePath) ? 1 : 0))) > 0)
					{
						goto IL_027d;
					}
					goto IL_0383;
					IL_027d:
					num = 14;
					text2 = Strings.Left(sFilePath, checked(Strings.Len(sFilePath) - Strings.Len(sFileName)));
					goto IL_0299;
					IL_0299:
					num = 15;
					if (Operators.CompareString(Strings.Left(sFileName, 10), "Backup of ", false) == 0)
					{
						goto IL_02b7;
					}
					goto IL_034f;
					IL_02b7:
					num = 16;
					num7 = checked(Strings.InStr(sFileName, "Backup(", (CompareMethod)0) + 8);
					goto IL_02cb;
					IL_02cb:
					num = 17;
					if (num7 > 8)
					{
						goto IL_02d3;
					}
					goto IL_02fd;
					IL_02d3:
					num = 18;
					num8 = checked((short)(Conversions.ToShort(Strings.Mid(sFileName, num7, 1)) + 1));
					goto IL_02e9;
					IL_02e9:
					num = 19;
					StringType.MidStmtStr(ref sFileName, num7, 1, Conversions.ToString((int)num8));
					goto IL_0322;
					IL_02fd:
					num = 21;
					goto IL_0301;
					IL_0301:
					num = 22;
					sFileName = "Backup(1) of " + Strings.Right(sFileName, checked(Strings.Len(sFileName) - 10));
					goto IL_0322;
					IL_0322:
					num = 24;
					sFilePath2 = text2 + sFileName;
					WS = sBackup;
					WriteOut(ref sFilePath2, ref WS);
					sBackup = Conversions.ToString(WS);
					goto IL_0383;
					IL_034f:
					num = 26;
					goto IL_0353;
					IL_0353:
					num = 27;
					sFilePath2 = text2 + "Backup of " + sFileName;
					WS = sBackup;
					WriteOut(ref sFilePath2, ref WS);
					sBackup = Conversions.ToString(WS);
					goto IL_0383;
					IL_0383:
					num = 30;
					WS = text;
					WriteOut(ref sFilePath, ref WS);
					text = Conversions.ToString(WS);
					goto IL_039a;
					IL_039a:
					num = 31;
					sFileInMemory = sFilePath;
					goto IL_03a5;
					IL_03a5:
					num = 32;
					sFname = sFileName;
					goto IL_03b0;
					IL_03b0:
					num = 33;
					nChange = 0;
					goto IL_03ba;
					IL_03ba:
					num = 34;
					CleanUpForm();
					goto IL_03c3;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1552;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void CleanUpForm()
	{
		frmAlias defInstance = frmAlias.DefInstance;
		((Control)defInstance.lblProgress).set_Visible(false);
		((Form)defInstance).set_Text(frmAlias.DefInstance.resManager.GetString("STR_MAINTITLE"));
		if (Operators.CompareString(sFname, "", false) != 0)
		{
			((Form)defInstance).set_Text(Path.GetFileName(sFname) + " - " + frmAlias.DefInstance.resManager.GetString("STR_MAINTITLE"));
		}
		defInstance = null;
	}

	public static string PGPString(ref short WhichTab)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						text = "";
						string text2 = "                                        ";
						Cursor.set_Current(Cursors.get_WaitCursor());
						ListView val = (ListView)frmAlias.DefInstance.lvwAlias[WhichTab];
						ListViewItemCollection items = val.get_Items();
						val.Sort();
						short[] array = new short[3];
						switch (WhichTab)
						{
						case 0:
						{
							if (Operators.CompareString(sSysAliases, "", false) == 0)
							{
								short num10 = (short)(val.get_Items().get_Count() - 1);
								for (short num4 = 0; num4 <= num10; num4 = (short)unchecked(num4 + 1))
								{
									string text3 = val.get_Items().get_Item(unchecked((int)num4)).get_Text();
									short num6 = (short)(10 - Strings.Len(text3));
									if (num6 < 0)
									{
										num6 = 1;
									}
									if (Operators.CompareString(text3, "---", false) != 0)
									{
										text = unchecked(text + text3 + "," + Strings.Left(text2, (int)num6) + "*" + val.get_Items().get_Item((int)num4).get_SubItems()
											.get_Item(1)
											.get_Text()) + "\r\n";
									}
								}
								break;
							}
							text = sSysAliases;
							if (nUserDefTotalAlias < 0)
							{
								break;
							}
							short num11 = (short)(sUserDefAlias.Length - 1);
							for (short num4 = 0; num4 <= num11; num4 = (short)unchecked(num4 + 1))
							{
								string text3 = sUserDefAlias[num4];
								short num6 = (short)(10 - Strings.Len(text3));
								if (num6 < 0)
								{
									num6 = 1;
								}
								if (Operators.CompareString(text3, "---", false) != 0)
								{
									text = text + text3 + "," + Strings.Left(text2, unchecked((int)num6)) + "*" + sUserDefRep[num4] + "\r\n";
								}
							}
							break;
						}
						case 1:
							array[1] = 0;
							array[2] = 0;
							if (Operators.CompareString(sSysAliases, "", false) == 0)
							{
								short num3 = (short)(items.get_Count() - 1);
								for (short num4 = 0; num4 <= num3; num4 = (short)unchecked(num4 + 1))
								{
									if (Strings.Len(items.get_Item(unchecked((int)num4)).get_Text()) > array[1])
									{
										array[1] = (short)Strings.Len(items.get_Item(unchecked((int)num4)).get_Text());
									}
									if (Strings.Len(items.get_Item(unchecked((int)num4)).get_SubItems().get_Item(1)
										.get_Text()) > array[2])
									{
										array[2] = (short)Strings.Len(items.get_Item(unchecked((int)num4)).get_SubItems().get_Item(1)
											.get_Text());
									}
								}
								short num5 = (short)(items.get_Count() - 1);
								for (short num4 = 0; num4 <= num5; num4 = (short)unchecked(num4 + 1))
								{
									string text3;
									string text4;
									unchecked
									{
										text3 = items.get_Item((int)num4).get_Text();
										text4 = "";
										if (Operators.CompareString(items.get_Item((int)num4).get_SubItems().get_Item(2)
											.get_Text(), "", false) != 0)
										{
											text4 = "*";
										}
									}
									short num6 = (short)(array[1] + 1 - Strings.Len(text3));
									short num7 = (short)(array[2] + 1 - Strings.Len(items.get_Item(unchecked((int)num4)).get_SubItems().get_Item(1)
										.get_Text()));
									if (Operators.CompareString(text3, "---", false) != 0)
									{
										text = unchecked(text + text3 + "," + Strings.Left(text2, (int)num6) + items.get_Item((int)num4).get_SubItems().get_Item(1)
											.get_Text() + "," + Strings.Left(text2, (int)num7) + items.get_Item((int)num4).get_SubItems().get_Item(2)
											.get_Text() + "," + text4 + items.get_Item((int)num4).get_SubItems().get_Item(3)
											.get_Text()) + ",\r\n";
									}
								}
							}
							else
							{
								if (nUserDefTotalShell < 0)
								{
									break;
								}
								short num8 = (short)(sUserDefShell.Length - 1);
								for (short num4 = 0; num4 <= num8; num4 = (short)unchecked(num4 + 1))
								{
									if (Strings.Len(sUserDefShell[num4]) > array[1])
									{
										array[1] = (short)Strings.Len(sUserDefShell[num4]);
									}
									if (Strings.Len(sUserDefCommand[num4]) > array[2])
									{
										array[2] = (short)Strings.Len(sUserDefCommand[num4]);
									}
								}
								short num9 = (short)(sUserDefShell.Length - 1);
								for (short num4 = 0; num4 <= num9; num4 = (short)unchecked(num4 + 1))
								{
									string text3 = sUserDefShell[num4];
									string text4 = "";
									if (Operators.CompareString(sUserDefPrompt[num4], "", false) != 0)
									{
										text4 = "*";
									}
									short num6 = (short)(array[1] + 1 - Strings.Len(text3));
									short num7 = (short)(array[2] + 1 - Strings.Len(sUserDefCommand[num4]));
									if (Operators.CompareString(text3, "---", false) != 0)
									{
										text = unchecked(text + text3 + "," + Strings.Left(text2, (int)num6) + sUserDefCommand[num4] + "," + Strings.Left(text2, (int)num7)) + sUserDefFlag[num4] + "," + text4 + sUserDefPrompt[num4] + ",\r\n";
									}
								}
							}
							break;
						}
						Cursor.set_Current(Cursors.get_Default());
						goto end_IL_0000;
					}
					case 1482:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor.set_Current(Cursors.get_Default());
							Interaction.MsgBox((object)("Error in PGPString" + Conversion.Str((object)Information.Err().get_Number()) + ": " + Information.Err().get_Description()), (MsgBoxStyle)0, (object)null);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_0604;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1482;
				continue;
			}
			break;
			IL_0604:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ShowDialog(ref Form sWhichForm)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		Form val = sWhichForm;
		checked
		{
			((Control)val).set_Left((int)Math.Round((double)((Control)frmAlias.DefInstance).get_Left() + (double)(((Control)frmAlias.DefInstance).get_Width() - ((Control)val).get_Width()) / 2.0));
			((Control)val).set_Top((int)Math.Round((double)((Control)frmAlias.DefInstance).get_Top() + (double)(((Control)frmAlias.DefInstance).get_Height() - ((Control)val).get_Height()) / 2.0));
			val.ShowDialog();
		}
	}

	public static void WriteOut(ref string FN, ref object WS)
	{
		FileSystem.FileClose(new int[0]);
		int num = FileSystem.FreeFile();
		FileSystem.FileOpen(num, FN, (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.PrintLine(num, new object[1] { RuntimeHelpers.GetObjectValue(WS) });
		FileSystem.FileClose(new int[0]);
	}

	public static bool IsAlphaNumeric(string vsAlpha)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		bool flag = default(bool);
		int num2 = default(int);
		int num3 = default(int);
		short num5 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					flag = false;
					goto IL_0005;
				case 128:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0005;
						case 3:
							goto IL_000c;
						case 4:
							goto IL_0017;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0017:
					num = 4;
					if (!((num5 >= 48 && num5 <= 57) || (num5 >= 65 && num5 <= 90) || (num5 >= 97 && num5 <= 122)))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0005:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_000c;
					IL_000c:
					num = 3;
					num5 = checked((short)Strings.Asc(vsAlpha));
					goto IL_0017;
					end_IL_0000_2:
					break;
				}
				num = 5;
				flag = true;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 128;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool isAcadPGPFile(int FileNum)
	{
		bool result = false;
		string text = "";
		while (!FileSystem.EOF(FileNum))
		{
			string text2 = FileSystem.LineInput(FileNum);
			if (text2.IndexOf("This PGP file was created with the AutoCAD Alias Editor.") >= 0)
			{
				int num = 0;
				do
				{
					text2 = FileSystem.LineInput(FileNum);
					num = checked(num + 1);
				}
				while (num <= 4);
			}
			text = text + text2 + "\r\n";
			if ((text2.IndexOf("**********----------**********") >= 0) | (text2.IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINED")!.Trim()) >= 0) | (text2.IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDDEU")!.Trim()) >= 0) | (text2.IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDFRA")!.Trim()) >= 0) | (text2.IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDITA")!.Trim()) >= 0) | (text2.IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDESP")!.Trim()) >= 0) | (text2.IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDPTB")!.Trim()) >= 0) | (text2.IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDRUS")!.Trim()) >= 0) | (text2.IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDPLK")!.Trim()) >= 0))
			{
				result = true;
				text2 = FileSystem.LineInput(FileNum);
				while (((text2.IndexOf(";") == 0) | (Operators.CompareString(Strings.Trim(text2), "", false) == 0)) & !FileSystem.EOF(FileNum))
				{
					text = text + text2 + "\r\n";
					text2 = FileSystem.LineInput(FileNum);
				}
				if (FileSystem.EOF(FileNum) & (Operators.CompareString(text2, "", false) == 0))
				{
					sSysAliases = sSysAliases + text + text2 + "\r\n";
				}
				else
				{
					sSysAliases += text;
				}
				text = text2 + "\r\n";
			}
		}
		FileSystem.Seek(FileNum, 1L);
		return result;
	}

	public static void ParsePGPNew(int FileNum, ref bool Import)
	{
		string[] array = new string[1];
		int num = -1;
		int num2 = -1;
		if (!Import)
		{
			sBackup = "";
		}
		checked
		{
			while (!FileSystem.EOF(FileNum))
			{
				num++;
				array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
				array[num] = FileSystem.LineInput(FileNum);
				if ((array[num].IndexOf("**********----------**********") >= 0) | (array[num].IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINED")!.Trim()) >= 0) | (array[num].IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDDEU")!.Trim()) >= 0) | (array[num].IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDFRA")!.Trim()) >= 0) | (array[num].IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDITA")!.Trim()) >= 0) | (array[num].IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDESP")!.Trim()) >= 0) | (array[num].IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDPTB")!.Trim()) >= 0) | (array[num].IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDRUS")!.Trim()) >= 0) | (array[num].IndexOf(frmAlias.DefInstance.resManager.GetString("STR_USERDEFINEDPLK")!.Trim()) >= 0))
				{
					num2 = num;
				}
				if (!Import)
				{
					sBackup = sBackup + array[num] + "\r\n";
				}
				if (Operators.CompareString(Strings.Trim(array[num]), "", false) == 0)
				{
					num--;
				}
				else if ((Strings.Asc(array[num]) == 59) | (Strings.Asc(array[num]) < 32))
				{
					num--;
				}
			}
			FileSystem.FileClose(new int[0]);
			int num3 = default(int);
			if (Import)
			{
				num2 = 0;
				num3 = nUserDefTotalAlias;
			}
			else
			{
				nUserDefTotalAlias = -1;
				nUserDefTotalShell = -1;
			}
			string[] array2 = (string[])Utils.CopyArray((Array)array2, (Array)new string[num + 1 + 1]);
			string[] array3 = (string[])Utils.CopyArray((Array)array3, (Array)new string[num + 1 + 1]);
			string[] array4 = (string[])Utils.CopyArray((Array)array4, (Array)new string[num + 1 + 1]);
			string[] array5 = (string[])Utils.CopyArray((Array)array5, (Array)new string[num + 1 + 1]);
			short num4 = 0;
			nTotalAlias = -1;
			nTotalShell = -1;
			int num8 = default(int);
			while (num4 <= num)
			{
				int num5 = Strings.InStr(1, array[num4], ",", (CompareMethod)0);
				if (num5 == 0)
				{
					string[] array6 = array3;
					short num6 = num4;
					string x = "$";
					array6[num6] = BogusString(ref x);
					array2[num4] = array[num4];
					nTotalAlias++;
				}
				else if (num5 == Strings.Len(array[num4]))
				{
					array3[num4] = array[num4];
					string[] array7 = array2;
					short num7 = num4;
					string x = "?";
					array7[num7] = BogusString(ref x);
					nTotalAlias++;
				}
				else
				{
					num8 = Strings.InStr(num5 + 1, array[num4], ",", (CompareMethod)0);
					if (num8 == 0)
					{
						nTotalAlias++;
						array3[nTotalAlias] = Strings.Left(array[num4], num5 - 1);
						array2[nTotalAlias] = Strings.Right(array[num4], Strings.Len(array[num4]) - num5);
					}
					else
					{
						nTotalShell++;
						sShell = (string[])Utils.CopyArray((Array)sShell, (Array)new string[nTotalShell + 1]);
						sCommand = (string[])Utils.CopyArray((Array)sCommand, (Array)new string[nTotalShell + 1]);
						sFlag = (string[])Utils.CopyArray((Array)sFlag, (Array)new string[nTotalShell + 1]);
						sPrompt = (string[])Utils.CopyArray((Array)sPrompt, (Array)new string[nTotalShell + 1]);
						sCode = (string[])Utils.CopyArray((Array)sCode, (Array)new string[nTotalShell + 1]);
						int num9 = Strings.InStr(num8 + 1, array[num4], ",", (CompareMethod)0);
						short num10 = (short)Strings.InStr(num9 + 1, array[num4], ",", (CompareMethod)0);
						sShell[nTotalShell] = Strings.Left(array[num4], num5 - 1);
						if (num8 == 1 + num5)
						{
							sCommand[nTotalShell] = "";
						}
						else
						{
							sCommand[nTotalShell] = Strings.Mid(array[num4], num5 + 1, num8 - (num5 + 1));
						}
						unchecked
						{
							if (num9 == checked(1 + num8) || num8 == 0)
							{
								sFlag[nTotalShell] = "";
							}
							else
							{
								sFlag[nTotalShell] = checked(Strings.Mid(array[num4], num8 + 1, num9 - (num8 + 1)));
							}
							if (num10 == checked(1 + num9) || num9 == 0)
							{
								sPrompt[nTotalShell] = "";
							}
							else
							{
								checked
								{
									sPrompt[nTotalShell] = Strings.Mid(array[num4], num9 + 1, num10 - (num9 + 1));
									if (Operators.CompareString(Strings.Left(sPrompt[nTotalShell], 1), "*", false) == 0)
									{
										sPrompt[nTotalShell] = Strings.Right(sPrompt[nTotalShell], Strings.Len(sPrompt[nTotalShell]) - 1);
									}
								}
							}
						}
						if (num10 == 0)
						{
							sCode[nTotalShell] = "";
						}
						else
						{
							sCode[nTotalShell] = Strings.Right(array[num4], Strings.Len(array[num4]) - num10);
						}
					}
				}
				if (num4 >= num2)
				{
					if (num8 == 0)
					{
						nUserDefTotalAlias++;
						array5[nUserDefTotalAlias] = array3[nTotalAlias];
						array4[nUserDefTotalAlias] = array2[nTotalAlias];
					}
					else
					{
						nUserDefTotalShell++;
						sUserDefShell = (string[])Utils.CopyArray((Array)sUserDefShell, (Array)new string[nUserDefTotalShell + 1]);
						sUserDefCommand = (string[])Utils.CopyArray((Array)sUserDefCommand, (Array)new string[nUserDefTotalShell + 1]);
						sUserDefFlag = (string[])Utils.CopyArray((Array)sUserDefFlag, (Array)new string[nUserDefTotalShell + 1]);
						sUserDefPrompt = (string[])Utils.CopyArray((Array)sUserDefPrompt, (Array)new string[nUserDefTotalShell + 1]);
						sUserDefShell[nUserDefTotalShell] = sShell[nTotalShell];
						sUserDefCommand[nUserDefTotalShell] = sCommand[nTotalShell];
						sUserDefFlag[nUserDefTotalShell] = sFlag[nTotalShell];
						sUserDefPrompt[nUserDefTotalShell] = sPrompt[nTotalShell];
					}
				}
				num4 = (short)(num4 + 1);
			}
			sAlias = (string[])Utils.CopyArray((Array)sAlias, (Array)new string[nTotalAlias + 1]);
			sRep = (string[])Utils.CopyArray((Array)sRep, (Array)new string[nTotalAlias + 1]);
			sUserDefAlias = (string[])Utils.CopyArray((Array)sUserDefAlias, (Array)new string[nUserDefTotalAlias + 1]);
			sUserDefRep = (string[])Utils.CopyArray((Array)sUserDefRep, (Array)new string[nUserDefTotalAlias + 1]);
			for (num4 = 0; num4 <= nTotalAlias; num4 = (short)(num4 + 1))
			{
				array2[num4] = Strings.Trim(array2[num4]);
				while (((Strings.Asc(array2[num4]) <= 42) | (Strings.Asc(array2[num4]) > 122)) & (Strings.Len(array2[num4]) > 1))
				{
					array2[num4] = Strings.Right(array2[num4], Strings.Len(array2[num4]) - 1);
				}
				sRep[num4] = array2[num4];
				sAlias[num4] = array3[num4];
				if (Operators.CompareString(sAlias[num4], "", false) == 0)
				{
					sAlias[num4] = "---";
				}
			}
			for (num4 = (short)num3; num4 <= nUserDefTotalAlias; num4 = (short)(num4 + 1))
			{
				if (!Information.IsNothing((object)array4[num4]))
				{
					array4[num4] = Strings.Trim(array4[num4]);
					while (((Strings.Asc(array4[num4]) <= 42) | (Strings.Asc(array4[num4]) > 122)) & (Strings.Len(array4[num4]) > 1))
					{
						array4[num4] = Strings.Right(array4[num4], Strings.Len(array4[num4]) - 1);
					}
					sUserDefRep[num4] = array4[num4].ToUpper();
					sUserDefAlias[num4] = array5[num4].ToUpper();
					if (Operators.CompareString(sUserDefAlias[num4], "", false) == 0)
					{
						sUserDefAlias[num4] = "---";
					}
				}
			}
		}
	}

	public static void ParsePGPOld(int FileNum, ref bool Import)
	{
		string[] array = new string[1];
		int num = -1;
		if (!Import)
		{
			sBackup = "";
		}
		checked
		{
			while (!FileSystem.EOF(FileNum))
			{
				num++;
				array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
				array[num] = FileSystem.LineInput(FileNum);
				if (!Import)
				{
					sBackup = sBackup + array[num] + "\r\n";
				}
				if (Operators.CompareString(Strings.Trim(array[num]), "", false) == 0)
				{
					num--;
				}
				else if ((Strings.Asc(array[num]) == 59) | (Strings.Asc(array[num]) < 32))
				{
					num--;
				}
			}
			FileSystem.FileClose(new int[0]);
			string[] array2 = (string[])Utils.CopyArray((Array)array2, (Array)new string[num + 1 + 1]);
			string[] array3 = (string[])Utils.CopyArray((Array)array3, (Array)new string[num + 1 + 1]);
			short num2 = 0;
			nTotalAlias = -1;
			nTotalShell = -1;
			while (num2 <= num)
			{
				int num3 = Strings.InStr(1, array[num2], ",", (CompareMethod)0);
				if (num3 == 0)
				{
					string[] array4 = array3;
					short num4 = num2;
					string x = "$";
					array4[num4] = BogusString(ref x);
					array2[num2] = array[num2];
					nTotalAlias++;
				}
				else if (num3 == Strings.Len(array[num2]))
				{
					array3[num2] = array[num2];
					string[] array5 = array2;
					short num5 = num2;
					string x = "?";
					array5[num5] = BogusString(ref x);
					nTotalAlias++;
				}
				else
				{
					int num6 = Strings.InStr(num3 + 1, array[num2], ",", (CompareMethod)0);
					if (num6 == 0)
					{
						nTotalAlias++;
						array3[nTotalAlias] = Strings.Left(array[num2], num3 - 1);
						array2[nTotalAlias] = Strings.Right(array[num2], Strings.Len(array[num2]) - num3);
					}
					else
					{
						nTotalShell++;
						sShell = (string[])Utils.CopyArray((Array)sShell, (Array)new string[nTotalShell + 1]);
						sCommand = (string[])Utils.CopyArray((Array)sCommand, (Array)new string[nTotalShell + 1]);
						sFlag = (string[])Utils.CopyArray((Array)sFlag, (Array)new string[nTotalShell + 1]);
						sPrompt = (string[])Utils.CopyArray((Array)sPrompt, (Array)new string[nTotalShell + 1]);
						sCode = (string[])Utils.CopyArray((Array)sCode, (Array)new string[nTotalShell + 1]);
						int num7 = Strings.InStr(num6 + 1, array[num2], ",", (CompareMethod)0);
						short num8 = (short)Strings.InStr(num7 + 1, array[num2], ",", (CompareMethod)0);
						sShell[nTotalShell] = Strings.Left(array[num2], num3 - 1);
						if (num6 == 1 + num3)
						{
							sCommand[nTotalShell] = "";
						}
						else
						{
							sCommand[nTotalShell] = Strings.Mid(array[num2], num3 + 1, num6 - (num3 + 1));
						}
						unchecked
						{
							if (num7 == checked(1 + num6) || num6 == 0)
							{
								sFlag[nTotalShell] = "";
							}
							else
							{
								sFlag[nTotalShell] = checked(Strings.Mid(array[num2], num6 + 1, num7 - (num6 + 1)));
							}
							if (num8 == checked(1 + num7) || num7 == 0)
							{
								sPrompt[nTotalShell] = "";
							}
							else
							{
								checked
								{
									sPrompt[nTotalShell] = Strings.Mid(array[num2], num7 + 1, num8 - (num7 + 1));
									if (Operators.CompareString(Strings.Left(sPrompt[nTotalShell], 1), "*", false) == 0)
									{
										sPrompt[nTotalShell] = Strings.Right(sPrompt[nTotalShell], Strings.Len(sPrompt[nTotalShell]) - 1);
									}
								}
							}
						}
						if (num8 == 0)
						{
							sCode[nTotalShell] = "";
						}
						else
						{
							sCode[nTotalShell] = Strings.Right(array[num2], Strings.Len(array[num2]) - num8);
						}
					}
				}
				num2 = (short)(num2 + 1);
			}
			sAlias = (string[])Utils.CopyArray((Array)sAlias, (Array)new string[nTotalAlias + 1]);
			sRep = (string[])Utils.CopyArray((Array)sRep, (Array)new string[nTotalAlias + 1]);
			for (num2 = 0; num2 <= nTotalAlias; num2 = (short)(num2 + 1))
			{
				array2[num2] = Strings.Trim(array2[num2]);
				while (((Strings.Asc(array2[num2]) <= 42) | (Strings.Asc(array2[num2]) > 122)) & (Strings.Len(array2[num2]) > 1))
				{
					array2[num2] = Strings.Right(array2[num2], Strings.Len(array2[num2]) - 1);
				}
				sRep[num2] = array2[num2];
				sAlias[num2] = array3[num2];
				if (Operators.CompareString(sAlias[num2], "", false) == 0)
				{
					sAlias[num2] = "---";
				}
			}
		}
	}

	public static void ParsePGP(ref string FileName, ref bool Import)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num6 = default(short);
		int num7 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				ErrObject val;
				int errVal;
				short num5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 517:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						case 2:
							goto IL_019c;
						default:
							goto end_IL_0000;
						}
						goto IL_0143;
					}
					IL_0143:
					num4 = num2 + 1;
					goto IL_0061;
					IL_0061:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0011;
					case 4:
						goto IL_0020;
					case 5:
						goto IL_002e;
					case 7:
						goto IL_003d;
					case 8:
						goto IL_0040;
					case 18:
					case 19:
						goto IL_004f;
					default:
						goto end_IL_0000;
					case 14:
					case 16:
						goto IL_0102;
					case 31:
					case 32:
						goto IL_010e;
					case 13:
					case 17:
					case 20:
					case 21:
					case 25:
					case 26:
					case 30:
					case 33:
					case 34:
					case 35:
						goto IL_0133;
					case 24:
						goto IL_014c;
					case 22:
					case 23:
						goto IL_015b;
					case 12:
						goto IL_017d;
					case 11:
						goto IL_019c;
					case 0:
					case 15:
						goto end_IL_0000;
					case 27:
					case 28:
						goto end_IL_0000_2;
					case 6:
					case 9:
					case 10:
					case 29:
					case 36:
						goto end_IL_0000_3;
					}
					goto default;
					IL_019c:
					num = 11;
					val = Information.Err();
					errVal = val.get_Number();
					num5 = ErrorHandler.FileErrors(ref errVal);
					val.set_Number(errVal);
					num6 = num5;
					goto IL_017d;
					IL_017d:
					num = 12;
					switch (num6)
					{
					case 1:
						break;
					case 0:
						goto IL_0102;
					default:
						goto IL_010e;
					case 2:
						goto IL_015b;
					case 3:
						goto end_IL_0000_2;
					}
					goto IL_004f;
					IL_015b:
					num = 23;
					Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_PGPERR1"), (MsgBoxStyle)0, (object)null);
					goto IL_014c;
					IL_014c:
					num = 24;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_0143;
					IL_002e:
					num = 5;
					ParsePGPNew(num7, ref Import);
					goto end_IL_0000_3;
					IL_010e:
					num = 32;
					Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_INTERNALERROR"), (MsgBoxStyle)0, (object)null);
					ProjectData.EndApp();
					goto IL_0133;
					IL_0102:
					num = 16;
					GetPath();
					goto IL_0133;
					IL_0133:
					num = 35;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_0143;
					IL_0020:
					num = 4;
					if (isAcadPGPFile(num7) | Import)
					{
						goto IL_002e;
					}
					goto IL_003d;
					IL_004f:
					num = 19;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num4 = num2;
						goto IL_0061;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_003d:
					num = 7;
					goto IL_0040;
					IL_0040:
					num = 8;
					ParsePGPOld(num7, ref Import);
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					num7 = FileSystem.FreeFile();
					goto IL_0011;
					IL_0011:
					num = 3;
					FileSystem.FileOpen(num7, FileName, (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_0020;
					end_IL_0000_2:
					break;
				}
				num = 28;
				Interaction.MsgBox((object)frmAlias.DefInstance.resManager.GetString("STR_PGPERR2"), (MsgBoxStyle)0, (object)null);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 517;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void FillInAllCommands()
	{
		nStdRep = 1000;
		checked
		{
			sRep = (string[])Utils.CopyArray((Array)sRep, (Array)new string[nStdRep + 1]);
			short num = 0;
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string cmd = "";
			string cmdFile = GetCmdFile(ref cmd);
			if (Operators.CompareString(cmdFile, "", false) == 0)
			{
				return;
			}
			FileSystem.FileOpen(1, cmdFile, (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
			while (!FileSystem.EOF(1))
			{
				FileSystem.Input(1, ref text5);
				if (num > nStdRep)
				{
					nStdRep += 500;
					sRep = (string[])Utils.CopyArray((Array)sRep, (Array)new string[nStdRep + 1]);
				}
				string text7 = Strings.LCase(Strings.Left(text5, 2));
				if (Operators.CompareString(text7, "#i", false) == 0)
				{
					text5 = Strings.Trim(Strings.Right(text5, Strings.Len(text5) - 9));
					short num2 = (short)Strings.Len(text5);
					text = Strings.Left(Strings.Right(text5, num2 - 1), num2 - 2);
					text2 = GetCmdFile(ref text);
					if (Operators.CompareString(text2, "", false) != 0)
					{
						FileSystem.FileOpen(2, text2, (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
						while (!FileSystem.EOF(2))
						{
							FileSystem.Input(2, ref text6);
							if (Operators.CompareString(Strings.UCase(text6), Strings.UCase(text3), false) != 0)
							{
								sRep[num] = text6;
								num = (short)(num + 1);
							}
							text3 = text6;
						}
						FileSystem.FileClose(new int[1] { 2 });
					}
				}
				else if (Operators.CompareString(text7, "//", false) != 0 && Operators.CompareString(Strings.UCase(text5), Strings.UCase(text4), false) != 0)
				{
					sRep[num] = text5;
					num = (short)(num + 1);
				}
				text4 = text5;
			}
			FileSystem.FileClose(new int[1] { 1 });
			sRep = (string[])Utils.CopyArray((Array)sRep, (Array)new string[num + 1]);
			frmNewAlias.DefInstance.cmbRep.get_Items().Clear();
			short num3 = (short)(num - 1);
			for (short num4 = 0; num4 <= num3; num4 = (short)unchecked(num4 + 1))
			{
				frmNewAlias.DefInstance.cmbRep.get_Items().Add((object)sRep[num4]);
			}
		}
	}

	public static string GetCmdFile(ref string cmd = "")
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		string F;
		if (Operators.CompareString(cmd, "", false) != 0)
		{
			F = cmd;
			if (!Exist(ref F))
			{
				F = Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\" + cmd;
			}
		}
		else
		{
			F = Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\alias.pgc";
		}
		if (!Exist(ref F))
		{
			Interaction.MsgBox((object)(frmAlias.DefInstance.resManager.GetString("STR_SUPPORT1") + F + frmAlias.DefInstance.resManager.GetString("STR_SUPPORT2")), (MsgBoxStyle)0, (object)frmAlias.DefInstance.resManager.GetString("STR_FNFTITLE"));
			F = "";
		}
		return F;
	}

	public static string BogusString(ref string x)
	{
		string text = "";
		checked
		{
			_0024STATIC_0024BogusString_002401E10E_0024Length++;
			short num = _0024STATIC_0024BogusString_002401E10E_0024Length;
			for (short num2 = 1; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				text += x;
			}
			return text;
		}
	}

	public static string Capitalize(ref string CapString)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		string text;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						short num3 = (short)Strings.Len(CapString);
						short num4 = 1;
						while (num4 <= num3)
						{
							if (!unchecked((Strings.Asc(Strings.Mid(CapString, (int)num4, 1)) > 96) & (Strings.Asc(Strings.Mid(CapString, (int)num4, 1)) < 123)))
							{
								if (!unchecked((Strings.Asc(Strings.Mid(CapString, (int)num4, 1)) > 64) & (Strings.Asc(Strings.Mid(CapString, (int)num4, 1)) < 91)))
								{
									num4 = (short)unchecked(num4 + 1);
									continue;
								}
								text = CapString;
								break;
							}
							StringType.MidStmtStr(ref CapString, unchecked((int)num4), 1, Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(CapString, unchecked((int)num4), 1)) - 32)));
							break;
						}
						text = CapString;
						goto end_IL_0000;
					}
					case 163:
						num = -1;
						switch (num2)
						{
						case 2:
							text = "";
							goto end_IL_0000;
						}
						break;
					}
					goto IL_00dd;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 163;
				continue;
			}
			break;
			IL_00dd:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
