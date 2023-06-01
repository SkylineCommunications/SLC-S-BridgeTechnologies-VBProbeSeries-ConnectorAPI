namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries
{
	using System;
	using System.Collections.Generic;

	using Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.Ethernet;
	using Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.OTT;
	using Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.StrobeManager;

	public static class InterApp
	{
		public static List<Type> KnownTypes { get; } = new List<Type>
		{
			// Alarm Thresholds
			////typeof(CreateEthThreshold),
			////typeof(CreateEthThresholdResult),
			////typeof(EditEthThreshold),
			////typeof(EditEthThresholdResult),
			////typeof(DeleteEthThresholds),
			////typeof(DeleteEthThresholdsResult),

			////typeof(CreateEtrThreshold),
			////typeof(CreateEtrThresholdResult),
			////typeof(EditEtrThreshold),
			////typeof(EditEtrThresholdResult),
			////typeof(DeleteEtrThresholds),
			////typeof(DeleteEtrThresholdsResult),

			////typeof(CreatePidThreshold),
			////typeof(CreatePidThresholdResult),
			////typeof(EditPidThreshold),
			////typeof(EditPidThresholdResult),
			////typeof(DeletePidThresholds),
			////typeof(DeletePidThresholdsResult),
			////typeof(CreateSubPidThreshold),
			////typeof(CreateSubPidThresholdResult),
			////typeof(EditSubPidThreshold),
			////typeof(EditSubPidThresholdResult),
			////typeof(DeleteSubPidThresholds),
			////typeof(DeleteSubPidThresholdsResult),

			// Ethernet
			typeof(CreateEthStream),
			typeof(CreateEthStreamResult),
			typeof(EditEthStream),
			typeof(EditEthStreamResult),
			typeof(DeleteEthStreams),
			typeof(DeleteEthStreamsResult),

			// OTT
			typeof(CreateOttChannel),
			typeof(CreateOttChannelResult),
			typeof(EditOttChannel),
			typeof(EditOttChannelResult),
			typeof(DeleteOttChannels),
			typeof(DeleteOttChannelsResult),

			// Strobe Manager
			typeof(CreateBtStrobeMgrFilter),
			typeof(RemoveBtStrobeMgrFilter),
		};
	}
}
