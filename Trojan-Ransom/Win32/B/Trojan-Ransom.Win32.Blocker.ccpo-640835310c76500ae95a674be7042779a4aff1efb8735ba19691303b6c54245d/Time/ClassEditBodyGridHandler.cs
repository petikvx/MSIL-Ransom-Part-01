using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Time;

public class ClassEditBodyGridHandler
{
	private SortedList<int, object> _copiedInstructions;

	private object _currentMethod;

	private int _currentRowIndex;

	private int _currentVarIndex;

	private DataTable _dtBody;

	private DataTable _dtGeneral;

	private DataTable _dtVariable;

	private object _form;

	private object _frmDeobfMethod;

	private bool _markBlocks;

	private const int COL_INDEX = 0;

	private const int COL_OFFSET = 1;

	private const int COL_OPCODE = 2;

	private const int COL_OPERAND = 3;

	private const int COL_OPERANDTYPE = 4;

	private DataGridView dgBody;

	private DataGridView dgGeneral;

	private DataGridView dgVariable;

	private Rectangle dragBoxFromMouseDown;

	private int rowIndexFromMouseDown;

	private int rowIndexUnderMouseToDrop;

	private TabPage tabDetails;

	private const string TRY_MARK = ".try";

	public object CurrentMethod => _currentMethod;

	public int CurrentRowIndex
	{
		get
		{
			return _currentRowIndex;
		}
		set
		{
			_currentRowIndex = value;
		}
	}

	public ClassEditBodyGridHandler()
	{
		_currentRowIndex = -1;
		_currentVarIndex = -1;
	}

	public void cmMarkBlocks_Click(object sender, EventArgs e)
	{
		ToolStripMenuItem val = (ToolStripMenuItem)((sender is ToolStripMenuItem) ? sender : null);
		val.set_Checked(!val.get_Checked());
		_markBlocks = val.get_Checked();
		MarkBlocks();
	}

