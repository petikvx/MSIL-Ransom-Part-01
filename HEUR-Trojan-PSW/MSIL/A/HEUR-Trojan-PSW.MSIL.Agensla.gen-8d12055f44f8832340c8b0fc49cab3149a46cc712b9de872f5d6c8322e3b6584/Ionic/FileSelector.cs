using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic;

public class FileSelector
{
	private enum ParseState
	{
		Start,
		OpenParen,
		CriterionDone,
		ConjunctionPending,
		Whitespace
	}

	private static class RegexAssertions
	{
		public static readonly string PrecededByOddNumberOfSingleQuotes = "(?<=(?:[^']*'[^']*')*'[^']*)";

		public static readonly string FollowedByOddNumberOfSingleQuotesAndLineEnd = "(?=[^']*'(?:[^']*'[^']*')*[^']*$)";

		public static readonly string PrecededByEvenNumberOfSingleQuotes = "(?<=(?:[^']*'[^']*')*[^']*)";

		public static readonly string FollowedByEvenNumberOfSingleQuotesAndLineEnd = "(?=(?:[^']*'[^']*')*[^']*$)";
	}

	internal SelectionCriterion _Criterion;

	public bool TraverseReparsePoints { get; set; }

	public FileSelector(string selectionCriteria, bool traverseDirectoryReparsePoints)
	{
		if (!string.IsNullOrEmpty(selectionCriteria))
		{
			_Criterion = _ParseCriterion(selectionCriteria);
		}
		TraverseReparsePoints = traverseDirectoryReparsePoints;
	}

	private static string NormalizeCriteriaExpression(string source)
	{
		string[][] array = new string[11][]
		{
			new string[2] { "([^']*)\\(\\(([^']+)", "$1( ($2" },
			new string[2] { "(.)\\)\\)", "$1) )" },
			new string[2] { "\\(([^'\\f\\n\\r\\t\\v\\x85\\p{Z}])", "( $1" },
			new string[2] { "(\\S)\\)", "$1 )" },
			new string[2] { "^\\)", " )" },
			new string[2] { "(\\S)\\(", "$1 (" },
			new string[2] { "\\)([^'\\f\\n\\r\\t\\v\\x85\\p{Z}])", ") $1" },
			new string[2] { "(=)('[^']*')", "$1 $2" },
			new string[2] { "([^ !><])(>|<|!=|=)", "$1 $2" },
			new string[2] { "(>|<|!=|=)([^ =])", "$1 $2" },
			new string[2] { "/", "\\" }
		};
		string input = source;
		for (int i = 0; i < array.Length; i++)
		{
			string pattern = RegexAssertions.PrecededByEvenNumberOfSingleQuotes + array[i][0] + RegexAssertions.FollowedByEvenNumberOfSingleQuotesAndLineEnd;
			input = Regex.Replace(input, pattern, array[i][1]);
		}
		string pattern2 = "/" + RegexAssertions.FollowedByOddNumberOfSingleQuotesAndLineEnd;
		input = Regex.Replace(input, pattern2, "\\");
		pattern2 = " " + RegexAssertions.FollowedByOddNumberOfSingleQuotesAndLineEnd;
		return Regex.Replace(input, pattern2, "\u0006");
	}

