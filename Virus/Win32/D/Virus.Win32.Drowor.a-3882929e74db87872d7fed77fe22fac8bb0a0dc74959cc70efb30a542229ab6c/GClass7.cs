using System;
using System.ComponentModel;
using System.Threading;

public class GClass7 : BackgroundWorker
{
	public delegate void GDelegate7(string string_0);

	private GClass6 gclass6_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private double double_0;

	public GClass7(int int_3, int int_4, int int_5, double double_1)
	{
		base.WorkerReportsProgress = true;
		base.WorkerSupportsCancellation = true;
		double_0 = double_1;
		gclass6_0 = new GClass6();
		gclass6_0.method_2(method_4);
		gclass6_0.method_4(method_3);
		gclass6_0.method_6(method_2);
		gclass6_0.method_8(method_1);
		gclass6_0.method_0(method_0);
		int_0 = int_3;
		int_1 = int_4;
		int_2 = int_5;
	}

	private void method_0(string string_0, string string_1, string string_2, string string_3)
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.string_0 = "Found";
		gStruct.string_1 = string_0;
		gStruct.string_3 = string_1;
		gStruct.string_2 = string_2;
		gStruct.string_4 = string_3;
		ReportProgress(0, gStruct);
		if (double_0 >= 0.0)
		{
			Random random = new Random(DateTime.Now.Millisecond);
			double num = random.NextDouble();
			num *= double_0;
			int millisecondsTimeout = Convert.ToInt32(num * 1000.0);
			if (double_0 > 0.0)
			{
				Thread.Sleep(millisecondsTimeout);
			}
		}
		else
		{
			Thread.Sleep(1000);
		}
	}

	private void method_1(int int_3)
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.string_0 = "Progress";
		ReportProgress(int_3, gStruct);
	}

	private void method_2(string string_0)
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.string_0 = "Finish";
		ReportProgress(0, gStruct);
	}

	private void method_3(string string_0)
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.string_0 = "Stop";
		ReportProgress(0, gStruct);
	}

	private void method_4(string string_0, int int_3, int int_4)
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.string_0 = "Start";
		gStruct.int_0 = int_3;
		gStruct.int_1 = int_4;
		ReportProgress(0, gStruct);
	}

	void BackgroundWorker.OnDoWork(DoWorkEventArgs doWorkEventArgs_0)
	{
		base.OnDoWork(doWorkEventArgs_0);
		gclass6_0.method_22(int_0, int_1, int_2);
	}

	void BackgroundWorker.OnRunWorkerCompleted(RunWorkerCompletedEventArgs runWorkerCompletedEventArgs_0)
	{
		base.OnRunWorkerCompleted(runWorkerCompletedEventArgs_0);
	}

	void BackgroundWorker.OnProgressChanged(ProgressChangedEventArgs progressChangedEventArgs_0)
	{
		base.OnProgressChanged(progressChangedEventArgs_0);
		if (base.CancellationPending)
		{
			gclass6_0.method_11(bool_1: true);
		}
	}
}
