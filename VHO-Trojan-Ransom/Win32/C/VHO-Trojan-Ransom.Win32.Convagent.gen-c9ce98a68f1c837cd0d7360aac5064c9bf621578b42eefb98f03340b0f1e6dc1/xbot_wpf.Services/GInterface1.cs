using System.Collections.Generic;
using System.Threading.Tasks;

namespace xbot_wpf.Services;

public interface GInterface1
{
	Task Export(IList<ExporterAnalyticsItem> items);

	Task<IList<ExporterAnalyticsItem>> Import(string path);
}
