using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal static class OptionUsage
{
	private static class OptionHelpGenerator
	{
		private const int IntentLength = 36;

		private const string optionHelpPattern = "{0,33} - {1}{2}";

		private const string optionOnlyPattern = "{0,33}   ";

		private static ToolStringBuilder builder;

		static OptionHelpGenerator()
		{
			builder = new ToolStringBuilder(36);
		}

		internal static void WriteNetworkUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("network", string.Empty, SR.GetString("ConsoleUsageLineNetworkUse"), SR.GetString("ConsoleUsageLineNetworkHelp")));
		}

		internal static void WritePortUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("port", string.Empty, SR.GetString("ConsoleUsageLinePortUse"), SR.GetString("ConsoleUsageLinePortHelp")));
		}

		internal static void WriteEndpointCertsUsage()
		{
			List<string> list = new List<string>();
			list.Add(SR.GetString("ConsoleUsageLineEndpointCertsUse1"));
			list.Add(SR.GetString("ConsoleUsageLineEndpointCertsUse2"));
			WriteMultiUsesUsage("endpointCert", list, SR.GetString("ConsoleUsageLineEndpointCertsHelp"));
		}

		internal static void WriteAccountsCertsUsage()
		{
			List<string> list = new List<string>();
			list.Add(SR.GetString("ConsoleUsageLineAccountsCertsUse1"));
			list.Add(SR.GetString("ConsoleUsageLineAccountsCertsUse2"));
			WriteMultiUsesUsage("accountsCerts", list, SR.GetString("ConsoleUsageLineAccountsCertsHelp"));
		}

		internal static void WriteClusterVirtualServerUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("virtualServer", string.Empty, SR.GetString("ConsoleUsageLineClusterVirtualServerUse"), SR.GetString("ConsoleUsageLineClusterVirtualServerHelp")));
		}

		internal static void WriteTraceLevelUsage()
		{
			List<string> list = new List<string>();
			list.Add(SR.GetString("ConsoleUsageLineTraceLevelUse1"));
			list.Add(SR.GetString("ConsoleUsageLineTraceLevelUse2"));
			list.Add(SR.GetString("ConsoleUsageLineTraceLevelUse3"));
			WriteMultiUsesUsage("traceLevel", list, SR.GetString("ConsoleUsageLineTraceLevelHelp"));
		}

		internal static void WriteAccountsUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("accounts", string.Empty, SR.GetString("ConsoleUsageLineAccountsUse"), SR.GetString("ConsoleUsageLineAccountsHelp")));
		}

		internal static void WriteTimeoutUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("timeout", string.Empty, SR.GetString("ConsoleUsageLineTimeoutUse"), SR.GetString("ConsoleUsageLineTimeoutHelp")));
		}

		internal static void WriteMaxTimeoutUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("maxTimeout", string.Empty, SR.GetString("ConsoleUsageLineMaxTimeoutUse"), SR.GetString("ConsoleUsageLineMaxTimeoutHelp")));
		}

		internal static void WriteTraceActivityUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("traceActivity", string.Empty, SR.GetString("ConsoleUsageLineTraceActivityUse"), SR.GetString("ConsoleUsageLineTraceActivityHelp")));
		}

		internal static void WriteTracePropUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("traceProp", string.Empty, SR.GetString("ConsoleUsageLineTracePropUse"), SR.GetString("ConsoleUsageLineTracePropHelp")));
		}

		internal static void WriteTracePiiUsage()
		{
			builder.WriteParagraph(GenerateParameterHelp("tracePII", string.Empty, SR.GetString("ConsoleUsageLineTracePIIUse"), SR.GetString("ConsoleUsageLineTracePIIHelp")));
		}

		internal static void WriteShowUsage()
		{
			builder.WriteParagraph(GenerateFlagHelp("show", string.Empty, SR.GetString("ConsoleUsageLineShowHelp")));
		}

		internal static void WriteRestartUsage()
		{
			builder.WriteParagraph(GenerateFlagHelp("restart", string.Empty, SR.GetString("ConsoleUsageLineRestartHelp")));
		}

		private static string GetShortForm(string optionAbbr)
		{
			return string.Empty;
		}

		private static string GenerateParameterHelp(string option, string optionAbbr, string optionUse, string helpText)
		{
			string optionString = string.Format(CultureInfo.InvariantCulture, "-{0}:{1}", new object[2] { option, optionUse });
			return GenerateOptionHelp(optionString, optionAbbr, helpText);
		}

		private static string GenerateFlagHelp(string option, string optionAbbr, string helpText)
		{
			string optionString = string.Format(CultureInfo.InvariantCulture, "-{0}", new object[1] { option });
			return GenerateOptionHelp(optionString, optionAbbr, helpText);
		}

		private static string GenerateOptionHelp(string optionString, string optionAbbr, string helpText)
		{
			string shortForm = GetShortForm(optionAbbr);
			return string.Format(CultureInfo.InvariantCulture, "{0,33} - {1}{2}", new object[3] { optionString, helpText, shortForm });
		}

		private static void WriteMultiUsesUsage(string option, List<string> optionUses, string helpText)
		{
			string text = GenerateParameterHelp(option, string.Empty, optionUses[0], helpText);
			builder.WriteSingleLine(ref text);
			for (int i = 1; i < optionUses.Count; i++)
			{
				Console.Write(string.Format(CultureInfo.InvariantCulture, "{0,33}   ", new object[1] { optionUses[i] }));
				if (string.IsNullOrEmpty(text))
				{
					Console.WriteLine();
				}
				else if (i == optionUses.Count - 1)
				{
					builder.WriteParagraph(text);
				}
				else
				{
					builder.WriteSingleLine(ref text);
				}
			}
		}
	}

	private class ToolStringBuilder
	{
		private int indentLength;

		private int cursorLeft;

		private int lineWidth;

		private StringBuilder stringBuilder;

		private int BufferWidth => lineWidth - cursorLeft;

		private int HangingLineWidth => lineWidth - indentLength;

		public ToolStringBuilder(int indentLength)
		{
			this.indentLength = indentLength;
		}

		private void Reset()
		{
			stringBuilder = new StringBuilder();
			cursorLeft = GetConsoleCursorLeft();
			lineWidth = GetBufferWidth();
		}

		public void WriteParagraph(string text)
		{
			Reset();
			AppendParagraph(text);
			WriteLine(stringBuilder.ToString());
			stringBuilder = null;
		}

		public void WriteSingleLine(ref string text)
		{
			Reset();
			AppendLineText(ref text);
			WriteLine(stringBuilder.ToString());
			stringBuilder = null;
		}

		private void WriteLine(string lineText)
		{
			if (cursorLeft == lineWidth)
			{
				Console.Write(lineText);
			}
			else
			{
				Console.WriteLine(lineText);
			}
		}

		private void AppendParagraph(string text)
		{
			if (indentLength >= lineWidth)
			{
				stringBuilder.AppendLine(text);
				return;
			}
			int index = 0;
			while (index < text.Length)
			{
				AppendWord(text, ref index);
				AppendWhitespace(text, ref index);
			}
		}

		private void AppendLineText(ref string text)
		{
			if (indentLength >= lineWidth)
			{
				stringBuilder.AppendLine(text);
				text = string.Empty;
				return;
			}
			int index = 0;
			while (index < text.Length)
			{
				int num = index;
				AppendWord(text, ref index, onlyWithinCurrentLine: true);
				AppendWhitespace(text, ref index);
				if (num == index)
				{
					break;
				}
			}
			text = text.Substring(index);
		}

		private void AppendWord(string text, ref int index)
		{
			AppendWord(text, ref index, onlyWithinCurrentLine: false);
		}

		private void AppendWord(string text, ref int index, bool onlyWithinCurrentLine)
		{
			if (cursorLeft == 0 && index != 0)
			{
				AppendIndent();
			}
			int wordLength = FindWordLength(text, index);
			if (wordLength < HangingLineWidth)
			{
				if (wordLength > BufferWidth)
				{
					if (onlyWithinCurrentLine)
					{
						return;
					}
					AppendLineBreak();
					AppendIndent();
				}
				stringBuilder.Append(text, index, wordLength);
				cursorLeft += wordLength;
			}
			else
			{
				AppendWithOverflow(text, ref index, ref wordLength);
			}
			index += wordLength;
		}

		private void AppendWithOverflow(string test, ref int start, ref int wordLength)
		{
			do
			{
				stringBuilder.Append(test, start, BufferWidth);
				start += BufferWidth;
				wordLength -= BufferWidth;
				AppendLineBreak();
				if (wordLength > 0)
				{
					AppendIndent();
				}
			}
			while (wordLength > BufferWidth);
			if (wordLength > 0)
			{
				stringBuilder.Append(test, start, wordLength);
				cursorLeft += wordLength;
			}
		}

		private void AppendWhitespace(string text, ref int index)
		{
			while (index < text.Length && char.IsWhiteSpace(text[index]))
			{
				if (BufferWidth == 0)
				{
					AppendLineBreak();
				}
				if (AtNewLine(text, index))
				{
					AppendLineBreak();
					index += Environment.NewLine.Length;
				}
				else if (cursorLeft == 0 && index != 0)
				{
					AppendIndent();
					index++;
				}
				else
				{
					stringBuilder.Append(text[index]);
					index++;
					cursorLeft++;
				}
			}
		}

		private void AppendIndent()
		{
			stringBuilder.Append(' ', indentLength);
			cursorLeft += indentLength;
		}

		private void AppendLineBreak()
		{
			if (BufferWidth != 0)
			{
				stringBuilder.AppendLine();
			}
			cursorLeft = 0;
		}

		private static int FindWordLength(string text, int index)
		{
			int num = index;
			while (true)
			{
				if (num < text.Length)
				{
					if (char.IsWhiteSpace(text[num]))
					{
						break;
					}
					num++;
					continue;
				}
				return text.Length - index;
			}
			return num - index;
		}

		private static bool AtNewLine(string text, int index)
		{
			if (index + Environment.NewLine.Length > text.Length)
			{
				return false;
			}
			int num = 0;
			while (true)
			{
				if (num < Environment.NewLine.Length)
				{
					if (Environment.NewLine[num] != text[index + num])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}

		private static int GetConsoleCursorLeft()
		{
			try
			{
				return Console.CursorLeft;
			}
			catch
			{
				return 0;
			}
		}

		private static int GetBufferWidth()
		{
			try
			{
				_ = Console.CursorVisible;
				return Console.BufferWidth;
			}
			catch
			{
				return int.MaxValue;
			}
		}
	}

	public static void Print()
	{
		Console.WriteLine();
		Console.WriteLine(SR.GetString("ConsoleUsageLine01"));
		Console.WriteLine(SR.GetString("ConsoleUsageLine02"));
		Console.WriteLine(SR.GetString("ConsoleUsageLineOptions"));
		OptionHelpGenerator.WriteNetworkUsage();
		Console.WriteLine();
		OptionHelpGenerator.WritePortUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteEndpointCertsUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteAccountsUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteAccountsCertsUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteClusterVirtualServerUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteTimeoutUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteMaxTimeoutUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteTraceLevelUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteTraceActivityUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteTracePropUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteTracePiiUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteShowUsage();
		Console.WriteLine();
		OptionHelpGenerator.WriteRestartUsage();
	}
}
