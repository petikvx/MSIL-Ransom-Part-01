using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Pexeso.My;

namespace Pexeso;

[DesignerGenerated]
public class frmGameSelect : Form
{
	private IContainer components;

	internal virtual ListBox lstDifficulty
	{
		[CompilerGenerated]
		get
		{
			return _lstDifficulty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lstDifficulty_SelectedIndexChanged;
			ListBox val = _lstDifficulty;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_lstDifficulty = value;
			val = _lstDifficulty;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual Button cmdStart
	{
		[CompilerGenerated]
		get
		{
			return _cmdStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmdStart_Click;
			Button val = _cmdStart;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_cmdStart = value;
			val = _cmdStart;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button cmdBack
	{
		[CompilerGenerated]
		get
		{
			return _cmdBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmdBack_Click;
			Button val = _cmdBack;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_cmdBack = value;
			val = _cmdBack;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual NumericUpDown NumericUpDownX
	{
		[CompilerGenerated]
		get
		{
			return _NumericUpDownX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = NumericUpDownX_ValueChanged;
			NumericUpDown numericUpDownX = _NumericUpDownX;
			if (numericUpDownX != null)
			{
				numericUpDownX.remove_ValueChanged(eventHandler);
			}
			_NumericUpDownX = value;
			numericUpDownX = _NumericUpDownX;
			if (numericUpDownX != null)
			{
				numericUpDownX.add_ValueChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual NumericUpDown NumericUpDownY
	{
		[CompilerGenerated]
		get
		{
			return _NumericUpDownY;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = NumericUpDownY_ValueChanged;
			NumericUpDown numericUpDownY = _NumericUpDownY;
			if (numericUpDownY != null)
			{
				numericUpDownY.remove_ValueChanged(eventHandler);
			}
			_NumericUpDownY = value;
			numericUpDownY = _NumericUpDownY;
			if (numericUpDownY != null)
			{
				numericUpDownY.add_ValueChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalNumberOfCards")]
	internal virtual Label lblTotalNumberOfCards
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFirst")]
	internal virtual Label lblFirst
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLast")]
	internal virtual Label lblLast
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public frmGameSelect()
	{
		((Form)this).add_Load((EventHandler)frmGameSelect_Load);
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected O, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected O, but got Unknown
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected O, but got Unknown
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected O, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected O, but got Unknown
		lstDifficulty = new ListBox();
		cmdStart = new Button();
		cmdBack = new Button();
		NumericUpDownX = new NumericUpDown();
		Label1 = new Label();
		NumericUpDownY = new NumericUpDown();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		lblTotalNumberOfCards = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		lblFirst = new Label();
		lblLast = new Label();
		((ISupportInitialize)NumericUpDownX).BeginInit();
		((ISupportInitialize)NumericUpDownY).BeginInit();
		((Control)this).SuspendLayout();
		lstDifficulty.set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((ListControl)lstDifficulty).set_FormattingEnabled(true);
		lstDifficulty.set_ItemHeight(25);
		lstDifficulty.get_Items().AddRange(new object[4] { "Easy", "Normal", "Hard", "User defined" });
		((Control)lstDifficulty).set_Location(new Point(12, 44));
		((Control)lstDifficulty).set_Name("lstDifficulty");
		((Control)lstDifficulty).set_Size(new Size(225, 104));
		((Control)lstDifficulty).set_TabIndex(1);
		((Control)cmdStart).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)cmdStart).set_Location(new Point(40, 266));
		((Control)cmdStart).set_Name("cmdStart");
		((Control)cmdStart).set_Size(new Size(160, 40));
		((Control)cmdStart).set_TabIndex(5);
		((ButtonBase)cmdStart).set_Text("Start the game");
		((ButtonBase)cmdStart).set_UseVisualStyleBackColor(true);
		cmdBack.set_DialogResult((DialogResult)2);
		((Control)cmdBack).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)cmdBack).set_Location(new Point(40, 198));
		((Control)cmdBack).set_Name("cmdBack");
		((Control)cmdBack).set_Size(new Size(160, 40));
		((Control)cmdBack).set_TabIndex(4);
		((ButtonBase)cmdBack).set_Text("Back to menu");
		((ButtonBase)cmdBack).set_UseVisualStyleBackColor(true);
		((UpDownBase)NumericUpDownX).set_BackColor(Color.White);
		((Control)NumericUpDownX).set_Enabled(false);
		((Control)NumericUpDownX).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)NumericUpDownX).set_ImeMode((ImeMode)0);
		((Control)NumericUpDownX).set_Location(new Point(283, 83));
		NumericUpDownX.set_Maximum(new decimal(new int[4] { 15, 0, 0, 0 }));
		NumericUpDownX.set_Minimum(new decimal(new int[4] { 4, 0, 0, 0 }));
		((Control)NumericUpDownX).set_Name("NumericUpDownX");
		((UpDownBase)NumericUpDownX).set_ReadOnly(true);
		((Control)NumericUpDownX).set_Size(new Size(59, 32));
		((Control)NumericUpDownX).set_TabIndex(2);
		((UpDownBase)NumericUpDownX).set_TextAlign((HorizontalAlignment)2);
		NumericUpDownX.set_Value(new decimal(new int[4] { 4, 0, 0, 0 }));
		((Control)Label1).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label1).set_Location(new Point(345, 80));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(37, 32));
		((Control)Label1).set_TabIndex(5);
		Label1.set_Text("x");
		Label1.set_TextAlign((ContentAlignment)32);
		((UpDownBase)NumericUpDownY).set_BackColor(Color.White);
		((Control)NumericUpDownY).set_Enabled(false);
		((Control)NumericUpDownY).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)NumericUpDownY).set_ImeMode((ImeMode)0);
		((Control)NumericUpDownY).set_Location(new Point(381, 83));
		NumericUpDownY.set_Maximum(new decimal(new int[4] { 6, 0, 0, 0 }));
		NumericUpDownY.set_Minimum(new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)NumericUpDownY).set_Name("NumericUpDownY");
		((UpDownBase)NumericUpDownY).set_ReadOnly(true);
		((Control)NumericUpDownY).set_Size(new Size(59, 32));
		((Control)NumericUpDownY).set_TabIndex(3);
		((UpDownBase)NumericUpDownY).set_TextAlign((HorizontalAlignment)2);
		NumericUpDownY.set_Value(new decimal(new int[4] { 4, 0, 0, 0 }));
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label2).set_Location(new Point(12, 9));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(231, 32));
		((Control)Label2).set_TabIndex(7);
		Label2.set_Text("Difficulty selection");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label3).set_Location(new Point(277, 9));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(206, 32));
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text("Number of cards");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label4).set_Location(new Point(278, 55));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(64, 25));
		((Control)Label4).set_TabIndex(9);
		Label4.set_Text("X asix");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label5).set_Location(new Point(376, 55));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(64, 25));
		((Control)Label5).set_TabIndex(10);
		Label5.set_Text("Y axis");
		((Control)Label6).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label6).set_Location(new Point(446, 81));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(37, 32));
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text("=");
		Label6.set_TextAlign((ContentAlignment)32);
		((Control)lblTotalNumberOfCards).set_BackColor(Color.White);
		lblTotalNumberOfCards.set_BorderStyle((BorderStyle)1);
		((Control)lblTotalNumberOfCards).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lblTotalNumberOfCards).set_Location(new Point(489, 83));
		((Control)lblTotalNumberOfCards).set_Name("lblTotalNumberOfCards");
		((Control)lblTotalNumberOfCards).set_Size(new Size(55, 32));
		((Control)lblTotalNumberOfCards).set_TabIndex(12);
		lblTotalNumberOfCards.set_Text("16");
		lblTotalNumberOfCards.set_TextAlign((ContentAlignment)32);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label7).set_Location(new Point(277, 172));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(159, 32));
		((Control)Label7).set_TabIndex(13);
		Label7.set_Text("Time to beat");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label8).set_Location(new Point(297, 228));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(92, 25));
		((Control)Label8).set_TabIndex(14);
		Label8.set_Text("1st place");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label9).set_Location(new Point(297, 281));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(107, 25));
		((Control)Label9).set_TabIndex(15);
		Label9.set_Text("10th place");
		((Control)lblFirst).set_Anchor((AnchorStyles)0);
		lblFirst.set_BorderStyle((BorderStyle)1);
		((Control)lblFirst).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lblFirst).set_Location(new Point(432, 222));
		((Control)lblFirst).set_Name("lblFirst");
		((Control)lblFirst).set_Size(new Size(84, 34));
		((Control)lblFirst).set_TabIndex(16);
		lblFirst.set_Text("00:00");
		lblFirst.set_TextAlign((ContentAlignment)32);
		((Control)lblLast).set_Anchor((AnchorStyles)0);
		lblLast.set_BorderStyle((BorderStyle)1);
		((Control)lblLast).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lblLast).set_Location(new Point(432, 275));
		((Control)lblLast).set_Name("lblLast");
		((Control)lblLast).set_Size(new Size(84, 34));
		((Control)lblLast).set_TabIndex(17);
		lblLast.set_Text("00:00");
		lblLast.set_TextAlign((ContentAlignment)32);
		((Form)this).set_AcceptButton((IButtonControl)(object)cmdStart);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		((Form)this).set_CancelButton((IButtonControl)(object)cmdBack);
		((Form)this).set_ClientSize(new Size(560, 334));
		((Control)this).get_Controls().Add((Control)(object)lblLast);
		((Control)this).get_Controls().Add((Control)(object)lblFirst);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)lblTotalNumberOfCards);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)NumericUpDownY);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)NumericUpDownX);
		((Control)this).get_Controls().Add((Control)(object)cmdBack);
		((Control)this).get_Controls().Add((Control)(object)cmdStart);
		((Control)this).get_Controls().Add((Control)(object)lstDifficulty);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmGameSelect");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmGameSelect");
		((ISupportInitialize)NumericUpDownX).EndInit();
		((ISupportInitialize)NumericUpDownY).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.frmMainMenu).Show();
	}

	private void cmdStart_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmGameplay.SetNumberOfCards(NumericUpDownX.get_Value(), NumericUpDownY.get_Value());
		((Control)this).Hide();
		if (!MyProject.Forms.frmGameplay.IsFirstRun())
		{
			MyProject.Forms.frmGameplay.InitializeCardBoard();
		}
		((Control)MyProject.Forms.frmGameplay).Show();
	}

	private void lstDifficulty_SelectedIndexChanged(object sender, EventArgs e)
	{
		RefreshTime();
		switch (lstDifficulty.get_SelectedIndex())
		{
		case 0:
		{
			object obj = 4;
			object obj2 = 4;
			SetInputValue(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj2));
			break;
		}
		case 1:
		{
			object obj = 8;
			object obj2 = 4;
			SetInputValue(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj2));
			break;
		}
		case 2:
		{
			object obj = 10;
			object obj2 = 5;
			SetInputValue(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj2));
			break;
		}
		case 3:
			((Control)NumericUpDownX).set_Enabled(true);
			((Control)NumericUpDownY).set_Enabled(true);
			break;
		}
	}

	private void SetInputValue(object valueX, object valueY)
	{
		NumericUpDownX.set_Value(Conversions.ToDecimal(valueX));
		NumericUpDownY.set_Value(Conversions.ToDecimal(valueY));
		((Control)NumericUpDownX).set_Enabled(false);
		((Control)NumericUpDownY).set_Enabled(false);
	}

	public void RefreshTime()
	{
		if (lstDifficulty.get_SelectedIndex() == 3)
		{
			lblFirst.set_Text("––:––");
			lblLast.set_Text("––:––");
		}
		else
		{
			lblFirst.set_Text(SetTime(GetDifficultyID(), 1));
			lblLast.set_Text(SetTime(GetDifficultyID(), 10));
		}
	}

	private void NumericUpDownX_ValueChanged(object sender, EventArgs e)
	{
		HandleOddNumbers(NumericUpDownX.get_Value(), NumericUpDownY.get_Value());
	}

	private void NumericUpDownY_ValueChanged(object sender, EventArgs e)
	{
		HandleOddNumbers(NumericUpDownX.get_Value(), NumericUpDownY.get_Value());
	}

	private void HandleOddNumbers(object Number1, object Number2)
	{
		object obj = Operators.MultiplyObject(Number1, Number2);
		while (Operators.ConditionalCompareObjectGreater(obj, (object)0, false))
		{
			obj = Operators.SubtractObject(obj, (object)2);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)0, false))
		{
			((UpDownBase)NumericUpDownX).set_BackColor(Color.White);
			((UpDownBase)NumericUpDownY).set_BackColor(Color.White);
			((Control)lblTotalNumberOfCards).set_BackColor(Color.White);
			((Control)cmdStart).set_Enabled(true);
		}
		else
		{
			((UpDownBase)NumericUpDownX).set_BackColor(Color.LightCoral);
			((UpDownBase)NumericUpDownY).set_BackColor(Color.LightCoral);
			((Control)lblTotalNumberOfCards).set_BackColor(Color.LightCoral);
			((Control)cmdStart).set_Enabled(false);
		}
		RecalculateNumberOfCards();
	}

	private void RecalculateNumberOfCards()
	{
		lblTotalNumberOfCards.set_Text(Conversions.ToString(decimal.Multiply(NumericUpDownX.get_Value(), NumericUpDownY.get_Value())));
	}

	public object GetDifficulty(bool convertToUppercase)
	{
		string text = lstDifficulty.get_Text();
		if (convertToUppercase)
		{
			text = Strings.UCase(text);
		}
		return text;
	}

	private void frmGameSelect_Load(object sender, EventArgs e)
	{
		lstDifficulty.set_SelectedIndex(0);
	}

	public int GetDifficultyID()
	{
		object difficulty = GetDifficulty(convertToUppercase: false);
		if (Operators.ConditionalCompareObjectEqual(difficulty, (object)"Easy", false))
		{
			return 1;
		}
		if (Operators.ConditionalCompareObjectEqual(difficulty, (object)"Normal", false))
		{
			return 3;
		}
		if (Operators.ConditionalCompareObjectEqual(difficulty, (object)"Hard", false))
		{
			return 5;
		}
		return 0;
	}

	public string SetTime(object difficultyID, object position)
	{
		string[] array = Strings.Split(Conversions.ToString(((ApplicationSettingsBase)MySettingsProperty.Settings).get_Item("L" + Conversions.ToString(Operators.AddObject(difficultyID, (object)1)))), ";", -1, (CompareMethod)0);
		return array[Conversions.ToInteger(Operators.SubtractObject(position, (object)1))];
	}
}
