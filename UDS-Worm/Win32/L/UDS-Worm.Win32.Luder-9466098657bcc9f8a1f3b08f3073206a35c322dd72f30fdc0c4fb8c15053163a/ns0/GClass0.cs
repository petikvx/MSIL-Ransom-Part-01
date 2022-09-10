using System;
using System.Reflection;
using System.Windows.Forms;
using ns4;

namespace ns0;

[GAttribute0(1)]
public sealed class GClass0
{
	public static bool smethod_0()
	{
		DateTime dateTime = DateTime.Parse("〲㈱\u302dⴷ\u3130ご㨰〰〺");
		if (DateTime.Now > dateTime)
		{
			Form0 form = new Form0(string.Format("桔獩䄠獳浥汢⁹慨\u2073敢湥戠極瑬眠瑩\u2068湡攠慶畬瑡潩\u206e敶獲潩\u206e景笠獻慭瑲獡敳扭祬絽\u202c桷捩\u2068慨\u2073硥楰敲\u2064湯笠細ਮ夊畯渠敥\u2064潴瀠牵档獡\u2065\u2061楬散獮\u2065景笠獻慭瑲獡敳扭祬絽", dateTime.ToString("")), "獻慭瑲獡敳扭祬⁽楌散獮\u2065硅散瑰潩", "牥潲");
			try
			{
				typeof(Application).InvokeMember("湅扡敬楖畳污瑓汹獥", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
			}
			catch (MissingMethodException)
			{
			}
			Application.Run((Form)(object)form);
			return false;
		}
		return true;
	}
}
