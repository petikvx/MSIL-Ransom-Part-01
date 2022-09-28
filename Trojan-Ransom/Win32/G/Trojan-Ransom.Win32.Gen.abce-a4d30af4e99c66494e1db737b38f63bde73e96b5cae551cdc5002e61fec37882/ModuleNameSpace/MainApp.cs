using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ModuleNameSpace;

internal class MainApp : MainAppInterface
{
	private bool shouldExit;

	private int exitCode;

	public bool ShouldExit
	{
		get
		{
			return shouldExit;
		}
		set
		{
			shouldExit = value;
		}
	}

	public int ExitCode
	{
		get
		{
			return exitCode;
		}
		set
		{
			exitCode = value;
		}
	}

	[STAThread]
	private static int Main(string[] args)
	{
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Invalid comparison between Unknown and I4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		MainApp mainApp = new MainApp();
		bool flag = false;
		string text = string.Empty;
		MainModuleUI ui = new MainModuleUI();
		MainModule mainModule = new MainModule(mainApp, ui);
		ManualResetEvent mre = new ManualResetEvent(initialState: false);
		AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
		try
		{
			Runspace val = RunspaceFactory.CreateRunspace((PSHost)(object)mainModule);
			try
			{
				val.set_ApartmentState(ApartmentState.STA);
				val.Open();
				PowerShell val2 = PowerShell.Create();
				try
				{
					val2.set_Runspace(val);
					val2.get_Streams().get_Error().add_DataAdded((EventHandler<DataAddedEventArgs>)delegate(object sender, DataAddedEventArgs e)
					{
						((PSHostUserInterface)ui).WriteErrorLine(((object)((PSDataCollection<ErrorRecord>)sender).get_Item(e.get_Index())).ToString());
					});
					PSDataCollection<string> val3 = new PSDataCollection<string>();
					if (Console_Info.IsInputRedirected())
					{
						string text2 = "";
						while ((text2 = Console.ReadLine()) != null)
						{
							val3.Add(text2);
						}
					}
					val3.Complete();
					PSDataCollection<PSObject> colOutput = new PSDataCollection<PSObject>();
					colOutput.add_DataAdded((EventHandler<DataAddedEventArgs>)delegate(object sender, DataAddedEventArgs e)
					{
						((PSHostUserInterface)ui).WriteLine(((object)colOutput.get_Item(e.get_Index())).ToString());
					});
					int num = 0;
					int num2 = 0;
					foreach (string text3 in args)
					{
						if (string.Compare(text3, "-whatt".Replace("hat", "ai"), ignoreCase: true) == 0)
						{
							flag = true;
						}
						else if (text3.StartsWith("-extdummt".Replace("dumm", "rac"), StringComparison.InvariantCultureIgnoreCase))
						{
							string[] array = text3.Split(new string[1] { ":" }, 2, StringSplitOptions.RemoveEmptyEntries);
							if (array.Length != 2)
							{
								MessageBox.Show("If you spzzcify thzz -zzxtract option you nzzed to add a filzz for zzxtraction in this way\r\n   -zzxtract:\"<filzznamzz>\"".Replace("zz", "e"), AppDomain.CurrentDomain.FriendlyName, (MessageBoxButtons)0, (MessageBoxIcon)16);
								return 1;
							}
							text = array[1].Trim(new char[1] { '"' });
						}
						else
						{
							if (string.Compare(text3, "-end", ignoreCase: true) == 0)
							{
								num = num2 + 1;
								break;
							}
							if (string.Compare(text3, "-debug", ignoreCase: true) == 0)
							{
								Debugger.Launch();
								break;
							}
						}
						num2++;
					}
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String("IyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQojIChjKSBEb2RvIENDDQojIEdlbmVyYXRlZCBCeTogQWxla3NleSBNZWR2ZWRvdnNraXkNCiMgRWRpdGVkIGJ5IG1heC5jZmcNCiMgMjAyMQ0KIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQokdmVyc2lvbiA9ICIzLjkuMiINCg0KJEFycmF5ID0gQCgNCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0JIg0YLQtdGB0YLQvtCy0YvQuSDQutCw0L3QsNC7IjsgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gInRlc3RtZXNzYWdlc2thY2sifSAjIHRlc3RtZXNzYWdlc2thY2sgLyB0ZXN0DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gJG51bGw7ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAkbnVsbH0NCiAgICAjW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCh0LXQsdC1INCyINGC0LXRgdGC0L7QstGD0Y4g0LPRgNGD0L/Qv9GDIjsgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIlRlc3QgZ3JvdXAifSAjINC00LvRjyDRgtC10YHRgtC+0LINCiAgICAjW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gJG51bGw7ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAkbnVsbH0gICAgICAgICMg0LTQu9GPINGC0LXRgdGC0L7Qsg0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQntC/0LXRgNCw0YLQvtGA0LDQvCI7ICAgICAgICAgICAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJPcGVyYXRvciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCh0L/QtdGG0LjQsNC70LjRgdGC0LDQvCDQutC70LjQtdC90YLRgdC60L7QuSDQu9C40L3QuNC4IjsgICAgICAgICAiV2hhdElkbyIgPSAiU3BlY2lhbGlzdCJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCa0L7QvNGM0Y7QvdC40YLQuCDRgdC/0LXRhtC40LDQu9C40YHRgtCw0LwiOyAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiQ29tbXVuaXR5IHNwZWNpYWxpc3QifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQntC/0LXRgNCw0YLQvtGA0LDQvCDQv9C+0YfRgtGLIjsgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIk1haWwgb3BlcmF0b3IifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQmtC+0LzRjNGO0L3QuNGC0Lgg0LzQtdC90LXQtNC20LXRgNCw0LwiOyAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJDb21tdW5pdHktbWFuYWdlciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCi0YDQtdC90LXRgNCw0LwgKNCR0LDQt9CwINC30L3QsNC90LjQuSDQuCDQvNC10YLRgNC40LrQuCkiOyAgICAgICJXaGF0SWRvIiA9ICJUcmFpbmVyIEJhc2UifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQotGA0LXQvdC10YDQsNC8ICjQndCw0LnQvCwg0L7QsdGD0YfQtdC90LjQtSDQuCDQsNC00LDQv9GC0LDRhtC40Y8pIjsgIldoYXRJZG8iID0gIlRyYWluZXIgVGVhY2gifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQotGA0LXQvdC10YDQsNC8ICjQotC10LrRgdGCKSI7ICAgICAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJUcmFpbmVyIFRleHQifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQkdC40LfQvdC10YEt0YLRgNC10L3QtdGA0LDQvCI7ICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiQnVzaW5lc3MgVHJhaW5lciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gIkhSINGB0L/QtdGG0LjQsNC70LjRgdGC0LDQvCI7ICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiSFIgU3BlY2lhbGlzdCBvZiBDb250YWN0IENlbnRlciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gIkhSINC80LXQvdC10LTQttC10YDQsNC8IjsgICAgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIkhSIERvZG9DQyJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCc0LXQvdC10LTQttC10YDQsNC8INGB0LzQtdC90YsiOyAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiU2hpZnQgbWFuYWdlciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCc0LXQvdC10LTQttC10YDQsNC8INC/0L4g0YDQtdC60LvQsNC80LDRhtC40Y/QvCI7ICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJDbGFpbXMgbWFuYWdlciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gIlFBLdC80LXQvdC10LTQttC10YDQsNC8IjsgICAgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIlFBIn0NCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0KHQv9C10YbQuNCw0LvQuNGB0YLQsNC8INGH0LDRgi3Qv9C+0LTQtNC10YDQttC60LgiOyAgICAgICAgICAgICJXaGF0SWRvIiA9ICJDaGF0IFN1cHBvcnQifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQodC/0LXRhtC40LDQu9C40YHRgtCw0Lwg0J7QnNCfIjsgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIk1vYmlsZSBzdXBwb3J0In0NCikNCg0KZnVuY3Rpb24gR2VuZXJhdGVGb3JtIHsNCiAgICBBZGQtVHlwZSAtQXNzZW1ibHlOYW1lIFN5c3RlbS5XaW5kb3dzLkZvcm1zLCBTeXN0ZW0uRHJhd2luZw0KICAgIFtTeXN0ZW0uV2luZG93cy5Gb3Jtcy5BcHBsaWNhdGlvbl06OkVuYWJsZVZpc3VhbFN0eWxlcygpDQoNCiAgICAjIEdsb2JhbCBJbmRlbnQgKGhhcmQpDQogICAgJHogID0gMTAgIyBSaWNoVGV4dEJveF8xLCBMYWJlbF8xLCBMYWJlbF8yLCBCdXR0b25fMSwgTGFiZWxfMywgUHJvZ3Jlc3NCYXJfMSwgQ2hlY2tCb3hlcw0KICAgICMgU2l6ZSAoaGFyZCkNCiAgICAkdyAgPSA3NjAgIyBGb3JtXzENCiAgICAkdzIgPSAyNDkgIyBDaGVja0JveGVzDQogICAgJGgyID0gMjAgICMgTGFiZWxfMSwgTGFiZWxfMiwgQ2hlY2tCb3hlcw0KICAgICRoMyA9IDUwICAjIEJ1dHRvbl8xDQogICAgIyBTaXplDQogICAgJGggPSAoJEFycmF5LkNvdW50ICogJGgyKSArICgkeiAqIDIpICMgRm9ybV8xDQogICAgaWYgKCAkaCAtbHQgJHcgLyAyICkgeyAkaCA9ICR3IC8gMiB9ICAjIEZvcm1fMSAoIGggbWluaW11bSAxLzIgb2YgdyApDQogICAgJGgxID0gJGggLSAkaDMgLSAoJGgyICogMikgLSAoJHogKiAyKSAjIFJpY2hUZXh0Qm94XzENCiAgICAkaDQgPSAkaDMgLyAyICMgTGFiZWxfMywgUHJvZ3Jlc3NCYXJfMQ0KICAgICR3MSA9ICR3IC0gJHcyIC0gKCR6ICogMykgIyBSaWNoVGV4dEJveF8xLCBMYWJlbF8xLCBMYWJlbF8yLCBCdXR0b25fMSwgTGFiZWxfMywgUHJvZ3Jlc3NCYXJfMQ0KICAgICMgUG9pbnQNCiAgICAkeDEgPSAkdzEgKyAoJHogKiAyKSAjIENoZWNrQm94ZXMNCiAgICAkeTEgPSAkaDEgKyAkeiAgIyBMYWJlbF8xDQogICAgJHkyID0gJHkxICsgJGgyICMgTGFiZWxfMg0KICAgICR5MyA9ICR5MiArICRoMiAjIEJ1dHRvbl8xLCBMYWJlbF8zDQogICAgJHk0ID0gJHkzICsgKCAkaDMgLyAyICkgIyBQcm9ncmVzc0Jhcl8xDQogICAgIyBHbG9iYWwgRm9udA0KICAgICRmb250ID0gIk1pY3Jvc29mdCBTYW5zIFNlcmlmIg0KDQogICAgIyBGb3JtXzEgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KICAgICRGb3JtXzEgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkZvcm0NCiAgICAgICAgJEZvcm1fMS5DbGllbnRTaXplID0gIiR3LCRoIg0KICAgICAgICAkRm9ybV8xLkljb24gPSAiQzpcT3BlcmF0b3JUb29sc1xpY29cRmF2aWNvbi5pY28iDQogICAgICAgICRGb3JtXzEuQmFja0NvbG9yID0gIjIyNSwyMjUsMjI1Ig0KICAgICAgICAkRm9ybV8xLkZvcm1Cb3JkZXJTdHlsZSA9ICJGaXhlZDNEIg0KICAgICAgICAkRm9ybV8xLlN0YXJ0UG9zaXRpb24gPSAiQ2VudGVyU2NyZWVuIg0KICAgICAgICAkRm9ybV8xLk1heGltaXplQm94ID0gMA0KICAgICAgICAkRm9ybV8xLlRleHQgPSAiRG9kbyBDb250YWN0IENlbnRlcjogU2xhY2sgU2VuZCBNZXNzYWdlIFRvb2xzIHYkKCR2ZXJzaW9uKSINCg0KICAgICMgUmljaFRleHRCb3hfMSAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQogICAgJFJpY2hUZXh0Qm94XzEgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLlJpY2hUZXh0Qm94DQogICAgICAgICRSaWNoVGV4dEJveF8xLkxvY2F0aW9uID0gIiR6LCR6Ig0KICAgICAgICAkUmljaFRleHRCb3hfMS5TaXplID0gIiR3MSwkaDEiDQogICAgICAgICRSaWNoVGV4dEJveF8xLkZvbnQgPSAiJGZvbnQsMTAiDQogICAgICAgICRSaWNoVGV4dEJveF8xLkJhY2tDb2xvciA9ICIyNTUsMjU1LDI1NSINCiAgICAgICAgJFJpY2hUZXh0Qm94XzEuQm9yZGVyU3R5bGUgPSAiTm9uZSINCiAgICAgICAgJFJpY2hUZXh0Qm94XzEuU2VsZWN0aW9uSW5kZW50ID0gKCAkeiAvIDIgKQ0KICAgICAgICAkUmljaFRleHRCb3hfMS5TZWxlY3Rpb25SaWdodEluZGVudCA9ICggJHogLyAyICkNCiAgICAgICAgJFJpY2hUZXh0Qm94XzEuRW5hYmxlZCA9ICR0cnVlDQogICAgICAgICRSaWNoVGV4dEJveF8xLlRleHQgPSBAJw0KYGBg4oaTINCt0YLQviDQv9GA0LjQvNC10YAg0YHQvtC+0LHRidC10L3QuNGPIOKGk2BgYA0K0KDQtdCx0Y/RgtCwLCDQv9GA0LjQstC10YIhDQoNCtCS0LDQttC90L7QtSAi0YPRgtC+0YfQvdC10L3QuNC1IiDQv9C+INCw0LrRhtC40Lg6IF/QktGC0L7RgNCw0Y8g0L/QvtC70L7QstC40L3QutCwINCyINC/0L7QtNCw0YDQvtC6Xywg0L/QviDQv9GA0L7QvNC+0LrQvtC00YMgYExPVkVgLg0K0KfRgtC+0LHRiyDRgdC90LjQt9C40YLRjCDQvdCw0LPRgNGD0LfQutGDINC90LAg0L/QuNGG0YbQtdGA0LjQuCwg0L/RgNC40L3Rj9GC0L4g0YDQtdGI0LXQvdC40LUg0LLQstC10YHRgtC4INC+0LPRgNCw0L3QuNGH0LXQvdC40LUuDQoNCj46d2FybmluZzogKtCR0YPQtNGM0YLQtSDQstC90LjQvNCw0YLQtdC70YzQvdGLLioNCj4q0KLQtdC/0LXRgNGMINC+0LTQuNC9INC60LvQuNC10L3RgiDRgdC80L7QttC10YIg0LLQvtGB0L/QvtC70YzQt9C+0LLQsNGC0YzRgdGPINC/0YDQvtC80L7QutC+0LTQvtC8INGC0L7Qu9GM0LrQviB+MiDRgNCw0LfQsH4gMSDRgNCw0LcuKg0KDQo6Ym9vazogPGh0dHBzOi8vZG9kb3BpenphLmluZm8vc3RhbmRhcmRzL3zQkdCw0LfQsCDQt9C90LDQvdC40Lk+DQoNCl9NYXkgdGhlIEZvcmNlIGJlIHdpdGggeW91XyA6eW9kYV9mb3JjZToNCmBgYOKGkSDQrdGC0L4g0L/RgNC40LzQtdGAINGB0L7QvtCx0YnQtdC90LjRjyDihpFgYGANCidADQogICAgJEZvcm1fMS5Db250cm9scy5BZGQoJFJpY2hUZXh0Qm94XzEpDQoNCiAgICAjIExhYmVsXzEgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KICAgICRMYWJlbF8xID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5MYWJlbA0KICAgICAgICAkTGFiZWxfMS5Mb2NhdGlvbiA9ICIkeiwkeTEiDQogICAgICAgICRMYWJlbF8xLlNpemUgPSAiJHcxLCRoMiINCiAgICAgICAgJExhYmVsXzEuRm9udCA9ICIkZm9udCw5Ig0KICAgICAgICAkTGFiZWxfMS5Gb3JlQ29sb3IgPSAiODAsODAsODAiDQogICAgICAgICRMYWJlbF8xLlRleHQgPSAnXG4gIC0g0L/QtdGA0LXQvdC+0YEg0YHRgtGA0L7QutC4ICAgICrQttC40YDQvdGL0LkqICAgIF/QutGD0YDRgdC40LJfICAgIH7Qt9Cw0YfQtdGA0YLQvdGD0YLRi9C5fiAgICBgYGDQutC+0LQg0LHQu9C+0LpgYGAnDQogICAgJEZvcm1fMS5Db250cm9scy5BZGQoJExhYmVsXzEpDQoNCiAgICAjIExhYmVsXzIgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KICAgICRMYWJlbF8yID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5MYWJlbA0KICAgICAgICAkTGFiZWxfMi5Mb2NhdGlvbiA9ICIkeiwkeTIiDQogICAgICAgICRMYWJlbF8yLlNpemUgPSAiJHcxLCRoMiINCiAgICAgICAgJExhYmVsXzIuRm9udCA9ICIkZm9udCw5Ig0KICAgICAgICAkTGFiZWxfMi5Gb3JlQ29sb3IgPSAiODAsODAsODAiDQogICAgICAgICRMYWJlbF8yLlRleHQgPSAnXG4+ICAtINGG0LjRgtC40YDQvtCy0LDQvdC40LUgICAgYNC60L7QtCDQutGA0LDRgdC90YvQvGAgICAgOtGN0LzQvtC00LfQuDogICAgPGRvZG9waXp6YS5ydXzRgtC10LrRgdGCINGB0YHRi9C70LrQuD4nDQogICAgJEZvcm1fMS5Db250cm9scy5BZGQoJExhYmVsXzIpDQoNCiAgICAjIEJ1dHRvbl8xICMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KICAgICRCdXR0b25fMSA9IE5ldy1PYmplY3QgU3lzdGVtLldpbmRvd3MuRm9ybXMuQnV0dG9uDQogICAgICAgICRCdXR0b25fMS5Mb2NhdGlvbiA9ICIkeiwkeTMiDQogICAgICAgICRCdXR0b25fMS5TaXplID0gIiR3MSwkaDMiDQogICAgICAgICRCdXR0b25fMS5Gb250ID0gIiRmb250LDEyIg0KICAgICAgICAkQnV0dG9uXzEuVXNlVmlzdWFsU3R5bGVCYWNrQ29sb3IgPSAkVHJ1ZQ0KICAgICAgICAkQnV0dG9uXzEuVGV4dCA9ICLQniDQoiDQnyDQoCDQkCDQkiDQmCDQoiDQrCINCiAgICAgICAgJEJ1dHRvbl8xLkFkZF9DbGljayggew0KDQogICAgICAgICAgICAkTGFiZWxfMy5TaG93KCkNCiAgICAgICAgICAgICRCdXR0b25fMS5IaWRlKCkNCg0KICAgICAgICAgICAgU2VuZE1lc3NhZ2VTbGFjaw0KICAgICAgICAgICAgU3RhcnQtU2xlZXAgLVNlY29uZHMgMQ0KDQogICAgICAgICAgICAkTGFiZWxfMy5IaWRlKCkNCiAgICAgICAgICAgICRCdXR0b25fMS5TaG93KCkNCg0KICAgICAgICB9ICkNCiAgICAkRm9ybV8xLkNvbnRyb2xzLkFkZCgkQnV0dG9uXzEpDQoNCiAgICAjIExhYmVsXzMgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KICAgICRMYWJlbF8zID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5MYWJlbA0KICAgICAgICAkTGFiZWxfMy5Mb2NhdGlvbiA9ICIkeiwkeTMiDQogICAgICAgICRMYWJlbF8zLlNpemUgPSAiJHcxLCRoNCINCiAgICAgICAgJExhYmVsXzMuRm9udCA9IFtTeXN0ZW0uRHJhd2luZy5Gb250XTo6bmV3KCAkZm9udCwgMTAsIFtTeXN0ZW0uRHJhd2luZy5Gb250U3R5bGVdOjpCb2xkICkNCiAgICAgICAgJExhYmVsXzMuSGlkZSgpDQogICAgJEZvcm1fMS5Db250cm9scy5BZGQoJExhYmVsXzMpDQoNCiAgICAjIFByb2dyZXNzQmFyXzEgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KICAgICRQcm9ncmVzc0Jhcl8xID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5Qcm9ncmVzc0Jhcg0KICAgICAgICAkUHJvZ3Jlc3NCYXJfMS5Mb2NhdGlvbiA9ICIkeiwkeTQiDQogICAgICAgICRQcm9ncmVzc0Jhcl8xLlNpemUgPSAiJHcxLCRoNCINCiAgICAgICAgJFByb2dyZXNzQmFyXzEuRm9udCA9ICIkZm9udCwxMiINCiAgICAgICAgJFByb2dyZXNzQmFyXzEuSGlkZSgpDQogICAgJEZvcm1fMS5Db250cm9scy5BZGQoJFByb2dyZXNzQmFyXzEpDQoNCiAgICAjIENoZWNrQm94ZXMgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQogICAgJENoZWNrQm94ZXMgPSBAKCkNCiAgICAkQXJyYXkuRm9yZWFjaHsNCiAgICAgICAgJENoZWNrQm94ID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5DaGVja0JveA0KICAgICAgICAgICAgJENoZWNrQm94LkxvY2F0aW9uID0gIiR4MSwkeiINCiAgICAgICAgICAgICRDaGVja0JveC5TaXplID0gIiR3MiwkaDIiDQogICAgICAgICAgICAkQ2hlY2tCb3guRm9udCA9ICIkZm9udCw5Ig0KICAgICAgICAgICAgJENoZWNrQm94LkFwcGVhcmFuY2UgPSAiQnV0dG9uIg0KICAgICAgICAgICAgJENoZWNrQm94LkZsYXRTdHlsZSA9ICJGbGF0Ig0KICAgICAgICAgICAgJENoZWNrQm94LkZsYXRBcHBlYXJhbmNlLkJvcmRlclNpemUgPSAwDQogICAgICAgICAgICAkQ2hlY2tCb3guRmxhdEFwcGVhcmFuY2UuQ2hlY2tlZEJhY2tDb2xvciA9ICIxNjAsMjAwLDI0MCINCiAgICAgICAgICAgICRDaGVja0JveC5OYW1lID0gJF8uV2hhdElkbw0KICAgICAgICAgICAgJENoZWNrQm94LlRleHQgPSAkXy5UZXh0DQoNCiAgICAgICAgSWYgKCAkbnVsbCAtbmUgJF8uVGV4dCApIHsNCiAgICAgICAgICAgIElmICggJF8uV2hhdElkbyAtZXEgJEFycmF5LldoYXRJZG9bMF0gKSB7ICRDaGVja0JveC5DaGVja2VkID0gJHRydWUgfQ0KICAgICAgICAgICAgJEZvcm1fMS5Db250cm9scy5BZGQoJENoZWNrQm94KQ0KICAgICAgICAgICAgJENoZWNrQm94ZXMgKz0gJENoZWNrQm94DQogICAgICAgIH0NCiAgICAgICAgJHogKz0gJGgyDQogICAgfQ0KICAgICMgU2hvdyB0aGUgRm9ybQ0KICAgIFt2b2lkXSRGb3JtXzEuU2hvd0RpYWxvZygpDQp9ICMgRW5kIEdlbmVyYXRlRm9ybQ0KDQpGdW5jdGlvbiBTZW5kTWVzc2FnZVNsYWNrIHsNCg0KICAgICMg0J/RgNC+0LLQtdGA0Y/QtdC8INC+0LHRj9C30LDRgtC10LvRjNC90YvQtSDRg9GB0LvQvtCy0LjRjw0KICAgICRMYWJlbF8zLkZvcmVDb2xvciA9ICIxNjAsNDAsNDAiDQogICAgaWYgKCAkQ2hlY2tCb3hlcy5XaGVyZXskXy5DaGVja2VkIC1lcSAkVHJ1ZX0uY291bnQgLWVxIDAgKSB7DQogICAgICAgICRMYWJlbF8zLlRleHQgPSAi0J3QldCa0J7QnNCjINCe0KLQn9Cg0JDQktCb0K/QotCsIg0KICAgICAgICByZXR1cm4NCiAgICB9IGVsc2VpZiAoICRSaWNoVGV4dEJveF8xLlRleHQgLWVxICIiICkgew0KICAgICAgICAkTGFiZWxfMy5UZXh0ID0gItCd0JXQp9CV0JPQniDQntCi0J/QoNCQ0JLQm9Cv0KLQrCINCiAgICAgICAgcmV0dXJuDQogICAgfQ0KICAgICRMYWJlbF8zLkZvcmVDb2xvciA9ICI4MCw4MCw4MCINCiAgICAkTGFiZWxfMy5UZXh0ID0gItCf0L7QtNCz0L7RgtC+0LLQutCwINC6INC+0YLQv9GA0LDQstC60LUgLiAuIC4iDQoNCiAgICAjINCQ0YPRgSBTbGFjaw0KICAgICRCb3RVc2VyT0F1dGhBY2Nlc3NUb2tlbiA9ICJ4b3hiLTQ2MzM0NTYzNjY3NC01MTE1OTI3MTgzMjItaGp5YVljdXJObVdCUXJod05nV0NZaW1sIg0KICAgICRoZWFkZXJzX3NsYWNrID0gQHsgIkF1dGhvcml6YXRpb24iID0gIkJlYXJlciAkKCRCb3RVc2VyT0F1dGhBY2Nlc3NUb2tlbikiOyAiQ29udGVudC1UeXBlIiA9ICJhcHBsaWNhdGlvbi9qc29uO2NoYXJzZXQ9VVRGLTgiIH0NCg0KICAgICMg0J/QvtC70YPRh9Cw0LXQvCDRgdC/0LjRgdC+0Log0LLRgdC10YUg0L/QvtC70YzQt9C+0LLQsNGC0LXQu9C10LkgU2xhY2sNCiAgICAjINCf0LXRgNCy0LDRjyDQv9Cw0YDRgtC40Y8gKNC00L4gMTAwMCkNCiAgICAkc2xhY2tfYWxsX3VzZXJzID0gQCgpDQogICAgJHNsYWNrX3JlcXVpZXN0ID0gSW52b2tlLVJlc3RNZXRob2QgLU1ldGhvZCBHRVQgLVVyaSAiaHR0cHM6Ly9zbGFjay5jb20vYXBpL3VzZXJzLmxpc3QiIC1IZWFkZXJzICRoZWFkZXJzX3NsYWNrDQogICAgJHNsYWNrX2FsbF91c2VycyArPSAkc2xhY2tfcmVxdWllc3QubWVtYmVycw0KICAgICMg0KHQu9C10LTRg9GO0YnQuNC1INC/0LDRgNGC0LjQuCAo0LXRgdC70Lgg0LXRgdGC0YwpDQogICAgd2hpbGUgKCAkc2xhY2tfcmVxdWllc3QucmVzcG9uc2VfbWV0YWRhdGEubmV4dF9jdXJzb3IgLW5lICIiICkgew0KICAgICAgICAkc2xhY2tfcmVxdWllc3QgPSBJbnZva2UtUmVzdE1ldGhvZCAtTWV0aG9kIEdFVCAtVXJpICJodHRwczovL3NsYWNrLmNvbS9hcGkvdXNlcnMubGlzdD9jdXJzb3I9JCgkc2xhY2tfcmVxdWllc3QucmVzcG9uc2VfbWV0YWRhdGEubmV4dF9jdXJzb3IpIiAtSGVhZGVycyAkaGVhZGVyc19zbGFjaw0KICAgICAgICAkc2xhY2tfYWxsX3VzZXJzICs9ICRzbGFja19yZXF1aWVzdC5tZW1iZXJzDQogICAgfQ0KDQogICAgIyDQntGC0L/RgNCw0LLQutCwINGB0L7QvtCx0YnQtdC90LjRjyDQsiBTbGFjaw0KICAgICRwYXJhbXMgPSBAew0KICAgICAgICBNZXRob2QgICAgICA9ICJQT1NUIg0KICAgICAgICBVcmkgICAgICAgICA9ICJodHRwczovL3NsYWNrLmNvbS9hcGkvY2hhdC5wb3N0TWVzc2FnZSINCiAgICAgICAgSGVhZGVycyAgICAgPSAkaGVhZGVyc19zbGFjaw0KICAgICAgICBDb250ZW50VHlwZSA9ICJhcHBsaWNhdGlvbi9qc29uO2NoYXJzZXQ9VVRGLTgiDQogICAgfQ0KICAgIGZvcmVhY2ggKCAkQ2hlY2tCb3ggaW4gJENoZWNrQm94ZXMuV2hlcmV7ICRfLkNoZWNrZWQgLWVxICRUcnVlIH0gKSB7DQoNCiAgICAgICAgaWYgKCAkQ2hlY2tCb3guTmFtZSAtZXEgJEFycmF5LldoYXRJZG9bMF0gKSB7DQoNCiAgICAgICAgICAgIFtzdHJpbmddJFNlbmRfVG8gPSAnKtCe0YLQv9GA0LDQstC70LXQvdC+OiogJw0KICAgICAgICAgICAgJENoZWNrQm94ZXMuV2hlcmV7ICRfLkNoZWNrZWQgLWVxICRUcnVlIH0uRm9yRWFjaHsNCg0KICAgICAgICAgICAgICAgICRTZW5kX1RvICs9ICggJ1xuPmAnICsgJF8uVGV4dCArICdgICcgKQ0KICAgICAgICAgICAgfQ0KICAgICAgICAgICAgJFNlbmRfVG8gKz0gJ1xuIFxuICcNCg0KICAgICAgICAgICAgJGJvZHlfc2xhY2sgPSBbUFNDdXN0b21PYmplY3RdQHsNCiAgICAgICAgICAgICAgICBjaGFubmVsICAgID0gJENoZWNrQm94Lk5hbWUNCiAgICAgICAgICAgICAgICBpY29uX2Vtb2ppID0gIjp6YXA6Ig0KICAgICAgICAgICAgICAgIHRleHQgICAgICAgPSAkU2VuZF9UbyArICggJFJpY2hUZXh0Qm94XzEuVGV4dCAtcmVwbGFjZSAnIicsICdcIicgKQ0KICAgICAgICAgICAgICAgIHVzZXJuYW1lICAgPSAiQ0NCb3QiDQogICAgICAgICAgICB9IHwgQ29udmVydFRvLUpzb24gfCBGb3JFYWNoLU9iamVjdCB7IFtTeXN0ZW0uVGV4dC5SZWd1bGFyRXhwcmVzc2lvbnMuUmVnZXhdOjpVbmVzY2FwZSgkXykgfQ0KDQogICAgICAgICAgICBJbnZva2UtUmVzdE1ldGhvZCBAcGFyYW1zIC1Cb2R5ICRib2R5X3NsYWNrDQoNCiAgICAgICAgfSBlbHNlIHsNCiAgICAgICAgICAgICRyZXF1aWVzdF9vYmogPSAkc2xhY2tfYWxsX3VzZXJzLldoZXJleyAkXy5wcm9maWxlLnRpdGxlIC1lcSAkQ2hlY2tCb3guTmFtZSAtYW5kICRfLmRlbGV0ZWQgLWVxICRmYWxzZSB9DQoNCiAgICAgICAgICAgICRwcm9ncmVzcyA9IDANCiAgICAgICAgICAgICRQcm9ncmVzc0Jhcl8xLk1heGltdW0gPSAkcmVxdWllc3Rfb2JqLkNvdW50DQogICAgICAgICAgICAkUHJvZ3Jlc3NCYXJfMS5TaG93KCkNCg0KICAgICAgICAgICAgJHJlcXVpZXN0X29iai5Gb3JlYWNoew0KDQogICAgICAgICAgICAgICAgJGJvZHlfc2xhY2sgPSBbUFNDdXN0b21PYmplY3RdQHsNCiAgICAgICAgICAgICAgICAgICAgY2hhbm5lbCAgICA9ICRfLklEDQogICAgICAgICAgICAgICAgICAgIGljb25fZW1vamkgPSAiOnphcDoiDQogICAgICAgICAgICAgICAgICAgIHRleHQgICAgICAgPSAoICRSaWNoVGV4dEJveF8xLlRleHQgLXJlcGxhY2UgJyInLCAnXCInICkNCiAgICAgICAgICAgICAgICAgICAgdXNlcm5hbWUgICA9ICJDQ0JvdCINCiAgICAgICAgICAgICAgICB9IHwgQ29udmVydFRvLUpzb24gfCBGb3JFYWNoLU9iamVjdCB7IFtTeXN0ZW0uVGV4dC5SZWd1bGFyRXhwcmVzc2lvbnMuUmVnZXhdOjpVbmVzY2FwZSgkXykgfQ0KDQogICAgICAgICAgICAgICAgSW52b2tlLVJlc3RNZXRob2QgQHBhcmFtcyAtQm9keSAkYm9keV9zbGFjaw0KDQogICAgICAgICAgICAgICAgJHByb2dyZXNzICs9IDENCiAgICAgICAgICAgICAgICB0cnkgeyAkUHJvZ3Jlc3NCYXJfMS5WYWx1ZSA9ICRwcm9ncmVzcyArIDEgfSBjYXRjaCB7fQ0KICAgICAgICAgICAgICAgICRQcm9ncmVzc0Jhcl8xLlZhbHVlID0gJHByb2dyZXNzDQogICAgICAgICAgICAgICAgJExhYmVsXzMuVGV4dCA9ICLQntGC0L/RgNCw0LLQutCwICQoJENoZWNrQm94LlRleHQpOiAkKCRwcm9ncmVzcykg0LjQtyAkKCRyZXF1aWVzdF9vYmouQ291bnQpIg0KICAgICAgICAgICAgfQ0KICAgICAgICAgICAgJFByb2dyZXNzQmFyXzEuSGlkZSgpDQogICAgICAgICAgICAkTGFiZWxfMy5Gb3JlQ29sb3IgPSAiNDAsMTIwLDAiDQogICAgICAgICAgICAkTGFiZWxfMy5UZXh0ID0gItCe0YLQv9GA0LDQstC60LAgJCgkQ2hlY2tCb3guVGV4dCk6INCX0JDQktCV0KDQqNCV0J3QkCINCiAgICAgICAgICAgIFN0YXJ0LVNsZWVwIC1TZWNvbmRzIDMNCiAgICAgICAgfQ0KICAgIH0NCn0gIyBFbmQgU2VuZE1lc3NhZ2VTbGFjaw0KDQpHZW5lcmF0ZUZvcm0="));
					if (!string.IsNullOrEmpty(text))
					{
						File.WriteAllText(text, @string);
						return 0;
					}
					val2.AddScript(@string);
					string text4 = null;
					Regex regex = new Regex("^-([^: ]+)[ :]?([^:]*)$");
					for (int j = num; j < args.Length; j++)
					{
						Match match = regex.Match(args[j]);
						if (match.Success && match.Groups.Count == 3 && !double.TryParse(args[j], out var _))
						{
							if (text4 != null)
							{
								val2.AddParameter(text4);
							}
							if (match.Groups[2].Value.Trim() == "")
							{
								text4 = match.Groups[1].Value;
							}
							else if (!(match.Groups[2].Value == "True") && !(match.Groups[2].Value.ToUpper() == "$TRUE"))
							{
								if (!(match.Groups[2].Value == "False") && !(match.Groups[2].Value.ToUpper() == "$FALSE"))
								{
									val2.AddParameter(match.Groups[1].Value, (object)match.Groups[2].Value);
									text4 = null;
								}
								else
								{
									val2.AddParameter(match.Groups[1].Value, (object)false);
									text4 = null;
								}
							}
							else
							{
								val2.AddParameter(match.Groups[1].Value, (object)true);
								text4 = null;
							}
						}
						else if (text4 != null)
						{
							val2.AddParameter(text4, (object)args[j]);
							text4 = null;
						}
						else
						{
							val2.AddArgument((object)args[j]);
						}
					}
					if (text4 != null)
					{
						val2.AddParameter(text4);
					}
					val2.AddCommand("out-string");
					val2.AddParameter("stream");
					val2.BeginInvoke<string, PSObject>(val3, colOutput, (PSInvocationSettings)null, (AsyncCallback)delegate(IAsyncResult ar)
					{
						if (ar.IsCompleted)
						{
							mre.Set();
						}
					}, (object)null);
					while (!mainApp.ShouldExit && !mre.WaitOne(100))
					{
					}
					val2.Stop();
					if ((int)val2.get_InvocationStateInfo().get_State() == 5)
					{
						((PSHostUserInterface)ui).WriteErrorLine(val2.get_InvocationStateInfo().get_Reason().Message);
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				val.Close();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("An exception occured: " + ex.Message, AppDomain.CurrentDomain.FriendlyName, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		if (flag)
		{
			MessageBox.Show("Click OK to exit...", AppDomain.CurrentDomain.FriendlyName);
		}
		return mainApp.ExitCode;
	}

	private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		throw new Exception("Unhandled exception in " + AppDomain.CurrentDomain.FriendlyName);
	}
}
