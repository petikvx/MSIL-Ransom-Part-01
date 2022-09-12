using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using Mono.Options;
using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NChanges;

public class ExcelCommand
{
	private class FieldInfo
	{
		public string Header { get; set; }

		public Getter Getter { get; set; }
	}

	private delegate string Getter(AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mi);

	private readonly OptionSet _optionSet;

	private string _output = "%name%-%version%-report.xls";

	private string _columns = "assembly,version,change,changeDetails,namespace,typeKind,type,memberKind,member,params,memberType";

	private string[] _splitColumns;

	private string _name;

	private bool _multipleSheets;

	private int _rowIndex = 1;

	private static string _currentName;

	private static readonly Dictionary<string, FieldInfo> _columnMap;

	static ExcelCommand()
	{
		_columnMap = new Dictionary<string, FieldInfo>();
		_columnMap["name"] = new FieldInfo
		{
			Header = "Name",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => _currentName
		};
		_columnMap["assembly"] = new FieldInfo
		{
			Header = "Assembly",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => a.Name
		};
		_columnMap["version"] = new FieldInfo
		{
			Header = "Version",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => (tc == null) ? mc.Version : tc.Version
		};
		_columnMap["change"] = new FieldInfo
		{
			Header = "Change",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => (tc == null) ? mc.Kind.ToString() : tc.Kind.ToString()
		};
		_columnMap["changeDetails"] = new FieldInfo
		{
			Header = "Change Details",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => GetDetails(tc, mc)
		};
		_columnMap["namespace"] = new FieldInfo
		{
			Header = "Namespace",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => t.Namespace
		};
		_columnMap["typeKind"] = new FieldInfo
		{
			Header = "Type Kind",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => t.Kind.ToString()
		};
		_columnMap["type"] = new FieldInfo
		{
			Header = "Type",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => t.Name
		};
		_columnMap["memberKind"] = new FieldInfo
		{
			Header = "Member Kind",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => (m == null) ? "" : m.Kind.ToString()
		};
		_columnMap["member"] = new FieldInfo
		{
			Header = "Member",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => (m == null) ? "" : m.Name
		};
		_columnMap["params"] = new FieldInfo
		{
			Header = "Parameters",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => (m == null) ? "" : string.Join(", ", m.Parameters.Select((ParameterInfo mi) => TypeHelpers.NormalizeTypeName(mi.Type) + " " + mi.Name).ToArray())
		};
		_columnMap["memberType"] = new FieldInfo
		{
			Header = "Return/Property/Event/Field Type",
			Getter = (AssemblyInfo a, TypeInfo t, TypeChangeInfo tc, MemberInfo m, MemberChangeInfo mc) => (m == null) ? "" : TypeHelpers.NormalizeTypeName(m.Type)
		};
	}

	private static string GetDetails(TypeChangeInfo tc, MemberChangeInfo mc)
	{
		if (mc != null)
		{
			string text = "";
			if (!string.IsNullOrEmpty(mc.Old))
			{
				text = mc.Old;
				if (!string.IsNullOrEmpty(mc.New))
				{
					text += " → ";
				}
			}
			if (!string.IsNullOrEmpty(mc.New))
			{
				text += mc.New;
			}
			return text;
		}
		return null;
	}

	public ExcelCommand()
	{
		_optionSet = new OptionSet
		{
			{
				"o|output=",
				"output file",
				delegate(string v)
				{
					_output = v;
				}
			},
			{
				"c|columns=",
				"columns",
				delegate(string v)
				{
					_columns = v;
				}
			},
			{
				"m|multiple-sheets",
				"create a new worksheet for each report",
				(Action<string>)delegate
				{
					_multipleSheets = true;
				}
			},
			{
				"n|name=",
				"library name regex pattern",
				delegate(string v)
				{
					_name = v;
				}
			}
		};
	}

