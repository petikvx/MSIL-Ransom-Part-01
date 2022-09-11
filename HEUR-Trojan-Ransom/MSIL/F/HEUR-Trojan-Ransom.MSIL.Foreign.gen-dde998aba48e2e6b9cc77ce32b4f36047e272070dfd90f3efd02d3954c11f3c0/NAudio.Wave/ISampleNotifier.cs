using System;

namespace NAudio.Wave;

public interface ISampleNotifier
{
	event EventHandler<SampleEventArgs> Sample;
}
