using System.IO;
using System.Text;

namespace LogToText;

internal class Program
{
	private static void Main(string[] args)
	{
		if (args.Length < 1)
		{
			return;
		}
		string path = args[0];
		string path2;
		if (args.Length < 2)
		{
			path2 = Path.GetFileNameWithoutExtension(path) + ".txt";
			int num = 0;
			while (File.Exists(path2))
			{
				path2 = Path.GetFileNameWithoutExtension(path) + "_" + num + ".txt";
				num++;
			}
		}
		else
		{
			path2 = args[1];
		}
		FileStream input = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		FileStream stream = new FileStream(path2, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
		LogReader logReader = new LogReader(input, Encoding.GetEncoding(1251));
		StreamWriter streamWriter = new StreamWriter(stream, Encoding.GetEncoding(1251));
		LogRec logRec;
		while ((logRec = logReader.ReadRec()) != null)
		{
			if (logRec.Type == LogRecType.CallRec)
			{
				CallRec callRec = (CallRec)logRec;
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat("{0:X8}:   ", callRec.CallAddr);
				for (int i = 0; i < callRec.Level; i++)
				{
					stringBuilder.Append("    ");
				}
				stringBuilder.Append(logRec.ToString());
				stringBuilder.Replace('\n', ' ').Replace('\r', ' ');
				streamWriter.WriteLine(stringBuilder.ToString());
			}
		}
		streamWriter.Close();
		logReader.Close();
	}
}
