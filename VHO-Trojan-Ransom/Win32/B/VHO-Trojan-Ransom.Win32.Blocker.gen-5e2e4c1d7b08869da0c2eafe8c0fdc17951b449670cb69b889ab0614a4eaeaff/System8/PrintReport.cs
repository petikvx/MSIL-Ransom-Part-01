using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Base8;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace System8;

public class PrintReport
{
	private const string string_0 = "Preview Report";

	private string string_1;

	private string string_2;

	private string string_3;

	public string Title
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	public string WorkSetCode
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public PrintReport()
	{
		string_1 = "";
		string_2 = "System8";
		string_3 = "Preview Report";
	}

	public bool PrintFormPages(string reportCode, DataSet inputDataSet = null, string checkColumnName = "", bool preview = true, int copies = 1, string title = "Preview Report")
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		string reportFileName = GetReportFileName(reportCode);
		if (Operators.CompareString(reportFileName, "", false) == 0)
		{
			return false;
		}
		if (Shared.IsEmpty(inputDataSet))
		{
			return false;
		}
		OpenParameters val = new OpenParameters();
		val.Add("@wset_cd", string_1, (QueryParameterType)1, (QueryParameterKind)1);
		DataSet dataSet = Link.ReadDataSet("workset_g11", val);
		object obj = null;
		object obj2 = null;
		int num = 0;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = inputDataSet.Tables[0].Rows.GetEnumerator();
				IEnumerator enumerator2 = default(IEnumerator);
				bool result = default(bool);
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if ((Operators.CompareString(checkColumnName, "", false) != 0 && (Operators.CompareString(checkColumnName, "", false) == 0 || Operators.CompareString(Shared.ToStr(RuntimeHelpers.GetObjectValue(dataRow[checkColumnName])), "1", false) != 0)) || 1 == 0)
					{
						continue;
					}
					val.Clear();
					try
					{
						enumerator2 = dataSet.Tables[0].Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							string text = Conversions.ToString(dataRow2["in_param"]);
							string columnName = text.Replace("@", "");
							string text2 = Shared.ToStr(RuntimeHelpers.GetObjectValue(dataRow[columnName]));
							val.Add(text, text2, (QueryParameterType)1, (QueryParameterKind)1);
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					DataSet dataSet_ = Link.ReadDataSet(string_1, val);
					obj2 = RuntimeHelpers.GetObjectValue(method_0(reportFileName, dataSet_));
					if (obj2 != null)
					{
						num = checked(num + 1);
						if (num == 1)
						{
							obj = RuntimeHelpers.GetObjectValue(obj2);
							continue;
						}
						object obj3 = NewLateBinding.LateGet(obj, (Type)null, "Pages", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array = new object[1];
						object obj4 = obj2;
						array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "Pages", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array2 = array;
						bool[] array3 = new bool[1] { true };
						NewLateBinding.LateCall(obj3, (Type)null, "AddRange", array2, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							NewLateBinding.LateSetComplex(obj4, (Type)null, "Pages", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
						}
						continue;
					}
					return result;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (obj == null)
			{
				return false;
			}
			if (preview)
			{
				frmPrintReport frmPrintReport2 = new frmPrintReport();
				frmPrintReport2.PrintControl1.set_PrintingSystem((PrintingSystemBase)NewLateBinding.LateGet(obj, (Type)null, "PrintingSystem", new object[0], (string[])null, (Type[])null, (bool[])null));
				((Form)frmPrintReport2).set_Text(string_3);
				((Form)frmPrintReport2).ShowDialog();
			}
			else
			{
				PrintTool val2 = new PrintTool((PrintingSystemBase)NewLateBinding.LateGet(obj, (Type)null, "PrintingSystem", new object[0], (string[])null, (Type[])null, (bool[])null));
				val2.Print();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Shared.MessageInfo(ex2.Message, (string)null, (string)null);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	public void AddParameter(string parameter, string value)
	{
	}

	public bool PrintReportFileName(string reportFileName, DataSet dSet, bool preview = true, int copies = 1, string title = "", object printControl = null)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		if (Operators.CompareString(title, "", false) != 0)
		{
			string_3 = title;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(method_0(reportFileName, dSet));
		if (objectValue == null)
		{
			return false;
		}
		try
		{
			if (printControl == null)
			{
				frmPrintReport frmPrintReport2 = new frmPrintReport();
				frmPrintReport2.PrintControl1.set_PrintingSystem((PrintingSystemBase)NewLateBinding.LateGet(objectValue, (Type)null, "PrintingSystem", new object[0], (string[])null, (Type[])null, (bool[])null));
				((Form)frmPrintReport2).set_Text(string_3);
				((Form)frmPrintReport2).ShowDialog();
			}
			else
			{
				if (!(printControl is PrintControl))
				{
					Shared.MessageInfo("출력할 Control 이 DevExpress PrintControl 이 아닙니다", (string)null, (string)null);
					return false;
				}
				((PrintControl)printControl).set_PrintingSystem((PrintingSystemBase)NewLateBinding.LateGet(objectValue, (Type)null, "PrintingSystem", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Shared.MessageInfo(ex2.Message, (string)null, (string)null);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	private object method_0(string string_4, DataSet dataSet_0)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(method_1(string_4, string_2));
		if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
		{
			Shared.MessageInfo(string_4 + ".dll Instance 를 생성할 수 없습니다.", (string)null, (string)null);
			return null;
		}
		int num = 0;
		try
		{
			object[] array = new object[1] { dataSet_0 };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			NewLateBinding.LateCall(objectValue, (Type)null, "SetDateSet", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				dataSet_0 = (DataSet)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(DataSet));
			}
			num = 1;
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Pages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				NewLateBinding.LateCall(objectValue, (Type)null, "CreateDocument", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			num = 2;
			NewLateBinding.LateSet(objectValue, (Type)null, "ShowPrintMarginsWarning", new object[1] { false }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "ShowPreviewMarginLines", new object[1] { false }, (string[])null, (Type[])null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (num == 0)
			{
				Shared.MessageInfo(ex2.Message + "\n\n" + string_4 + ".SetDateSet(DataSet)", (string)null, (string)null);
			}
			if (num == 1)
			{
				Shared.MessageInfo(ex2.Message + "\n\n" + string_4 + ".CreateDocument()", (string)null, (string)null);
			}
			if (num == 2)
			{
				Shared.MessageInfo(ex2.Message, (string)null, (string)null);
			}
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
		return objectValue;
	}

	private object method_1(string string_4, string string_5 = "System8")
	{
		return Main.LoadAssembly(string_4, "");
	}

	public string GetReportFileName(string reportCode, bool notExistsMessage = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		try
		{
			OpenParameters val = new OpenParameters();
			val.Add("@rpt_cd", reportCode, (QueryParameterType)1, (QueryParameterKind)1);
			DataSet dataSet = Link.ReadDataSetExists("system_print_file_name", val);
			if (!Shared.IsEmpty(dataSet))
			{
				text = Shared.DataValue(dataSet, "file_nm", 0, false);
				string_3 = Shared.DataValue(dataSet, "rpt_nm", 0, false);
				string_1 = Shared.DataValue(dataSet, "wset_cd", 0, false);
				string_2 = Shared.DataValue(dataSet, "name_space", 0, false);
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				if (notExistsMessage)
				{
					Shared.MessageInfo("Report 정보가 등록되어 있지 않습니다.", (string)null, (string)null);
				}
				return "";
			}
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Shared.MessageError(ex2, (string)null, "Main.Report.GetReportFile()");
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
