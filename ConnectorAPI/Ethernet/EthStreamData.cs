namespace Skyline.DataMiner.ConnectorAPI.BridgeTechnologies.VBProbeSeries.Ethernet
{
	public class EthStreamData
	{
		public string Name { get; set; }

		public string Address { get; set; }

		public string Port { get; set; }

		public string VLanId { get; set; }

		public int? Page { get; set; }

		// Page property is used both for page and dispPage attributes to keep them in sync
		////public string DisplayPage { get; set; }

		public string EtrThresholds { get; set; }

		public string ServiceThresholds { get; set; }

		public string PidThresholds { get; set; }

		public string ReferenceThresholds { get; set; }

		public string VbcThresholds { get; set; }

		public string EthThresholds { get; set; }

		public bool? Join { get; set; }

		public string JoinInterface { get; set; }

		public bool? IsEtrEnabled { get; set; }

		public string EtrEngine { get; set; }

		public bool? IsFecEnabled { get; set; }

		public string T2miStream { get; set; }

		public string T2miPid { get; set; }

		public string T2miPlpId { get; set; }

		public string Dash7Stream1 { get; set; }

		public string Dash7Stream2 { get; set; }

		public string SsmAddress { get; set; }

		public string SsmName { get; set; }

		public string SsmAddress2 { get; set; }

		public string SsmName2 { get; set; }

		public string SsmAddress3 { get; set; }

		public string SsmName3 { get; set; }

		public string SsmAddress4 { get; set; }

		public string SsmName4 { get; set; }

		public string SsmAddress5 { get; set; }

		public string SsmName5 { get; set; }

		public bool? IsSrtEnabled { get; set; }

		public string SrtHost { get; set; }

		public int? SrtPort { get; set; }

		public SrtMode? SrtMode { get; set; }

		public string SrtPassphrase { get; set; }

		public int? SrtLatency { get; set; }

		public string ContentThresholds { get; set; }
	}
}
