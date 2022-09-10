using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmNewOptionsStock : InheritedForm
{
	public delegate void StockAddedEventHandler(string strBridgeSymbol);

	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("UltraGroupBox3")]
	private UltraGroupBox _UltraGroupBox3;

	[AccessedThroughProperty("btnClose")]
	private UltraButton _btnClose;

	[AccessedThroughProperty("UltraGroupBox2")]
	private UltraGroupBox _UltraGroupBox2;

	[AccessedThroughProperty("btnStockAdd1")]
	private UltraButton _btnStockAdd1;

	[AccessedThroughProperty("cmbCategory1")]
	private UltraComboEditor _cmbCategory1;

	[AccessedThroughProperty("cmbName")]
	private UltraComboEditor _cmbName;

	[AccessedThroughProperty("UltraGroupBox1")]
	private UltraGroupBox _UltraGroupBox1;

	[AccessedThroughProperty("btnStockAdd")]
	private UltraButton _btnStockAdd;

	[AccessedThroughProperty("cmbCategory")]
	private UltraComboEditor _cmbCategory;

	[AccessedThroughProperty("txtSymbol")]
	private UltraTextEditor _txtSymbol;

	[AccessedThroughProperty("cmbOption_Type1")]
	private UltraComboEditor _cmbOption_Type1;

	[AccessedThroughProperty("cmbOption_Type")]
	private UltraComboEditor _cmbOption_Type;

	private string strSQL;

	private clsEquity objEquity;

	private StockAddedEventHandler StockAddedEvent;

	internal virtual UltraGroupBox UltraGroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGroupBox3 = value;
		}
	}

	internal virtual UltraButton btnClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_btnClose = value;
		}
	}

	internal virtual UltraGroupBox UltraGroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGroupBox2 = value;
		}
	}

	internal virtual UltraButton btnStockAdd1
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnStockAdd1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnStockAdd1 != null)
			{
				((Control)_btnStockAdd1).remove_Click((EventHandler)btnStockAdd1_Click);
			}
			_btnStockAdd1 = value;
			if (_btnStockAdd1 != null)
			{
				((Control)_btnStockAdd1).add_Click((EventHandler)btnStockAdd1_Click);
			}
		}
	}

	internal virtual UltraComboEditor cmbCategory1
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbCategory1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbCategory1 = value;
		}
	}

	internal virtual UltraComboEditor cmbName
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbName = value;
		}
	}

	internal virtual UltraGroupBox UltraGroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraGroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraGroupBox1 = value;
		}
	}

	internal virtual UltraButton btnStockAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnStockAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnStockAdd != null)
			{
				((Control)_btnStockAdd).remove_Click((EventHandler)btnStockAdd_Click);
			}
			_btnStockAdd = value;
			if (_btnStockAdd != null)
			{
				((Control)_btnStockAdd).add_Click((EventHandler)btnStockAdd_Click);
			}
		}
	}

	internal virtual UltraComboEditor cmbCategory
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbCategory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbCategory = value;
		}
	}

	internal virtual UltraTextEditor txtSymbol
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSymbol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSymbol = value;
		}
	}

	internal virtual UltraComboEditor cmbOption_Type1
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbOption_Type1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbOption_Type1 = value;
		}
	}

	internal virtual UltraComboEditor cmbOption_Type
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbOption_Type;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbOption_Type = value;
		}
	}

	public event StockAddedEventHandler StockAdded
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			StockAddedEvent = (StockAddedEventHandler)Delegate.Combine(StockAddedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			StockAddedEvent = (StockAddedEventHandler)Delegate.Remove(StockAddedEvent, value);
		}
	}

	[DebuggerNonUserCode]
	public frmNewOptionsStock()
	{
		((Form)this).add_Load((EventHandler)frmOptionsNewStock_Load);
		__ENCList.Add(new WeakReference(this));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected O, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Expected O, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected O, but got Unknown
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		ValueListItem val3 = new ValueListItem();
		ValueListItem val4 = new ValueListItem();
		ValueListItem val5 = new ValueListItem();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		ValueListItem val8 = new ValueListItem();
		ValueListItem val9 = new ValueListItem();
		ValueListItem val10 = new ValueListItem();
		Appearance val11 = new Appearance();
		UltraGroupBox3 = new UltraGroupBox();
		btnClose = new UltraButton();
		UltraGroupBox2 = new UltraGroupBox();
		cmbOption_Type1 = new UltraComboEditor();
		btnStockAdd1 = new UltraButton();
		cmbCategory1 = new UltraComboEditor();
		cmbName = new UltraComboEditor();
		UltraGroupBox1 = new UltraGroupBox();
		cmbOption_Type = new UltraComboEditor();
		btnStockAdd = new UltraButton();
		cmbCategory = new UltraComboEditor();
		txtSymbol = new UltraTextEditor();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((ISupportInitialize)UltraGroupBox3).BeginInit();
		((Control)UltraGroupBox3).SuspendLayout();
		((ISupportInitialize)UltraGroupBox2).BeginInit();
		((Control)UltraGroupBox2).SuspendLayout();
		((ISupportInitialize)cmbOption_Type1).BeginInit();
		((ISupportInitialize)cmbCategory1).BeginInit();
		((ISupportInitialize)cmbName).BeginInit();
		((ISupportInitialize)UltraGroupBox1).BeginInit();
		((Control)UltraGroupBox1).SuspendLayout();
		((ISupportInitialize)cmbOption_Type).BeginInit();
		((ISupportInitialize)cmbCategory).BeginInit();
		((ISupportInitialize)txtSymbol).BeginInit();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox3);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox2);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox1);
		UltraGroupBox obj = grForm;
		Size size = new Size(604, 290);
		((Control)obj).set_Size(size);
		grForm.set_Text("OPTIONS NEW STOCK");
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox1, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox2, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox3, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(564, 2);
		((Control)closeButton).set_Location(location);
		((Control)CloseButton).set_TabIndex(0);
		UltraGroupBox3.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)btnClose);
		((Control)UltraGroupBox3).set_Dock((DockStyle)1);
		UltraGroupBox ultraGroupBox = UltraGroupBox3;
		location = new Point(3, 229);
		((Control)ultraGroupBox).set_Location(location);
		((Control)UltraGroupBox3).set_Name("UltraGroupBox3");
		UltraGroupBox ultraGroupBox2 = UltraGroupBox3;
		size = new Size(598, 56);
		((Control)ultraGroupBox2).set_Size(size);
		((Control)UltraGroupBox3).set_TabIndex(20);
		UltraGroupBox3.set_ViewStyle((GroupBoxViewStyle)3);
		val.set_BorderColor(Color.Black);
		val.set_BorderColor2(Color.Black);
		((ControlBase)btnClose).set_Appearance((AppearanceBase)(object)val);
		((UltraButtonBase)btnClose).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnClose).set_DialogResult((DialogResult)2);
		((Control)btnClose).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj2 = btnClose;
		location = new Point(219, 16);
		((Control)obj2).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		UltraButton obj3 = btnClose;
		size = new Size(160, 23);
		((Control)obj3).set_Size(size);
		((Control)btnClose).set_TabIndex(9);
		((ControlBase)btnClose).set_Text("CLOSE");
		UltraGroupBox2.set_CaptionAlignment((GroupBoxCaptionAlignment)3);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbOption_Type1);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)btnStockAdd1);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbCategory1);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbName);
		((Control)UltraGroupBox2).set_Dock((DockStyle)1);
		val2.get_FontData().set_BoldAsString("True");
		val2.get_FontData().set_ItalicAsString("True");
		val2.get_FontData().set_SizeInPoints(10f);
		UltraGroupBox2.set_HeaderAppearance((AppearanceBase)(object)val2);
		UltraGroupBox2.set_HeaderBorderStyle((UIElementBorderStyle)12);
		UltraGroupBox2.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox ultraGroupBox3 = UltraGroupBox2;
		location = new Point(3, 129);
		((Control)ultraGroupBox3).set_Location(location);
		((Control)UltraGroupBox2).set_Name("UltraGroupBox2");
		UltraGroupBox ultraGroupBox4 = UltraGroupBox2;
		size = new Size(598, 100);
		((Control)ultraGroupBox4).set_Size(size);
		((Control)UltraGroupBox2).set_TabIndex(19);
		UltraGroupBox2.set_Text("STOCK NAME");
		UltraGroupBox2.set_ViewStyle((GroupBoxViewStyle)3);
		cmbOption_Type1.set_AutoComplete(true);
		((TextEditorControlBase)cmbOption_Type1).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		cmbOption_Type1.set_DropDownStyle((DropDownStyle)1);
		((Control)cmbOption_Type1).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val3.set_DataValue((object)"0");
		val3.set_DisplayText("- All -");
		val4.set_DataValue((object)"P");
		val4.set_DisplayText("P");
		val5.set_DataValue((object)"C");
		val5.set_DisplayText("C");
		cmbOption_Type1.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[3] { val3, val4, val5 });
		UltraComboEditor obj4 = cmbOption_Type1;
		location = new Point(338, 48);
		((Control)obj4).set_Location(location);
		((Control)cmbOption_Type1).set_Name("cmbOption_Type1");
		UltraComboEditor obj5 = cmbOption_Type1;
		size = new Size(70, 23);
		((Control)obj5).set_Size(size);
		((Control)cmbOption_Type1).set_TabIndex(7);
		val6.set_BorderColor(Color.Black);
		val6.set_BorderColor2(Color.Black);
		((ControlBase)btnStockAdd1).set_Appearance((AppearanceBase)(object)val6);
		((UltraButtonBase)btnStockAdd1).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnStockAdd1).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj6 = btnStockAdd1;
		location = new Point(420, 48);
		((Control)obj6).set_Location(location);
		((Control)btnStockAdd1).set_Name("btnStockAdd1");
		UltraButton obj7 = btnStockAdd1;
		size = new Size(160, 23);
		((Control)obj7).set_Size(size);
		((Control)btnStockAdd1).set_TabIndex(8);
		((ControlBase)btnStockAdd1).set_Text("ADD");
		cmbCategory1.set_AutoComplete(true);
		((TextEditorControlBase)cmbCategory1).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		cmbCategory1.set_DropDownStyle((DropDownStyle)1);
		((Control)cmbCategory1).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj8 = cmbCategory1;
		location = new Point(178, 48);
		((Control)obj8).set_Location(location);
		((Control)cmbCategory1).set_Name("cmbCategory1");
		UltraComboEditor obj9 = cmbCategory1;
		size = new Size(148, 23);
		((Control)obj9).set_Size(size);
		((Control)cmbCategory1).set_TabIndex(6);
		cmbName.set_AutoComplete(true);
		((TextEditorControlBase)cmbName).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbName).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj10 = cmbName;
		location = new Point(18, 48);
		((Control)obj10).set_Location(location);
		((Control)cmbName).set_Name("cmbName");
		UltraComboEditor obj11 = cmbName;
		size = new Size(148, 23);
		((Control)obj11).set_Size(size);
		((Control)cmbName).set_TabIndex(5);
		UltraGroupBox1.set_CaptionAlignment((GroupBoxCaptionAlignment)3);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)cmbOption_Type);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)btnStockAdd);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)cmbCategory);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)txtSymbol);
		((Control)UltraGroupBox1).set_Dock((DockStyle)1);
		val7.get_FontData().set_BoldAsString("True");
		val7.get_FontData().set_ItalicAsString("True");
		val7.get_FontData().set_SizeInPoints(10f);
		UltraGroupBox1.set_HeaderAppearance((AppearanceBase)(object)val7);
		UltraGroupBox1.set_HeaderBorderStyle((UIElementBorderStyle)12);
		UltraGroupBox1.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox ultraGroupBox5 = UltraGroupBox1;
		location = new Point(3, 29);
		((Control)ultraGroupBox5).set_Location(location);
		((Control)UltraGroupBox1).set_Name("UltraGroupBox1");
		UltraGroupBox ultraGroupBox6 = UltraGroupBox1;
		size = new Size(598, 100);
		((Control)ultraGroupBox6).set_Size(size);
		((Control)UltraGroupBox1).set_TabIndex(18);
		UltraGroupBox1.set_Text("STOCK SYMBOL");
		UltraGroupBox1.set_ViewStyle((GroupBoxViewStyle)3);
		cmbOption_Type.set_AutoComplete(true);
		((TextEditorControlBase)cmbOption_Type).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		cmbOption_Type.set_DropDownStyle((DropDownStyle)1);
		((Control)cmbOption_Type).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val8.set_DataValue((object)"0");
		val8.set_DisplayText("- All -");
		val9.set_DataValue((object)"P");
		val9.set_DisplayText("P");
		val10.set_DataValue((object)"C");
		val10.set_DisplayText("C");
		cmbOption_Type.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[3] { val8, val9, val10 });
		UltraComboEditor obj12 = cmbOption_Type;
		location = new Point(338, 51);
		((Control)obj12).set_Location(location);
		((Control)cmbOption_Type).set_Name("cmbOption_Type");
		UltraComboEditor obj13 = cmbOption_Type;
		size = new Size(70, 23);
		((Control)obj13).set_Size(size);
		((Control)cmbOption_Type).set_TabIndex(3);
		val11.set_BorderColor(Color.Black);
		val11.set_BorderColor2(Color.Black);
		((ControlBase)btnStockAdd).set_Appearance((AppearanceBase)(object)val11);
		((UltraButtonBase)btnStockAdd).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnStockAdd).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj14 = btnStockAdd;
		location = new Point(420, 52);
		((Control)obj14).set_Location(location);
		((Control)btnStockAdd).set_Name("btnStockAdd");
		UltraButton obj15 = btnStockAdd;
		size = new Size(160, 23);
		((Control)obj15).set_Size(size);
		((Control)btnStockAdd).set_TabIndex(4);
		((ControlBase)btnStockAdd).set_Text("ADD");
		cmbCategory.set_AutoComplete(true);
		((TextEditorControlBase)cmbCategory).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		cmbCategory.set_DropDownStyle((DropDownStyle)1);
		((Control)cmbCategory).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj16 = cmbCategory;
		location = new Point(178, 51);
		((Control)obj16).set_Location(location);
		((Control)cmbCategory).set_Name("cmbCategory");
		UltraComboEditor obj17 = cmbCategory;
		size = new Size(148, 23);
		((Control)obj17).set_Size(size);
		((Control)cmbCategory).set_TabIndex(2);
		((TextEditorControlBase)txtSymbol).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)txtSymbol).set_Enabled(false);
		UltraTextEditor obj18 = txtSymbol;
		location = new Point(18, 52);
		((Control)obj18).set_Location(location);
		((Control)txtSymbol).set_Name("txtSymbol");
		UltraTextEditor obj19 = txtSymbol;
		size = new Size(148, 22);
		((Control)obj19).set_Size(size);
		((Control)txtSymbol).set_TabIndex(1);
		((TextEditorControlBase)txtSymbol).set_Text("IN;NSX");
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		size = new Size(604, 290);
		((Form)this).set_ClientSize(size);
		((Control)this).set_Name("frmNewOptionsStock");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((ISupportInitialize)UltraGroupBox3).EndInit();
		((Control)UltraGroupBox3).ResumeLayout(false);
		((ISupportInitialize)UltraGroupBox2).EndInit();
		((Control)UltraGroupBox2).ResumeLayout(false);
		((Control)UltraGroupBox2).PerformLayout();
		((ISupportInitialize)cmbOption_Type1).EndInit();
		((ISupportInitialize)cmbCategory1).EndInit();
		((ISupportInitialize)cmbName).EndInit();
		((ISupportInitialize)UltraGroupBox1).EndInit();
		((Control)UltraGroupBox1).ResumeLayout(false);
		((Control)UltraGroupBox1).PerformLayout();
		((ISupportInitialize)cmbOption_Type).EndInit();
		((ISupportInitialize)cmbCategory).EndInit();
		((ISupportInitialize)txtSymbol).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmOptionsNewStock_Load(object sender, EventArgs e)
	{
		BindControls();
		((TextEditorControlBase)txtSymbol).Focus();
	}

	private void btnStockAdd_Click(object sender, EventArgs e)
	{
		Options_Add(((TextEditorControlBase)txtSymbol).get_Text(), cmbCategory, cmbOption_Type);
	}

	private void btnStockAdd1_Click(object sender, EventArgs e)
	{
		try
		{
			Options_Add(Conversions.ToString(cmbName.get_Value()), cmbCategory1, cmbOption_Type1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BindControls()
	{
		try
		{
			DataTable dataTable = new DataTable();
			strSQL = "Select  Distinct CONVERT(VARCHAR(3),DATENAME(m,Expiry_Date)) AS MonthName, RIGHT(YEAR(Expiry_Date),2) AS MonthYear, [Expiry_Date]  from FNO_TRANSACTION_DATA order  by expiry_DATE";
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			DataRow dataRow = dataTable.NewRow();
			dataRow[0] = "- All -";
			dataRow[1] = 0;
			dataTable.Rows.InsertAt(dataRow, 0);
			cmbCategory1.set_DataSource((object)dataTable);
			cmbCategory1.DataBind();
			cmbCategory.set_DataSource((object)dataTable);
			cmbCategory.DataBind();
			cmbCategory1.set_DisplayMember("MonthName");
			cmbCategory1.set_ValueMember("MonthYear");
			cmbCategory.set_DisplayMember("MonthName");
			cmbCategory.set_ValueMember("MonthYear");
			strSQL = "Select Distinct Left(BridgeSymbol,len(BridgeSymbol)-8) as ES,Exchangesymbol from OPTIONS_TRANSACTION_DATA order by Exchangesymbol";
			cmbName.set_DataSource((object)SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0]);
			cmbName.set_DisplayMember("Exchangesymbol");
			cmbName.set_ValueMember("ES");
			cmbCategory.set_SelectedIndex(0);
			cmbCategory1.set_SelectedIndex(0);
			cmbName.set_SelectedIndex(0);
			cmbOption_Type.set_SelectedIndex(0);
			cmbOption_Type1.set_SelectedIndex(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AddOptionsLookUp(string strSymbol, string strBridgeSymbol, string strMonthName, UltraComboEditor cmbOption)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(strBridgeSymbol, "", false) == 0)
				{
					return;
				}
				string text = "";
				strSQL = "SELECT * FROM OPTIONS_TRANSACTION_DATA WHERE [CLOSE]>0   and newBridgesymbol is not NULL   and ExchangeSymbol is not NULL   and Expiry_date is not NULL   and option_type is not NULL   and Market_type is not NULL  AND newBridgeSymbol<>''";
				strSQL = strSQL + " and newBridgesymbol like '%" + Strings.Trim(Strings.UCase(strBridgeSymbol)) + "%'";
				strSQL = strSQL + " and UPPER(LEFT(DATENAME(m, Expiry_date),3)) ='" + Strings.Trim(Strings.UCase(strMonthName)) + "'";
				string text2 = "";
				if (Operators.ConditionalCompareObjectEqual(cmbOption.get_Value(), (object)"0", false))
				{
					int num = ((DisposableObjectCollectionBase)cmbOption.get_Items()).get_Count() - 1;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						text2 = ((num2 != 1) ? Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text2 + ",'"), cmbOption.get_Items().get_Item(num2).get_DataValue()), (object)"'")) : Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", cmbOption.get_Items().get_Item(num2).get_DataValue()), (object)"'")));
						num2++;
					}
				}
				else
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", cmbOption.get_Value()), (object)"'"));
				}
				strSQL = strSQL + " AND LEFT(Option_Type,1) IN (" + text2 + ")";
				DataTable dataTable = new DataTable();
				dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				int num5 = dataTable.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						objEquity = new clsEquity();
						string text3 = Conversions.ToString(DateAndTime.Month(Conversions.ToDate("01 " + strMonthName + " 2009")));
						text3 = Conversions.ToString(Interaction.IIf(text3.Length == 1, (object)("0" + text3), (object)text3));
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[num6]["ExchangeSymbol"], (object)"-"), (object)text3), (object)"-"), dataTable.Rows[num6]["Option_Type"]), (object)"-"), dataTable.Rows[num6]["Strike_Price"]));
						objEquity.AddLookUp(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(strBridgeSymbol + "."), dataTable.Rows[num6]["Option_Type"]), (object)"."), dataTable.Rows[num6]["Strike_Price"])), text, "OPTIONS", -2);
						objEquity = null;
						StockAddedEvent?.Invoke(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(strBridgeSymbol + "."), dataTable.Rows[num6]["Option_Type"]), (object)"."), dataTable.Rows[num6]["Strike_Price"])));
						num6++;
						continue;
					}
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Options_Add(string strSymbol, UltraComboEditor cmbCat, UltraComboEditor cmbOptiontype)
	{
		Money_Splash money_Splash = new Money_Splash();
		checked
		{
			try
			{
				((Control)money_Splash).Show();
				((Control)money_Splash).Refresh();
				if (Operators.ConditionalCompareObjectEqual(cmbCat.get_Value(), (object)0, false))
				{
					int num = ((DisposableObjectCollectionBase)cmbCat.get_Items()).get_Count() - 1;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							AddOptionsLookUp(strSymbol, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)strSymbol, cmbCat.get_Items().get_Item(num2).get_DataValue()), (object)cmbCat.get_Items().get_Item(num2).get_DisplayText())), cmbCat.get_Items().get_Item(num2).get_DisplayText(), cmbOptiontype);
							num2++;
							continue;
						}
						break;
					}
				}
				else
				{
					AddOptionsLookUp(strSymbol, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)strSymbol, cmbCat.get_Value()), (object)cmbCat.get_Text())), cmbCat.get_Text(), cmbOptiontype);
				}
				objEquity = new clsEquity();
				objEquity.Update_ConnectedUsers(-2);
				((Form)money_Splash).Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((Form)money_Splash).Close();
				ProjectData.ClearProjectError();
			}
		}
	}
}