	public void cmMove_Click(object sender, EventArgs e)
	{
		if (dgBody.get_SelectedRows() == null || ((BaseCollection)dgBody.get_SelectedRows()).get_Count() < 1)
		{
			return;
		}
		int num = default(int);
		if (num == 0)
		{
		}
		checked
		{
			if (num + 1 != ((BaseCollection)dgBody.get_SelectedRows()).get_Count())
			{
				return;
			}
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				SetCurrentRow(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "DisplayStartIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
				int num2 = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(objectValue, (Type)null, "DisplayStartIndex", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue, (Type)null, "DisplayLength", new object[0], (string[])null, (Type[])null, (bool[])null)));
				int num3 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "DisplayStartIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
				int num4 = num2 - 1;
				for (int i = num3; i <= num4; i++)
				{
					dgBody.get_Rows().get_Item(i).set_Selected(true);
				}
			}
		}
	}

	public void cmNewExceptionHandler_Click(object sender, EventArgs e)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false);
	}

	public void cmNop_Click(object sender, EventArgs e)
	{
		if (dgBody.get_SelectedRows() == null || ((BaseCollection)dgBody.get_SelectedRows()).get_Count() < 1)
		{
			return;
		}
		checked
		{
			int num = ((BaseCollection)dgBody.get_SelectedRows()).get_Count() - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				if (num2 < 0)
				{
				}
			}
		}
	}

	public void cmOp_Opening(object sender, object e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		ContextMenuStrip val = (ContextMenuStrip)((sender is ContextMenuStrip) ? sender : null);
		if (dgBody.get_CurrentRow() == null)
		{
			NewLateBinding.LateSet(e, (Type)null, "Cancel", new object[1] { true }, (string[])null, (Type[])null);
			return;
		}
		ToolStripItem obj = ((ToolStrip)val).get_Items().get_Item("cmHighlight");
		InitHighlightContextMenu((ToolStripMenuItem)(object)((obj is ToolStripMenuItem) ? obj : null));
		((ToolStripMenuItem)((ToolStrip)val).get_Items().get_Item("cmMarkBlocks")).set_Checked(_markBlocks);
		int num2 = default(int);
		int num = default(int);
		if ((num >= 0 || num2 >= 0) && ((BaseCollection)dgBody.get_SelectedRows()).get_Count() > 0)
		{
			((ToolStrip)val).get_Items().get_Item("cmRemove").set_Enabled(true);
		}
		else
		{
			((ToolStrip)val).get_Items().get_Item("cmRemove").set_Enabled(false);
		}
		if (num >= 0 && ((BaseCollection)dgBody.get_SelectedRows()).get_Count() > 0)
		{
			((ToolStrip)val).get_Items().get_Item("cmNop").set_Enabled(true);
			((ToolStrip)val).get_Items().get_Item("cmCopy").set_Enabled(true);
			((ToolStrip)val).get_Items().get_Item("cmMove").set_Enabled(true);
		}
		else
		{
			((ToolStrip)val).get_Items().get_Item("cmNop").set_Enabled(false);
			((ToolStrip)val).get_Items().get_Item("cmCopy").set_Enabled(false);
			((ToolStrip)val).get_Items().get_Item("cmMove").set_Enabled(false);
		}
		if (num >= 0 && ((BaseCollection)dgBody.get_SelectedRows()).get_Count() == 1 && _copiedInstructions != null && _copiedInstructions.Count > 0)
		{
			((ToolStrip)val).get_Items().get_Item("cmPaste").set_Enabled(true);
		}
		else
		{
			((ToolStrip)val).get_Items().get_Item("cmPaste").set_Enabled(false);
		}
		if (Conversions.ToBoolean((!Conversions.ToBoolean((object)((num >= 0 || num2 >= 0) ? true : false)) || !Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(_form, (Type)null, "SaveAssemblyButton", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null)) || !Conversions.ToBoolean((object)(((BaseCollection)dgBody.get_SelectedRows()).get_Count() == 1))) ? ((object)false) : ((object)true)))
		{
			((ToolStrip)val).get_Items().get_Item("cmEdit").set_Enabled(true);
		}
		else
		{
			((ToolStrip)val).get_Items().get_Item("cmEdit").set_Enabled(false);
		}
		if (Conversions.ToBoolean((!Conversions.ToBoolean((object)(num >= 0)) || !Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(_form, (Type)null, "SaveAssemblyButton", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null)) || !Conversions.ToBoolean((object)(((BaseCollection)dgBody.get_SelectedRows()).get_Count() == 1))) ? ((object)false) : ((object)true)))
		{
			((ToolStrip)val).get_Items().get_Item("cmInsertBefore").set_Enabled(true);
			((ToolStrip)val).get_Items().get_Item("cmInsertAfter").set_Enabled(true);
			((ToolStrip)val).get_Items().get_Item("cmDuplicate").set_Enabled(true);
			((ToolStrip)val).get_Items().get_Item("cmHighlight").set_Enabled(true);
			((ToolStrip)val).get_Items().get_Item("cmMakeBranch").set_Enabled(true);
			object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Instructions", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { num };
			bool[] array2 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Item", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			RuntimeHelpers.GetObjectValue(obj3);
			((ToolStrip)val).get_Items().get_Item("cmDeobfBranch").set_Enabled(true);
			((ToolStrip)val).get_Items().get_Item("cmDeobfBranch").set_Enabled(false);
			((ToolStrip)val).get_Items().get_Item("cmInsertBefore").set_Enabled(false);
			((ToolStrip)val).get_Items().get_Item("cmInsertAfter").set_Enabled(false);
			((ToolStrip)val).get_Items().get_Item("cmDuplicate").set_Enabled(false);
			((ToolStrip)val).get_Items().get_Item("cmHighlight").set_Enabled(false);
			((ToolStrip)val).get_Items().get_Item("cmDeobfBranch").set_Enabled(false);
			((ToolStrip)val).get_Items().get_Item("cmMakeBranch").set_Enabled(false);
		}
	}

	public void cmPaste_Click(object sender, EventArgs e)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Instructions", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array = new object[1] { 0 };
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(objectValue, (Type)null, "Item", array2, (string[])null, (Type[])null, array3);
		int num = default(int);
		if (array3[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetILProcessor", new object[0], (string[])null, (Type[])null, (bool[])null));
		object objectValue4 = default(object);
		foreach (KeyValuePair<int, object> copiedInstruction in _copiedInstructions)
		{
			RuntimeHelpers.GetObjectValue(copiedInstruction.Value);
			object[] array4 = new object[2]
			{
				RuntimeHelpers.GetObjectValue(objectValue2),
				RuntimeHelpers.GetObjectValue(objectValue4)
			};
			object[] array5 = array4;
			array3 = new bool[2] { true, true };
			NewLateBinding.LateCall(objectValue3, (Type)null, "InsertAfter", array5, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(array4[0]);
			}
			if (array3[1])
			{
				objectValue4 = RuntimeHelpers.GetObjectValue(array4[1]);
			}
			objectValue2 = RuntimeHelpers.GetObjectValue(objectValue4);
		}
		SetCurrentRow(checked(num + 1 + 1));
	}

	public void cmRemove_Click(object sender, EventArgs e)
	{
		if (dgBody.get_SelectedRows() == null || ((BaseCollection)dgBody.get_SelectedRows()).get_Count() < 1)
		{
			return;
		}
		checked
		{
			object[] array = new object[((BaseCollection)dgBody.get_SelectedRows()).get_Count() - 1 + 1];
			int num = ((BaseCollection)dgBody.get_SelectedRows()).get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i;
				object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Instructions", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array2 = new object[1] { 15 };
				object[] array3 = array2;
				bool[] array4 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Item", array3, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					_ = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				array[num2] = RuntimeHelpers.GetObjectValue(obj2);
			}
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetILProcessor", new object[0], (string[])null, (Type[])null, (bool[])null));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ExceptionHandlers", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array5 = array;
			for (int j = 0; j < array5.Length; j++)
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(array5[j]);
				if (objectValue3 != null)
				{
					if (objectValue3 is object)
					{
						NewLateBinding.LateCall(objectValue, (Type)null, "Remove", new object[1] { RuntimeHelpers.GetObjectValue(objectValue3) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					else if (objectValue3 is object)
					{
						NewLateBinding.LateCall(objectValue2, (Type)null, "Remove", new object[1] { RuntimeHelpers.GetObjectValue(objectValue3) }, (string[])null, (Type[])null, (bool[])null, true);
					}
				}
			}
		}
	}

	public void cmSaveDetailsAs_Click(object sender, EventArgs e)
	{
		string text = default(string);
		if (text.Length <= 250)
		{
		}
		string path = default(string);
		if (!Directory.Exists(path))
		{
			path = Environment.CurrentDirectory;
		}
		string text2 = default(string);
		string.IsNullOrEmpty(text2);
		if (string.IsNullOrEmpty(text2))
		{
			return;
		}
		checked
		{
			try
			{
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					DataGridViewRowCollection rows = dgBody.get_Rows();
					int num = rows.get_Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						string value = string.Format("{0,-8} {1,-12} {2,-12} {3}", 50, 42, 45, 454);
						streamWriter.WriteLine(value);
					}
				}
				NewLateBinding.LateCall(_form, (Type)null, "SetStatusText", new object[1] { $"{text2} saved." }, (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				throw;
			}
			finally
			{
				((Control)dgBody).ResumeLayout();
			}
		}
	}

	public void dgBody_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.get_ColumnIndex() == 3)
		{
			DataGridViewRow val = dgBody.get_Rows().get_Item(e.get_RowIndex());
			switch (val.get_Cells().get_Item(e.get_ColumnIndex()).get_Value() as string)
			{
			case "MethodDefinition":
				e.get_CellStyle().set_ForeColor(Color.Indigo);
				break;
			case "Instruction":
			case "Instruction[]":
				e.get_CellStyle().set_ForeColor(Color.FromArgb(0, 0, 192));
				break;
			case "String":
			case "Int16":
			case "Int32":
			case "Int64":
			case "UInt16":
			case "UInt32":
			case "UInt64":
				e.get_CellStyle().set_ForeColor(Color.DarkRed);
				break;
			}
		}
		else
		{
			if (e.get_ColumnIndex() != 2)
			{
				return;
			}
			dgBody.get_Rows().get_Item(e.get_RowIndex());
			int num = default(int);
			if (num >= 0)
			{
				object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Instructions", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1] { num };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Item", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				RuntimeHelpers.GetObjectValue(obj2);
				e.get_CellStyle().set_ForeColor(Color.Red);
			}
		}
	}

	public void dgBody_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	public void dgBody_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)((MouseEventArgs)e).get_Button() == 2097152 && e.get_RowIndex() >= 0 && !dgBody.get_Rows().get_Item(e.get_RowIndex()).get_Selected())
		{
			dgBody.set_CurrentCell(dgBody.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(e.get_ColumnIndex()));
		}
	}

	public void dgBody_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		DataGridViewRow val = dgBody.get_Rows().get_Item(((DataGridViewCellEventArgs)e).get_RowIndex());
		if (((DataGridViewCellEventArgs)e).get_ColumnIndex() == 2)
		{
			DataGridViewCell val2 = val.get_Cells().get_Item(((DataGridViewCellEventArgs)e).get_ColumnIndex());
			_ = val2.get_Value() is string;
		}
		else if (((DataGridViewCellEventArgs)e).get_ColumnIndex() == 3)
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Instructions", new object[0], (string[])null, (Type[])null, (bool[])null);
			int num = default(int);
			object[] array = new object[1] { num };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Item", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			object objectValue = RuntimeHelpers.GetObjectValue(obj2);
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "Operand", new object[0], (string[])null, (Type[])null, (bool[])null));
			object objectValue3 = RuntimeHelpers.GetObjectValue(objectValue2);
			object obj4;
			if (!(objectValue3 is UIOption))
			{
				object obj3 = new object();
				object[] array4 = new object[3]
				{
					RuntimeHelpers.GetObjectValue(objectValue3),
					null,
					null
				};
				object[] array5 = array4;
				object form = _form;
				array = new object[0];
				object[] array6 = array;
				string[] array7 = null;
				array5[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(form, (Type)null, "TreeViewHandler", array6, array7, (Type[])null, (bool[])null), (Type)null, "GetLoadedAssemblyList", new object[0], (string[])null, (Type[])null, (bool[])null));
				array4[2] = null;
				object[] array8 = array4;
				array3 = new bool[3] { true, true, false };
				obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Resolve", array8, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					objectValue3 = RuntimeHelpers.GetObjectValue(array8[0]);
				}
				if (array3[1])
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(form, (Type)null, "TreeViewHandler", array, array7, (Type[])null, (bool[])null), (Type)null, "GetLoadedAssemblyList", new object[1] { RuntimeHelpers.GetObjectValue(array8[1]) }, (string[])null, (Type[])null, true, true);
				}
			}
			else
			{
				obj4 = (object)(UIOption)objectValue3;
			}
			Conversions.ToInteger(obj4);
			DataGridViewCell val3 = val.get_Cells().get_Item(((DataGridViewCellEventArgs)e).get_ColumnIndex());
			if (val3.get_Value() != null)
			{
				e.set_ToolTipText(val3.get_Value().ToString());
			}
		}
		else if (((DataGridViewCellEventArgs)e).get_ColumnIndex() == 1)
		{
			_ = (MethodBody)NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null);
			object obj5 = default(object);
			int num2 = Conversions.ToInteger(Operators.AddObject((object)1, NewLateBinding.LateGet(obj5, (Type)null, "Offset", new object[0], (string[])null, (Type[])null, (bool[])null)));
			e.set_ToolTipText($"RVA: 0x{num2:x}");
		}
	}

	public void dgBody_DragDrop(object sender, DragEventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		DataGridView obj = dgBody;
		Point point = new Point(e.get_X(), e.get_Y());
		Point point2 = ((Control)obj).PointToClient(point);
		rowIndexUnderMouseToDrop = dgBody.HitTest(point2.X, point2.Y).get_RowIndex();
		if ((int)e.get_Effect() == 2)
		{
			int num = 5;
			int num2 = 8;
			object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Instructions", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { 5 };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Item", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			object objectValue = RuntimeHelpers.GetObjectValue(obj3);
			object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Instructions", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array4 = new object[1] { num2 };
			object[] array5 = array4;
			array3 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Item", array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(obj5);
			object obj6 = NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetILProcessor", new object[0], (string[])null, (Type[])null, (bool[])null);
			array4 = new object[1] { RuntimeHelpers.GetObjectValue(objectValue) };
			object[] array6 = array4;
			array3 = new bool[1] { true };
			NewLateBinding.LateCall(obj6, (Type)null, "Remove", array6, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				objectValue = RuntimeHelpers.GetObjectValue(array4[0]);
			}
			object obj7 = NewLateBinding.LateGet(NewLateBinding.LateGet(_currentMethod, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetILProcessor", new object[0], (string[])null, (Type[])null, (bool[])null);
			object obj8 = default(object);
			array4 = new object[2]
			{
				RuntimeHelpers.GetObjectValue(objectValue2),
				RuntimeHelpers.GetObjectValue(obj8)
			};
			object[] array7 = array4;
			array3 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj7, (Type)null, "InsertAfter", array7, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(array4[0]);
			}
			if (array3[1])
			{
				obj8 = RuntimeHelpers.GetObjectValue(array4[1]);
			}
			checked
			{
				if (num <= num2)
				{
					SetCurrentRow(num2 + 1);
				}
				else
				{
					SetCurrentRow(num2 + 2);
				}
			}
		}
	}

	public void dgBody_DragOver(object sender, DragEventArgs e)
	{
		e.set_Effect((DragDropEffects)2);
	}

	public void dgBody_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 93 && ((BaseCollection)dgBody.get_SelectedRows()).get_Count() > 0)
		{
			Rectangle cellDisplayRectangle = dgBody.GetCellDisplayRectangle(2, ((DataGridViewBand)dgBody.get_SelectedRows().get_Item(0)).get_Index(), true);
			Point point = checked(new Point((int)Math.Round((double)cellDisplayRectangle.Left + (double)cellDisplayRectangle.Width / 2.0), (int)Math.Round((double)cellDisplayRectangle.Top + (double)cellDisplayRectangle.Height / 2.0)));
			point = ((Control)dgBody).PointToScreen(point);
			object obj = NewLateBinding.LateGet(_form, (Type)null, "BodyContextMenuStrip", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { point };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "Show", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				point = (Point)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Point));
			}
			e.set_Handled(true);
		}
		else if (e.get_Control() && (int)e.get_KeyCode() == 68)
		{
			e.set_Handled(true);
		}
	}

	private void InitDataTableGeneral(object md)
	{
		DataRow row = _dtGeneral.NewRow();
		_dtGeneral.Rows.Add(row);
		row = _dtGeneral.NewRow();
		row["content"] = string.Format("/* Token: 0x{0:x08} */", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(md, (Type)null, "MetadataToken", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToUInt32", new object[0], (string[])null, (Type[])null, (bool[])null)));
		_dtGeneral.Rows.Add(row);
		row = _dtGeneral.NewRow();
		row["content"] = string.Format("/* RVA: 0x{0:x} */", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(md, (Type)null, "RVA", new object[0], (string[])null, (Type[])null, (bool[])null)));
		_dtGeneral.Rows.Add(row);
		row = _dtGeneral.NewRow();
		_dtGeneral.Rows.Add(row);
		if (Conversions.ToBoolean(NewLateBinding.LateGet(md, (Type)null, "HasOverrides", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(md, (Type)null, "Overrides", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				TypedReference typedReference = default(TypedReference);
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					if (current != null)
					{
						_ = (TypedReference)current;
					}
					else
						_ = typedReference;
					row = _dtGeneral.NewRow();
					row["content"] = string.Format(".override {0}", "".ToString());
					_dtGeneral.Rows.Add(row);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		if (Conversions.ToBoolean(NewLateBinding.LateGet(md, (Type)null, "HasBody", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			row = _dtGeneral.NewRow();
			row["content"] = string.Format(".maxstack {0}", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(md, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaxStackSize", new object[0], (string[])null, (Type[])null, (bool[])null)));
			_dtGeneral.Rows.Add(row);
		}
		row = _dtGeneral.NewRow();
		_dtGeneral.Rows.Add(row);
		((Control)dgGeneral).set_Height(checked(_dtGeneral.Rows.Count * dgGeneral.get_RowTemplate().get_Height()));
	}

	private void InitDataTableVariable(object md)
	{
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(md, (Type)null, "HasBody", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(md, (Type)null, "Body", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Variables", new object[0], (string[])null, (Type[])null, (bool[])null));
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(objectValue, (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			DataRow dataRow = _dtVariable.NewRow();
			dataRow["index"] = i;
			object[] array = new object[1] { i };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(objectValue, (Type)null, "Item", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			dataRow["name"] = obj.ToString();
			object[] array4 = new object[1] { i };
			object[] array5 = array4;
			array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(objectValue, (Type)null, "Item", array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
			}
			dataRow["type"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "VariableType", new object[0], (string[])null, (Type[])null, (bool[])null));
			array4 = new object[1] { i };
			object[] array6 = array4;
			array3 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet(objectValue, (Type)null, "Item", array6, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
			}
			dataRow["ispinned"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "IsPinned", new object[0], (string[])null, (Type[])null, (bool[])null));
			_dtVariable.Rows.Add(dataRow);
		}
	}

	private void InitHighlightContextMenu(ToolStripMenuItem highlight)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		if (highlight != null && ((ArrangedElementCollection)((ToolStripDropDownItem)highlight).get_DropDownItems()).get_Count() != 2)
		{
			((ToolStripDropDownItem)highlight).get_DropDownItems().Clear();
			ToolStripMenuItem val = new ToolStripMenuItem();
			((ToolStripItem)val).set_Name("cmHighlightOpCode");
			((ToolStripItem)val).set_Text("OpCode");
			((ToolStripItem)val).add_Click((EventHandler)cmRemove_Click);
			((ToolStripDropDownItem)highlight).get_DropDownItems().Add((ToolStripItem)(object)val);
			val = new ToolStripMenuItem();
			((ToolStripItem)val).set_Name("cmHighlightReference");
			((ToolStripItem)val).set_Text("Reference");
			((ToolStripItem)val).add_Click((EventHandler)cmNop_Click);
			((ToolStripDropDownItem)highlight).get_DropDownItems().Add((ToolStripItem)(object)val);
		}
	}

	private void MarkBlocks()
	{
		Color backColor = ((!_markBlocks) ? dgBody.get_DefaultCellStyle().get_BackColor() : Color.PaleGoldenrod);
		object obj = default(object);
		if (!Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(obj, (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			return;
		}
		bool flag = false;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)obj).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					if (flag)
					{
						for (int i = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "StartIndex", new object[0], (string[])null, (Type[])null, (bool[])null)); Operators.ConditionalCompareObjectLessEqual((object)i, NewLateBinding.LateGet(objectValue, (Type)null, "EndIndex", new object[0], (string[])null, (Type[])null, (bool[])null), false); i++)
						{
							dgBody.get_Rows().get_Item(i + 1).get_DefaultCellStyle()
								.set_BackColor(backColor);
						}
					}
					flag = !flag;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
	}

	public void SetCurrentRow(int rowIndex)
	{
		if (dgBody.get_Rows().get_Count() > rowIndex)
		{
			dgBody.set_CurrentCell(dgBody.get_Rows().get_Item(rowIndex).get_Cells()
				.get_Item(0));
			dgBody.set_FirstDisplayedScrollingRowIndex((rowIndex > 10) ? checked(rowIndex - 10) : 0);
		}
	}

	public void SetCurrentVariable(int varIndex)
	{
		if (dgVariable.get_Rows().get_Count() > varIndex)
		{
			dgVariable.set_CurrentCell(dgVariable.get_Rows().get_Item(varIndex).get_Cells()
				.get_Item(0));
			dgVariable.set_FirstDisplayedScrollingRowIndex((varIndex > 10) ? checked(varIndex - 10) : 0);
		}
	}
}
