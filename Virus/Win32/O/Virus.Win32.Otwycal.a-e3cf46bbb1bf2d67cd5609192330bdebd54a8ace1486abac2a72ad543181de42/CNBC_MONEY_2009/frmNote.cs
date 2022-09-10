using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmNote : InheritedForm
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("txtNote")]
	private UltraTextEditor _txtNote;

	[AccessedThroughProperty("btnAdd")]
	private UltraButton _btnAdd;

	[AccessedThroughProperty("btnClose")]
	private UltraButton _btnClose;

	[AccessedThroughProperty("ugNotes")]
	private UltraGrid _ugNotes;

	[AccessedThroughProperty("btnClearFrm")]
	private UltraButton _btnClearFrm;

	private string strSQL;

	private string _BridgeSymbol;

	private string _ExchangeSymbol;

	private string _ScripName;

	private string _TabName;

	private string _Tab_Index;

	private clsEquity objEquity;

	internal virtual UltraTextEditor txtNote
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNote;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNote = value;
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

	internal virtual UltraGrid ugNotes
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugNotes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_ugNotes != null)
			{
				_ugNotes.remove_DoubleClickRow(new DoubleClickRowEventHandler(ugNotes_DoubleClickRow));
				_ugNotes.remove_InitializeLayout(new InitializeLayoutEventHandler(ugNotes_InitializeLayout));
			}
			_ugNotes = value;
			if (_ugNotes != null)
			{
				_ugNotes.add_DoubleClickRow(new DoubleClickRowEventHandler(ugNotes_DoubleClickRow));
				_ugNotes.add_InitializeLayout(new InitializeLayoutEventHandler(ugNotes_InitializeLayout));
			}
		}
	}

	internal virtual UltraButton btnClearFrm
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnClearFrm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnClearFrm != null)
			{
				((Control)_btnClearFrm).remove_Click((EventHandler)btnClearFrm_Click);
			}
			_btnClearFrm = value;
			if (_btnClearFrm != null)
			{
				((Control)_btnClearFrm).add_Click((EventHandler)btnClearFrm_Click);
			}
		}
	}

	public string BridgeSymbol
	{
		get
		{
			return _BridgeSymbol;
		}
		set
		{
			_BridgeSymbol = value;
		}
	}

	public object ExchangeSymbol
	{
		get
		{
			return _ExchangeSymbol;
		}
		set
		{
			_ExchangeSymbol = Conversions.ToString(value);
		}
	}

	public string ScripName
	{
		get
		{
			return _ScripName;
		}
		set
		{
			_ScripName = value;
		}
	}

	public string TabName
	{
		get
		{
			return _TabName;
		}
		set
		{
			_TabName = value;
		}
	}

	public string Tab_Index
	{
		get
		{
			return _Tab_Index;
		}
		set
		{
			_Tab_Index = value;
		}
	}

	[DebuggerNonUserCode]
	public frmNote()
	{
		((Form)this).add_Load((EventHandler)frmNote_Load);
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
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Appearance val4 = new Appearance();
		Appearance val5 = new Appearance();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		Appearance val8 = new Appearance();
		txtNote = new UltraTextEditor();
		btnAdd = new UltraButton();
		btnClose = new UltraButton();
		ugNotes = new UltraGrid();
		btnClearFrm = new UltraButton();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((ISupportInitialize)txtNote).BeginInit();
		((ISupportInitialize)ugNotes).BeginInit();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)btnClearFrm);
		((Control)grForm).get_Controls().Add((Control)(object)btnClose);
		((Control)grForm).get_Controls().Add((Control)(object)btnAdd);
		((Control)grForm).get_Controls().Add((Control)(object)txtNote);
		((Control)grForm).get_Controls().Add((Control)(object)ugNotes);
		UltraGroupBox obj = grForm;
		Size size = new Size(603, 549);
		((Control)obj).set_Size(size);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)ugNotes, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)txtNote, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)btnAdd, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)btnClose, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)btnClearFrm, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(563, 1);
		((Control)closeButton).set_Location(location);
		((TextEditorControlBase)txtNote).set_DisplayStyle((EmbeddableElementDisplayStyle)6);
		((Control)txtNote).set_Dock((DockStyle)1);
		UltraTextEditor obj2 = txtNote;
		location = new Point(3, 29);
		((Control)obj2).set_Location(location);
		txtNote.set_Multiline(true);
		((Control)txtNote).set_Name("txtNote");
		txtNote.set_Scrollbars((ScrollBars)3);
		UltraTextEditor obj3 = txtNote;
		size = new Size(597, 169);
		((Control)obj3).set_Size(size);
		((Control)txtNote).set_TabIndex(0);
		((Control)txtNote).set_Tag((object)"0");
		val.set_BorderColor(Color.Black);
		val.set_BorderColor2(Color.Black);
		((ControlBase)btnAdd).set_Appearance((AppearanceBase)(object)val);
		((UltraButtonBase)btnAdd).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnAdd).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj4 = btnAdd;
		location = new Point(6, 205);
		((Control)obj4).set_Location(location);
		((Control)btnAdd).set_Name("btnAdd");
		UltraButton obj5 = btnAdd;
		size = new Size(160, 23);
		((Control)obj5).set_Size(size);
		((Control)btnAdd).set_TabIndex(1);
		((ControlBase)btnAdd).set_Text("ADD");
		val2.set_BorderColor(Color.Black);
		val2.set_BorderColor2(Color.Black);
		((ControlBase)btnClose).set_Appearance((AppearanceBase)(object)val2);
		((UltraButtonBase)btnClose).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnClose).set_DialogResult((DialogResult)2);
		((Control)btnClose).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj6 = btnClose;
		location = new Point(436, 205);
		((Control)obj6).set_Location(location);
		((Control)btnClose).set_Name("btnClose");
		UltraButton obj7 = btnClose;
		size = new Size(160, 23);
		((Control)obj7).set_Size(size);
		((Control)btnClose).set_TabIndex(2);
		((ControlBase)btnClose).set_Text("CLOSE");
		val3.set_BackColor(Color.White);
		((UltraGridBase)ugNotes).get_DisplayLayout().set_Appearance((AppearanceBase)(object)val3);
		((UltraGridBase)ugNotes).get_DisplayLayout().set_AutoFitStyle((AutoFitStyle)1);
		((UltraGridBase)ugNotes).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		val4.set_BackColor(Color.Transparent);
		((UltraGridBase)ugNotes).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val4);
		val5.set_BackColor(Color.FromArgb(89, 135, 214));
		val5.set_BackColor2(Color.FromArgb(7, 59, 150));
		val5.set_BackGradientStyle((GradientStyle)2);
		val5.get_FontData().set_BoldAsString("True");
		val5.get_FontData().set_Name("Arial");
		val5.get_FontData().set_SizeInPoints(10f);
		val5.set_ForeColor(Color.White);
		val5.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugNotes).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val5);
		val6.set_BackColor(Color.FromArgb(89, 135, 214));
		val6.set_BackColor2(Color.FromArgb(7, 59, 150));
		val6.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugNotes).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val6);
		val7.set_BackColor(Color.FromArgb(251, 230, 148));
		val7.set_BackColor2(Color.FromArgb(238, 149, 21));
		val7.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugNotes).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val7);
		((Control)ugNotes).set_Dock((DockStyle)2);
		UltraGrid obj8 = ugNotes;
		location = new Point(3, 235);
		((Control)obj8).set_Location(location);
		((Control)ugNotes).set_Name("ugNotes");
		UltraGrid obj9 = ugNotes;
		size = new Size(597, 311);
		((Control)obj9).set_Size(size);
		((Control)ugNotes).set_TabIndex(15);
		((Control)ugNotes).set_Text("UltraGrid1");
		val8.set_BorderColor(Color.FromArgb(64, 64, 64));
		val8.set_BorderColor2(Color.FromArgb(64, 64, 64));
		((ControlBase)btnClearFrm).set_Appearance((AppearanceBase)(object)val8);
		((UltraButtonBase)btnClearFrm).set_ButtonStyle((UIElementButtonStyle)17);
		UltraButton obj10 = btnClearFrm;
		location = new Point(220, 205);
		((Control)obj10).set_Location(location);
		((Control)btnClearFrm).set_Name("btnClearFrm");
		UltraButton obj11 = btnClearFrm;
		size = new Size(160, 23);
		((Control)obj11).set_Size(size);
		((Control)btnClearFrm).set_TabIndex(16);
		((ControlBase)btnClearFrm).set_Text("CLEAR");
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((Form)this).set_CancelButton((IButtonControl)(object)btnClose);
		size = new Size(603, 549);
		((Form)this).set_ClientSize(size);
		((Control)this).set_Name("frmNote");
		((Form)this).set_Text("Note");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((Control)grForm).PerformLayout();
		((ISupportInitialize)txtNote).EndInit();
		((ISupportInitialize)ugNotes).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmNote_Load(object sender, EventArgs e)
	{
		BindControls();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		Add_Click();
		((Control)txtNote).set_Tag((object)0);
		((TextEditorControlBase)txtNote).set_Text("");
		((ControlBase)btnAdd).set_Text("ADD");
		BindGrid();
	}

	private void btnClearFrm_Click(object sender, EventArgs e)
	{
		((Control)txtNote).set_Tag((object)0);
		((TextEditorControlBase)txtNote).set_Text("");
		((ControlBase)btnAdd).set_Text("ADD");
		((TextEditorControlBase)txtNote).set_ReadOnly(false);
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ugNotes_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		UltraGridBand val = e.get_Layout().get_Bands().get_Item(0);
		val.get_Columns().get_Item(0).set_Hidden(true);
		val.get_Columns().get_Item(1).set_Hidden(true);
		val.get_Override().set_CellClickAction((CellClickAction)2);
		checked
		{
			int num = ((DisposableObjectCollectionBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()).get_Count() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				val.get_Columns().get_Item(num2).set_CellActivation((Activation)3);
				num2++;
			}
			val = null;
		}
	}

	private void ugNotes_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
	{
		try
		{
			((Control)txtNote).set_Tag(RuntimeHelpers.GetObjectValue(e.get_Row().get_Cells().get_Item("NOTE_DTLID")
				.get_Value()));
			((TextEditorControlBase)txtNote).set_Text(Conversions.ToString(e.get_Row().get_Cells().get_Item("NOTE")
				.get_Value()));
			((ControlBase)btnAdd).set_Text("UPDATE");
			if (Operators.ConditionalCompareObjectEqual(e.get_Row().get_Cells().get_Item("USERNAME")
				.get_Value(), (object)mdlMain.gUserName, false))
			{
				((TextEditorControlBase)txtNote).set_ReadOnly(false);
			}
			else
			{
				((TextEditorControlBase)txtNote).set_ReadOnly(true);
			}
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
			grForm.set_Text(ScripName);
			((TextEditorControlBase)txtNote).set_ReadOnly(false);
			((TextEditorControlBase)txtNote).set_Text("");
			((Control)txtNote).set_Tag((object)0);
			BindGrid();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BindGrid()
	{
		try
		{
			int num = 0;
			strSQL = "SELECT GROUPID FROM CNBCMONEY_LOGINS WHERE LOGINID = " + Conversions.ToString(mdlMain.gLoginID);
			num = Conversions.ToInteger(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL));
			if (num == 0)
			{
				strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT NOTEID, NOTE_DTLID, USERNAME, NOTE, UPDATED_DATETIME FROM vw_CNBCMONEY_NOTES_DETAILS WHERE EXCHANGESYMBOL = '", ExchangeSymbol), (object)"' AND (USERNAME = '"), (object)mdlMain.gUserName), (object)"') ORDER BY UPDATED_DATETIME DESC"));
			}
			else
			{
				strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT NOTEID, NOTE_DTLID, USERNAME, NOTE, UPDATED_DATETIME FROM vw_CNBCMONEY_NOTES_DETAILS WHERE EXCHANGESYMBOL = '", ExchangeSymbol), (object)"' AND (GROUPID = "), (object)num), (object)" OR USERNAME = '"), (object)mdlMain.gUserName), (object)"') ORDER BY UPDATED_DATETIME DESC"));
			}
			((UltraGridBase)ugNotes).set_DataSource((object)SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL).Tables[0]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Add_Click_Old()
	{
		try
		{
			objEquity = new clsEquity();
			strSQL = "SELECT USERID FROM CNBCMONEY_USERS_MST WHERE TABINDEX = " + Tab_Index + " AND USERNAME = '" + mdlMain.gUserName + "'";
			int num = Conversions.ToInteger(SqlHelper.ExecuteScalar(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL));
			strSQL = "UPDATE CNBCMONEY_DETAILS SET NOTE = '" + Strings.Replace(((TextEditorControlBase)txtNote).get_Text(), "'", "''", 1, -1, (CompareMethod)0) + "' WHERE USERID = " + Conversions.ToString(num) + " AND BRIDGESYMBOL = '" + BridgeSymbol + "'";
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.Text, strSQL);
			((Form)this).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Add_Click()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		try
		{
			SqlParameter[] array = (SqlParameter[])(object)new SqlParameter[5]
			{
				new SqlParameter(),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter),
				default(SqlParameter)
			};
			array[0].set_Direction(ParameterDirection.Input);
			array[0].set_ParameterName("@EXCHANGESYMBOL");
			array[0].set_DbType(DbType.String);
			array[0].set_Value(RuntimeHelpers.GetObjectValue(ExchangeSymbol));
			array[1] = new SqlParameter();
			array[1].set_Direction(ParameterDirection.Input);
			array[1].set_ParameterName("@LOGINID");
			array[1].set_DbType(DbType.Int64);
			array[1].set_Value((object)mdlMain.gLoginID);
			array[2] = new SqlParameter();
			array[2].set_Direction(ParameterDirection.Input);
			array[2].set_ParameterName("@USERNAME");
			array[2].set_DbType(DbType.String);
			array[2].set_Value((object)mdlMain.gUserName);
			array[3] = new SqlParameter();
			array[3].set_Direction(ParameterDirection.Input);
			array[3].set_ParameterName("@NOTE_DTLID");
			array[3].set_DbType(DbType.Int64);
			array[3].set_Value((object)Conversions.ToInteger(((Control)txtNote).get_Tag()));
			array[4] = new SqlParameter();
			array[4].set_Direction(ParameterDirection.Input);
			array[4].set_ParameterName("@NOTE");
			array[4].set_DbType(DbType.String);
			array[4].set_Value((object)Strings.Replace(((TextEditorControlBase)txtNote).get_Text(), "'", "''", 1, -1, (CompareMethod)0));
			SqlHelper.ExecuteNonQuery(MySettingsProperty.Settings.strCON, CommandType.StoredProcedure, "sp_SAVE_CNBCMONEY_NOTES", array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
