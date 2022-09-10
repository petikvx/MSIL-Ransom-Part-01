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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmFeedRanking : InheritedForm
{
	public delegate void TextHasChangedEventHandler();

	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("btnAdd")]
	private UltraButton _btnAdd;

	[AccessedThroughProperty("btnClose")]
	private UltraButton _btnClose;

	[AccessedThroughProperty("UltraGroupBox2")]
	private UltraGroupBox _UltraGroupBox2;

	[AccessedThroughProperty("txtMktCapL")]
	private UltraTextEditor _txtMktCapL;

	[AccessedThroughProperty("txtMktCapG")]
	private UltraTextEditor _txtMktCapG;

	[AccessedThroughProperty("txtLastPrice")]
	private UltraTextEditor _txtLastPrice;

	[AccessedThroughProperty("txtVolume")]
	private UltraTextEditor _txtVolume;

	[AccessedThroughProperty("cmbExchange")]
	private UltraComboEditor _cmbExchange;

	[AccessedThroughProperty("cmbSeries")]
	private UltraComboEditor _cmbSeries;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("UltraGroupBox1")]
	private UltraGroupBox _UltraGroupBox1;

	[AccessedThroughProperty("txtChange")]
	private UltraTextEditor _txtChange;

	[AccessedThroughProperty("cmbMarketType")]
	private UltraComboEditor _cmbMarketType;

	[AccessedThroughProperty("cmbNumber")]
	private UltraComboEditor _cmbNumber;

	[AccessedThroughProperty("cmbRanking")]
	private UltraComboEditor _cmbRanking;

	[AccessedThroughProperty("cmbSectorName")]
	private UltraComboEditor _cmbSectorName;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UltraGroupBox3")]
	private UltraGroupBox _UltraGroupBox3;

	private string strSQL;

	private DataTable dt;

	private TextHasChangedEventHandler TextHasChangedEvent;

	internal virtual UltraButton btnAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnAdd != null)
			{
				((Control)_btnAdd).remove_Click((EventHandler)btnAdd_Click);
			}
			_btnAdd = value;
			if (_btnAdd != null)
			{
				((Control)_btnAdd).add_Click((EventHandler)btnAdd_Click);
			}
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

	internal virtual UltraTextEditor txtMktCapL
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMktCapL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMktCapL = value;
		}
	}

	internal virtual UltraTextEditor txtMktCapG
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMktCapG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMktCapG = value;
		}
	}

	internal virtual UltraTextEditor txtLastPrice
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLastPrice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLastPrice = value;
		}
	}

	internal virtual UltraTextEditor txtVolume
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVolume;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtVolume = value;
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
			_cmbExchange = value;
		}
	}

	internal virtual UltraComboEditor cmbSeries
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbSeries;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbSeries = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
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

	internal virtual UltraTextEditor txtChange
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChange = value;
		}
	}

	internal virtual UltraComboEditor cmbMarketType
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbMarketType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbMarketType = value;
		}
	}

	internal virtual UltraComboEditor cmbNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbNumber = value;
		}
	}

	internal virtual UltraComboEditor cmbRanking
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbRanking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbRanking = value;
		}
	}

	internal virtual UltraComboEditor cmbSectorName
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbSectorName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmbSectorName != null)
			{
				((Control)_cmbSectorName).remove_TextChanged((EventHandler)cmbSectorName_TextChanged);
			}
			_cmbSectorName = value;
			if (_cmbSectorName != null)
			{
				((Control)_cmbSectorName).add_TextChanged((EventHandler)cmbSectorName_TextChanged);
			}
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
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

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
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

	public event TextHasChangedEventHandler TextHasChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			TextHasChangedEvent = (TextHasChangedEventHandler)Delegate.Combine(TextHasChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			TextHasChangedEvent = (TextHasChangedEventHandler)Delegate.Remove(TextHasChangedEvent, value);
		}
	}

	[DebuggerNonUserCode]
	public frmFeedRanking()
	{
		((Form)this).add_Load((EventHandler)frmFeedRanking_Load);
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
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Expected O, but got Unknown
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected O, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected O, but got Unknown
		//IL_0be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected O, but got Unknown
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected O, but got Unknown
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1c: Expected O, but got Unknown
		//IL_1389: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected O, but got Unknown
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1437: Expected O, but got Unknown
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14db: Expected O, but got Unknown
		//IL_1569: Unknown result type (might be due to invalid IL or missing references)
		//IL_1573: Expected O, but got Unknown
		//IL_1601: Unknown result type (might be due to invalid IL or missing references)
		//IL_160b: Expected O, but got Unknown
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		ValueListItem val3 = new ValueListItem();
		ValueListItem val4 = new ValueListItem();
		ValueListItem val5 = new ValueListItem();
		ValueListItem val6 = new ValueListItem();
		ValueListItem val7 = new ValueListItem();
		ValueListItem val8 = new ValueListItem();
		ValueListItem val9 = new ValueListItem();
		ValueListItem val10 = new ValueListItem();
		ValueListItem val11 = new ValueListItem();
		ValueListItem val12 = new ValueListItem();
		ValueListItem val13 = new ValueListItem();
		ValueListItem val14 = new ValueListItem();
		ValueListItem val15 = new ValueListItem();
		ValueListItem val16 = new ValueListItem();
		ValueListItem val17 = new ValueListItem();
		ValueListItem val18 = new ValueListItem();
		ValueListItem val19 = new ValueListItem();
		ValueListItem val20 = new ValueListItem();
		ValueListItem val21 = new ValueListItem();
		ValueListItem val22 = new ValueListItem();
		ValueListItem val23 = new ValueListItem();
		ValueListItem val24 = new ValueListItem();
		ValueListItem val25 = new ValueListItem();
		ValueListItem val26 = new ValueListItem();
		ValueListItem val27 = new ValueListItem();
		ValueListItem val28 = new ValueListItem();
		ValueListItem val29 = new ValueListItem();
		btnAdd = new UltraButton();
		btnClose = new UltraButton();
		UltraGroupBox2 = new UltraGroupBox();
		txtMktCapL = new UltraTextEditor();
		txtMktCapG = new UltraTextEditor();
		txtLastPrice = new UltraTextEditor();
		txtVolume = new UltraTextEditor();
		cmbExchange = new UltraComboEditor();
		cmbSeries = new UltraComboEditor();
		Label11 = new Label();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		UltraGroupBox1 = new UltraGroupBox();
		txtChange = new UltraTextEditor();
		cmbMarketType = new UltraComboEditor();
		cmbNumber = new UltraComboEditor();
		cmbRanking = new UltraComboEditor();
		cmbSectorName = new UltraComboEditor();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		UltraGroupBox3 = new UltraGroupBox();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((ISupportInitialize)UltraGroupBox2).BeginInit();
		((Control)UltraGroupBox2).SuspendLayout();
		((ISupportInitialize)txtMktCapL).BeginInit();
		((ISupportInitialize)txtMktCapG).BeginInit();
		((ISupportInitialize)txtLastPrice).BeginInit();
		((ISupportInitialize)txtVolume).BeginInit();
		((ISupportInitialize)cmbExchange).BeginInit();
		((ISupportInitialize)cmbSeries).BeginInit();
		((ISupportInitialize)UltraGroupBox1).BeginInit();
		((Control)UltraGroupBox1).SuspendLayout();
		((ISupportInitialize)txtChange).BeginInit();
		((ISupportInitialize)cmbMarketType).BeginInit();
		((ISupportInitialize)cmbNumber).BeginInit();
		((ISupportInitialize)cmbRanking).BeginInit();
		((ISupportInitialize)cmbSectorName).BeginInit();
		((ISupportInitialize)UltraGroupBox3).BeginInit();
		((Control)UltraGroupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox3);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox2);
		((Control)grForm).get_Controls().Add((Control)(object)UltraGroupBox1);
		UltraGroupBox obj = grForm;
		Size size = new Size(670, 305);
		((Control)obj).set_Size(size);
		grForm.set_Text("FEED RANKING");
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox1, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox2, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)UltraGroupBox3, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(630, 2);
		((Control)closeButton).set_Location(location);
		val.set_BorderColor(Color.Black);
		val.set_BorderColor2(Color.Black);
		((ControlBase)btnAdd).set_Appearance((AppearanceBase)(object)val);
		((UltraButtonBase)btnAdd).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnAdd).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj2 = btnAdd;
		location = new Point(154, 19);
		((Control)obj2).set_Location(location);
		((Control)btnAdd).set_Name("btnAdd");
		UltraButton obj3 = btnAdd;
		size = new Size(160, 23);
		((Control)obj3).set_Size(size);
		((Control)btnAdd).set_TabIndex(11);
		((ControlBase)btnAdd).set_Text("ADD");
		val2.set_BorderColor(Color.Black);
		val2.set_BorderColor2(Color.Black);
		((ControlBase)btnClose).set_Appearance((AppearanceBase)(object)val2);
		((UltraButtonBase)btnClose).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnClose).set_DialogResult((DialogResult)2);
		((Control)btnClose).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj4 = btnClose;
		location = new Point(346, 19);
		((Control)obj4).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		UltraButton obj5 = btnClose;
		size = new Size(160, 23);
		((Control)obj5).set_Size(size);
		((Control)btnClose).set_TabIndex(12);
		((ControlBase)btnClose).set_Text("CLOSE");
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)txtMktCapL);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)txtMktCapG);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)txtLastPrice);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)txtVolume);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbExchange);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)cmbSeries);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label11);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label10);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label9);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label8);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)UltraGroupBox2).get_Controls().Add((Control)(object)Label6);
		((Control)UltraGroupBox2).set_Dock((DockStyle)1);
		UltraGroupBox ultraGroupBox = UltraGroupBox2;
		location = new Point(3, 104);
		((Control)ultraGroupBox).set_Location(location);
		((Control)UltraGroupBox2).set_Name("UltraGroupBox2");
		UltraGroupBox ultraGroupBox2 = UltraGroupBox2;
		size = new Size(664, 143);
		((Control)ultraGroupBox2).set_Size(size);
		((Control)UltraGroupBox2).set_TabIndex(8);
		UltraGroupBox2.set_ViewStyle((GroupBoxViewStyle)3);
		((TextEditorControlBase)txtMktCapL).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		UltraTextEditor obj6 = txtMktCapL;
		location = new Point(162, 102);
		((Control)obj6).set_Location(location);
		((Control)txtMktCapL).set_Name("txtMktCapL");
		UltraTextEditor obj7 = txtMktCapL;
		size = new Size(144, 22);
		((Control)obj7).set_Size(size);
		((Control)txtMktCapL).set_TabIndex(10);
		((TextEditorControlBase)txtMktCapG).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		UltraTextEditor obj8 = txtMktCapG;
		location = new Point(12, 102);
		((Control)obj8).set_Location(location);
		((Control)txtMktCapG).set_Name("txtMktCapG");
		UltraTextEditor obj9 = txtMktCapG;
		size = new Size(144, 22);
		((Control)obj9).set_Size(size);
		((Control)txtMktCapG).set_TabIndex(9);
		((TextEditorControlBase)txtLastPrice).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		UltraTextEditor obj10 = txtLastPrice;
		location = new Point(465, 35);
		((Control)obj10).set_Location(location);
		((Control)txtLastPrice).set_Name("txtLastPrice");
		UltraTextEditor obj11 = txtLastPrice;
		size = new Size(144, 22);
		((Control)obj11).set_Size(size);
		((Control)txtLastPrice).set_TabIndex(8);
		((TextEditorControlBase)txtVolume).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		UltraTextEditor obj12 = txtVolume;
		location = new Point(312, 35);
		((Control)obj12).set_Location(location);
		((Control)txtVolume).set_Name("txtVolume");
		UltraTextEditor obj13 = txtVolume;
		size = new Size(148, 22);
		((Control)obj13).set_Size(size);
		((Control)txtVolume).set_TabIndex(7);
		cmbExchange.set_AutoComplete(true);
		((TextEditorControlBase)cmbExchange).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		val3.set_DataValue((object)"BSE");
		val3.set_DisplayText("BSE");
		val4.set_DataValue((object)"NSE");
		val4.set_DisplayText("NSE");
		val5.set_DataValue((object)"BOTH");
		val5.set_DisplayText("BOTH");
		cmbExchange.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[3] { val3, val4, val5 });
		UltraComboEditor obj14 = cmbExchange;
		location = new Point(162, 35);
		((Control)obj14).set_Location(location);
		((Control)cmbExchange).set_Name("cmbExchange");
		UltraComboEditor obj15 = cmbExchange;
		size = new Size(144, 22);
		((Control)obj15).set_Size(size);
		((Control)cmbExchange).set_TabIndex(6);
		cmbSeries.set_AutoComplete(true);
		((TextEditorControlBase)cmbSeries).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		val6.set_DataValue((object)"EQ");
		val6.set_DisplayText("EQ");
		val7.set_DataValue((object)"BE");
		val7.set_DisplayText("BE");
		val8.set_DataValue((object)"IL");
		val8.set_DisplayText("IL");
		val9.set_DataValue((object)"BL");
		val9.set_DisplayText("BL");
		val10.set_DataValue((object)"INX");
		val10.set_DisplayText("INX");
		cmbSeries.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[5] { val6, val7, val8, val9, val10 });
		UltraComboEditor obj16 = cmbSeries;
		location = new Point(12, 35);
		((Control)obj16).set_Location(location);
		((Control)cmbSeries).set_Name("cmbSeries");
		UltraComboEditor obj17 = cmbSeries;
		size = new Size(144, 22);
		((Control)obj17).set_Size(size);
		((Control)cmbSeries).set_TabIndex(5);
		Label11.set_AutoSize(true);
		((Control)Label11).set_BackColor(Color.Transparent);
		((Control)Label11).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label = Label11;
		location = new Point(162, 81);
		((Control)label).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label2 = Label11;
		size = new Size(105, 13);
		((Control)label2).set_Size(size);
		((Control)Label11).set_TabIndex(6);
		Label11.set_Text("MKT CAPITAL <");
		Label10.set_AutoSize(true);
		((Control)Label10).set_BackColor(Color.Transparent);
		((Control)Label10).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label3 = Label10;
		location = new Point(12, 81);
		((Control)label3).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label4 = Label10;
		size = new Size(105, 13);
		((Control)label4).set_Size(size);
		((Control)Label10).set_TabIndex(5);
		Label10.set_Text("MKT CAPITAL >");
		Label9.set_AutoSize(true);
		((Control)Label9).set_BackColor(Color.Transparent);
		((Control)Label9).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label5 = Label9;
		location = new Point(465, 15);
		((Control)label5).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label6 = Label9;
		size = new Size(94, 13);
		((Control)label6).set_Size(size);
		((Control)Label9).set_TabIndex(4);
		Label9.set_Text("LAST PRICE >");
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label7 = Label8;
		location = new Point(312, 15);
		((Control)label7).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label8 = Label8;
		size = new Size(71, 13);
		((Control)label8).set_Size(size);
		((Control)Label8).set_TabIndex(3);
		Label8.set_Text("VOLUME >");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label9 = Label7;
		location = new Point(162, 15);
		((Control)label9).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label10 = Label7;
		size = new Size(75, 13);
		((Control)label10).set_Size(size);
		((Control)Label7).set_TabIndex(2);
		Label7.set_Text("EXCHANGE");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label11 = Label6;
		location = new Point(12, 15);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(53, 13);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(1);
		Label6.set_Text("SERIES");
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)txtChange);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)cmbMarketType);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)cmbNumber);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)cmbRanking);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)cmbSectorName);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)UltraGroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)UltraGroupBox1).set_Dock((DockStyle)1);
		UltraGroupBox ultraGroupBox3 = UltraGroupBox1;
		location = new Point(3, 29);
		((Control)ultraGroupBox3).set_Location(location);
		((Control)UltraGroupBox1).set_Name("UltraGroupBox1");
		UltraGroupBox ultraGroupBox4 = UltraGroupBox1;
		size = new Size(664, 75);
		((Control)ultraGroupBox4).set_Size(size);
		((Control)UltraGroupBox1).set_TabIndex(7);
		UltraGroupBox1.set_ViewStyle((GroupBoxViewStyle)3);
		((TextEditorControlBase)txtChange).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		UltraTextEditor obj18 = txtChange;
		location = new Point(465, 34);
		((Control)obj18).set_Location(location);
		((Control)txtChange).set_Name("txtChange");
		UltraTextEditor obj19 = txtChange;
		size = new Size(144, 22);
		((Control)obj19).set_Size(size);
		((Control)txtChange).set_TabIndex(4);
		((Control)txtChange).set_Visible(false);
		cmbMarketType.set_AutoComplete(true);
		((TextEditorControlBase)cmbMarketType).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		val11.set_DataValue((object)"N");
		val11.set_DisplayText("N");
		val12.set_DataValue((object)"S");
		val12.set_DisplayText("S");
		val13.set_DataValue((object)"O");
		val13.set_DisplayText("O");
		val14.set_DataValue((object)"A");
		val14.set_DisplayText("A");
		cmbMarketType.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[4] { val11, val12, val13, val14 });
		UltraComboEditor obj20 = cmbMarketType;
		location = new Point(381, 34);
		((Control)obj20).set_Location(location);
		((Control)cmbMarketType).set_Name("cmbMarketType");
		UltraComboEditor obj21 = cmbMarketType;
		size = new Size(78, 22);
		((Control)obj21).set_Size(size);
		((Control)cmbMarketType).set_TabIndex(3);
		((Control)cmbMarketType).set_Visible(false);
		cmbNumber.set_AutoComplete(true);
		((TextEditorControlBase)cmbNumber).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		val15.set_DataValue((object)"5");
		val15.set_DisplayText("5");
		val16.set_DataValue((object)"10");
		val16.set_DisplayText("10");
		val17.set_DataValue((object)"20");
		val17.set_DisplayText("20");
		val18.set_DataValue((object)"50");
		val18.set_DisplayText("50");
		cmbNumber.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[4] { val15, val16, val17, val18 });
		UltraComboEditor obj22 = cmbNumber;
		location = new Point(312, 34);
		((Control)obj22).set_Location(location);
		((Control)cmbNumber).set_Name("cmbNumber");
		UltraComboEditor obj23 = cmbNumber;
		size = new Size(63, 22);
		((Control)obj23).set_Size(size);
		((Control)cmbNumber).set_TabIndex(2);
		cmbRanking.set_AutoComplete(true);
		((TextEditorControlBase)cmbRanking).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		val19.set_DataValue((object)"WEEKHIGH52");
		val19.set_DisplayText("WEEKHIGH52");
		val20.set_DataValue((object)"WEEKLOW52");
		val20.set_DisplayText("WEEKLOW52");
		val21.set_DataValue((object)"LIFETIMEHIGH");
		val21.set_DisplayText("LIFETIMEHIGH");
		val22.set_DataValue((object)"LIFETIMELOW");
		val22.set_DisplayText("LIFETIMELOW");
		val23.set_DataValue((object)"GAINERS");
		val23.set_DisplayText("GAINERS");
		val24.set_DataValue((object)"LOSERS");
		val24.set_DisplayText("LOSERS");
		val25.set_DataValue((object)"VOLUME");
		val25.set_DisplayText("VOLUME");
		val26.set_DataValue((object)"TURNOVER");
		val26.set_DisplayText("TURNOVER");
		val27.set_DataValue((object)"NAME");
		val27.set_DisplayText("NAME");
		val28.set_DataValue((object)"UPPER_CIRCUIT");
		val28.set_DisplayText("UPPER_CIRCUIT");
		val29.set_DataValue((object)"LOWER_CIRCUIT");
		val29.set_DisplayText("LOWER_CIRCUIT");
		cmbRanking.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[11]
		{
			val19, val20, val21, val22, val23, val24, val25, val26, val27, val28,
			val29
		});
		UltraComboEditor obj24 = cmbRanking;
		location = new Point(162, 34);
		((Control)obj24).set_Location(location);
		((Control)cmbRanking).set_Name("cmbRanking");
		UltraComboEditor obj25 = cmbRanking;
		size = new Size(144, 22);
		((Control)obj25).set_Size(size);
		((Control)cmbRanking).set_TabIndex(1);
		cmbSectorName.set_AutoComplete(true);
		((TextEditorControlBase)cmbSectorName).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		UltraComboEditor obj26 = cmbSectorName;
		location = new Point(12, 34);
		((Control)obj26).set_Location(location);
		((Control)cmbSectorName).set_Name("cmbSectorName");
		UltraComboEditor obj27 = cmbSectorName;
		size = new Size(144, 22);
		((Control)obj27).set_Size(size);
		((Control)cmbSectorName).set_TabIndex(0);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label13 = Label5;
		location = new Point(465, 14);
		((Control)label13).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label14 = Label5;
		size = new Size(59, 13);
		((Control)label14).set_Size(size);
		((Control)Label5).set_TabIndex(4);
		Label5.set_Text("CHANGE");
		((Control)Label5).set_Visible(false);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label15 = Label4;
		location = new Point(381, 14);
		((Control)label15).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label16 = Label4;
		size = new Size(69, 13);
		((Control)label16).set_Size(size);
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("MKT TYPE");
		((Control)Label4).set_Visible(false);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label17 = Label3;
		location = new Point(312, 14);
		((Control)label17).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label18 = Label3;
		size = new Size(59, 13);
		((Control)label18).set_Size(size);
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("NUMBER");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label19 = Label2;
		location = new Point(162, 14);
		((Control)label19).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label20 = Label2;
		size = new Size(101, 13);
		((Control)label20).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("RANKING TYPE");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label21 = Label1;
		location = new Point(12, 14);
		((Control)label21).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label22 = Label1;
		size = new Size(64, 13);
		((Control)label22).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("SECTORS");
		UltraGroupBox3.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)btnAdd);
		((Control)UltraGroupBox3).get_Controls().Add((Control)(object)btnClose);
		((Control)UltraGroupBox3).set_Dock((DockStyle)1);
		UltraGroupBox ultraGroupBox5 = UltraGroupBox3;
		location = new Point(3, 247);
		((Control)ultraGroupBox5).set_Location(location);
		((Control)UltraGroupBox3).set_Name("UltraGroupBox3");
		UltraGroupBox ultraGroupBox6 = UltraGroupBox3;
		size = new Size(664, 55);
		((Control)ultraGroupBox6).set_Size(size);
		((Control)UltraGroupBox3).set_TabIndex(9);
		UltraGroupBox3.set_ViewStyle((GroupBoxViewStyle)3);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnAdd);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((Form)this).set_CancelButton((IButtonControl)(object)btnClose);
		size = new Size(670, 305);
		((Form)this).set_ClientSize(size);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmFeedRanking");
		((Form)this).set_Text("FEED RANKING");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((ISupportInitialize)UltraGroupBox2).EndInit();
		((Control)UltraGroupBox2).ResumeLayout(false);
		((Control)UltraGroupBox2).PerformLayout();
		((ISupportInitialize)txtMktCapL).EndInit();
		((ISupportInitialize)txtMktCapG).EndInit();
		((ISupportInitialize)txtLastPrice).EndInit();
		((ISupportInitialize)txtVolume).EndInit();
		((ISupportInitialize)cmbExchange).EndInit();
		((ISupportInitialize)cmbSeries).EndInit();
		((ISupportInitialize)UltraGroupBox1).EndInit();
		((Control)UltraGroupBox1).ResumeLayout(false);
		((Control)UltraGroupBox1).PerformLayout();
		((ISupportInitialize)txtChange).EndInit();
		((ISupportInitialize)cmbMarketType).EndInit();
		((ISupportInitialize)cmbNumber).EndInit();
		((ISupportInitialize)cmbRanking).EndInit();
		((ISupportInitialize)cmbSectorName).EndInit();
		((ISupportInitialize)UltraGroupBox3).EndInit();
		((Control)UltraGroupBox3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmFeedRanking_Load(object sender, EventArgs e)
	{
		BindSector();
		cmbRanking.set_Value((object)"VOLUME");
		cmbNumber.set_Value((object)"50");
		cmbMarketType.set_Value((object)"N");
		cmbSeries.set_Value((object)"EQ");
		cmbExchange.set_Value((object)"NSE");
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		Money_Splash money_Splash = new Money_Splash();
		((Control)money_Splash).Show();
		((Control)money_Splash).Refresh();
		if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(cmbSectorName.get_Value())) | !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(cmbNumber.get_Value())))
		{
			((Form)money_Splash).Close();
			return;
		}
		Add_click();
		((Form)money_Splash).Close();
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void BindSector()
	{
		try
		{
			strSQL = "Select * from Sector order by Sectorname";
			dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			cmbSectorName.set_DataSource((object)dt);
			cmbSectorName.set_DisplayMember("SECTORNAME");
			cmbSectorName.set_ValueMember("SectorID");
			cmbSectorName.set_SelectedIndex(cmbSectorName.FindString("ALL"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Add_click()
	{
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text;
			if (Operators.CompareString(Strings.UCase(((TextEditorControlBase)txtChange).get_Text()), "Y", false) == 0)
			{
				text = "Y";
			}
			else if (Operators.CompareString(Strings.UCase(((TextEditorControlBase)txtChange).get_Text()), "W", false) == 0)
			{
				text = "W";
			}
			else if (Operators.CompareString(Strings.UCase(((TextEditorControlBase)txtChange).get_Text()), "M", false) == 0)
			{
				text = "M";
			}
			else if (Strings.InStr(1, Strings.UCase(((TextEditorControlBase)txtChange).get_Text()), "D", (CompareMethod)0) > 0)
			{
				string text2 = Strings.Trim(Strings.Replace(Strings.UCase(((TextEditorControlBase)txtChange).get_Text()), "D", "", 1, -1, (CompareMethod)0));
				if (Strings.Len(text2) < 4)
				{
					return;
				}
				string text3 = Strings.Mid(text2, 3, 2);
				string text4 = Strings.Mid(text2, 1, 2);
				string text5 = ((Strings.Len(text2) <= 4) ? Conversions.ToString(DateAndTime.Year(DateAndTime.get_Now())) : Strings.Mid(Conversions.ToString(5), Conversions.ToInteger(text2), Strings.Len(text2)));
				text2 = text3 + "/" + text4 + "/" + text5;
				if (!Information.IsDate((object)text2))
				{
					Interaction.MsgBox((object)"Not a valid Date", (MsgBoxStyle)0, (object)null);
					return;
				}
				text = "D" + text2;
			}
			else
			{
				text = "C";
			}
			cmbSectorName.get_Text();
			cmbNumber.get_Text();
			cmbSeries.get_Text();
			cmbExchange.get_Text();
			cmbRanking.get_Text();
			((TextEditorControlBase)txtChange).set_Text(text);
			((TextEditorControlBase)txtVolume).get_Text();
			((TextEditorControlBase)txtLastPrice).get_Text();
			TextHasChangedEvent?.Invoke();
			((Form)this).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private bool CheckCombo_Value(UltraComboEditor cmb, string theText)
	{
		bool result = default(bool);
		try
		{
			if (cmb.get_SelectedItem() == null)
			{
				result = false;
				return result;
			}
			result = true;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void cmbSectorName_TextChanged(object sender, EventArgs e)
	{
		if (!CheckCombo_Value(cmbSectorName, cmbSectorName.get_Text()))
		{
			cmbSectorName.set_Text("");
		}
	}
}
