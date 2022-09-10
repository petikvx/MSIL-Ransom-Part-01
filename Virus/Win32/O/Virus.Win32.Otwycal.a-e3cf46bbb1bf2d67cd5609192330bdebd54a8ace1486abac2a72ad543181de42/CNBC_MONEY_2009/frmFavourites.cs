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
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmFavourites : InheritedForm
{
	public delegate void Refresh_FavouritesEventHandler();

	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("btnAdd")]
	private UltraButton _btnAdd;

	[AccessedThroughProperty("cmbCompany1")]
	private UltraComboEditor _cmbCompany1;

	[AccessedThroughProperty("cmbExchange1")]
	private UltraComboEditor _cmbExchange1;

	[AccessedThroughProperty("cmbCompany5")]
	private UltraComboEditor _cmbCompany5;

	[AccessedThroughProperty("cmbCompany4")]
	private UltraComboEditor _cmbCompany4;

	[AccessedThroughProperty("cmbCompany3")]
	private UltraComboEditor _cmbCompany3;

	[AccessedThroughProperty("cmbCompany2")]
	private UltraComboEditor _cmbCompany2;

	[AccessedThroughProperty("btnClose")]
	private UltraButton _btnClose;

	[AccessedThroughProperty("cmbExchange5")]
	private UltraComboEditor _cmbExchange5;

	[AccessedThroughProperty("cmbExchange4")]
	private UltraComboEditor _cmbExchange4;

	[AccessedThroughProperty("cmbExchange3")]
	private UltraComboEditor _cmbExchange3;

	[AccessedThroughProperty("cmbExchange2")]
	private UltraComboEditor _cmbExchange2;

	private string strSQL;

	private DataTable dt;

	private clsEquity objEquity;

	private Refresh_FavouritesEventHandler Refresh_FavouritesEvent;

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

	internal virtual UltraComboEditor cmbCompany1
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbCompany1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbCompany1 = value;
		}
	}

	internal virtual UltraComboEditor cmbExchange1
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbExchange1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmbExchange1 != null)
			{
				((TextEditorControlBase)_cmbExchange1).remove_ValueChanged((EventHandler)cmbExchange1_ValueChanged);
			}
			_cmbExchange1 = value;
			if (_cmbExchange1 != null)
			{
				((TextEditorControlBase)_cmbExchange1).add_ValueChanged((EventHandler)cmbExchange1_ValueChanged);
			}
		}
	}

	internal virtual UltraComboEditor cmbCompany5
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbCompany5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbCompany5 = value;
		}
	}

	internal virtual UltraComboEditor cmbCompany4
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbCompany4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbCompany4 = value;
		}
	}

	internal virtual UltraComboEditor cmbCompany3
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbCompany3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbCompany3 = value;
		}
	}

	internal virtual UltraComboEditor cmbCompany2
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbCompany2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbCompany2 = value;
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

	internal virtual UltraComboEditor cmbExchange5
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbExchange5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmbExchange5 != null)
			{
				((TextEditorControlBase)_cmbExchange5).remove_ValueChanged((EventHandler)cmbExchange5_ValueChanged);
			}
			_cmbExchange5 = value;
			if (_cmbExchange5 != null)
			{
				((TextEditorControlBase)_cmbExchange5).add_ValueChanged((EventHandler)cmbExchange5_ValueChanged);
			}
		}
	}

	internal virtual UltraComboEditor cmbExchange4
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbExchange4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmbExchange4 != null)
			{
				((TextEditorControlBase)_cmbExchange4).remove_ValueChanged((EventHandler)cmbExchange4_ValueChanged);
			}
			_cmbExchange4 = value;
			if (_cmbExchange4 != null)
			{
				((TextEditorControlBase)_cmbExchange4).add_ValueChanged((EventHandler)cmbExchange4_ValueChanged);
			}
		}
	}

	internal virtual UltraComboEditor cmbExchange3
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbExchange3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmbExchange3 != null)
			{
				((TextEditorControlBase)_cmbExchange3).remove_ValueChanged((EventHandler)cmbExchange3_ValueChanged);
			}
			_cmbExchange3 = value;
			if (_cmbExchange3 != null)
			{
				((TextEditorControlBase)_cmbExchange3).add_ValueChanged((EventHandler)cmbExchange3_ValueChanged);
			}
		}
	}

	internal virtual UltraComboEditor cmbExchange2
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbExchange2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmbExchange2 != null)
			{
				((TextEditorControlBase)_cmbExchange2).remove_ValueChanged((EventHandler)cmbExchange2_ValueChanged);
			}
			_cmbExchange2 = value;
			if (_cmbExchange2 != null)
			{
				((TextEditorControlBase)_cmbExchange2).add_ValueChanged((EventHandler)cmbExchange2_ValueChanged);
			}
		}
	}

	public event Refresh_FavouritesEventHandler Refresh_Favourites
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			Refresh_FavouritesEvent = (Refresh_FavouritesEventHandler)Delegate.Combine(Refresh_FavouritesEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			Refresh_FavouritesEvent = (Refresh_FavouritesEventHandler)Delegate.Remove(Refresh_FavouritesEvent, value);
		}
	}

	[DebuggerNonUserCode]
	public frmFavourites()
	{
		((Form)this).add_Load((EventHandler)frmFavourites_Load);
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
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
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
		//IL_00ea: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected O, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Expected O, but got Unknown
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected O, but got Unknown
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Expected O, but got Unknown
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Expected O, but got Unknown
		//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d48: Expected O, but got Unknown
		ValueListItem val = new ValueListItem();
		ValueListItem val2 = new ValueListItem();
		ValueListItem val3 = new ValueListItem();
		ValueListItem val4 = new ValueListItem();
		ValueListItem val5 = new ValueListItem();
		ValueListItem val6 = new ValueListItem();
		ValueListItem val7 = new ValueListItem();
		ValueListItem val8 = new ValueListItem();
		ValueListItem val9 = new ValueListItem();
		ValueListItem val10 = new ValueListItem();
		Appearance val11 = new Appearance();
		Appearance val12 = new Appearance();
		cmbExchange5 = new UltraComboEditor();
		cmbExchange4 = new UltraComboEditor();
		cmbExchange3 = new UltraComboEditor();
		cmbExchange2 = new UltraComboEditor();
		cmbCompany5 = new UltraComboEditor();
		cmbCompany4 = new UltraComboEditor();
		cmbCompany3 = new UltraComboEditor();
		cmbCompany2 = new UltraComboEditor();
		Label4 = new Label();
		Label3 = new Label();
		cmbCompany1 = new UltraComboEditor();
		cmbExchange1 = new UltraComboEditor();
		btnAdd = new UltraButton();
		btnClose = new UltraButton();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((ISupportInitialize)cmbExchange5).BeginInit();
		((ISupportInitialize)cmbExchange4).BeginInit();
		((ISupportInitialize)cmbExchange3).BeginInit();
		((ISupportInitialize)cmbExchange2).BeginInit();
		((ISupportInitialize)cmbCompany5).BeginInit();
		((ISupportInitialize)cmbCompany4).BeginInit();
		((ISupportInitialize)cmbCompany3).BeginInit();
		((ISupportInitialize)cmbCompany2).BeginInit();
		((ISupportInitialize)cmbCompany1).BeginInit();
		((ISupportInitialize)cmbExchange1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)cmbExchange5);
		((Control)grForm).get_Controls().Add((Control)(object)btnClose);
		((Control)grForm).get_Controls().Add((Control)(object)cmbExchange4);
		((Control)grForm).get_Controls().Add((Control)(object)cmbExchange3);
		((Control)grForm).get_Controls().Add((Control)(object)cmbExchange2);
		((Control)grForm).get_Controls().Add((Control)(object)btnAdd);
		((Control)grForm).get_Controls().Add((Control)(object)cmbCompany5);
		((Control)grForm).get_Controls().Add((Control)(object)cmbCompany1);
		((Control)grForm).get_Controls().Add((Control)(object)cmbCompany4);
		((Control)grForm).get_Controls().Add((Control)(object)cmbExchange1);
		((Control)grForm).get_Controls().Add((Control)(object)cmbCompany3);
		((Control)grForm).get_Controls().Add((Control)(object)Label3);
		((Control)grForm).get_Controls().Add((Control)(object)cmbCompany2);
		((Control)grForm).get_Controls().Add((Control)(object)Label4);
		UltraGroupBox obj = grForm;
		Size size = new Size(384, 274);
		((Control)obj).set_Size(size);
		grForm.set_Text("FAVOURITES");
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)Label4, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbCompany2, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)Label3, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbCompany3, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbExchange1, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbCompany4, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbCompany1, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbCompany5, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)btnAdd, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbExchange2, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbExchange3, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbExchange4, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)btnClose, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)cmbExchange5, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(344, 2);
		((Control)closeButton).set_Location(location);
		cmbExchange5.set_AutoComplete(true);
		((TextEditorControlBase)cmbExchange5).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbExchange5).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_DataValue((object)"1732257");
		val.set_DisplayText("NSE");
		val2.set_DataValue((object)"1732256");
		val2.set_DisplayText("BSE");
		cmbExchange5.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[2] { val, val2 });
		UltraComboEditor obj2 = cmbExchange5;
		location = new Point(17, 179);
		((Control)obj2).set_Location(location);
		((Control)cmbExchange5).set_Name("cmbExchange5");
		UltraComboEditor obj3 = cmbExchange5;
		size = new Size(83, 23);
		((Control)obj3).set_Size(size);
		((Control)cmbExchange5).set_TabIndex(8);
		cmbExchange4.set_AutoComplete(true);
		((TextEditorControlBase)cmbExchange4).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbExchange4).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val3.set_DataValue((object)"1732257");
		val3.set_DisplayText("NSE");
		val4.set_DataValue((object)"1732256");
		val4.set_DisplayText("BSE");
		cmbExchange4.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[2] { val3, val4 });
		UltraComboEditor obj4 = cmbExchange4;
		location = new Point(17, 150);
		((Control)obj4).set_Location(location);
		((Control)cmbExchange4).set_Name("cmbExchange4");
		UltraComboEditor obj5 = cmbExchange4;
		size = new Size(83, 23);
		((Control)obj5).set_Size(size);
		((Control)cmbExchange4).set_TabIndex(6);
		cmbExchange3.set_AutoComplete(true);
		((TextEditorControlBase)cmbExchange3).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbExchange3).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val5.set_DataValue((object)"1732257");
		val5.set_DisplayText("NSE");
		val6.set_DataValue((object)"1732256");
		val6.set_DisplayText("BSE");
		cmbExchange3.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[2] { val5, val6 });
		UltraComboEditor obj6 = cmbExchange3;
		location = new Point(17, 121);
		((Control)obj6).set_Location(location);
		((Control)cmbExchange3).set_Name("cmbExchange3");
		UltraComboEditor obj7 = cmbExchange3;
		size = new Size(83, 23);
		((Control)obj7).set_Size(size);
		((Control)cmbExchange3).set_TabIndex(4);
		cmbExchange2.set_AutoComplete(true);
		((TextEditorControlBase)cmbExchange2).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbExchange2).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val7.set_DataValue((object)"1732257");
		val7.set_DisplayText("NSE");
		val8.set_DataValue((object)"1732256");
		val8.set_DisplayText("BSE");
		cmbExchange2.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[2] { val7, val8 });
		UltraComboEditor obj8 = cmbExchange2;
		location = new Point(17, 92);
		((Control)obj8).set_Location(location);
		((Control)cmbExchange2).set_Name("cmbExchange2");
		UltraComboEditor obj9 = cmbExchange2;
		size = new Size(83, 23);
		((Control)obj9).set_Size(size);
		((Control)cmbExchange2).set_TabIndex(2);
		cmbCompany5.set_AutoComplete(true);
		((TextEditorControlBase)cmbCompany5).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbCompany5).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj10 = cmbCompany5;
		location = new Point(106, 179);
		((Control)obj10).set_Location(location);
		((Control)cmbCompany5).set_Name("cmbCompany5");
		UltraComboEditor obj11 = cmbCompany5;
		size = new Size(255, 23);
		((Control)obj11).set_Size(size);
		((Control)cmbCompany5).set_TabIndex(9);
		cmbCompany4.set_AutoComplete(true);
		((TextEditorControlBase)cmbCompany4).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbCompany4).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj12 = cmbCompany4;
		location = new Point(106, 150);
		((Control)obj12).set_Location(location);
		((Control)cmbCompany4).set_Name("cmbCompany4");
		UltraComboEditor obj13 = cmbCompany4;
		size = new Size(255, 23);
		((Control)obj13).set_Size(size);
		((Control)cmbCompany4).set_TabIndex(7);
		cmbCompany3.set_AutoComplete(true);
		((TextEditorControlBase)cmbCompany3).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbCompany3).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj14 = cmbCompany3;
		location = new Point(106, 121);
		((Control)obj14).set_Location(location);
		((Control)cmbCompany3).set_Name("cmbCompany3");
		UltraComboEditor obj15 = cmbCompany3;
		size = new Size(255, 23);
		((Control)obj15).set_Size(size);
		((Control)cmbCompany3).set_TabIndex(5);
		cmbCompany2.set_AutoComplete(true);
		((TextEditorControlBase)cmbCompany2).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbCompany2).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj16 = cmbCompany2;
		location = new Point(106, 92);
		((Control)obj16).set_Location(location);
		((Control)cmbCompany2).set_Name("cmbCompany2");
		UltraComboEditor obj17 = cmbCompany2;
		size = new Size(255, 23);
		((Control)obj17).set_Size(size);
		((Control)cmbCompany2).set_TabIndex(3);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label = Label4;
		location = new Point(106, 43);
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
		location = new Point(17, 43);
		((Control)label3).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label4 = Label3;
		size = new Size(75, 13);
		((Control)label4).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("EXCHANGE");
		cmbCompany1.set_AutoComplete(true);
		((TextEditorControlBase)cmbCompany1).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbCompany1).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraComboEditor obj18 = cmbCompany1;
		location = new Point(106, 63);
		((Control)obj18).set_Location(location);
		((Control)cmbCompany1).set_Name("cmbCompany1");
		UltraComboEditor obj19 = cmbCompany1;
		size = new Size(255, 23);
		((Control)obj19).set_Size(size);
		((Control)cmbCompany1).set_TabIndex(1);
		cmbExchange1.set_AutoComplete(true);
		((TextEditorControlBase)cmbExchange1).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)cmbExchange1).set_Font(new Font("Verdana", 8.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val9.set_DataValue((object)"1732257");
		val9.set_DisplayText("NSE");
		val10.set_DataValue((object)"1732256");
		val10.set_DisplayText("BSE");
		cmbExchange1.get_Items().AddRange((ValueListItem[])(object)new ValueListItem[2] { val9, val10 });
		UltraComboEditor obj20 = cmbExchange1;
		location = new Point(17, 63);
		((Control)obj20).set_Location(location);
		((Control)cmbExchange1).set_Name("cmbExchange1");
		UltraComboEditor obj21 = cmbExchange1;
		size = new Size(83, 23);
		((Control)obj21).set_Size(size);
		((Control)cmbExchange1).set_TabIndex(0);
		val11.set_BorderColor(Color.Black);
		val11.set_BorderColor2(Color.Black);
		((ControlBase)btnAdd).set_Appearance((AppearanceBase)(object)val11);
		((UltraButtonBase)btnAdd).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnAdd).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj22 = btnAdd;
		location = new Point(20, 227);
		((Control)obj22).set_Location(location);
		((Control)btnAdd).set_Name("btnAdd");
		UltraButton obj23 = btnAdd;
		size = new Size(160, 23);
		((Control)obj23).set_Size(size);
		((Control)btnAdd).set_TabIndex(10);
		((ControlBase)btnAdd).set_Text("ADD");
		val12.set_BorderColor(Color.Black);
		val12.set_BorderColor2(Color.Black);
		((ControlBase)btnClose).set_Appearance((AppearanceBase)(object)val12);
		((UltraButtonBase)btnClose).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnClose).set_DialogResult((DialogResult)2);
		((Control)btnClose).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj24 = btnClose;
		location = new Point(201, 227);
		((Control)obj24).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		UltraButton obj25 = btnClose;
		size = new Size(160, 23);
		((Control)obj25).set_Size(size);
		((Control)btnClose).set_TabIndex(11);
		((ControlBase)btnClose).set_Text("CLOSE");
		((Form)this).set_AcceptButton((IButtonControl)(object)btnAdd);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((Form)this).set_CancelButton((IButtonControl)(object)btnClose);
		size = new Size(384, 274);
		((Form)this).set_ClientSize(size);
		((Control)this).set_Name("frmFavourites");
		((Form)this).set_Text("FAVOURITES");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((Control)grForm).PerformLayout();
		((ISupportInitialize)cmbExchange5).EndInit();
		((ISupportInitialize)cmbExchange4).EndInit();
		((ISupportInitialize)cmbExchange3).EndInit();
		((ISupportInitialize)cmbExchange2).EndInit();
		((ISupportInitialize)cmbCompany5).EndInit();
		((ISupportInitialize)cmbCompany4).EndInit();
		((ISupportInitialize)cmbCompany3).EndInit();
		((ISupportInitialize)cmbCompany2).EndInit();
		((ISupportInitialize)cmbCompany1).EndInit();
		((ISupportInitialize)cmbExchange1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmFavourites_Load(object sender, EventArgs e)
	{
		BindControls();
	}

	private void cmbExchange1_ValueChanged(object sender, EventArgs e)
	{
		Exchange_Change(cmbExchange1, cmbCompany1);
	}

	private void cmbExchange2_ValueChanged(object sender, EventArgs e)
	{
		Exchange_Change(cmbExchange2, cmbCompany2);
	}

	private void cmbExchange3_ValueChanged(object sender, EventArgs e)
	{
		Exchange_Change(cmbExchange3, cmbCompany3);
	}

	private void cmbExchange4_ValueChanged(object sender, EventArgs e)
	{
		Exchange_Change(cmbExchange4, cmbCompany4);
	}

	private void cmbExchange5_ValueChanged(object sender, EventArgs e)
	{
		Exchange_Change(cmbExchange5, cmbCompany5);
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		Money_Splash money_Splash = new Money_Splash();
		try
		{
			((Control)money_Splash).Show();
			((Control)money_Splash).Refresh();
			clsEquity clsEquity2 = new clsEquity();
			clsEquity2.getMyIP();
			strSQL = "DELETE FROM CNBCMONEY_DETAILS WHERE USERID IN (SELECT USERID FROM CNBCMONEY_USERS_MST WHERE TABINDEX = 0 AND USERNAME = '" + mdlMain.gUserName + "')";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
			strSQL = "DELETE FROM CNBCMONEY_USERS_MST WHERE TABINDEX = 0 AND USERNAME = '" + mdlMain.gUserName + "'";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
			if (cmbCompany1.get_SelectedIndex() > -1)
			{
				AddFavourites(Conversions.ToString(cmbExchange1.get_Value()), Conversions.ToString(cmbCompany1.get_Value()), "1");
			}
			if (cmbCompany2.get_SelectedIndex() > -1)
			{
				AddFavourites(Conversions.ToString(cmbExchange2.get_Value()), Conversions.ToString(cmbCompany2.get_Value()), "2");
			}
			if (cmbCompany3.get_SelectedIndex() > -1)
			{
				AddFavourites(Conversions.ToString(cmbExchange3.get_Value()), Conversions.ToString(cmbCompany3.get_Value()), "3");
			}
			if (cmbCompany4.get_SelectedIndex() > -1)
			{
				AddFavourites(Conversions.ToString(cmbExchange4.get_Value()), Conversions.ToString(cmbCompany4.get_Value()), "4");
			}
			if (cmbCompany5.get_SelectedIndex() > -1)
			{
				AddFavourites(Conversions.ToString(cmbExchange5.get_Value()), Conversions.ToString(cmbCompany5.get_Value()), "5");
			}
			Refresh_FavouritesEvent?.Invoke();
			((Form)this).Close();
			((Form)money_Splash).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)money_Splash).Close();
			ProjectData.ClearProjectError();
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void BindControls()
	{
		checked
		{
			try
			{
				objEquity = new clsEquity();
				strSQL = "SELECT ISNULL(EXCHANGE,'') AS EXCHANGE, BRIDGESYMBOL, TABNAME FROM vw_CNBCMONEY_DETAILS WHERE  USERNAME = '" + mdlMain.gUserName + "' AND TABINDEX = 0 ORDER BY TABNAME";
				DataTable dataTable = new DataTable();
				dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
				int num = dataTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						object obj = dataTable.Rows[num2]["TABNAME"];
						if (Operators.ConditionalCompareObjectEqual(obj, (object)"1", false))
						{
							cmbExchange1.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["EXCHANGE"]));
							cmbCompany1.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["BRIDGESYMBOL"]));
						}
						else if (Operators.ConditionalCompareObjectEqual(obj, (object)"2", false))
						{
							cmbExchange2.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["EXCHANGE"]));
							cmbCompany2.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["BRIDGESYMBOL"]));
						}
						else if (Operators.ConditionalCompareObjectEqual(obj, (object)"3", false))
						{
							cmbExchange3.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["EXCHANGE"]));
							cmbCompany3.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["BRIDGESYMBOL"]));
						}
						else if (Operators.ConditionalCompareObjectEqual(obj, (object)"4", false))
						{
							cmbExchange4.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["EXCHANGE"]));
							cmbCompany4.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["BRIDGESYMBOL"]));
						}
						else if (Operators.ConditionalCompareObjectEqual(obj, (object)"5", false))
						{
							cmbExchange5.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["EXCHANGE"]));
							cmbCompany5.set_Value(RuntimeHelpers.GetObjectValue(dataTable.Rows[num2]["BRIDGESYMBOL"]));
						}
						num2++;
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

	private void Exchange_Change(UltraComboEditor ctrlComboExchange, UltraComboEditor ctrlComboCompany)
	{
		try
		{
			ctrlComboCompany.set_Text(string.Empty);
			ctrlComboExchange.set_DataSource((object)null);
			strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select DISTINCT(vehicletype.shortname) AS shortname,vehicle_exchange.ExchangeSymbol as ES, bridgesymbol from equity_transaction_data , vehicletype, vehicle_exchange  Where symbol = bridgesymbol AND vehicletype.code = vehicle_exchange.code AND vehicle_exchange.exchange_id = ", ctrlComboExchange.get_Value()), (object)" AND equity_transaction_data.SERIES IN ('EQ', 'BE') AND equity_transaction_data.Market_Type= 'N'  order by vehicletype.shortname"));
			dt = new DataTable();
			dt = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0];
			UltraComboEditor val = ctrlComboCompany;
			val.set_DataSource((object)dt);
			val.set_DisplayMember("shortname");
			val.set_ValueMember("bridgesymbol");
			val = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AddFavourites(string strExchange, string strBridgeSymbol, string ctrlIndex)
	{
		try
		{
			objEquity = new clsEquity();
			objEquity.getMyIP();
			string text = "";
			strSQL = "SELECT ExchangeSymbol FROM Vehicle_Exchange WHERE Symbol = '" + strBridgeSymbol + "' AND SERIES = 'EQUITY'";
			text = Conversions.ToString(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL));
			objEquity.AddLookUp(strBridgeSymbol, text, ctrlIndex, 0, strExchange);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
