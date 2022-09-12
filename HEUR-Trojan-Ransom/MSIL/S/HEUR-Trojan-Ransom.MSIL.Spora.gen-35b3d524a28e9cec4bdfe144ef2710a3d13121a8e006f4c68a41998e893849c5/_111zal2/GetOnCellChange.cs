using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _111zal2;

public class GetOnCellChange : Form
{
	private Label UnSafeCharBuffer;

	private Label DeploymentUpdate;

	private Label InternalFE;

	private NumericUpDown SpecifiedAccessor;

	private TextBox _003CReadElementContentAsBinHexAsync_003Ed__149;

	private Button BooleanArrayTypeInfo;

	private Label IEnumConnections;

	private Label CaseConversion;

	private Class2.Class10 class10_0 = new Class2.Class10();

	public GetOnCellChange()
	{
		object obj = null;
		class10_0.icontainer_0 = (IContainer)obj;
		((Form)this)._002Ector();
		AssignBinaryExpression();
	}

	private void TdsDateTime(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void PartitionedStream_00602(object sender, EventArgs e)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		object obj = new GetStyleSheets();
		if (((Control)class10_0.textBox_0).get_Text() != "" || ((Control)class10_0.textBox_1).get_Text() != "" || ((Control)class10_0.comboBox_0).get_Text() != "")
		{
			(obj as GetStyleSheets).SqlColumnEncryptionCspProvider = ((Control)class10_0.textBox_0).get_Text();
			(obj as GetStyleSheets).LinkBehavior = ((Control)class10_0.textBox_1).get_Text();
			((GetStyleSheets)obj).WebBrowserBase = ((Control)_003CReadElementContentAsBinHexAsync_003Ed__149).get_Text();
			if (float.TryParse(((Control)class10_0.textBox_2).get_Text(), out var _))
			{
				(obj as GetStyleSheets).MethodDef = float.Parse(((Control)class10_0.textBox_2).get_Text());
			}
			else
			{
				MessageBox.Show("Invalid price format.\nPrice was set to 0.");
				((GetStyleSheets)obj).MethodDef = 0.0;
			}
			(obj as GetStyleSheets).HTTP_DATA_CHUNK_TYPE = ((Control)class10_0.comboBox_0).get_Text();
			(obj as GetStyleSheets).CodeTryCatchFinallyStatement = long.Parse(SpecifiedAccessor.get_Value().ToString());
			MessageBox.Show("Product added successfully");
			((TextBoxBase)class10_0.textBox_0).Clear();
			((TextBoxBase)class10_0.textBox_1).Clear();
			((TextBoxBase)_003CReadElementContentAsBinHexAsync_003Ed__149).Clear();
			((TextBoxBase)class10_0.textBox_2).Clear();
			((Control)class10_0.comboBox_0).set_Text("");
			SpecifiedAccessor.set_Value(0m);
		}
		else
		{
			MessageBox.Show("Product was not added please fix any errors and try again");
		}
	}

	protected override void XmlIgnoreNamespaceReader(bool ApplicationSecurityInfo)
	{
		if (ApplicationSecurityInfo && class10_0.icontainer_0 != null)
		{
			class10_0.icontainer_0.Dispose();
		}
		((Form)this).Dispose(ApplicationSecurityInfo);
	}

