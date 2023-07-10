namespace Skyline.DataMiner.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.PidThresholdsPresets
{
	public class PidThresholdPresetData
	{
		#region preset
		public PresetType? Type { get; set; }

		/// <summary>
		/// The ID of the PIDs this preset relates to.
		/// </summary>
		public string Pid { get; set; }

		/// <summary>
		/// The description of the PIDs this preset relates to.
		/// </summary>
		public string PidDescription { get; set; }

		/// <summary>
		/// Allows to enable/disable the PID presence check.
		/// </summary>
		public bool? RequirePresence { get; set; }

		/// <summary>
		/// The required language for this preset.
		/// </summary>
		public string RequiredLanguage { get; set; }

		public Scrambling? MonitorScrambling { get; set; }
		#endregion

		#region Min Bit Rate
		/// <summary>
		/// Allows to enable/disable the Min Bit Rate check.
		/// </summary>
		public bool? MonitorMinBitRate { get; set; }

		/// <summary>
		/// The min bandwidth allowed for the PID in kbps.
		/// </summary>
		public double? MinBitRateValue { get; set; }
		#endregion

		#region Max Bit Rate
		/// <summary>
		/// Allows to enable/disable the Max Bit Rate check.
		/// </summary>
		public bool? MonitorMaxBitRate { get; set; }

		/// <summary>
		/// The max bandwidth allowed for the PID in Mbps.
		/// </summary>
		public double? MaxBitRateValue { get; set; }
		#endregion

		#region Ignore
		/// <summary>
		/// Allows to configure when PCR Errors should be ignored via schedule name.
		/// </summary>
		public string IgnorePcrErrorsSchedule { get; set; }

		/// <summary>
		/// Allows to configure when CC Errors should be ignored via schedule name.
		/// </summary>
		public string IgnoreCcErrors { get; set; }

		/// <summary>
		/// Allows to configure when Missing Pid Errors should be ignored via schedule name.
		/// </summary>
		public string IgnoreMissingPidAlarm { get; set; }

		/// <summary>
		/// Allows to configure when Unreferenced Errors should be ignored via schedule name.
		/// </summary>
		public string IgnoreUnreferencedPidAlarm { get; set; }

		/// <summary>
		/// Allows to configure when All Errors should be ignored via schedule name.
		/// </summary>
		public string IgnoreAll { get; set; }
		#endregion
	}
}
