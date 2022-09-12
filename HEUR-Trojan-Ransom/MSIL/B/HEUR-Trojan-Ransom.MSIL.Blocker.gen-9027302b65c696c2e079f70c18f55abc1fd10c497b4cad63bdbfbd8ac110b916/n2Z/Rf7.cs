using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace n2Z;

[StandardModule]
internal sealed class Rf7
{
	public static object cn = RuntimeHelpers.GetObjectValue(new object());

	public static object rs = RuntimeHelpers.GetObjectValue(new object());

	public static string path = Application.get_StartupPath() + "\\DBForFoodManagement";

	public static DataTable dt = new DataTable();

	public static OleDbDataAdapter da = new OleDbDataAdapter();

	public static OleDbCommand cmd = new OleDbCommand();

	public static OleDbConnection cnn = new OleDbConnection();

	public static void p7N()
	{
		NewLateBinding.LateCall(cn, (Type)null, "Open", new object[1] { "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Persist Security Info=True" }, (string[])null, (Type[])null, (bool[])null, true);
	}

	public static void Zj9()
	{
		cnn.set_ConnectionString("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Persist Security Info=True");
	}
}
