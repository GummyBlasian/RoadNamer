﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadNamer
{
    // Taken from https://github.com/PropaneDragon/Cimtographer
    public enum RoadTypes
    {
        None,
        ZonablePedestrianGravel,
        ZonablePedestrianPavement,
        ZonablePedestrianElevated,
        PedestrianConnection,
        PedestrianConnectionInside,
        PedestrianConnectionSurface,
        PedestrianGravel,
        PedestrianPavement,
        PedestrianPavementBicycle,
        PedestrianPavementBicycleElevated,
        PedestrianSlope,
        PedestrianSlopeBicycle,
        PedestrianTunnel,
        PedestrianTunnelBicycle,
        PedestrianElevatedBicycle,
        PedestrianElevated,

        BusLine,
        MetroLine,
        TrainLine,
        TrainCargoTrack,
        TrainCargoTrackTunnel,
        TrainCargoTrackElevated,

        BasicRoad,
        BasicRoadDecorationTrees,
        BasicRoadDecorationGrass,
        BasicRoadBridge,
        BasicRoadElevated,
        BasicRoadElevatedBike,
        BasicRoadTunnel,
        BasicRoadSlope,
        HarborRoad,
        SmallBusway,
        SmallBuswayDecorationGrass,
        SmallBuswayDecorationTrees,
        SmallBuswayElevated,
        SmallBuswayOneWay,
        SmallBuswayOneWayDecorationGrass,
        SmallBuswayOneWayDecorationTrees,
        SmallBuswayOneWayElevated,
        SmallBuswayOneWaySlope,
        SmallBuswayOneWayTunnel,
        SmallBuswayOneWayBridge,
        SmallBuswaySlope,
        SmallBuswayTunnel,
        SmallBuswayBridge,
        SmallAvenue,
        SmallRuralHighway,
        OnewayRoad,
        OnewayRoadDecorationTrees,
        OnewayRoadDecorationGrass,
        OnewayRoadElevated,
        OnewayRoadBridge,
        OnewayRoadSlope,
        OnewayRoadTunnel,
        Oneway3L,
        Oneway4L,
        LargeOneway,
        LargeOnewayDecorationGrass,
        LargeOnewayDecorationTrees,
        LargeOnewayBridge,
        LargeOnewayElevated,
        LargeOnewayRoadSlope,
        MediumRoad,
        MediumRoadBicycle,
        MediumRoadBus,
        MediumRoadElevated,
        MediumRoadElevatedBike,
        MediumRoadElevatedBus,
        MediumRoadSlope,
        MediumRoadSlopeBike,
        MediumRoadSlopeBus,
        MediumRoadDecorationGrass,
        MediumRoadDecorationTrees,
        MediumRoadBridge,
        MediumRoadTunnel,
        MediumRoadTunnelBike,
        MediumRoadTunnelBus,
        MediumAvenue,
        MediumAvenueTL,
        LargeRoad,
        LargeRoadBicycle,
        LargeRoadBridge,
        LargeRoadBus,
        LargeRoadDecorationGrass,
        LargeRoadDecorationGrassWithBusLanes,
        LargeRoadDecorationTrees,
        LargeRoadDecorationTreesWithBusLanes,
        LargeRoadElevated,
        LargeRoadElevatedBike,
        LargeRoadElevatedBus,
        LargeRoadElevatedWithBusLanes,
        LargeRoadSlope,
        LargeRoadSlopeBus,
        LargeRoadSlopeWithBusLanes,
        LargeRoadTunnel,
        LargeRoadTunnelBus,
        LargeRoadTunnelWithBusLanes,
        LargeRoadWithBusLanes,
        LargeHighway,
        LargeHighwayElevated,
        LargeHighwaySlope,
        LargeHighwayTunnel,
        GravelRoad,

        TrainTrack,
        MetroTrack,
        MetroStationTrack,
        TrainStationTrack,
        TrainTrackBridge,
        TrainTrackElevated,
        TrainTrackSlope,
        TrainTrackTunnel,
        OnewayTrainTrack,
        OnewayTrainTrackElevated,
        OnewayTrainTrackSlope,
        OnewayTrainTrackTunnel,
        OnewayTrainTrackBridge,
        StationTrackEleva,
        StationTrackSunken,
        TrainConnectionTrack,
        RuralHighway,
        RuralHighwayElevated,
        RuralHighwaySlope,
        RuralHighwayTunnel,
        Highway,
        HighwayBridge,
        HighwayElevated,
        HighwayRamp,
        HighwayRampSlope,
        HighwayRampElevated,
        HighwayRampTunnel,
        HighwaySlope,
        HighwayTunnel,
        HighwayBarrier,

        AirplaneTaxiway,
        AirplaneRunway,
        Dam,
    }
}
