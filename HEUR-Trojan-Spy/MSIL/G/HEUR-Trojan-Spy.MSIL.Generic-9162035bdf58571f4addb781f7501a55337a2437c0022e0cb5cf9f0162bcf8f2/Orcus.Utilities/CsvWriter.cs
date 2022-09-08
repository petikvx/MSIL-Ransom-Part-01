using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Orcus.Shared.Csv;

namespace Orcus.Utilities;

public sealed class CsvWriter : IDisposable
{
	private StreamWriter _streamWriter;

	public bool ReplaceCarriageReturnsAndLineFeedsFromFieldValues { get; set; } = true;


	public string CarriageReturnAndLineFeedReplacement { get; set; } = ",";


	public void Dispose()
	{
		_streamWriter?.Dispose();
	}

	public void WriteCsv(CsvFile csvFile, string filePath)
	{
		WriteCsv(csvFile, filePath, null);
	}

	public void WriteCsv(CsvFile csvFile, string filePath, Encoding encoding)
	{
		if (File.Exists(filePath))
		{
			File.Delete(filePath);
		}
		using StreamWriter streamWriter = new StreamWriter(filePath, append: false, encoding ?? Encoding.Default);
		WriteToStream(csvFile, streamWriter);
		streamWriter.Close();
	}

	public void WriteCsv(CsvFile csvFile, Stream stream)
	{
		WriteCsv(csvFile, stream, null);
	}

	public void WriteCsv(CsvFile csvFile, Stream stream, Encoding encoding)
	{
		stream.Position = 0L;
		_streamWriter = new StreamWriter(stream, encoding ?? Encoding.Default);
		WriteToStream(csvFile, _streamWriter);
		_streamWriter.Flush();
		stream.Position = 0L;
	}

	public void WriteToStream(CsvFile csvFile, TextWriter writer)
	{
		if (csvFile.Headers.Count > 0)
		{
			WriteRecord(csvFile.Headers, writer);
		}
		foreach (CsvRecord item in (List<CsvRecord>)(object)csvFile.Records)
		{
			WriteRecord(item.Fields, writer);
		}
	}

	private void WriteRecord(IList<string> fields, TextWriter writer)
	{
		for (int i = 0; i < fields.Count; i++)
		{
			bool flag = fields[i].Contains(",");
			bool flag2;
			string text = ((flag2 = fields[i].Contains("\"")) ? fields[i].Replace("\"", "\"\"") : fields[i]);
			if (ReplaceCarriageReturnsAndLineFeedsFromFieldValues && (text.Contains("\r") || text.Contains("\n")))
			{
				flag = true;
				text = text.Replace("\r\n", CarriageReturnAndLineFeedReplacement);
				text = text.Replace("\r", CarriageReturnAndLineFeedReplacement);
				text = text.Replace("\n", CarriageReturnAndLineFeedReplacement);
			}
			writer.Write("{0}{1}{0}{2}", (flag || flag2) ? "\"" : string.Empty, text, (i < fields.Count - 1) ? "," : string.Empty);
		}
		writer.WriteLine();
	}
}
