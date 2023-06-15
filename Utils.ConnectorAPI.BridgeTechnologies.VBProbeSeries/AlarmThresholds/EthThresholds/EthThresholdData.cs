namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.EthThresholds
{
	public class EthThresholdData
	{
		public string Name { get; set; }

		public string MdiError { get; set; }

		public string MdiWarning { get; set; }

		public double? MaxBitRateError { get; set; }

		public double? MinBitRateError { get; set; }

		/// <summary>
		/// Allows to configure when alarm of type "No signal" should be raised by the probe. Delay should be inputed in milliseconds (ms).
		/// </summary>
		public int? NoSignalDelay { get; set; }

		public int? RtpLossLimit { get; set; }

		public string IgnoreCcPids { get; set; }
	}
}
