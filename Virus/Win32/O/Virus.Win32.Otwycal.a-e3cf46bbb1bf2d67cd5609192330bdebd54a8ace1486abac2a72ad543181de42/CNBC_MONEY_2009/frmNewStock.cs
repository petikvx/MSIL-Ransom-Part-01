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
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmNewStock : InheritedForm
{
	public delegate void StockAddedEventHandler(string strBridgeSymbol);

	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("btnClose")]
	private UltraButton _btnClose;

	[AccessedThroughProperty("UltraGroupBox2")]
	private UltraGroupBox _UltraGroupBox2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("btnLookUpAdd")]
	private UltraButton _btnLookUpAdd;

	[AccessedThroughProperty("cmbCompany")]
	private UltraComboEditor _cmbCompany;

	[AccessedThroughProperty("cmbExchange")]
	private UltraComboEditor _cmbExchange;

	[AccessedThroughProperty("UltraLabel1")]
	private UltraLabel _UltraLabel1;

	[AccessedThroughProperty("UltraGroupBox1")]
	private UltraGroupBox _UltraGroupBox1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("btnStockAdd")]
	private UltraButton _btnStockAdd;

	[AccessedThroughProperty("cmbBridgeSymbol")]
	private UltraCombo _cmbBridgeSymbol;

	[AccessedThroughProperty("UltraGroupBox3")]
	private UltraGroupBox _UltraGroupBox3;

	private string strSQL;

	private DataTable dt;

	private StockAddedEventHandler StockAddedEvent;

	private clsEquity objEquity;

	private int _TabIndex;

	private string _Tab_Name;

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
			if (_btnClose != null)
			{
				((Control)_btnClose).remove_Click((EventHandler)btnClose_Click);
			}
			_btnClose = value;
			if (_btnClose != null)
			{
				((Control)_btnClose).add_Click((EventHandler)btnClose_Click);
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

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual UltraButton btnLookUpAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnLookUpAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnLookUpAdd != null)
			{
				((Control)_btnLookUpAdd).remove_Click((EventHandler)btnLookUpAdd_Click);
			}
			_btnLookUpAdd = value;
			if (_btnLookUpAdd != null)
			{
				((Control)_btnLookUpAdd).add_Click((EventHandler)btnLookUpAdd_Click);
			}
		}
	}

	internal virtual UltraComboEditor cmbCompany
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbCompany;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_cmbCompany != null)
			{
				((Control)_cmbCompany).remove_KeyUp(new KeyEventHandler(cmbCompany_KeyUp));
			}
			_cmbCompany = value;
			if (_cmbCompany != null)
			{
				((Control)_cmbCompany).add_KeyUp(new KeyEventHandler(cmbCompany_KeyUp));
			}
		}
	}

	internal virtual UltraComboEditor cmbExchange
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbExchange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmbExchange != null)
			{
				((TextEditorControlBase)_cmbExchange).remove_ValueChanged((EventHandler)cmbExchange_ValueChanged);
			}
			_cmbExchange = value;
			if (_cmbExchange != null)
			{
				((TextEditorControlBase)_cmbExchange).add_ValueChanged((EventHandler)cmbExchange_ValueChanged);
			}
		}
	}

	internal virtual UltraLabel UltraLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraLabel1 = value;
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

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
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

	internal virtual UltraCombo cmbBridgeSymbol
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbBridgeSymbol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_cmbBridgeSymbol != null)
			{
				((Control)_cmbBridgeSymbol).remove_KeyUp(new KeyEventHandler(cmbBridgeSymbol_KeyUp));
			}
			_cmbBridgeSymbol = value;
			if (_cmbBridgeSymbol != null)
			{
				((Control)_cmbBridgeSymbol).add_KeyUp(new KeyEventHandler(cmbBridgeSymbol_KeyUp));
			}
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

	public int Tab_Index
	{
		get
		{
			return _TabIndex;
		}
		set
		{
			_TabIndex = value;
		}
	}

	public string Tab_Name
	{
		get
		{
			return _Tab_Name;
		}
		set
		{
			_Tab_Name = value;
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
	public frmNewStock()
	{
		((Form)this).add_Load((EventHandler)frmNewStock_Load);
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
		//IL_002d: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected O, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected O, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected O, but got Unknown
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected O, but got Unknown
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		ValueListItem val3 = new ValueListItem();
		ValueListItem val4 = new ValueListItem();
		ValueListItem val5 = new ValueListItem();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		Appearance val8 = new Appearance();
		Appearance val9 = new Appearance();
		Appearance val10 = new Appearance();
		Appearance val11 = new Appearance();
		Appearance val12 = new Appearance();
		Appearance val13 = new Appearance();
		btnClose = new UltraButton();
		UltraGroupBox2 = new UltraGroupBox();
		Label4 = new Label();
		Label3 = new Label();
		btnLookUpAdd = new UltraButton();
		cmbCompany = new UltraComboEditor();
		cmbExchange = new UltraComboEditor();
		UltraLabel1 = new UltraLabel();
		UltraGroupBox1 = new UltraGroupBox();
		Label2 = new Label();
		btnStockAdd = new UltraButton();
		cmbBridgeSymbol = new UltraCombo();
		UltraGroupBox3 = new UltraGroupBox();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((ISupportInitialize)UltraGroupBox2).BeginInit();
		((Control)UltraGroupBox2).SuspendLayout();
		((ISupportInitialize)cmbCompany).BeginInit();
		((ISupportInitialize)cmbExchange).BeginInit();
		((ISupportInitialize)UltraGroupBox1).BeginInit();
		((Control)UltraGroupBox1).SuspendLayout();
		((ISupportInitialize)cmbBridgeSymbol).BeginInit();
		((ISupportInitialize)UltraGroupBox3).BeginInit();
		((Control)UltraGroupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox3);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox2);
		((Control)grForm).get_Controls().Add((Control)(object)UltraLabel1);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox1);
		UltraGroupBox obj = grForm;
		Size size = new Size(598, 333);
		((Control)obj).set_Size(size);
		grForm.set_Text("EQUITY NEW STOCK");
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox1, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraLabel1, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox2, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox3, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(559, 2);
		((Control)closeButton).set_Location(location);
		val.set_BorderColor(Color.Black);
		val.set_BorderColor2(Color.Black);
		((ControlBase)btnClose).set_Appearance((AppearanceBase)(object)val);
		((UltraButtonBase)btnClose).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnClose).set_DialogResult((DialogResult)2);
		((Control)btnClose).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj2 = btnClose;
		location = new Point(214, 17);
		((Control)obj2).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		UltraButton obj3 = btnClose;
		size = new Size(160, 23);
		((Control)obj3).set_Size(size);
		((Control)btnClose).set_TabIndex(5);
		((ControlBase)btnClose).set_Text("CLOSE");
		UltraGroupBox2.set_CaptionAlignment((GroupBoxCaptionAlignment)3);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)btnLookUpAdd);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbCompany);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbExchange);
		((Control)UltraGroupBox2).set_Font(new Font("Verdana", 10f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		UltraGroupBox2.set_HeaderBorderStyle((UIElementBorderStyle)12);
		UltraGroupBox2.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox ultraGroupBox = UltraGroupBox2;
		location = new Point(3, 168);
		((Control)ultraGroupBox).set_Location(location);
		((Control)UltraGroupBox2).set_Name("UltraGroupBox2");
		UltraGroupBox ultraGroupBox2 = UltraGroupBox2;
		size = new Size(592, 110);
		((Control)ultraGroupBox2).set_Size(size);
		((Control)UltraGroupBox2).set_TabIndex(9);
		UltraGroupBox2.set_Text("LOOK UP");
		UltraGroupBox2.set_ViewStyle((GroupBoxViewStyle)3);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label = Label4;
		location = new Point(167, 47);
		((Control)label).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label2 = Label4;
		size = new Size(68, 13);
		((Control)label2).set_Size(size);
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text("COMPANY");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label3 = Label3;
		location = new Point(42, 47);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(75, 13);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("EXCHANGE");
		val2.set_BorderColor(Color.Black);
		val2.set_BorderColor2(Color.Black);
		((ControlBase)btnLookUpAdd).set_Appearance((AppearanceBase)(object)val2);
		((UltraButtonBase)btnLookUpAdd).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnLookUpAdd).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj4 = btnLookUpAdd;
		location = new Point(392, 67);
		((Control)obj4).set_Location(location);
		((Control)btnLookUpAdd).set_Name("btnLookUpAdd");
		UltraButton obj5 = btnLookUpAdd;
		size = new Size(160, 23);
		((Control)obj5).set_Size(size);
		((Control)btnLookUpAdd).set_TabIndex(4);
		((ControlBase)btnLookUpAdd).set_Text("ADD");
		cmbCompany.set_AutoComplete(true);
		((TextEditorControlBase)cmbCompany).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbCompany).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj6 = cmbCompany;
		location = new Point(167, 67);
		((Control)obj6).set_Location(location);
		((Control)cmbCompany).set_Name("cmbCompany");
		UltraComboEditor obj7 = cmbCompany;
		size = new Size(219, 23);
		((Control)obj7).set_Size(size);
		((Control)cmbCompany).set_TabIndex(3);
		cmbExchange.set_AutoComplete(true);
		((TextEditorControlBase)cmbExchange).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbExchange).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val3.set_DataValue((object)"NSE");
		val3.set_DisplayText("NSE");
		val4.set_DataValue((object)"BSE");
		val4.set_DisplayText("BSE");
		val5.set_DataValue((object)"FOREIGN INDICES");
		val5.set_DisplayText("FOREIGN INDICES");
		cmbExchange.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[3] { val3, val4, val5 });
		UltraComboEditor obj8 = cmbExchange;
		location = new Point(42, 67);
		((Control)obj8).set_Location(location);
		((Control)cmbExchange).set_Name("cmbExchange");
		UltraComboEditor obj9 = cmbExchange;
		size = new Size(119, 23);
		((Control)obj9).set_Size(size);
		((Control)cmbExchange).set_TabIndex(2);
		((AppearanceBase)val6).set_TextHAlignAsString("Center");
		((AppearanceBase)val6).set_TextVAlignAsString("Middle");
		((ControlBase)UltraLabel1).set_Appearance((AppearanceBase)(object)val6);
		((Control)UltraLabel1).set_Dock((DockStyle)1);
		((Control)UltraLabel1).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		UltraLabel ultraLabel = UltraLabel1;
		location = new Point(3, 139);
		((Control)ultraLabel).set_Location(location);
		((Control)UltraLabel1).set_Name("UltraLabel1");
		UltraLabel ultraLabel2 = UltraLabel1;
		size = new Size(592, 23);
		((Control)ultraLabel2).set_Size(size);
		((Control)UltraLabel1).set_TabIndex(8);
		((ControlBase)UltraLabel1).set_Text("OR");
		UltraGroupBox1.set_CaptionAlignment((GroupBoxCaptionAlignment)3);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)btnStockAdd);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)cmbBridgeSymbol);
		((Control)UltraGroupBox1).set_Dock((DockStyle)1);
		((Control)UltraGroupBox1).set_Font(new Font("Verdana", 10f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		val7.get_FontData().set_ItalicAsString("True");
		val7.get_FontData().set_SizeInPoints(10f);
		UltraGroupBox1.set_HeaderAppearance((AppearanceBase)(object)val7);
		UltraGroupBox1.set_HeaderBorderStyle((UIElementBorderStyle)12);
		UltraGroupBox1.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox ultraGroupBox3 = UltraGroupBox1;
		location = new Point(3, 29);
		((Control)ultraGroupBox3).set_Location(location);
		((Control)UltraGroupBox1).set_Name("UltraGroupBox1");
		UltraGroupBox ultraGroupBox4 = UltraGroupBox1;
		size = new Size(592, 110);
		((Control)ultraGroupBox4).set_Size(size);
		((Control)UltraGroupBox1).set_TabIndex(7);
		UltraGroupBox1.set_Text("STOCK SYMBOL");
		UltraGroupBox1.set_ViewStyle((GroupBoxViewStyle)3);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label5 = Label2;
		location = new Point(42, 47);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(109, 13);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("BRIDGE SYMBOL");
		val8.set_BorderColor(Color.Black);
		val8.set_BorderColor2(Color.Black);
		((ControlBase)btnStockAdd).set_Appearance((AppearanceBase)(object)val8);
		((UltraButtonBase)btnStockAdd).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnStockAdd).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj10 = btnStockAdd;
		location = new Point(392, 67);
		((Control)obj10).set_Location(location);
		((Control)btnStockAdd).set_Name("btnStockAdd");
		UltraButton obj11 = btnStockAdd;
		size = new Size(160, 23);
		((Control)obj11).set_Size(size);
		((Control)btnStockAdd).set_TabIndex(1);
		((ControlBase)btnStockAdd).set_Text("ADD");
		cmbBridgeSymbol.set_AlwaysInEditMode(true);
		cmbBridgeSymbol.set_CharacterCasing((CharacterCasing)0);
		val9.set_BackColor(Color.White);
		((UltraGridBase)cmbBridgeSymbol).get_DisplayLayout().set_Appearance((AppearanceBase)(object)val9);
		val10.set_BackColor(Color.Transparent);
		((UltraGridBase)cmbBridgeSymbol).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val10);
		val11.set_BackColor(Color.FromArgb(89, 135, 214));
		val11.set_BackColor2(Color.FromArgb(7, 59, 150));
		val11.set_BackGradientStyle((GradientStyle)2);
		val11.get_FontData().set_BoldAsString("True");
		val11.get_FontData().set_Name("Arial");
		val11.get_FontData().set_SizeInPoints(10f);
		val11.set_ForeColor(Color.White);
		val11.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)cmbBridgeSymbol).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val11);
		val12.set_BackColor(Color.FromArgb(89, 135, 214));
		val12.set_BackColor2(Color.FromArgb(7, 59, 150));
		val12.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)cmbBridgeSymbol).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val12);
		val13.set_BackColor(Color.FromArgb(251, 230, 148));
		val13.set_BackColor2(Color.FromArgb(238, 149, 21));
		val13.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)cmbBridgeSymbol).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val13);
		cmbBridgeSymbol.set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbBridgeSymbol).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraCombo obj12 = cmbBridgeSymbol;
		location = new Point(42, 67);
		((Control)obj12).set_Location(location);
		((Control)cmbBridgeSymbol).set_Name("cmbBridgeSymbol");
		UltraCombo obj13 = cmbBridgeSymbol;
		size = new Size(344, 24);
		((Control)obj13).set_Size(size);
		((Control)cmbBridgeSymbol).set_TabIndex(0);
		UltraGroupBox3.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)btnClose);
		UltraGroupBox ultraGroupBox5 = UltraGroupBox3;
		location = new Point(3, 280);
		((Control)ultraGroupBox5).set_Location(location);
		((Control)UltraGroupBox3).set_Name("UltraGroupBox3");
		UltraGroupBox ultraGroupBox6 = UltraGroupBox3;
		size = new Size(592, 56);
		((Control)ultraGroupBox6).set_Size(size);
		((Control)UltraGroupBox3).set_TabIndex(10);
		UltraGroupBox3.set_ViewStyle((GroupBoxViewStyle)3);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((Form)this).set_CancelButton((IButtonControl)(object)btnClose);
		size = new Size(598, 333);
		((Form)this).set_ClientSize(size);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmNewStock");
		((Form)this).set_Text("NEW STOCK");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((ISupportInitialize)UltraGroupBox2).EndInit();
		((Control)UltraGroupBox2).ResumeLayout(false);
		((Control)UltraGroupBox2).PerformLayout();
		((ISupportInitialize)cmbCompany).EndInit();
		((ISupportInitialize)cmbExchange).EndInit();
		((ISupportInitialize)UltraGroupBox1).EndInit();
		((Control)UltraGroupBox1).ResumeLayout(false);
		((Control)UltraGroupBox1).PerformLayout();
		((ISupportInitialize)cmbBridgeSymbol).EndInit();
		((ISupportInitialize)UltraGroupBox3).EndInit();
		((Control)UltraGroupBox3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmNewStock_Load(object sender, EventArgs e)
	{
		cmbExchange.set_SelectedIndex(0);
		cmbCompany.set_SelectedIndex(0);
		BindBridgeSymbol();
	}

	private void btnStockAdd_Click(object sender, EventArgs e)
	{
		AddLookUp(cmbBridgeSymbol.get_Text());
	}

	private void cmbExchange_ValueChanged(object sender, EventArgs e)
	{
		Exchange_Change();
	}

	private void btnLookUpAdd_Click(object sender, EventArgs e)
	{
		AddLookUp(Conversions.ToString(cmbCompany.get_Value()));
	}

	private void cmbBridgeSymbol_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			AddLookUp(cmbBridgeSymbol.get_Text());
		}
	}

	private void cmbCompany_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			AddLookUp(Conversions.ToString(cmbCompany.get_Value()));
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void AddLookUp(string strBridgeSymbol = "")
	{
		Money_Splash money_Splash = new Money_Splash();
		try
		{
			((Control)money_Splash).Show();
			((Control)money_Splash).Refresh();
			if (Operators.CompareString(strBridgeSymbol, "", false) != 0)
			{
				string text = "";
				strSQL = "SELECT ExchangeSymbol FROM Vehicle_Exchange WHERE Symbol = '" + strBridgeSymbol + "' AND SERIES = 'EQUITY'";
				text = Conversions.ToString(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL));
				if (Operators.CompareString(text, "", false) == 0)
				{
					((Form)money_Splash).Close();
					return;
				}
				objEquity = new clsEquity();
				objEquity.AddLookUp(strBridgeSymbol, text, Tab_Name, Tab_Index);
				objEquity = null;
				StockAddedEvent?.Invoke(strBridgeSymbol);
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

	private void Exchange_Change()
	{
		try
		{
			if (cmbExchange.get_SelectedItem() == null)
			{
				((TextEditorControlBase)cmbCompany).Clear();
				cmbCompany.get_Items().Clear();
				return;
			}
			if (Operators.CompareString(Strings.Trim(cmbExchange.get_SelectedItem().ToString()), "NSE", false) == 0)
			{
				strSQL = "select DISTINCT(vehicletype.shortname) AS shortname,vehicle_exchange.ExchangeSymbol as ES, bridgesymbol from equity_transaction_data , vehicletype, vehicle_exchange  Where symbol = bridgesymbol AND vehicletype.code = vehicle_exchange.code AND vehicle_exchange.exchange_id = '1732257'  order by vehicletype.shortname";
			}
			else if (Operators.CompareString(Strings.Trim(cmbExchange.get_SelectedItem().ToString()), "BSE", false) == 0)
			{
				strSQL = "select DISTINCT(vehicletype.shortname) AS shortname,vehicle_exchange.ExchangeSymbol as ES, bridgesymbol from equity_transaction_data , vehicletype, vehicle_exchange  Where symbol = bridgesymbol AND vehicletype.code = vehicle_exchange.code AND vehicle_exchange.exchange_id = '1732256'  order by vehicletype.shortname";
			}
			else
			{
				if (Operators.CompareString(Strings.Trim(cmbExchange.get_SelectedItem().ToString()), "FOREIGN INDICES", false) != 0)
				{
					return;
				}
				strSQL = "select DISTINCT(vehicletype.shortname) AS shortname,vehicle_exchange.ExchangeSymbol as ES, bridgesymbol from equity_transaction_data , vehicletype, vehicle_exchange  Where symbol = bridgesymbol AND vehicletype.code = vehicle_exchange.code AND vehicle_exchange.exchange_id = '104'  order by vehicletype.shortname";
			}
			dt = new DataTable();
			dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			cmbCompany.set_DataSource((object)dt);
			cmbCompany.set_DisplayMember("shortname");
			cmbCompany.set_ValueMember("bridgesymbol");
			if (dt.Rows.Count > 0)
			{
				cmbCompany.set_SelectedIndex(0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BindBridgeSymbol()
	{
		try
		{
			strSQL = "SELECT BridgeSymbol, ExchangeSymbol, shortname AS Company FROM equity_transaction_data  WHERE BridgeSymbol IS NOT NULL ORDER BY BridgeSymbol";
			dt = new DataTable();
			dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			((UltraGridBase)cmbBridgeSymbol).set_DataSource((object)dt);
			((UltraDropDownBase)cmbBridgeSymbol).set_ValueMember("BridgeSymbol");
			((UltraDropDownBase)cmbBridgeSymbol).set_DisplayMember("BridgeSymbol");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
