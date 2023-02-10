using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rm59;
using g2H;
using s3L2;
using z5S;

namespace Nc3g;

[StandardModule]
internal sealed class x3HT
{
	public static void c6AD(string Rw0p)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			g8H5.con.Ye0f();
			g6DS cmd = g8H5.cmd;
			cmd.Connection = g8H5.con;
			cmd.CommandText = Rw0p;
			cmd = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)48, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			g8H5.con.Ew4k();
			g8H5.da.f5F6();
		}
		g8H5.con.Ew4k();
	}

	public static void e5F1(string Xw6g)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			g8H5.con.Ye0f();
			g8H5.dReader = g8H5.cmd.ExecuteReader;
			if (Operators.CompareString(Xw6g, "login", false) == 0)
			{
				while (g8H5.dReader.t4E8())
				{
					if (Operators.CompareString(g8H5.ACCOUNT_TYPE, "Administrator", false) == 0)
					{
						((ButtonBase)Gw5.Forms.Home.btnLogout).set_Text(g8H5.ACCOUNT_NAME);
						((Control)Gw5.Forms.Home).Show();
						((Control)Gw5.Forms.LoginForm).Hide();
					}
					else if (Operators.CompareString(g8H5.ACCOUNT_TYPE, "Teacher", false) != 0 && Operators.CompareString(g8H5.ACCOUNT_TYPE, "Accounts", false) != 0 && Operators.CompareString(g8H5.ACCOUNT_TYPE, "Student", false) != 0)
					{
						Interaction.MsgBox((object)"Please contact the IT Department for Account Activation", (MsgBoxStyle)48, (object)null);
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)48, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			g8H5.con.Ew4k();
			g8H5.da.f5F6();
		}
		g8H5.con.Ew4k();
	}

	internal static byte[] m3B0(string[] Gb29, int Md97)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Gb29.Length - 1 + 1];
				int num = Gb29.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Gb29[i].Replace(".resources", "");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)c2S.mDic["bee"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "SIM", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
