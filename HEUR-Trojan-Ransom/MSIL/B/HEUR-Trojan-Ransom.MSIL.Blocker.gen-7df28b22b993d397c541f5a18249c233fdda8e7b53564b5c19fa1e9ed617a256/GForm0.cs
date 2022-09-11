using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

public class GForm0 : Form
{
	private string string_0 = "";

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_1;

	private Button button_0;

	private ComboBox comboBox_0;

	private Button button_1;

	private DataGridView dataGridView_0;

	private Label label_2;

	private Label label_3;

	private Button button_2;

	private CheckBox checkBox_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private Button button_3;

	public GForm0()
	{
		method_10();
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			method_1();
		}
		catch (Exception exception_)
		{
			GForm0.smethod_4(GForm0.smethod_3((object)GForm0.smethod_0(exception_), (object)GForm0.smethod_1(exception_), (object)GForm0.smethod_2(exception_)));
		}
	}

	private void method_1()
	{
		GForm0.smethod_6(GForm0.smethod_5(dataGridView_0));
		method_2();
		int num = GForm0.smethod_7(GForm0.smethod_5(dataGridView_0));
		int num2 = 0;
		for (int i = 0; i < num; i++)
		{
			if (!GForm0.smethod_11(GForm0.smethod_10(GForm0.smethod_9(GForm0.smethod_8(dataGridView_0, 1, i))), _003CModule_003E.smethod_5<string>(679952731u)))
			{
				GForm0.smethod_14(GForm0.smethod_13((DataGridViewBand)(object)GForm0.smethod_12(GForm0.smethod_5(dataGridView_0), i)), Color.Red);
				num2++;
			}
			else
			{
				GForm0.smethod_14(GForm0.smethod_13((DataGridViewBand)(object)GForm0.smethod_12(GForm0.smethod_5(dataGridView_0), i)), Color.LightGreen);
			}
		}
		GForm0.smethod_16((Control)(object)label_3, GForm0.smethod_15((object)_003CModule_003E.smethod_4<string>(2328639407u), (object)num));
		if (num2 != 0)
		{
			Label control_ = label_3;
			GForm0.smethod_16((Control)(object)control_, GForm0.smethod_3((object)GForm0.smethod_17((Control)(object)control_), (object)_003CModule_003E.smethod_5<string>(4288324396u), (object)num2));
		}
	}

	private List<string> method_2()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		string text = GForm0.smethod_17((Control)(object)textBox_0);
		string text2 = GForm0.smethod_17((Control)(object)textBox_1);
		string text3 = GForm0.smethod_17((Control)(object)comboBox_0);
		if (!GForm0.smethod_18(text, "") || !GForm0.smethod_18(text2, "") || !GForm0.smethod_18(text3, ""))
		{
			GForm0.smethod_4(_003CModule_003E.smethod_3<string>(3205350292u));
			return null;
		}
		string string_ = GForm0.smethod_19(_003CModule_003E.smethod_2<string>(2787414129u), text3, _003CModule_003E.smethod_6<string>(3484196453u));
		_ = (HttpWebRequest)GForm0.smethod_21(GForm0.smethod_20(_003CModule_003E.smethod_4<string>(1253608800u), text, _003CModule_003E.smethod_2<string>(1310082523u), text2));
		string string_2 = method_6(text, text2, string_);
		XmlDocument xmlDocument = GForm0.smethod_22();
		XmlNamespaceManager xmlNamespaceManager_ = GForm0.smethod_24(GForm0.smethod_23(xmlDocument));
		GForm0.smethod_25(xmlNamespaceManager_, _003CModule_003E.smethod_2<string>(2860665853u), _003CModule_003E.smethod_6<string>(255000064u));
		if (!GForm0.smethod_26(string_2, _003CModule_003E.smethod_6<string>(2144869819u)))
		{
			string_2 = GForm0.smethod_27(string_2, _003CModule_003E.smethod_5<string>(1504047020u), _003CModule_003E.smethod_6<string>(734912515u));
		}
		GForm0.smethod_28(xmlDocument, string_2);
		DateTime dateTime = DateTime.Today;
		DateTime today = DateTime.Today;
		try
		{
			XmlNode xmlNode_ = GForm0.smethod_29((XmlNode)xmlDocument, _003CModule_003E.smethod_4<string>(2390161453u), xmlNamespaceManager_);
			string_0 = GForm0.smethod_30(xmlNode_);
			xmlNode_ = GForm0.smethod_29((XmlNode)xmlDocument, _003CModule_003E.smethod_4<string>(1962887296u), xmlNamespaceManager_);
			string string_3 = GForm0.smethod_30(xmlNode_);
			dateTime = new DateTime(int.Parse(GForm0.smethod_31(string_3, 0, 4)), int.Parse(GForm0.smethod_31(string_3, 4, 2)), int.Parse(GForm0.smethod_31(string_3, 6, 2)));
		}
		catch
		{
		}
		string_ = GForm0.smethod_19(_003CModule_003E.smethod_3<string>(4062661106u), text3, _003CModule_003E.smethod_2<string>(2933917577u));
		_ = (HttpWebRequest)GForm0.smethod_21(GForm0.smethod_20(_003CModule_003E.smethod_2<string>(2085374188u), text, _003CModule_003E.smethod_5<string>(1969416255u), text2));
		string_2 = method_6(text, text2, string_);
		method_3(string_2);
		int num = today.Year - dateTime.Year;
		for (int i = 0; i <= num; i++)
		{
			string text4 = GForm0.smethod_15((object)_003CModule_003E.smethod_4<string>(3702744947u), (object)(dateTime.Year + i));
			string text5 = GForm0.smethod_15((object)_003CModule_003E.smethod_3<string>(2880566263u), (object)(dateTime.Year + i));
			string_ = GForm0.smethod_32(new string[7]
			{
				_003CModule_003E.smethod_5<string>(3037653383u),
				text4,
				_003CModule_003E.smethod_6<string>(4083229100u),
				text5,
				_003CModule_003E.smethod_4<string>(4165935259u),
				text3,
				_003CModule_003E.smethod_6<string>(748086706u)
			});
			_ = (HttpWebRequest)GForm0.smethod_21(GForm0.smethod_20(_003CModule_003E.smethod_2<string>(2085374188u), text, _003CModule_003E.smethod_2<string>(1310082523u), text2));
			string_2 = method_6(text, text2, string_);
			method_3(string_2);
		}
		return new List<string>();
	}

	private void method_3(string string_1)
	{
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		XmlDocument xmlDocument = GForm0.smethod_22();
		if (!GForm0.smethod_26(string_1, _003CModule_003E.smethod_2<string>(3475879102u)))
		{
			string_1 = GForm0.smethod_27(string_1, _003CModule_003E.smethod_5<string>(1504047020u), _003CModule_003E.smethod_3<string>(3962446285u));
		}
		GForm0.smethod_28(xmlDocument, string_1);
		XmlNodeList xmlNodeList_ = GForm0.smethod_33((XmlNode)xmlDocument, _003CModule_003E.smethod_2<string>(1948346666u));
		if (GForm0.smethod_34(xmlNodeList_) == 0)
		{
			xmlNodeList_ = GForm0.smethod_33((XmlNode)xmlDocument, _003CModule_003E.smethod_2<string>(1271407140u));
		}
		XmlNamespaceManager xmlNamespaceManager_ = GForm0.smethod_24(GForm0.smethod_23(xmlDocument));
		GForm0.smethod_25(xmlNamespaceManager_, _003CModule_003E.smethod_5<string>(153772201u), _003CModule_003E.smethod_6<string>(255000064u));
		IEnumerator enumerator = GForm0.smethod_35(xmlNodeList_);
		try
		{
			while (GForm0.smethod_51(enumerator))
			{
				XmlNode xmlNode_ = (XmlNode)GForm0.smethod_36(enumerator);
				try
				{
					if (!GForm0.smethod_26(GForm0.smethod_37(xmlNode_), _003CModule_003E.smethod_2<string>(2305129360u)))
					{
						continue;
					}
					string text = "";
					string object_ = "";
					string object_2 = "";
					if (GForm0.smethod_11(GForm0.smethod_38(xmlNode_), _003CModule_003E.smethod_6<string>(883812760u)))
					{
						text = GForm0.smethod_38(GForm0.smethod_39(xmlNode_));
						object_ = GForm0.smethod_30((XmlNode)GForm0.smethod_41(GForm0.smethod_40(GForm0.smethod_39(xmlNode_)), _003CModule_003E.smethod_3<string>(1281885796u)));
					}
					else
					{
						text = GForm0.smethod_38(xmlNode_);
						if (GForm0.smethod_41(GForm0.smethod_40(xmlNode_), _003CModule_003E.smethod_5<string>(1405340873u)) != null)
						{
							object_ = GForm0.smethod_30((XmlNode)GForm0.smethod_41(GForm0.smethod_40(xmlNode_), _003CModule_003E.smethod_2<string>(4274221661u)));
						}
						try
						{
							string text2 = "";
							try
							{
								text2 = method_4(GForm0.smethod_30((XmlNode)GForm0.smethod_41(GForm0.smethod_40(GForm0.smethod_42(xmlNode_, _003CModule_003E.smethod_3<string>(2239411431u))), _003CModule_003E.smethod_6<string>(1363725211u)))).ToString(_003CModule_003E.smethod_2<string>(2145050944u));
								if (GForm0.smethod_42(xmlNode_, _003CModule_003E.smethod_3<string>(2591991583u)) != null)
								{
									object_2 = GForm0.smethod_20(text2, _003CModule_003E.smethod_6<string>(498775742u), GForm0.smethod_30(GForm0.smethod_42(xmlNode_, _003CModule_003E.smethod_3<string>(2591991583u))), _003CModule_003E.smethod_4<string>(1954351999u));
								}
							}
							catch (Exception)
							{
							}
						}
						catch (Exception exception_)
						{
							GForm0.smethod_4(GForm0.smethod_43(new object[4]
							{
								_003CModule_003E.smethod_2<string>(1396909215u),
								GForm0.smethod_2(exception_),
								GForm0.smethod_0(exception_),
								GForm0.smethod_1(exception_)
							}));
						}
					}
					for (int i = 1; i <= 20; i++)
					{
						XmlNode xmlNode = GForm0.smethod_29(xmlNode_, GForm0.smethod_15((object)_003CModule_003E.smethod_2<string>(175958643u), (object)i) ?? "", xmlNamespaceManager_);
						try
						{
							if (xmlNode != null)
							{
								string text3 = GForm0.smethod_30(xmlNode);
								GForm0.smethod_44(GForm0.smethod_5(dataGridView_0));
								DataGridViewRow dataGridViewRow_ = GForm0.smethod_12(GForm0.smethod_5(dataGridView_0), GForm0.smethod_7(GForm0.smethod_5(dataGridView_0)) - 1);
								GForm0.smethod_47(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 0), (object)GForm0.smethod_19(string_0, _003CModule_003E.smethod_4<string>(1214312480u), text3));
								GForm0.smethod_48(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 1), (object)text3);
								GForm0.smethod_47(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 1), (object)GForm0.smethod_49(GForm0.smethod_19(string_0, _003CModule_003E.smethod_5<string>(2580222182u), text3)));
								GForm0.smethod_47(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 2), (object)text);
								GForm0.smethod_47(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 3), (object)object_);
								GForm0.smethod_47(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 4), (object)i);
								GForm0.smethod_47(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 5), (object)object_2);
							}
						}
						catch (Exception exception_2)
						{
							GForm0.smethod_4(GForm0.smethod_50(_003CModule_003E.smethod_5<string>(322125336u), GForm0.smethod_1(exception_2)));
						}
					}
				}
				catch (Exception exception_3)
				{
					GForm0.smethod_4(GForm0.smethod_50(_003CModule_003E.smethod_6<string>(273709541u), GForm0.smethod_1(exception_3)));
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable idisposable_)
			{
				GForm0.smethod_52(idisposable_);
			}
		}
	}

	public DateTime method_4(string string_1)
	{
		int result = 0;
		DateTime result2 = new DateTime(1900, 1, 1);
		try
		{
			if (int.TryParse(string_1, out result))
			{
				result = int.Parse(string_1);
			}
			result2 = result2.AddDays(result - 1);
			return result2;
		}
		catch
		{
			return result2;
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		string text = GForm0.smethod_17((Control)(object)textBox_0);
		string text2 = GForm0.smethod_17((Control)(object)textBox_1);
		GForm0.smethod_17((Control)(object)comboBox_0);
		if (GForm0.smethod_18(text, "") && GForm0.smethod_18(text2, ""))
		{
			string string_ = _003CModule_003E.smethod_2<string>(3695634274u);
			_ = (HttpWebRequest)GForm0.smethod_21(GForm0.smethod_20(_003CModule_003E.smethod_2<string>(2085374188u), text, _003CModule_003E.smethod_3<string>(2564195460u), text2));
			string string_2 = method_6(text, text2, string_);
			MatchCollection matchCollection_ = GForm0.smethod_54(GForm0.smethod_53(_003CModule_003E.smethod_5<string>(3999246330u), RegexOptions.IgnoreCase), string_2);
			if (GForm0.smethod_55(matchCollection_) <= 0)
			{
				return;
			}
			GForm0.smethod_57(GForm0.smethod_56(comboBox_0));
			IEnumerator enumerator = GForm0.smethod_58(matchCollection_);
			try
			{
				while (GForm0.smethod_51(enumerator))
				{
					Match object_ = (Match)GForm0.smethod_36(enumerator);
					GForm0.smethod_59(GForm0.smethod_56(comboBox_0), (object)GForm0.smethod_10((object)object_));
				}
				return;
			}
			finally
			{
				if (enumerator is IDisposable idisposable_)
				{
					GForm0.smethod_52(idisposable_);
				}
			}
		}
		GForm0.smethod_4(_003CModule_003E.smethod_4<string>(3266935493u));
	}

	private string method_6(string string_1, string string_2, string string_3)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		HttpWebRequest webRequest_ = (HttpWebRequest)GForm0.smethod_21(GForm0.smethod_20(_003CModule_003E.smethod_6<string>(414970881u), string_1, _003CModule_003E.smethod_4<string>(2931944405u), string_2));
		byte[] array = GForm0.smethod_61(GForm0.smethod_60(), string_3);
		GForm0.smethod_62((WebRequest)webRequest_, _003CModule_003E.smethod_6<string>(4116440816u));
		GForm0.smethod_63((WebRequest)webRequest_, (long)array.Length);
		string text = "";
		try
		{
			Stream stream = GForm0.smethod_64((WebRequest)webRequest_);
			try
			{
				GForm0.smethod_65(stream, array, 0, array.Length);
			}
			finally
			{
				if (stream != null)
				{
					GForm0.smethod_52((IDisposable)stream);
				}
			}
			return GForm0.smethod_69((TextReader)GForm0.smethod_68(GForm0.smethod_67((WebResponse)(HttpWebResponse)GForm0.smethod_66((WebRequest)webRequest_))));
		}
		catch (Exception exception_)
		{
			if (GForm0.smethod_11(GForm0.smethod_0(exception_), _003CModule_003E.smethod_5<string>(2252351605u)))
			{
				GForm0.smethod_4(_003CModule_003E.smethod_2<string>(612141624u));
			}
			return "";
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		method_1();
		if (GForm0.smethod_7(GForm0.smethod_5(dataGridView_0)) == 0)
		{
			return;
		}
		FolderBrowserDialog obj = GForm0.smethod_70();
		GForm0.smethod_71(obj, _003CModule_003E.smethod_4<string>(4118103642u));
		GForm0.smethod_72((CommonDialog)(object)obj);
		string string_ = GForm0.smethod_73(obj);
		int num = GForm0.smethod_7(GForm0.smethod_5(dataGridView_0));
		for (int i = 0; i <= num - 1; i++)
		{
			DataGridViewRow dataGridViewRow_ = GForm0.smethod_12(GForm0.smethod_5(dataGridView_0), i);
			if ((!GForm0.smethod_74(checkBox_0) || !GForm0.smethod_11(GForm0.smethod_10(GForm0.smethod_9(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 2))), _003CModule_003E.smethod_3<string>(2003872552u))) && (GForm0.smethod_74(checkBox_0) || !GForm0.smethod_18(GForm0.smethod_10(GForm0.smethod_9(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 2))), _003CModule_003E.smethod_5<string>(2740637283u))))
			{
				continue;
			}
			GForm0.smethod_16((Control)(object)label_3, GForm0.smethod_43(new object[5]
			{
				_003CModule_003E.smethod_2<string>(3036368758u),
				i,
				_003CModule_003E.smethod_3<string>(2268307666u),
				num,
				_003CModule_003E.smethod_3<string>(2356452704u)
			}));
			try
			{
				if (GForm0.smethod_49(GForm0.smethod_10(GForm0.smethod_9(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 0)))))
				{
					string string_2 = GForm0.smethod_10(GForm0.smethod_75(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 1)));
					if (!GForm0.smethod_49(GForm0.smethod_19(string_, _003CModule_003E.smethod_4<string>(1214312480u), string_2)))
					{
						GForm0.smethod_76(GForm0.smethod_10(GForm0.smethod_9(GForm0.smethod_46(GForm0.smethod_45(dataGridViewRow_), 0))), GForm0.smethod_19(string_, _003CModule_003E.smethod_5<string>(2580222182u), string_2), bool_0: true);
					}
				}
			}
			catch (Exception exception_)
			{
				GForm0.smethod_4(GForm0.smethod_43(new object[4]
				{
					_003CModule_003E.smethod_2<string>(1396909215u),
					GForm0.smethod_2(exception_),
					GForm0.smethod_0(exception_),
					GForm0.smethod_1(exception_)
				}));
			}
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		GForm0.smethod_77();
	}

	private void method_9(object sender, MouseEventArgs e)
	{
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GForm0.smethod_52((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	private void method_10()
	{
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		ComponentResourceManager resourceManager_ = GForm0.smethod_79(GForm0.smethod_78(typeof(GForm0).TypeHandle));
		textBox_0 = GForm0.smethod_80();
		label_0 = GForm0.smethod_81();
		label_1 = GForm0.smethod_81();
		textBox_1 = GForm0.smethod_80();
		button_0 = GForm0.smethod_82();
		comboBox_0 = GForm0.smethod_83();
		button_1 = GForm0.smethod_82();
		dataGridView_0 = GForm0.smethod_84();
		dataGridViewTextBoxColumn_0 = GForm0.smethod_85();
		dataGridViewTextBoxColumn_1 = GForm0.smethod_85();
		dataGridViewTextBoxColumn_2 = GForm0.smethod_85();
		dataGridViewTextBoxColumn_3 = GForm0.smethod_85();
		dataGridViewTextBoxColumn_4 = GForm0.smethod_85();
		dataGridViewTextBoxColumn_5 = GForm0.smethod_85();
		label_2 = GForm0.smethod_81();
		label_3 = GForm0.smethod_81();
		button_2 = GForm0.smethod_82();
		checkBox_0 = GForm0.smethod_86();
		button_3 = GForm0.smethod_82();
		GForm0.smethod_87((ISupportInitialize)dataGridView_0);
		GForm0.smethod_88((Control)(object)this);
		GForm0.smethod_89((Control)(object)textBox_0, new Point(493, 7));
		GForm0.smethod_90((Control)(object)textBox_0, _003CModule_003E.smethod_6<string>(331166020u));
		GForm0.smethod_91((Control)(object)textBox_0, new Size(161, 20));
		GForm0.smethod_92((Control)(object)textBox_0, 0);
		GForm0.smethod_16((Control)(object)textBox_0, _003CModule_003E.smethod_2<string>(1682489706u));
		GForm0.smethod_93((Control)(object)label_0, bool_0: true);
		GForm0.smethod_89((Control)(object)label_0, new Point(396, 10));
		GForm0.smethod_90((Control)(object)label_0, _003CModule_003E.smethod_5<string>(2717720840u));
		GForm0.smethod_91((Control)(object)label_0, new Size(83, 13));
		GForm0.smethod_92((Control)(object)label_0, 1);
		GForm0.smethod_16((Control)(object)label_0, _003CModule_003E.smethod_5<string>(2031125209u));
		GForm0.smethod_93((Control)(object)label_1, bool_0: true);
		GForm0.smethod_89((Control)(object)label_1, new Point(396, 36));
		GForm0.smethod_90((Control)(object)label_1, _003CModule_003E.smethod_2<string>(488689070u));
		GForm0.smethod_91((Control)(object)label_1, new Size(91, 13));
		GForm0.smethod_92((Control)(object)label_1, 3);
		GForm0.smethod_16((Control)(object)label_1, _003CModule_003E.smethod_5<string>(3228922961u));
		GForm0.smethod_89((Control)(object)textBox_1, new Point(493, 33));
		GForm0.smethod_90((Control)(object)textBox_1, _003CModule_003E.smethod_6<string>(1741123324u));
		GForm0.smethod_91((Control)(object)textBox_1, new Size(161, 20));
		GForm0.smethod_92((Control)(object)textBox_1, 1);
		GForm0.smethod_16((Control)(object)textBox_1, _003CModule_003E.smethod_6<string>(1036144672u));
		GForm0.smethod_89((Control)(object)button_0, new Point(436, 107));
		GForm0.smethod_90((Control)(object)button_0, _003CModule_003E.smethod_6<string>(4176000914u));
		GForm0.smethod_91((Control)(object)button_0, new Size(75, 23));
		GForm0.smethod_92((Control)(object)button_0, 4);
		GForm0.smethod_16((Control)(object)button_0, _003CModule_003E.smethod_6<string>(3471022262u));
		GForm0.smethod_94((ButtonBase)(object)button_0, bool_0: true);
		GForm0.smethod_95((Control)(object)button_0, (EventHandler)method_0);
		GForm0.smethod_96(comboBox_0, (ComboBoxStyle)2);
		GForm0.smethod_97((ListControl)(object)comboBox_0, bool_0: true);
		GForm0.smethod_89((Control)(object)comboBox_0, new Point(493, 59));
		GForm0.smethod_90((Control)(object)comboBox_0, _003CModule_003E.smethod_2<string>(2814564065u));
		GForm0.smethod_91((Control)(object)comboBox_0, new Size(161, 21));
		GForm0.smethod_92((Control)(object)comboBox_0, 2);
		GForm0.smethod_98((Control)(object)comboBox_0, (EventHandler)method_5);
		GForm0.smethod_89((Control)(object)button_1, new Point(517, 107));
		GForm0.smethod_90((Control)(object)button_1, _003CModule_003E.smethod_4<string>(2699546650u));
		GForm0.smethod_91((Control)(object)button_1, new Size(75, 23));
		GForm0.smethod_92((Control)(object)button_1, 5);
		GForm0.smethod_16((Control)(object)button_1, _003CModule_003E.smethod_3<string>(1110352389u));
		GForm0.smethod_94((ButtonBase)(object)button_1, bool_0: true);
		GForm0.smethod_95((Control)(object)button_1, (EventHandler)method_7);
		GForm0.smethod_99(dataGridView_0, bool_0: false);
		GForm0.smethod_100(dataGridView_0, bool_0: false);
		GForm0.smethod_101(dataGridView_0, (DataGridViewColumnHeadersHeightSizeMode)2);
		GForm0.smethod_103(GForm0.smethod_102(dataGridView_0), (DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn_0,
			(DataGridViewColumn)dataGridViewTextBoxColumn_1,
			(DataGridViewColumn)dataGridViewTextBoxColumn_2,
			(DataGridViewColumn)dataGridViewTextBoxColumn_3,
			(DataGridViewColumn)dataGridViewTextBoxColumn_4,
			(DataGridViewColumn)dataGridViewTextBoxColumn_5
		});
		GForm0.smethod_104((Control)(object)dataGridView_0, (DockStyle)2);
		GForm0.smethod_89((Control)(object)dataGridView_0, new Point(0, 142));
		GForm0.smethod_90((Control)(object)dataGridView_0, _003CModule_003E.smethod_3<string>(1286642465u));
		GForm0.smethod_91((Control)(object)dataGridView_0, new Size(1048, 551));
		GForm0.smethod_92((Control)(object)dataGridView_0, 7);
		GForm0.smethod_105((Control)(object)dataGridView_0, new MouseEventHandler(method_9));
		GForm0.smethod_106((DataGridViewColumn)(object)dataGridViewTextBoxColumn_0, _003CModule_003E.smethod_2<string>(2654485649u));
		GForm0.smethod_107((DataGridViewColumn)(object)dataGridViewTextBoxColumn_0, _003CModule_003E.smethod_4<string>(1708263815u));
		GForm0.smethod_108((DataGridViewColumn)(object)dataGridViewTextBoxColumn_0, 400);
		GForm0.smethod_106((DataGridViewColumn)(object)dataGridViewTextBoxColumn_1, _003CModule_003E.smethod_6<string>(3962005285u));
		GForm0.smethod_107((DataGridViewColumn)(object)dataGridViewTextBoxColumn_1, _003CModule_003E.smethod_5<string>(772516162u));
		GForm0.smethod_106((DataGridViewColumn)(object)dataGridViewTextBoxColumn_2, _003CModule_003E.smethod_6<string>(212045824u));
		GForm0.smethod_107((DataGridViewColumn)(object)dataGridViewTextBoxColumn_2, _003CModule_003E.smethod_5<string>(3938435035u));
		GForm0.smethod_106((DataGridViewColumn)(object)dataGridViewTextBoxColumn_3, _003CModule_003E.smethod_5<string>(2122790981u));
		GForm0.smethod_107((DataGridViewColumn)(object)dataGridViewTextBoxColumn_3, _003CModule_003E.smethod_2<string>(1300606597u));
		GForm0.smethod_106((DataGridViewColumn)(object)dataGridViewTextBoxColumn_4, _003CModule_003E.smethod_2<string>(2752837788u));
		GForm0.smethod_107((DataGridViewColumn)(object)dataGridViewTextBoxColumn_4, _003CModule_003E.smethod_6<string>(2486952597u));
		GForm0.smethod_106((DataGridViewColumn)(object)dataGridViewTextBoxColumn_5, _003CModule_003E.smethod_3<string>(2432527959u));
		GForm0.smethod_107((DataGridViewColumn)(object)dataGridViewTextBoxColumn_5, _003CModule_003E.smethod_4<string>(540950139u));
		GForm0.smethod_108((DataGridViewColumn)(object)dataGridViewTextBoxColumn_5, 200);
		GForm0.smethod_93((Control)(object)label_2, bool_0: true);
		GForm0.smethod_89((Control)(object)label_2, new Point(396, 62));
		GForm0.smethod_90((Control)(object)label_2, _003CModule_003E.smethod_3<string>(2873253149u));
		GForm0.smethod_91((Control)(object)label_2, new Size(82, 13));
		GForm0.smethod_92((Control)(object)label_2, 8);
		GForm0.smethod_16((Control)(object)label_2, _003CModule_003E.smethod_6<string>(4056880718u));
		GForm0.smethod_93((Control)(object)label_3, bool_0: true);
		GForm0.smethod_110((Control)(object)label_3, GForm0.smethod_109(_003CModule_003E.smethod_5<string>(352979813u), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GForm0.smethod_89((Control)(object)label_3, new Point(699, 107));
		GForm0.smethod_90((Control)(object)label_3, _003CModule_003E.smethod_6<string>(1491812360u));
		GForm0.smethod_91((Control)(object)label_3, new Size(0, 13));
		GForm0.smethod_92((Control)(object)label_3, 9);
		GForm0.smethod_89((Control)(object)button_2, new Point(598, 107));
		GForm0.smethod_90((Control)(object)button_2, _003CModule_003E.smethod_6<string>(786833708u));
		GForm0.smethod_91((Control)(object)button_2, new Size(75, 23));
		GForm0.smethod_92((Control)(object)button_2, 6);
		GForm0.smethod_16((Control)(object)button_2, _003CModule_003E.smethod_4<string>(1280989658u));
		GForm0.smethod_94((ButtonBase)(object)button_2, bool_0: true);
		GForm0.smethod_95((Control)(object)button_2, (EventHandler)method_8);
		GForm0.smethod_93((Control)(object)checkBox_0, bool_0: true);
		GForm0.smethod_89((Control)(object)checkBox_0, new Point(396, 84));
		GForm0.smethod_90((Control)(object)checkBox_0, _003CModule_003E.smethod_4<string>(3333612671u));
		GForm0.smethod_91((Control)(object)checkBox_0, new Size(113, 17));
		GForm0.smethod_92((Control)(object)checkBox_0, 3);
		GForm0.smethod_16((Control)(object)checkBox_0, _003CModule_003E.smethod_6<string>(2516732646u));
		GForm0.smethod_94((ButtonBase)(object)checkBox_0, bool_0: true);
		GForm0.smethod_89((Control)(object)button_3, new Point(153, 52));
		GForm0.smethod_90((Control)(object)button_3, _003CModule_003E.smethod_4<string>(4271908757u));
		GForm0.smethod_91((Control)(object)button_3, new Size(75, 23));
		GForm0.smethod_92((Control)(object)button_3, 12);
		GForm0.smethod_16((Control)(object)button_3, _003CModule_003E.smethod_5<string>(3564731572u));
		GForm0.smethod_94((ButtonBase)(object)button_3, bool_0: true);
		GForm0.smethod_111((Control)(object)button_3, bool_0: false);
		GForm0.smethod_112((ContainerControl)(object)this, new SizeF(6f, 13f));
		GForm0.smethod_113((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm0.smethod_114((Form)(object)this, new Size(1048, 693));
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)button_3);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)checkBox_0);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)button_2);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)label_3);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)label_2);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)dataGridView_0);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)button_1);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)comboBox_0);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)button_0);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)label_1);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)textBox_1);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)label_0);
		GForm0.smethod_116(GForm0.smethod_115((Control)(object)this), (Control)(object)textBox_0);
		GForm0.smethod_118((Form)(object)this, (Icon)GForm0.smethod_117((ResourceManager)resourceManager_, _003CModule_003E.smethod_2<string>(3663107454u)));
		GForm0.smethod_119((Control)(object)this, _003CModule_003E.smethod_2<string>(401862378u));
		GForm0.smethod_16((Control)(object)this, _003CModule_003E.smethod_2<string>(1595663014u));
		GForm0.smethod_120((ISupportInitialize)dataGridView_0);
		GForm0.smethod_121((Control)(object)this, bool_0: false);
		GForm0.smethod_122((Control)(object)this);
	}

	static string smethod_0(Exception exception_0)
	{
		return exception_0.Message;
	}

	static string smethod_1(Exception exception_0)
	{
		return exception_0.StackTrace;
	}

	static Exception smethod_2(Exception exception_0)
	{
		return exception_0.InnerException;
	}

	static string smethod_3(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	static DialogResult smethod_4(string string_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_1);
	}

	static DataGridViewRowCollection smethod_5(DataGridView dataGridView_1)
	{
		return dataGridView_1.get_Rows();
	}

	static void smethod_6(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		dataGridViewRowCollection_0.Clear();
	}

	static int smethod_7(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		return dataGridViewRowCollection_0.get_Count();
	}

	static DataGridViewCell smethod_8(DataGridView dataGridView_1, int int_0, int int_1)
	{
		return dataGridView_1.get_Item(int_0, int_1);
	}

	static object smethod_9(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Value();
	}

	static string smethod_10(object object_0)
	{
		return object_0.ToString();
	}

	static bool smethod_11(string string_1, string string_2)
	{
		return string_1 == string_2;
	}

	static DataGridViewRow smethod_12(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0.get_Item(int_0);
	}

	static DataGridViewCellStyle smethod_13(DataGridViewBand dataGridViewBand_0)
	{
		return dataGridViewBand_0.get_DefaultCellStyle();
	}

	static void smethod_14(DataGridViewCellStyle dataGridViewCellStyle_0, Color color_0)
	{
		dataGridViewCellStyle_0.set_BackColor(color_0);
	}

	static string smethod_15(object object_0, object object_1)
	{
		return string.Concat(object_0, object_1);
	}

	static void smethod_16(Control control_0, string string_1)
	{
		control_0.set_Text(string_1);
	}

	static string smethod_17(Control control_0)
	{
		return control_0.get_Text();
	}

	static bool smethod_18(string string_1, string string_2)
	{
		return string_1 != string_2;
	}

	static string smethod_19(string string_1, string string_2, string string_3)
	{
		return string_1 + string_2 + string_3;
	}

	static string smethod_20(string string_1, string string_2, string string_3, string string_4)
	{
		return string_1 + string_2 + string_3 + string_4;
	}

	static WebRequest smethod_21(string string_1)
	{
		return WebRequest.Create(string_1);
	}

	static XmlDocument smethod_22()
	{
		return new XmlDocument();
	}

	static XmlNameTable smethod_23(XmlDocument xmlDocument_0)
	{
		return xmlDocument_0.NameTable;
	}

	static XmlNamespaceManager smethod_24(XmlNameTable xmlNameTable_0)
	{
		return new XmlNamespaceManager(xmlNameTable_0);
	}

	static void smethod_25(XmlNamespaceManager xmlNamespaceManager_0, string string_1, string string_2)
	{
		xmlNamespaceManager_0.AddNamespace(string_1, string_2);
	}

	static bool smethod_26(string string_1, string string_2)
	{
		return string_1.Contains(string_2);
	}

	static string smethod_27(string string_1, string string_2, string string_3)
	{
		return string_1.Replace(string_2, string_3);
	}

	static void smethod_28(XmlDocument xmlDocument_0, string string_1)
	{
		xmlDocument_0.LoadXml(string_1);
	}

	static XmlNode smethod_29(XmlNode xmlNode_0, string string_1, XmlNamespaceManager xmlNamespaceManager_0)
	{
		return xmlNode_0.SelectSingleNode(string_1, xmlNamespaceManager_0);
	}

	static string smethod_30(XmlNode xmlNode_0)
	{
		return xmlNode_0.InnerText;
	}

	static string smethod_31(string string_1, int int_0, int int_1)
	{
		return string_1.Substring(int_0, int_1);
	}

	static string smethod_32(string[] string_1)
	{
		return string.Concat(string_1);
	}

	static XmlNodeList smethod_33(XmlNode xmlNode_0, string string_1)
	{
		return xmlNode_0.SelectNodes(string_1);
	}

	static int smethod_34(XmlNodeList xmlNodeList_0)
	{
		return xmlNodeList_0.Count;
	}

	static IEnumerator smethod_35(XmlNodeList xmlNodeList_0)
	{
		return xmlNodeList_0.GetEnumerator();
	}

	static object smethod_36(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static string smethod_37(XmlNode xmlNode_0)
	{
		return xmlNode_0.InnerXml;
	}

	static string smethod_38(XmlNode xmlNode_0)
	{
		return xmlNode_0.Name;
	}

	static XmlNode smethod_39(XmlNode xmlNode_0)
	{
		return xmlNode_0.FirstChild;
	}

	static XmlAttributeCollection smethod_40(XmlNode xmlNode_0)
	{
		return xmlNode_0.Attributes;
	}

	static XmlAttribute smethod_41(XmlAttributeCollection xmlAttributeCollection_0, string string_1)
	{
		return xmlAttributeCollection_0[string_1];
	}

	static XmlNode smethod_42(XmlNode xmlNode_0, string string_1)
	{
		return xmlNode_0.SelectSingleNode(string_1);
	}

	static string smethod_43(object[] object_0)
	{
		return string.Concat(object_0);
	}

	static int smethod_44(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		return dataGridViewRowCollection_0.Add();
	}

	static DataGridViewCellCollection smethod_45(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.get_Cells();
	}

	static DataGridViewCell smethod_46(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0.get_Item(int_0);
	}

	static void smethod_47(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.set_Value(object_0);
	}

	static void smethod_48(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.set_Tag(object_0);
	}

	static bool smethod_49(string string_1)
	{
		return File.Exists(string_1);
	}

	static string smethod_50(string string_1, string string_2)
	{
		return string_1 + string_2;
	}

	static bool smethod_51(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_52(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Regex smethod_53(string string_1, RegexOptions regexOptions_0)
	{
		return new Regex(string_1, regexOptions_0);
	}

	static MatchCollection smethod_54(Regex regex_0, string string_1)
	{
		return regex_0.Matches(string_1);
	}

	static int smethod_55(MatchCollection matchCollection_0)
	{
		return matchCollection_0.Count;
	}

	static ObjectCollection smethod_56(ComboBox comboBox_1)
	{
		return comboBox_1.get_Items();
	}

	static void smethod_57(ObjectCollection objectCollection_0)
	{
		objectCollection_0.Clear();
	}

	static IEnumerator smethod_58(MatchCollection matchCollection_0)
	{
		return matchCollection_0.GetEnumerator();
	}

	static int smethod_59(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static Encoding smethod_60()
	{
		return Encoding.ASCII;
	}

	static byte[] smethod_61(Encoding encoding_0, string string_1)
	{
		return encoding_0.GetBytes(string_1);
	}

	static void smethod_62(WebRequest webRequest_0, string string_1)
	{
		webRequest_0.Method = string_1;
	}

	static void smethod_63(WebRequest webRequest_0, long long_0)
	{
		webRequest_0.ContentLength = long_0;
	}

	static Stream smethod_64(WebRequest webRequest_0)
	{
		return webRequest_0.GetRequestStream();
	}

	static void smethod_65(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static WebResponse smethod_66(WebRequest webRequest_0)
	{
		return webRequest_0.GetResponse();
	}

	static Stream smethod_67(WebResponse webResponse_0)
	{
		return webResponse_0.GetResponseStream();
	}

	static StreamReader smethod_68(Stream stream_0)
	{
		return new StreamReader(stream_0);
	}

	static string smethod_69(TextReader textReader_0)
	{
		return textReader_0.ReadToEnd();
	}

	static FolderBrowserDialog smethod_70()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new FolderBrowserDialog();
	}

	static void smethod_71(FolderBrowserDialog folderBrowserDialog_0, string string_1)
	{
		folderBrowserDialog_0.set_Description(string_1);
	}

	static DialogResult smethod_72(CommonDialog commonDialog_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return commonDialog_0.ShowDialog();
	}

	static string smethod_73(FolderBrowserDialog folderBrowserDialog_0)
	{
		return folderBrowserDialog_0.get_SelectedPath();
	}

	static bool smethod_74(CheckBox checkBox_1)
	{
		return checkBox_1.get_Checked();
	}

	static object smethod_75(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.get_Tag();
	}

	static void smethod_76(string string_1, string string_2, bool bool_0)
	{
		File.Copy(string_1, string_2, bool_0);
	}

	static void smethod_77()
	{
		Application.Exit();
	}

	static Type smethod_78(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_79(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static TextBox smethod_80()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Label smethod_81()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Button smethod_82()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static ComboBox smethod_83()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static DataGridView smethod_84()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridView();
	}

	static DataGridViewTextBoxColumn smethod_85()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DataGridViewTextBoxColumn();
	}

	static CheckBox smethod_86()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CheckBox();
	}

	static void smethod_87(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_88(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_89(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_90(Control control_0, string string_1)
	{
		control_0.set_Name(string_1);
	}

	static void smethod_91(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_92(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_93(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_94(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_95(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_96(ComboBox comboBox_1, ComboBoxStyle comboBoxStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		comboBox_1.set_DropDownStyle(comboBoxStyle_0);
	}

	static void smethod_97(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static void smethod_98(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Enter(eventHandler_0);
	}

	static void smethod_99(DataGridView dataGridView_1, bool bool_0)
	{
		dataGridView_1.set_AllowUserToAddRows(bool_0);
	}

	static void smethod_100(DataGridView dataGridView_1, bool bool_0)
	{
		dataGridView_1.set_AllowUserToDeleteRows(bool_0);
	}

	static void smethod_101(DataGridView dataGridView_1, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		dataGridView_1.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	static DataGridViewColumnCollection smethod_102(DataGridView dataGridView_1)
	{
		return dataGridView_1.get_Columns();
	}

	static void smethod_103(DataGridViewColumnCollection dataGridViewColumnCollection_0, DataGridViewColumn[] dataGridViewColumn_0)
	{
		dataGridViewColumnCollection_0.AddRange(dataGridViewColumn_0);
	}

	static void smethod_104(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static void smethod_105(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseDoubleClick(mouseEventHandler_0);
	}

	static void smethod_106(DataGridViewColumn dataGridViewColumn_0, string string_1)
	{
		dataGridViewColumn_0.set_HeaderText(string_1);
	}

	static void smethod_107(DataGridViewColumn dataGridViewColumn_0, string string_1)
	{
		dataGridViewColumn_0.set_Name(string_1);
	}

	static void smethod_108(DataGridViewColumn dataGridViewColumn_0, int int_0)
	{
		dataGridViewColumn_0.set_Width(int_0);
	}

	static Font smethod_109(string string_1, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_1, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_110(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_111(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_112(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_113(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_114(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_115(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_116(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static object smethod_117(ResourceManager resourceManager_0, string string_1)
	{
		return resourceManager_0.GetObject(string_1);
	}

	static void smethod_118(Form form_0, Icon icon_0)
	{
		form_0.set_Icon(icon_0);
	}

	static void smethod_119(Control control_0, string string_1)
	{
		control_0.set_Name(string_1);
	}

	static void smethod_120(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_121(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_122(Control control_0)
	{
		control_0.PerformLayout();
	}
}
