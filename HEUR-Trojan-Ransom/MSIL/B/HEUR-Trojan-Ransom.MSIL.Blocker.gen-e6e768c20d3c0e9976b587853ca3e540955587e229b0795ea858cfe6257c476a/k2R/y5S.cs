using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace k2R;

[StandardModule]
internal sealed class y5S
{
	public static SqlConnection cn = new SqlConnection();

	public static SqlCommand cmd = new SqlCommand();

	public static SqlDataAdapter da = new SqlDataAdapter();

	public static DataSet ds = new DataSet();

	public static string str;

	public static void y6M()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		cn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CodingVisions;Integrated Security=True;Pooling=False");
	}
}
