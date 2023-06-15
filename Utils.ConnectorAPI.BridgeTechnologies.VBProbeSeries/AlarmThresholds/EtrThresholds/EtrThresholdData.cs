namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.EtrThresholds
{
	public class EtrThresholdData
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public EtrAnalyzingMode? AnalyzingMode { get; set; }

		/// <summary>
		/// Time (in seconds) the probe will be tuned to the frequency to check the ETR 290 parameters.
		/// </summary>
		public int? TuningDuration { get; set; }

		/// <summary>
		/// The probe will only be tuned to the frequency for this long (in seconds) when sync is not found.
		/// </summary>
		public int? SyncLossTuningDuration { get; set; }

		/// <summary>
		/// Minimum gap (in milliseconds) between the last TS packet of the previous section and the first packet of the following session.
		/// </summary>
		public int? MinSectionGap { get; set; }

		/// <summary>
		/// Time needed (in seconds) with positive results before an error is cleared.
		/// </summary>
		public int? ErrorTimeout { get; set; }
	}
}
