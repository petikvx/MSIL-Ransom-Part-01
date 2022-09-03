using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

public class GClass1
{
	public enum GEnum0
	{
		const_0 = 4,
		const_1 = 2,
		const_2 = 1,
		const_3 = 5,
		const_4 = 3
	}

	private const int int_0 = 101;

	private const int int_1 = 0;

	private const int int_2 = 100;

	private IntPtr intptr_0;

	public GClass1()
	{
		intptr_0 = IntPtr.Zero;
	}

	public GClass1(string string_0)
	{
		method_5(string_0);
	}

	public void method_0()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			sqlite3_close(intptr_0);
		}
	}

	public void method_1(string string_0)
	{
		sqlite3_exec(intptr_0, method_9(string_0), IntPtr.Zero, IntPtr.Zero, out var intptr_);
		if (intptr_ != IntPtr.Zero)
		{
			throw new Exception(GClass2.smethod_0("dŒɭͱѯԼ٬ݳ\u086d॰\u0a37୳౭൱\u0e70ཧၥᅹቡ፩ᐭᕢᙤᝤᠤ\u1979\u1a72᭣ᱷᵽḹἢ‣") + string_0 + GClass2.smethod_0("!ģȋ") + method_6(sqlite3_errmsg(intptr_)));
		}
	}

	public DataTable method_2(string string_0)
	{
		sqlite3_prepare_v2(intptr_0, method_9(string_0), method_3(method_9(string_0)), out var intptr_, out var _);
		DataTable dataTable_ = new DataTable();
		for (int num = method_7(intptr_, ref dataTable_); num == 100; num = method_8(intptr_, ref dataTable_))
		{
		}
		sqlite3_finalize(intptr_);
		return dataTable_;
	}

	private int method_3(IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return 0;
		}
		return lstrlen(intptr_1);
	}

	[DllImport("kernel32")]
	private static extern IntPtr GetProcessHeap();

	public ArrayList method_4()
	{
		string string_ = GClass2.smethod_0("âǵˣϫӮ\u05f8ڋ߄\u08c8\u09c5\u0ac2ஆ\u0ce3\u0df6\u0eec\u0fefႁᇓዮᏲᓴᗨ\u16fe\u17c5ᣴ᧹\u1ae4ᯢᳰ\u1de6ẳ\u1fc5\u20d9⇕⋝⏋⒭◸⛲⟺⣬⦨⫎⯈ⲥⶬ⺤⿶ム㇢㈓㌛㑚㕐㙜㜌㠐㤝㨀㭑㱜㵔㸲㼼䀵䅐䈁䌏䐀䔉䙋䜤䠦䤼䩇䬪䰬䴯並佂偆儓刮匲吴唨嘾圅塼奿娂嬘尜崛帝彲怐愜戃据搞攉昇朏栊検橧欨氤洩渦潢瀇焒牰獳琝畏癊睖硐祌穒筩籁絑繞罂聮腝艎荝葙蕉虙蜊衾襠詢譴豠贄蹗轛遑酅鈿鍗鑓锼阳霽顭饹驵魺鱰鴳鸿鼵ꁧꅹꉪꍹꐪꔥꘫꝅꡛ\ua94cꩂꭔ갥굆깚꼢뀰");
		DataTable dataTable = method_2(string_);
		ArrayList arrayList = new ArrayList();
		foreach (DataRow row in dataTable.Rows)
		{
			arrayList.Add(row.ItemArray[0]!.ToString());
		}
		return arrayList;
	}

	[DllImport("kernel32")]
	private static extern IntPtr HeapAlloc(IntPtr intptr_1, uint uint_0, uint uint_1);

	[DllImport("kernel32")]
	private static extern int lstrlen(IntPtr intptr_1);

	public void method_5(string string_0)
	{
		if (sqlite3_open(method_9(string_0), out intptr_0) != 0)
		{
			intptr_0 = IntPtr.Zero;
			throw new Exception(GClass2.smethod_0("YũɨͶѪԷ١ݼࡠॻਲ\u0b7eౠ൪\u0e60ཤ\u1062ᅬሪ፭ᑩᕳᙧᝧᡥᥰ\u1a67ᬡ") + string_0 + GClass2.smethod_0(" "));
		}
	}

	private string method_6(IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int num = method_3(intptr_1);
		byte[] array = new byte[num];
		Marshal.Copy(intptr_1, array, 0, num);
		return uTF.GetString(array, 0, num);
	}

	private int method_7(IntPtr intptr_1, ref DataTable dataTable_0)
	{
		dataTable_0 = new DataTable(GClass2.smethod_0("yůɺͽѫղ\u0651ݥࡡ८\u0a64"));
		if (sqlite3_step(intptr_1) == 100)
		{
			int num = sqlite3_column_count(intptr_1);
			string text = GClass2.smethod_0("");
			object[] array = new object[num];
			for (int i = 0; i < num; i++)
			{
				text = method_6(sqlite3_column_name(intptr_1, i));
				switch (sqlite3_column_type(intptr_1, i))
				{
				default:
					dataTable_0.Columns.Add(text, Type.GetType(GClass2.smethod_0("^ŵɸ;Ѭեةݕ\u0871ॶ੪୬౦")));
					array[i] = GClass2.smethod_0("");
					break;
				case 1:
					dataTable_0.Columns.Add(text, Type.GetType(GClass2.smethod_0("_Ųɹͽѭժب\u074cࡪॷ\u0a31ଳ")));
					array[i] = sqlite3_column_int(intptr_1, i);
					break;
				case 2:
					dataTable_0.Columns.Add(text, Type.GetType(GClass2.smethod_0("^ŵɸ;Ѭեةݕ\u086c४\u0a64୮\u0c64")));
					array[i] = sqlite3_column_double(intptr_1, i);
					break;
				case 3:
					dataTable_0.Columns.Add(text, Type.GetType(GClass2.smethod_0("^ŵɸ;Ѭեةݕ\u0871ॶ੪୬౦")));
					array[i] = method_6(sqlite3_column_text(intptr_1, i));
					break;
				case 4:
					dataTable_0.Columns.Add(text, Type.GetType(GClass2.smethod_0("^ŵɸ;Ѭեةݕ\u0871ॶ੪୬౦")));
					array[i] = method_6(sqlite3_column_blob(intptr_1, i));
					break;
				}
			}
			dataTable_0.Rows.Add(array);
		}
		return sqlite3_step(intptr_1);
	}

	private int method_8(IntPtr intptr_1, ref DataTable dataTable_0)
	{
		int num = sqlite3_column_count(intptr_1);
		object[] array = new object[num];
		for (int i = 0; i < num; i++)
		{
			switch (sqlite3_column_type(intptr_1, i))
			{
			default:
				array[i] = GClass2.smethod_0("");
				break;
			case 1:
				array[i] = sqlite3_column_int(intptr_1, i);
				break;
			case 2:
				array[i] = sqlite3_column_double(intptr_1, i);
				break;
			case 3:
				array[i] = method_6(sqlite3_column_text(intptr_1, i));
				break;
			case 4:
				array[i] = method_6(sqlite3_column_blob(intptr_1, i));
				break;
			}
		}
		dataTable_0.Rows.Add(array);
		return sqlite3_step(intptr_1);
	}

	[DllImport("sqlite3")]
	private static extern int sqlite3_close(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_blob(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_count(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern double sqlite3_column_double(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_int(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_name(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_table_name(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_text(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_type(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_errmsg(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern int sqlite3_exec(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, out IntPtr intptr_5);

	[DllImport("sqlite3")]
	private static extern int sqlite3_finalize(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern int sqlite3_open(IntPtr intptr_1, out IntPtr intptr_2);

	[DllImport("sqlite3")]
	private static extern int sqlite3_prepare_v2(IntPtr intptr_1, IntPtr intptr_2, int int_3, out IntPtr intptr_3, out IntPtr intptr_4);

	[DllImport("sqlite3")]
	private static extern int sqlite3_step(IntPtr intptr_1);

	private IntPtr method_9(string string_0)
	{
		if (string_0 == null)
		{
			return IntPtr.Zero;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		int uint_ = bytes.Length + 1;
		IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, (uint)uint_);
		Marshal.Copy(bytes, 0, intPtr, bytes.Length);
		Marshal.WriteByte(intPtr, bytes.Length, 0);
		return intPtr;
	}
}
