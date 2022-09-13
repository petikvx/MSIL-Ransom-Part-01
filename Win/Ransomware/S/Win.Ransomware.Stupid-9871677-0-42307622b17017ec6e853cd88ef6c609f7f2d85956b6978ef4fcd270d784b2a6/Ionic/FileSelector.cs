using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
		public static readonly string PrecededByOddNumberOfSingleQuotes;

		public static readonly string FollowedByOddNumberOfSingleQuotesAndLineEnd;

		public static readonly string PrecededByEvenNumberOfSingleQuotes;

		public static readonly string FollowedByEvenNumberOfSingleQuotesAndLineEnd;
	}

	internal SelectionCriterion _Criterion;

	public extern string SelectionCriteria { get; set; }

	public extern bool TraverseReparsePoints
	{
		[CompilerGenerated]
		get;
		set; }

	public FileSelector(string selectionCriteria)
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_0020
		//IL_0008: Invalid comparison between Unknown and Ref
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected native int or pointer, but got F4
		/*Error: Invalid metadata token*/;
	}

	public extern FileSelector(string selectionCriteria, bool traverseDirectoryReparsePoints);

	private static extern string NormalizeCriteriaExpression(string source);

	private static SelectionCriterion _ParseCriterion(string s)
	{
		//Discarded unreachable code: IL_000f, IL_0015, IL_0016, IL_0020, IL_0026, IL_002f, IL_0035
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Incompatible stack heights: 0 vs 1
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = /*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
		}
		while (/*Error near IL_0003: Stack underflow*/ * val == 0);
		/*Error near IL_000a: Invalid metadata token*/;
	}

	public override extern string ToString();

	private extern bool Evaluate(string filename);

	[Conditional("SelectorTrace")]
	private void SelectorTrace(string format, params object[] args)
	{
		//Discarded unreachable code: IL_000f
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		_ = /*Error near IL_0003: Stack underflow*/| /*Error near IL_0003: Stack underflow*/;
		_ = (nuint)0u;
		_ = 5;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	public extern ICollection<string> SelectFiles(string directory);

	public ReadOnlyCollection<string> SelectFiles(string directory, bool recurseDirectories)
	{
		//Discarded unreachable code: IL_0007, IL_0011
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected I4, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
		_003F val2 = /*Error near IL_0004: Stack underflow*/* val;
		((sbyte[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (sbyte)(int)val2;
		/*Error near IL_0006: Unknown opcode: 0xFA*/;
	}

	private extern bool Evaluate(ZipEntry entry);

	public extern ICollection<ZipEntry> SelectEntries(ZipFile zip);

	public ICollection<ZipEntry> SelectEntries(ZipFile zip, string directoryPathInArchive)
	{
		//Discarded unreachable code: IL_0015, IL_001d
		//IL_000b: Expected O, but got I8
		//IL_000e: Expected O, but got I
		//IL_0020: Expected F4, but got I
		IntPtr intPtr = (nint)((Array)(-6429269333295885699L)).LongLength;
		((object[])/*Error near IL_000e: Stack underflow*/)[5] = (nint)intPtr;
		/*Error near IL_000f: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0010: Invalid metadata token*/;
	}
}