	private void AssignBinaryExpression()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected O, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected O, but got Unknown
		Control val = (Control)new Label();
		class10_0.label_0 = (Label)(object)((val is Label) ? val : null);
		Control val2 = (Control)new Label();
		class10_0.label_1 = (Label)val2;
		UnSafeCharBuffer = new Label();
		DeploymentUpdate = new Label();
		InternalFE = new Label();
		TextBoxBase val3 = (TextBoxBase)new TextBox();
		class10_0.textBox_0 = (TextBox)(object)((val3 is TextBox) ? val3 : null);
		SpecifiedAccessor = new NumericUpDown();
		Control val4 = (Control)new Label();
		class10_0.label_2 = (Label)(object)((val4 is Label) ? val4 : null);
		ListControl val5 = (ListControl)new ComboBox();
		class10_0.comboBox_0 = (ComboBox)val5;
		object obj = (object)new Button();
		class10_0.button_0 = (Button)obj;
		TextBoxBase val6 = (TextBoxBase)new TextBox();
		class10_0.textBox_1 = (TextBox)val6;
		_003CReadElementContentAsBinHexAsync_003Ed__149 = new TextBox();
		object obj2 = (object)new TextBox();
		class10_0.textBox_2 = (TextBox)((obj2 is TextBox) ? obj2 : null);
		BooleanArrayTypeInfo = new Button();
		object obj3 = (object)new Label();
		class10_0.label_3 = (Label)obj3;
		IEnumConnections = new Label();
		CaseConversion = new Label();
		((ISupportInitialize)SpecifiedAccessor).BeginInit();
		((Control)this).SuspendLayout();
		((Control)class10_0.label_0).set_AutoSize(true);
		((Control)class10_0.label_0).set_Location(new Point(14, 37));
		((Control)class10_0.label_0).set_Name("label1");
		((Control)class10_0.label_0).set_Size(new Size(75, 13));
		((Control)class10_0.label_0).set_TabIndex(0);
		((Control)class10_0.label_0).set_Text("Product Name");
		((Control)class10_0.label_1).set_AutoSize(true);
		((Control)class10_0.label_1).set_Location(new Point(14, 82));
		((Control)class10_0.label_1).set_Name("label2");
		((Control)class10_0.label_1).set_Size(new Size(73, 13));
		((Control)class10_0.label_1).set_TabIndex(1);
		((Control)class10_0.label_1).set_Text("Serial Number");
		((Control)UnSafeCharBuffer).set_AutoSize(true);
		((Control)UnSafeCharBuffer).set_Location(new Point(55, 129));
		((Control)UnSafeCharBuffer).set_Name("label3");
		((Control)UnSafeCharBuffer).set_Size(new Size(31, 13));
		((Control)UnSafeCharBuffer).set_TabIndex(2);
		((Control)UnSafeCharBuffer).set_Text("Color");
		((Control)DeploymentUpdate).set_AutoSize(true);
		((Control)DeploymentUpdate).set_Location(new Point(55, 173));
		((Control)DeploymentUpdate).set_Name("label4");
		((Control)DeploymentUpdate).set_Size(new Size(31, 13));
		((Control)DeploymentUpdate).set_TabIndex(3);
		((Control)DeploymentUpdate).set_Text("Price");
		((Control)InternalFE).set_AutoSize(true);
		((Control)InternalFE).set_Location(new Point(55, 218));
		((Control)InternalFE).set_Name("label5");
		((Control)InternalFE).set_Size(new Size(31, 13));
		((Control)InternalFE).set_TabIndex(4);
		((Control)InternalFE).set_Text("Type");
		((Control)class10_0.textBox_0).set_Location(new Point(92, 34));
		((Control)class10_0.textBox_0).set_Name("textBox1");
		((Control)class10_0.textBox_0).set_Size(new Size(129, 20));
		((Control)class10_0.textBox_0).set_TabIndex(1);
		((Control)SpecifiedAccessor).set_Location(new Point(92, 257));
		((Control)SpecifiedAccessor).set_Name("numericUpDown1");
		((Control)SpecifiedAccessor).set_Size(new Size(129, 20));
		((Control)SpecifiedAccessor).set_TabIndex(6);
		((Control)class10_0.label_2).set_AutoSize(true);
		((Control)class10_0.label_2).set_Location(new Point(40, 259));
		((Control)class10_0.label_2).set_Name("label6");
		((Control)class10_0.label_2).set_Size(new Size(46, 13));
		((Control)class10_0.label_2).set_TabIndex(7);
		((Control)class10_0.label_2).set_Text("Quantity");
		((ListControl)class10_0.comboBox_0).set_FormattingEnabled(true);
		class10_0.comboBox_0.get_Items().AddRange(new object[3] { "Smartphone", "Tv", "Laptop" });
		((Control)class10_0.comboBox_0).set_Location(new Point(92, 215));
		((Control)class10_0.comboBox_0).set_Name("comboBox1");
		((Control)class10_0.comboBox_0).set_Size(new Size(129, 21));
		((Control)class10_0.comboBox_0).set_TabIndex(5);
		((Control)class10_0.button_0).set_Location(new Point(178, 299));
		((Control)class10_0.button_0).set_Name("button1");
		((Control)class10_0.button_0).set_Size(new Size(75, 23));
		((Control)class10_0.button_0).set_TabIndex(8);
		((Control)class10_0.button_0).set_Text("Ok");
		((ButtonBase)class10_0.button_0).set_UseVisualStyleBackColor(true);
		((Control)class10_0.button_0).add_Click((EventHandler)PartitionedStream_00602);
		((Control)class10_0.textBox_1).set_Location(new Point(92, 79));
		((Control)class10_0.textBox_1).set_Name("textBox2");
		((Control)class10_0.textBox_1).set_Size(new Size(129, 20));
		((Control)class10_0.textBox_1).set_TabIndex(2);
		((Control)_003CReadElementContentAsBinHexAsync_003Ed__149).set_Location(new Point(92, 126));
		((Control)_003CReadElementContentAsBinHexAsync_003Ed__149).set_Name("textBox3");
		((Control)_003CReadElementContentAsBinHexAsync_003Ed__149).set_Size(new Size(129, 20));
		((Control)_003CReadElementContentAsBinHexAsync_003Ed__149).set_TabIndex(3);
		((Control)class10_0.textBox_2).set_Location(new Point(92, 170));
		((Control)class10_0.textBox_2).set_Name("textBox4");
		((Control)class10_0.textBox_2).set_Size(new Size(129, 20));
		((Control)class10_0.textBox_2).set_TabIndex(4);
		((Control)BooleanArrayTypeInfo).set_Location(new Point(12, 299));
		((Control)BooleanArrayTypeInfo).set_Name("button2");
		((Control)BooleanArrayTypeInfo).set_Size(new Size(75, 23));
		((Control)BooleanArrayTypeInfo).set_TabIndex(7);
		((Control)BooleanArrayTypeInfo).set_Text("Cancel");
		((ButtonBase)BooleanArrayTypeInfo).set_UseVisualStyleBackColor(true);
		((Control)BooleanArrayTypeInfo).add_Click((EventHandler)TdsDateTime);
		((Control)class10_0.label_3).set_AutoSize(true);
		((Control)class10_0.label_3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)class10_0.label_3).set_ForeColor(Color.Red);
		((Control)class10_0.label_3).set_Location(new Point(227, 32));
		((Control)class10_0.label_3).set_Name("label7");
		((Control)class10_0.label_3).set_Size(new Size(15, 20));
		((Control)class10_0.label_3).set_TabIndex(14);
		((Control)class10_0.label_3).set_Text("*");
		((Control)IEnumConnections).set_AutoSize(true);
		((Control)IEnumConnections).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)IEnumConnections).set_ForeColor(Color.Red);
		((Control)IEnumConnections).set_Location(new Point(227, 79));
		((Control)IEnumConnections).set_Name("label8");
		((Control)IEnumConnections).set_Size(new Size(15, 20));
		((Control)IEnumConnections).set_TabIndex(15);
		((Control)IEnumConnections).set_Text("*");
		((Control)CaseConversion).set_AutoSize(true);
		((Control)CaseConversion).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)CaseConversion).set_ForeColor(Color.Red);
		((Control)CaseConversion).set_Location(new Point(227, 213));
		((Control)CaseConversion).set_Name("label9");
		((Control)CaseConversion).set_Size(new Size(15, 20));
		((Control)CaseConversion).set_TabIndex(16);
		((Control)CaseConversion).set_Text("*");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(265, 334));
		((Control)this).get_Controls().Add((Control)(object)CaseConversion);
		((Control)this).get_Controls().Add((Control)(object)IEnumConnections);
		((Control)this).get_Controls().Add((Control)(object)class10_0.label_3);
		((Control)this).get_Controls().Add((Control)(object)BooleanArrayTypeInfo);
		((Control)this).get_Controls().Add((Control)(object)class10_0.textBox_2);
		((Control)this).get_Controls().Add((Control)(object)_003CReadElementContentAsBinHexAsync_003Ed__149);
		((Control)this).get_Controls().Add((Control)(object)class10_0.textBox_1);
		((Control)this).get_Controls().Add((Control)(object)class10_0.button_0);
		((Control)this).get_Controls().Add((Control)(object)class10_0.comboBox_0);
		((Control)this).get_Controls().Add((Control)(object)class10_0.label_2);
		((Control)this).get_Controls().Add((Control)(object)SpecifiedAccessor);
		((Control)this).get_Controls().Add((Control)(object)class10_0.textBox_0);
		((Control)this).get_Controls().Add((Control)(object)InternalFE);
		((Control)this).get_Controls().Add((Control)(object)DeploymentUpdate);
		((Control)this).get_Controls().Add((Control)(object)UnSafeCharBuffer);
		((Control)this).get_Controls().Add((Control)(object)class10_0.label_1);
		((Control)this).get_Controls().Add((Control)(object)class10_0.label_0);
		((Control)this).set_Name("AddForm");
		((Control)this).set_Text("AddForm");
		((ISupportInitialize)SpecifiedAccessor).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