	private static SelectionCriterion _ParseCriterion(string s)
	{
		if (s == null)
		{
			return null;
		}
		s = NormalizeCriteriaExpression(s);
		if (s.IndexOf(" ") == -1)
		{
			s = "name = " + s;
		}
		string[] array = s.Trim().Split(' ', '\t');
		if (array.Length < 3)
		{
			throw new ArgumentException(s);
		}
		SelectionCriterion selectionCriterion = null;
		LogicalConjunction logicalConjunction = LogicalConjunction.NONE;
		Stack<ParseState> stack = new Stack<ParseState>();
		Stack<SelectionCriterion> stack2 = new Stack<SelectionCriterion>();
		stack.Push(ParseState.Start);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].ToLower();
			ParseState parseState;
			switch (text)
			{
			case ")":
				parseState = stack.Pop();
				if (stack.Peek() == ParseState.OpenParen)
				{
					stack.Pop();
					stack.Push(ParseState.CriterionDone);
					goto IL_0779;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "(":
				parseState = stack.Peek();
				if (parseState == ParseState.Start || parseState == ParseState.ConjunctionPending || parseState == ParseState.OpenParen)
				{
					if (array.Length > i + 4)
					{
						stack.Push(ParseState.OpenParen);
						goto IL_0779;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "size":
			case "length":
				if (array.Length > i + 2)
				{
					long num = 0L;
					string text3 = array[i + 2];
					num = (text3.ToUpper().EndsWith("K") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L) : (text3.ToUpper().EndsWith("KB") ? (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L) : (text3.ToUpper().EndsWith("M") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L * 1024L) : (text3.ToUpper().EndsWith("MB") ? (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L * 1024L) : (text3.ToUpper().EndsWith("G") ? (long.Parse(text3.Substring(0, text3.Length - 1)) * 1024L * 1024L * 1024L) : ((!text3.ToUpper().EndsWith("GB")) ? long.Parse(array[i + 2]) : (long.Parse(text3.Substring(0, text3.Length - 2)) * 1024L * 1024L * 1024L)))))));
					selectionCriterion = new SizeCriterion
					{
						Size = num,
						Operator = (ComparisonOperator)EnumUtil.Parse(typeof(ComparisonOperator), array[i + 1])
					};
					i += 2;
					stack.Push(ParseState.CriterionDone);
					goto IL_0779;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "":
				stack.Push(ParseState.Whitespace);
				goto IL_0779;
			case "filename":
			case "name":
				if (array.Length > i + 2)
				{
					ComparisonOperator comparisonOperator2 = (ComparisonOperator)EnumUtil.Parse(typeof(ComparisonOperator), array[i + 1]);
					if (comparisonOperator2 == ComparisonOperator.NotEqualTo || comparisonOperator2 == ComparisonOperator.EqualTo)
					{
						string text2 = array[i + 2];
						if (text2.StartsWith("'") && text2.EndsWith("'"))
						{
							text2 = text2.Substring(1, text2.Length - 2).Replace("\u0006", " ");
						}
						if (Path.DirectorySeparatorChar == '/')
						{
							text2 = text2.Replace('\\', Path.DirectorySeparatorChar);
						}
						selectionCriterion = new NameCriterion
						{
							MatchingFileSpec = text2,
							Operator = comparisonOperator2
						};
						i += 2;
						stack.Push(ParseState.CriterionDone);
						goto IL_0779;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "and":
			case "or":
			case "xor":
				parseState = stack.Peek();
				if (parseState == ParseState.CriterionDone)
				{
					if (array.Length > i + 3)
					{
						logicalConjunction = (LogicalConjunction)Enum.Parse(typeof(LogicalConjunction), array[i].ToUpper(), ignoreCase: true);
						selectionCriterion = new CompoundCriterion
						{
							Left = selectionCriterion,
							Right = null,
							Conjunction = logicalConjunction
						};
						stack.Push(parseState);
						stack.Push(ParseState.ConjunctionPending);
						stack2.Push(selectionCriterion);
						goto IL_0779;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "ctime":
			case "atime":
			case "mtime":
				if (array.Length > i + 2)
				{
					DateTime value;
					try
					{
						value = DateTime.ParseExact(array[i + 2], "yyyy-MM-dd-HH:mm:ss", null);
					}
					catch (FormatException)
					{
						try
						{
							value = DateTime.ParseExact(array[i + 2], "yyyy/MM/dd-HH:mm:ss", null);
						}
						catch (FormatException)
						{
							try
							{
								value = DateTime.ParseExact(array[i + 2], "yyyy/MM/dd", null);
								goto end_IL_066b;
							}
							catch (FormatException)
							{
								try
								{
									value = DateTime.ParseExact(array[i + 2], "MM/dd/yyyy", null);
									goto end_IL_066b;
								}
								catch (FormatException)
								{
									value = DateTime.ParseExact(array[i + 2], "yyyy-MM-dd", null);
									goto end_IL_066b;
								}
							}
							end_IL_066b:;
						}
					}
					value = DateTime.SpecifyKind(value, DateTimeKind.Local).ToUniversalTime();
					selectionCriterion = new TimeCriterion
					{
						Which = (WhichTime)Enum.Parse(typeof(WhichTime), array[i], ignoreCase: true),
						Operator = (ComparisonOperator)EnumUtil.Parse(typeof(ComparisonOperator), array[i + 1]),
						Time = value
					};
					i += 2;
					stack.Push(ParseState.CriterionDone);
					goto IL_0779;
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			case "type":
			case "attrs":
			case "attributes":
				if (array.Length > i + 2)
				{
					ComparisonOperator comparisonOperator = (ComparisonOperator)EnumUtil.Parse(typeof(ComparisonOperator), array[i + 1]);
					if (comparisonOperator == ComparisonOperator.NotEqualTo || comparisonOperator == ComparisonOperator.EqualTo)
					{
						selectionCriterion = ((text == "type") ? ((SelectionCriterion)new TypeCriterion
						{
							AttributeString = array[i + 2],
							Operator = comparisonOperator
						}) : ((SelectionCriterion)new AttributesCriterion
						{
							AttributeString = array[i + 2],
							Operator = comparisonOperator
						}));
						i += 2;
						stack.Push(ParseState.CriterionDone);
						goto IL_0779;
					}
					throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
			default:
				{
					throw new ArgumentException("'" + array[i] + "'");
				}
				IL_0779:
				parseState = stack.Peek();
				if (parseState == ParseState.CriterionDone)
				{
					stack.Pop();
					if (stack.Peek() == ParseState.ConjunctionPending)
					{
						while (stack.Peek() == ParseState.ConjunctionPending)
						{
							CompoundCriterion obj = stack2.Pop() as CompoundCriterion;
							obj.Right = selectionCriterion;
							selectionCriterion = obj;
							stack.Pop();
							parseState = stack.Pop();
							if (parseState != ParseState.CriterionDone)
							{
								throw new ArgumentException("??");
							}
						}
					}
					else
					{
						stack.Push(ParseState.CriterionDone);
					}
				}
				if (parseState == ParseState.Whitespace)
				{
					stack.Pop();
				}
				break;
			}
		}
		return selectionCriterion;
	}

	public override string ToString()
	{
		return "FileSelector(" + _Criterion.ToString() + ")";
	}

	private bool Evaluate(string filename)
	{
		return _Criterion.Evaluate(filename);
	}

	[Conditional("SelectorTrace")]
	private void SelectorTrace(string format, params object[] args)
	{
		if (_Criterion != null && _Criterion.Verbose)
		{
			Console.WriteLine(format, args);
		}
	}

	public ReadOnlyCollection<string> SelectFiles(string directory, bool recurseDirectories)
	{
		if (_Criterion == null)
		{
			throw new ArgumentException("SelectionCriteria has not been set");
		}
		List<string> list = new List<string>();
		try
		{
			if (Directory.Exists(directory))
			{
				string[] files = Directory.GetFiles(directory);
				foreach (string text in files)
				{
					if (Evaluate(text))
					{
						list.Add(text);
					}
				}
				if (recurseDirectories)
				{
					files = Directory.GetDirectories(directory);
					foreach (string text2 in files)
					{
						if (TraverseReparsePoints || (File.GetAttributes(text2) & FileAttributes.ReparsePoint) == 0)
						{
							if (Evaluate(text2))
							{
								list.Add(text2);
							}
							list.AddRange(SelectFiles(text2, recurseDirectories));
						}
					}
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (IOException)
		{
		}
		return list.AsReadOnly();
	}

	private bool Evaluate(ZipEntry entry)
	{
		return _Criterion.Evaluate(entry);
	}

	public ICollection<ZipEntry> SelectEntries(ZipFile zip)
	{
		if (zip == null)
		{
			throw new ArgumentNullException("zip");
		}
		List<ZipEntry> list = new List<ZipEntry>();
		foreach (ZipEntry item in zip)
		{
			if (Evaluate(item))
			{
				list.Add(item);
			}
		}
		return list;
	}
}
