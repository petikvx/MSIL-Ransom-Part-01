using System;
using System.Windows.Forms;
using SHUV_002D3.Serialization;

namespace Nbuujxdbv.Importers;

internal static class ContextCustomerImporter
{
	internal static ContextCustomerImporter ValidateContext;

	[STAThread]
	private static void ExcludeProducer()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new CandidatePolicySerializer());
		if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_da2fdd62f15b4cb397f4230c3ad28be9 != 0)
		{
			switch (0)
			{
			case 0:
				break;
			}
		}
	}

	internal static bool DefineContext()
	{
		return ValidateContext == null;
	}

	internal static ContextCustomerImporter RestartContext()
	{
		return ValidateContext;
	}
}
