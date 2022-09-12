using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Caliburn.Micro;
using CsvHelper;
using CsvHelper.Configuration;
using xbot_wpf.Common;

namespace xbot_wpf.Services;

public class ExporterAnalytics : GInterface1
{
	private readonly ILog ilog_0;

	private readonly string uqutpCeRyh;

	public ExporterAnalytics(ILog logger)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		ilog_0 = logger;
		uqutpCeRyh = Path.Combine(Const.DataDirectory, ConfigurationManager.get_AppSettings()["ExportAnalyticsFile"]);
	}

	public async Task Export(IList<ExporterAnalyticsItem> records)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass3_.records = records;
		await Task.Run(delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			using StreamWriter streamWriter = new StreamWriter(_003C_003Ec__DisplayClass3_._003C_003E4__this.uqutpCeRyh);
			CsvConfiguration val = new CsvConfiguration();
			val.set_Delimiter("|");
			val.set_HasHeaderRecord(false);
			val.set_CultureInfo(CultureInfo.InvariantCulture);
			CsvConfiguration val2 = val;
			CsvWriter val3 = new CsvWriter((TextWriter)streamWriter, val2);
			try
			{
				val3.WriteRecords((IEnumerable)_003C_003Ec__DisplayClass3_.records);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		});
	}

	public async Task<IList<ExporterAnalyticsItem>> Import(string path)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.path = path;
		return await Task.Run(delegate
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			using StreamReader streamReader = new StreamReader(_003C_003Ec__DisplayClass4_.path);
			CsvConfiguration val = new CsvConfiguration();
			val.set_Delimiter("|");
			val.set_HasHeaderRecord(false);
			val.set_CultureInfo(CultureInfo.InvariantCulture);
			CsvConfiguration val2 = val;
			List<ExporterAnalyticsItem> result = new List<ExporterAnalyticsItem>();
			CsvReader val3 = new CsvReader((TextReader)streamReader, val2);
			try
			{
				result = val3.GetRecords<ExporterAnalyticsItem>().ToList();
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			return result;
		});
	}
}
