namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.OTT
{
	public class OttChannelData
	{
		public string Name { get; set; }

		public int? Engine { get; set; }

		public bool? Enable { get; set; }

		public string Address { get; set; }

		public string ContentThreshold { get; set; }

		public string VbcThreshold { get; set; }

		public string Threshold { get; set; }

		public string PlayerUrl { get; set; }

		public int? RoundTime { get; set; }

		public int? Page { get; set; }

		public int? MeasurementMode { get; set; }

		public int? LiveTargetSegment { get; set; }

		public bool? Rtmp { get; set; }

		public bool? RtmpLive { get; set; }

		public bool? NoMasterMonitor { get; set; }

		public bool? ExtractThumbnails { get; set; }

		public bool? Alignment { get; set; }

		public int? DrmSystem { get; set; }

		public string DrmHostname { get; set; }

		public string DrmUsername { get; set; }

		public string DrmPassword { get; set; }

		public string AccountId { get; set; }

		public string ContentId { get; set; }

		public int? CryptoPeriod { get; set; }

		public string FixedKey { get; set; }

		public string FixedIv { get; set; }

		public bool? AdvancedManifest { get; set; }

		public string Method { get; set; }

		public string ContentType { get; set; }
	}
}
