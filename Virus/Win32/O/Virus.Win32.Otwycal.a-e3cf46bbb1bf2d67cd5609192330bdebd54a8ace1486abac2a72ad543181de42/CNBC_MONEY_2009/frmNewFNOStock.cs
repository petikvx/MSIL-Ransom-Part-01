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
public class frmNewFNOStock : InheritedForm
{
	public delegate void StockAddedEventHandler(string strBridgeSymbol);

	public delegate void RefreshGridEventHandler();

	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("UltraGroupBox1")]
	private UltraGroupBox _UltraGroupBox1;

	[AccessedThroughProperty("txtSymbol")]
	private UltraTextEditor _txtSymbol;

	[AccessedThroughProperty("cmbCategory")]
	private UltraComboEditor _cmbCategory;

	[AccessedThroughProperty("btnStockAdd")]
	private UltraButton _btnStockAdd;

	[AccessedThroughProperty("UltraGroupBox2")]
	private UltraGroupBox _UltraGroupBox2;

	[AccessedThroughProperty("UltraGroupBox3")]
	private UltraGroupBox _UltraGroupBox3;

	[AccessedThroughProperty("btnClose")]
	private UltraButton _btnClose;

	[AccessedThroughProperty("btnStockAdd1")]
	private UltraButton _btnStockAdd1;

	[AccessedThroughProperty("cmbCategory1")]
	private UltraComboEditor _cmbCategory1;

	[AccessedThroughProperty("cmbName")]
	private UltraComboEditor _cmbName;

	private string strSQL;

	private clsEquity objEquity;

	private StockAddedEventHandler StockAddedEvent;

	private RefreshGridEventHandler RefreshGridEvent;

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
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_txtSymbol != null)
			{
				((Control)_txtSymbol).remove_KeyUp(new KeyEventHandler(txtSymbol_KeyUp));
			}
			_txtSymbol = value;
			if (_txtSymbol != null)
			{
				((Control)_txtSymbol).add_KeyUp(new KeyEventHandler(txtSymbol_KeyUp));
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
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_cmbCategory != null)
			{
				((Control)_cmbCategory).remove_KeyUp(new KeyEventHandler(cmbCategory_KeyUp));
			}
			_cmbCategory = value;
			if (_cmbCategory != null)
			{
				((Control)_cmbCategory).add_KeyUp(new KeyEventHandler(cmbCategory_KeyUp));
			}
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
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_cmbCategory1 != null)
			{
				((Control)_cmbCategory1).remove_KeyUp(new KeyEventHandler(cmbCategory1_KeyUp));
			}
			_cmbCategory1 = value;
			if (_cmbCategory1 != null)
			{
				((Control)_cmbCategory1).add_KeyUp(new KeyEventHandler(cmbCategory1_KeyUp));
			}
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
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_cmbName != null)
			{
				((Control)_cmbName).remove_KeyUp(new KeyEventHandler(cmbName_KeyUp));
			}
			_cmbName = value;
			if (_cmbName != null)
			{
				((Control)_cmbName).add_KeyUp(new KeyEventHandler(cmbName_KeyUp));
			}
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

	public event RefreshGridEventHandler RefreshGrid
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			RefreshGridEvent = (RefreshGridEventHandler)Delegate.Combine(RefreshGridEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			RefreshGridEvent = (RefreshGridEventHandler)Delegate.Remove(RefreshGridEvent, value);
		}
	}

	[DebuggerNonUserCode]
	public frmNewFNOStock()
	{
		((Form)this).add_Load((EventHandler)frmFNONewStock_Load);
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
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Appearance val4 = new Appearance();
		Appearance val5 = new Appearance();
		UltraGroupBox1 = new UltraGroupBox();
		btnStockAdd = new UltraButton();
		cmbCategory = new UltraComboEditor();
		txtSymbol = new UltraTextEditor();
		UltraGroupBox2 = new UltraGroupBox();
		btnStockAdd1 = new UltraButton();
		cmbCategory1 = new UltraComboEditor();
		cmbName = new UltraComboEditor();
		UltraGroupBox3 = new UltraGroupBox();
		btnClose = new UltraButton();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((ISupportInitialize)UltraGroupBox1).BeginInit();
		((Control)UltraGroupBox1).SuspendLayout();
		((ISupportInitialize)cmbCategory).BeginInit();
		((ISupportInitialize)txtSymbol).BeginInit();
		((ISupportInitialize)UltraGroupBox2).BeginInit();
		((Control)UltraGroupBox2).SuspendLayout();
		((ISupportInitialize)cmbCategory1).BeginInit();
		((ISupportInitialize)cmbName).BeginInit();
		((ISupportInitialize)UltraGroupBox3).BeginInit();
		((Control)UltraGroupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox3);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox2);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox1);
		UltraGroupBox obj = grForm;
		Size size = new Size(519, 288);
		((Control)obj).set_Size(size);
		grForm.set_Text("FNO NEW STOCK");
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox1, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox2, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox3, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(480, 2);
		((Control)closeButton).set_Location(location);
		((Control)CloseButton).set_TabIndex(7);
		UltraGroupBox1.set_CaptionAlignment((GroupBoxCaptionAlignment)3);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)btnStockAdd);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)cmbCategory);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)txtSymbol);
		((Control)UltraGroupBox1).set_Dock((DockStyle)1);
		val.get_FontData().set_BoldAsString("True");
		val.get_FontData().set_ItalicAsString("True");
		val.get_FontData().set_SizeInPoints(10f);
		UltraGroupBox1.set_HeaderAppearance((AppearanceBase)(object)val);
		UltraGroupBox1.set_HeaderBorderStyle((UIElementBorderStyle)12);
		UltraGroupBox1.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox ultraGroupBox = UltraGroupBox1;
		location = new Point(3, 29);
		((Control)ultraGroupBox).set_Location(location);
		((Control)UltraGroupBox1).set_Name("UltraGroupBox1");
		UltraGroupBox ultraGroupBox2 = UltraGroupBox1;
		size = new Size(513, 100);
		((Control)ultraGroupBox2).set_Size(size);
		((Control)UltraGroupBox1).set_TabIndex(15);
		UltraGroupBox1.set_Text("STOCK SYMBOL");
		UltraGroupBox1.set_ViewStyle((GroupBoxViewStyle)3);
		val2.set_BorderColor(Color.Black);
		val2.set_BorderColor2(Color.Black);
		((ControlBase)btnStockAdd).set_Appearance((AppearanceBase)(object)val2);
		((UltraButtonBase)btnStockAdd).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnStockAdd).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj2 = btnStockAdd;
		location = new Point(338, 52);
		((Control)obj2).set_Location(location);
		((Control)btnStockAdd).set_Name("btnStockAdd");
		UltraButton obj3 = btnStockAdd;
		size = new Size(160, 23);
		((Control)obj3).set_Size(size);
		((Control)btnStockAdd).set_TabIndex(2);
		((ControlBase)btnStockAdd).set_Text("ADD");
		cmbCategory.set_AutoComplete(true);
		((TextEditorControlBase)cmbCategory).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		cmbCategory.set_DropDownStyle((DropDownStyle)1);
		((Control)cmbCategory).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj4 = cmbCategory;
		location = new Point(178, 51);
		((Control)obj4).set_Location(location);
		((Control)cmbCategory).set_Name("cmbCategory");
		UltraComboEditor obj5 = cmbCategory;
		size = new Size(148, 23);
		((Control)obj5).set_Size(size);
		((Control)cmbCategory).set_TabIndex(1);
		((TextEditorControlBase)txtSymbol).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		UltraTextEditor obj6 = txtSymbol;
		location = new Point(18, 52);
		((Control)obj6).set_Location(location);
		((Control)txtSymbol).set_Name("txtSymbol");
		UltraTextEditor obj7 = txtSymbol;
		size = new Size(148, 22);
		((Control)obj7).set_Size(size);
		((Control)txtSymbol).set_TabIndex(0);
		UltraGroupBox2.set_CaptionAlignment((GroupBoxCaptionAlignment)3);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)btnStockAdd1);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbCategory1);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbName);
		((Control)UltraGroupBox2).set_Dock((DockStyle)1);
		val3.get_FontData().set_BoldAsString("True");
		val3.get_FontData().set_ItalicAsString("True");
		val3.get_FontData().set_SizeInPoints(10f);
		UltraGroupBox2.set_HeaderAppearance((AppearanceBase)(object)val3);
		UltraGroupBox2.set_HeaderBorderStyle((UIElementBorderStyle)12);
		UltraGroupBox2.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox ultraGroupBox3 = UltraGroupBox2;
		location = new Point(3, 129);
		((Control)ultraGroupBox3).set_Location(location);
		((Control)UltraGroupBox2).set_Name("UltraGroupBox2");
		UltraGroupBox ultraGroupBox4 = UltraGroupBox2;
		size = new Size(513, 100);
		((Control)ultraGroupBox4).set_Size(size);
		((Control)UltraGroupBox2).set_TabIndex(16);
		UltraGroupBox2.set_Text("STOCK NAME");
		UltraGroupBox2.set_ViewStyle((GroupBoxViewStyle)3);
		val4.set_BorderColor(Color.Black);
		val4.set_BorderColor2(Color.Black);
		((ControlBase)btnStockAdd1).set_Appearance((AppearanceBase)(object)val4);
		((UltraButtonBase)btnStockAdd1).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnStockAdd1).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj8 = btnStockAdd1;
		location = new Point(338, 48);
		((Control)obj8).set_Location(location);
		((Control)btnStockAdd1).set_Name("btnStockAdd1");
		UltraButton obj9 = btnStockAdd1;
		size = new Size(160, 23);
		((Control)obj9).set_Size(size);
		((Control)btnStockAdd1).set_TabIndex(5);
		((ControlBase)btnStockAdd1).set_Text("ADD");
		cmbCategory1.set_AutoComplete(true);
		((TextEditorControlBase)cmbCategory1).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		cmbCategory1.set_DropDownStyle((DropDownStyle)1);
		((Control)cmbCategory1).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj10 = cmbCategory1;
		location = new Point(178, 48);
		((Control)obj10).set_Location(location);
		((Control)cmbCategory1).set_Name("cmbCategory1");
		UltraComboEditor obj11 = cmbCategory1;
		size = new Size(148, 23);
		((Control)obj11).set_Size(size);
		((Control)cmbCategory1).set_TabIndex(4);
		cmbName.set_AutoComplete(true);
		((TextEditorControlBase)cmbName).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbName).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj12 = cmbName;
		location = new Point(18, 48);
		((Control)obj12).set_Location(location);
		((Control)cmbName).set_Name("cmbName");
		UltraComboEditor obj13 = cmbName;
		size = new Size(148, 23);
		((Control)obj13).set_Size(size);
		((Control)cmbName).set_TabIndex(3);
		UltraGroupBox3.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)btnClose);
		((Control)UltraGroupBox3).set_Dock((DockStyle)1);
		UltraGroupBox ultraGroupBox5 = UltraGroupBox3;
		location = new Point(3, 229);
		((Control)ultraGroupBox5).set_Location(location);
		((Control)UltraGroupBox3).set_Name("UltraGroupBox3");
		UltraGroupBox ultraGroupBox6 = UltraGroupBox3;
		size = new Size(513, 56);
		((Control)ultraGroupBox6).set_Size(size);
		((Control)UltraGroupBox3).set_TabIndex(17);
		UltraGroupBox3.set_ViewStyle((GroupBoxViewStyle)3);
		val5.set_BorderColor(Color.Black);
		val5.set_BorderColor2(Color.Black);
		((ControlBase)btnClose).set_Appearance((AppearanceBase)(object)val5);
		((UltraButtonBase)btnClose).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnClose).set_DialogResult((DialogResult)2);
		((Control)btnClose).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj14 = btnClose;
		location = new Point(167, 17);
		((Control)obj14).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		UltraButton obj15 = btnClose;
		size = new Size(160, 23);
		((Control)obj15).set_Size(size);
		((Control)btnClose).set_TabIndex(6);
		((ControlBase)btnClose).set_Text("CLOSE");
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(519, 288);
		((Form)this).set_ClientSize(size);
		((Control)this).set_Name("frmFNONewStock");
		((Form)this).set_Text("frmFNONewStock");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((ISupportInitialize)UltraGroupBox1).EndInit();
		((Control)UltraGroupBox1).ResumeLayout(false);
		((Control)UltraGroupBox1).PerformLayout();
		((ISupportInitialize)cmbCategory).EndInit();
		((ISupportInitialize)txtSymbol).EndInit();
		((ISupportInitialize)UltraGroupBox2).EndInit();
		((Control)UltraGroupBox2).ResumeLayout(false);
		((Control)UltraGroupBox2).PerformLayout();
		((ISupportInitialize)cmbCategory1).EndInit();
		((ISupportInitialize)cmbName).EndInit();
		((ISupportInitialize)UltraGroupBox3).EndInit();
		((Control)UltraGroupBox3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmFNONewStock_Load(object sender, EventArgs e)
	{
		BindControls();
		((TextEditorControlBase)txtSymbol).Focus();
	}

	private void txtSymbol_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			FNO_Add(((TextEditorControlBase)txtSymbol).get_Text(), cmbCategory);
		}
	}

	private void cmbCategory_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			FNO_Add(((TextEditorControlBase)txtSymbol).get_Text(), cmbCategory);
		}
	}

	private void btnStockAdd_Click(object sender, EventArgs e)
	{
		FNO_Add(((TextEditorControlBase)txtSymbol).get_Text(), cmbCategory);
	}

	private void cmbName_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			FNO_Add(Conversions.ToString(cmbName.get_Value()), cmbCategory1);
		}
	}

	private void cmbCategory1_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			FNO_Add(Conversions.ToString(cmbName.get_Value()), cmbCategory1);
		}
	}

	private void btnStockAdd1_Click(object sender, EventArgs e)
	{
		FNO_Add(Conversions.ToString(cmbName.get_Value()), cmbCategory1);
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
			strSQL = "Select Distinct Left(Symbol,len(Symbol)-5) as ES,shortname from vehicle_exchange a join vehicletype b on a.code=b.code where series='FNO' order by shortname";
			cmbName.set_DataSource((object)SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0]);
			cmbName.set_DisplayMember("shortname");
			cmbName.set_ValueMember("ES");
			cmbCategory.set_SelectedIndex(0);
			cmbCategory1.set_SelectedIndex(0);
			cmbName.set_SelectedIndex(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AddFNOLookUp(string strSymbol, string strMonth, string strBridgeSymbol, string strEnd)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(strBridgeSymbol, "", false) == 0)
				{
					return;
				}
				DataTable dataTable = new DataTable();
				strSQL = "SELECT ExchangeSymbol, Symbol FROM Vehicle_Exchange WHERE Exchange_ID = 1732257 AND SERIES = 'EQUITY' ";
				if (Operators.CompareString(Strings.UCase(strSymbol), "ALL", false) != 0)
				{
					strSQL = strSQL + "AND Symbol = '" + strSymbol + "'";
				}
				if (Operators.CompareString(Strings.UCase(strSymbol), "ALL", false) != 0)
				{
					dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
					int num = dataTable.Rows.Count - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							objEquity = new clsEquity();
							objEquity.AddLookUp(Conversions.ToString(Operators.ConcatenateObject(dataTable.Rows[num2][1], (object)strEnd)), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows[num2][0], (object)"-"), (object)strMonth)), "FNO", -1);
							objEquity = null;
							StockAddedEvent?.Invoke(Conversions.ToString(Operators.ConcatenateObject(dataTable.Rows[num2][1], (object)strEnd)));
							num2++;
							continue;
						}
						break;
					}
				}
				else
				{
					objEquity = new clsEquity();
					objEquity.AddLookUp("ALL" + strEnd, "-" + strMonth, "FNO", -1);
					objEquity = null;
				}
				objEquity = new clsEquity();
				objEquity.Update_ConnectedUsers(-1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void FNO_Add(string strSymbol, UltraComboEditor cmbCat)
	{
		Money_Splash money_Splash = new Money_Splash();
		checked
		{
			try
			{
				((Control)money_Splash).Show();
				((Control)money_Splash).Refresh();
				if (Operators.CompareString(Strings.UCase(strSymbol), "ALL", false) == 0)
				{
					strSQL = "DELETE FROM dbo.CNBCMONEY_DETAILS WHERE USERID =  (SELECT USERID FROM CNBCMONEY_USERS_MST WHERE USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = -1 )";
					SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
				}
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
							string text = Conversions.ToString(DateAndTime.Month(Conversions.ToDate(Operators.ConcatenateObject((object)string.Concat("01 " + cmbCat.get_Items().get_Item(num2).get_DisplayText(), " "), cmbCat.get_Items().get_Item(num2).get_DataValue()))));
							if (text.Length == 1)
							{
								text = "0" + text;
							}
							AddFNOLookUp(strSymbol, text, strSymbol, Conversions.ToString(Operators.ConcatenateObject(cmbCat.get_Items().get_Item(num2).get_DataValue(), (object)cmbCat.get_Items().get_Item(num2).get_DisplayText())));
							num2++;
							continue;
						}
						break;
					}
				}
				else
				{
					AddFNOLookUp(strSymbol, Conversions.ToString(cmbCat.get_Value()), strSymbol, Conversions.ToString(Operators.ConcatenateObject(cmbCat.get_Value(), (object)cmbCat.get_Text())));
				}
				if (Operators.CompareString(Strings.UCase(strSymbol), "ALL", false) == 0)
				{
					RefreshGridEvent?.Invoke();
					objEquity = new clsEquity();
					objEquity.Update_ConnectedUsers(-1);
					((Form)money_Splash).Close();
					((Form)this).Close();
				}
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