	public void Run(IEnumerable<string> args)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		List<string> paths = _optionSet.Parse(args);
		if (!string.IsNullOrEmpty(_name) && !_multipleSheets)
		{
			_columns = "name," + _columns;
		}
		_splitColumns = _columns.Split(new char[1] { ',' });
		HSSFWorkbook val = new HSSFWorkbook();
		ICellStyle val2 = val.CreateCellStyle();
		IFont val3 = val.CreateFont();
		val3.set_Boldweight((short)700);
		val2.SetFont(val3);
		string text = null;
		ISheet val4 = null;
		foreach (string item in PathHelper.ExpandPaths(paths))
		{
			AssemblyInfo assemblyInfo = LoadReport(item);
			if (text == null)
			{
				text = PathHelper.FormatPath(_output, assemblyInfo);
			}
			if (!assemblyInfo.HasChanges())
			{
				continue;
			}
			_currentName = assemblyInfo.Name;
			if (!string.IsNullOrEmpty(_name))
			{
				Match match = Regex.Match(_currentName, _name);
				if (match.Success)
				{
					_currentName = match.Groups.Cast<Group>().Skip(1).First((Group g) => !string.IsNullOrEmpty(g.Value))
						.Value;
				}
			}
			if (_multipleSheets || val4 == null)
			{
				val4 = val.CreateSheet(_multipleSheets ? _currentName : "Changes");
				AddHeaders(val4, val2);
			}
			AddData(assemblyInfo, val4);
			if (_multipleSheets)
			{
				FinalizeWorkSheet(val4);
			}
		}
		if (!_multipleSheets)
		{
			FinalizeWorkSheet(val4);
		}
		((POIDocument)val).Write((Stream)new FileStream(text, FileMode.Create));
	}

	private void FinalizeWorkSheet(ISheet worksheet)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		if (worksheet != null)
		{
			ISheet obj = worksheet;
			HSSFSheet val = (HSSFSheet)(object)((obj is HSSFSheet) ? obj : null);
			if (val != null)
			{
				val.SetAutoFilter(new CellRangeAddress(0, _rowIndex - 1, 0, _splitColumns.Length - 1));
			}
			ForEachColumn(delegate(int i, FieldInfo f)
			{
				worksheet.AutoSizeColumn(i);
				int num = Math.Min(worksheet.GetColumnWidth(i) + 1024, 65280);
				worksheet.SetColumnWidth(i, num);
			});
		}
	}

	private AssemblyInfo LoadReport(string path)
	{
		AssemblyInfo assemblyInfo = new AssemblyInfo();
		assemblyInfo.ReadXml(new XmlTextReader(path));
		return assemblyInfo;
	}

	private void AddHeaders(ISheet worksheet, ICellStyle headerCellStyle)
	{
		IRow row = worksheet.CreateRow(0);
		ForEachColumn(delegate(int i, FieldInfo f)
		{
			ICell obj = row.CreateCell(i);
			obj.SetCellValue(f.Header);
			obj.set_CellStyle(headerCellStyle);
		});
	}

	private void AddData(AssemblyInfo report, ISheet worksheet)
	{
		List<List<string>> list = new List<List<string>>();
		foreach (TypeInfo typeInfo in report.Types)
		{
			foreach (TypeChangeInfo change2 in typeInfo.Changes)
			{
				List<string> row3 = new List<string>();
				list.Add(row3);
				ForEachColumn(delegate(int i, FieldInfo f)
				{
					row3.Add(f.Getter(report, typeInfo, change2, null, null));
				});
			}
			foreach (MemberInfo memberInfo in typeInfo.Members)
			{
				foreach (MemberChangeInfo change in memberInfo.Changes)
				{
					List<string> row2 = new List<string>();
					list.Add(row2);
					ForEachColumn(delegate(int i, FieldInfo f)
					{
						row2.Add(f.Getter(report, typeInfo, null, memberInfo, change));
					});
				}
			}
		}
		list = list.OrderByDescending((List<string> row) => row[0]).ToList();
		if (_multipleSheets)
		{
			_rowIndex = 1;
		}
		foreach (List<string> item in list)
		{
			IRow val = worksheet.CreateRow(_rowIndex);
			for (int j = 0; j < item.Count; j++)
			{
				val.CreateCell(j).SetCellValue(item[j]);
			}
			_rowIndex++;
		}
	}

	private void ForEachColumn(Action<int, FieldInfo> worker)
	{
		int num = 0;
		string[] splitColumns = _splitColumns;
		foreach (string text in splitColumns)
		{
			worker(num++, _columnMap[text.Trim()]);
		}
	}

	public void ShowHelp()
	{
		_optionSet.WriteOptionDescriptions(Console.Error);
		Console.Error.WriteLine();
		Console.Error.WriteLine("Avaliable Columns: " + string.Join(",", _columnMap.Keys.OrderBy((string c) => c).ToArray()));
		Console.Error.WriteLine("Default Columns: " + _columns);
	}
}
