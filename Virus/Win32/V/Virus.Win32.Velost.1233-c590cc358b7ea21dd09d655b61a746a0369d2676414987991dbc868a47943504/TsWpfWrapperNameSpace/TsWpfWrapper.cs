using System;
using System.IO;
using System.Printing;
using System.Windows.Documents;
using System.Windows.Documents.Serialization;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace TsWpfWrapperNameSpace;

internal class TsWpfWrapper
{
	[STAThread]
	private static void Main(string[] args)
	{
		bool flag = true;
		if (args.Length == 3 && args[2] == "/nodebug")
		{
			flag = false;
		}
		if (args.Length >= 2 && args.Length < 4)
		{
			if (flag)
			{
				Console.WriteLine("Printer       :" + args[0]);
				Console.WriteLine("File          :" + args[1]);
			}
			try
			{
				PrintXPSDocument(args[0], args[1]);
				return;
			}
			finally
			{
				if (!flag)
				{
					File.Delete(args[1]);
				}
			}
		}
		if (flag)
		{
			Console.WriteLine("Usage: TsWpfWrp.exe <PrinterName> <XPSFile> [/nodebug]");
		}
	}

	private static void PrintXPSDocument(string printQueueName, string xpsFileName)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		PrintQueue printQueue = GetPrintQueue(printQueueName);
		XpsDocumentWriter val = PrintQueue.CreateXpsDocumentWriter(printQueue);
		XpsDocument val2 = new XpsDocument(xpsFileName, FileAccess.Read);
		FixedDocumentSequence fixedDocumentSequence = val2.GetFixedDocumentSequence();
		PrintTicket printTicket = val2.get_FixedDocumentSequenceReader().get_PrintTicket();
		((SerializerWriter)val).Write(fixedDocumentSequence, printTicket);
		val2.Close();
	}

	private static PrintQueue GetPrintQueue(string PrinterFullName)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		if (PrinterFullName.StartsWith("\\\\", StringComparison.Ordinal))
		{
			int num = PrinterFullName.LastIndexOf('\\');
			string text = PrinterFullName.Substring(0, num);
			string text2 = PrinterFullName.Substring(num + 1);
			return new PrintQueue(new PrintServer(text), text2);
		}
		return new PrintQueue((PrintServer)new LocalPrintServer(), PrinterFullName);
	}
}
