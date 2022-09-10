using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using ns2;
using ns3;
using ns4;

namespace ns5;

[GAttribute0(43)]
public sealed class GClass3 : GClass2
{
	protected override void vmethod_2(GEventArgs2 geventArgs2_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Form2 form = new Form2(geventArgs2_0);
		((Form)form).ShowDialog();
	}

	protected override void vmethod_0(GEventArgs1 geventArgs1_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Form1 form = new Form1(this, geventArgs1_0);
		((Form)form).ShowDialog();
	}

	protected override void vmethod_1(GEventArgs0 geventArgs0_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(geventArgs0_0.method_0().ToString(), string.Format("ほ⁽湕硥数瑣摥䔠牲牯", "整瑳"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool smethod_2()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			GClass2.smethod_0(new GClass3());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				try
				{
					typeof(Application).InvokeMember("湅扡敬楖畳污瑓汹獥", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string string_ = string.Format("ほ⁽慣湮瑯椠楮楴污穩\u2065瑩敳晬戠捥畡敳猠浯\u2065数浲獩楳湯\u2073牡\u2065潮⁴牧湡整\u2e64ਊ潙⁵牰扯扡祬琠祲琠\u206f慬湵档笠細椠\u206e\u2061慰瑲慩\u2d6c牴獵⁴楳畴瑡潩\u2e6e䤠❴\u2073獵慵汬⁹桴\u2065慣敳眠敨\u206e桴\u2065灡汰捩瑡潩\u206e獩栠獯整\u2064湯愠渠瑥潷歲猠慨敲ਮ夊畯渠敥\u2064潴爠湵笠細椠\u206e畦汬琭畲瑳\u202c牯愠⁴敬獡⁴牧湡⁴瑩琠敨唠浮湡条摥潃敤猠捥牵瑩⁹数浲獩楳湯ਮ吊\u206f牧湡⁴桴獩愠灰楬慣楴湯琠敨爠煥極敲\u2064数浲獩楳湯\u202c潣瑮捡⁴潹牵猠獹整\u206d摡業楮瑳慲潴Ⱳ漠\u2072獵\u2065桴\u2065楍牣獯景⁴丮呅䘠慲敭潷歲䌠湯楦畧慲楴湯琠潯\u2e6c", "整瑳");
				Form2 form = new Form2(new GEventArgs2(string_, bool_3: false));
				((Form)form).set_ShowInTaskbar(true);
				((Form)form).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format("ほ⁽湕硥数瑣摥䔠牲牯", "整瑳"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}
}
