namespace NAudio.Wave;

internal enum AcmMetrics
{
	CountDrivers = 1,
	CountCodecs = 2,
	CountConverters = 3,
	CountFilters = 4,
	CountDisabled = 5,
	CountHardware = 6,
	CountLocalDrivers = 20,
	CountLocalCodecs = 21,
	CountLocalConverters = 22,
	CountLocalFilters = 23,
	CountLocalDisabled = 24,
	HardwareWaveInput = 30,
	HardwareWaveOutput = 31,
	MaxSizeFormat = 50,
	MaxSizeFilter = 51,
	DriverSupport = 100,
	DriverPriority = 101
}
