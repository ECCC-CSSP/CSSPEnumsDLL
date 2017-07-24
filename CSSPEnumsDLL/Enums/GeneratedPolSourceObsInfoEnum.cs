using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPEnumsDLL.Enums
{
    public enum PolSourceObsInfoEnum
    {
        Error = 0,

        Start = 10100,
        LandBased = 10101,
        WaterBased = 10102,

        DistanceFromShoreInMetersStart = 10200,
        DistanceFromShoreInMetersOnShore = 10201,
        DistanceFromShoreInMetersLessThan100 = 10202,
        DistanceFromShoreInMetersBetween100And250 = 10203,
        DistanceFromShoreInMetersBetween250And500 = 10204,
        DistanceFromShoreInMetersBetween500And1000 = 10205,
        DistanceFromShoreInMetersMoreThan1000 = 10206,

        DistanceOnWaterMetersStart = 10300,
        DistanceOnWaterMetersLessThan100 = 10301,
        DistanceOnWaterMetersBetween100And250 = 10302,
        DistanceOnWaterMetersBetween250And500 = 10303,
        DistanceOnWaterMetersBetween500And1000 = 10304,
        DistanceOnWaterMetersMoreThan1000 = 10305,

        AreaSlopeStart = 10400,
        AreaSlopeLow = 10401,
        AreaSlopeMedium = 10402,
        AreaSlopeHigh = 10403,

        SourceTypeLandStart = 10500,
        SourceTypeLandAgriculture = 10501,
        SourceTypeLandForested = 10502,
        SourceTypeLandIndustry = 10503,
        SourceTypeLandMarine = 10504,
        SourceTypeLandRecreation = 10505,
        SourceTypeLandUrban = 10506,
        SourceTypeShore = 10507,

        AgricultureStart = 10600,
        AgricultureCrop = 10601,
        AgriculturePasture = 10602,
        AgricultureFeedlot = 10603,
        AgricultureFarm = 10604,
        AgricultureBuilding = 10605,

        CropStart = 10700,
        CropFood = 10701,
        CropHay = 10702,
        CropPeatMoss = 10703,

        PastureStart = 10800,
        PastureActive = 10801,
        PastureFallow = 10802,

        FeedlotStart = 10900,
        FeedlotActive = 10901,
        FeedlotNotActive = 10902,

        FarmStart = 11000,
        FarmHobby = 11001,
        FarmCommerical = 11002,

        ForestedStart = 11100,
        ForestedLoggingActivity = 11101,
        ForestedClearcut = 11102,
        ForestedRegrowth = 11103,
        ForestedBuilding = 11104,

        IndustryStart = 11200,
        IndustryAirport = 11201,
        IndustryLandfill = 11202,
        IndustryFisheriesRelated = 11203,
        IndustryWaste = 11204,
        IndustryStorageTank = 11205,
        IndustryCommercial = 11206,

        TypeOfFishStart = 11300,
        FishProcessingShellfish = 11301,
        FishProcessingFinfish = 11302,
        FishProcessingFishMeal = 11303,

        MarineStart = 11400,
        MarineWharf = 11401,
        MarineBuildings = 11402,
        MarineSeaWall = 11403,

        WharfStart = 11500,
        WharfCommercialTransportation = 11501,
        WharfFishing = 11502,
        WharfPrivate = 11503,
        WharfMarina = 11504,
        WharfAbandoned = 11505,

        WharfTransportationStart = 11600,
        TransportationCommerical = 11601,
        TransportationFerry = 11602,

        RecreationStart = 11700,
        RecreationCampground = 11701,
        RecreationDayUseArea = 11702,
        RecreationSwimmingArea = 11703,
        RecreationRecreationaltArea = 11704,
        RecreationCommunityCentre = 11705,
        RecreationGolfCourse = 11706,

        CampgroundFacilitiesStart = 11800,
        CampgroundNoDumpStn = 11801,
        CampgroundwithDumpStn = 11802,

        SewageStart = 11900,
        SewageCesspool = 11901,
        SewageDirectDischarge = 11902,
        SewagePrivyOuthouse = 11903,
        SewageMunicipalSystem = 11904,
        SepticSystemDrainageField = 11905,
        SepticSystemFullRention = 11906,
        SepticSystemLagoon = 11907,
        SepticNoStructure = 11908,

        SeeMunicipalityInfrastructureStart = 12000,

        UrbanStart = 12100,
        UrbanStormWater = 12104,
        UrbanSurfaceRunoff = 12106,
        UrbanDumpStation = 12107,

        WildlifeStart = 12200,
        WildlifeBirds = 12201,
        WildlifeLandMammals = 12202,
        WildlifeMarineMammals = 12203,

        MunicipalSystemStart = 12300,
        MuncipialSystemConnected = 12301,
        MunicipalSystemNotConnected = 12302,

        StorageTankStart = 12400,
        StorageTankFuel = 12401,
        StorageTankPropane = 12402,
        StorageTankChemicals = 12403,

        TankSizeStart = 12500,
        TankSizeSmall = 12501,
        TankSizeLarge = 12502,

        BuildingAgricultureStart = 12600,
        BuildingResidentialFarm = 12601,
        BuildingWarehouseFarm = 12602,
        BuildingCommericalFarm = 12603,
        BuildingBarnFarm = 12604,
        BuildingRecreational = 12605,

        BuildingForestedStart = 12700,
        BuildingForestedResidential = 12701,
        BuildingForestedWarehouse = 12702,
        BuildingForestedRecreational = 12703,
        BuildingForestedTrailer = 12704,
        BuildingForestedFactory = 12705,
        BuildingForestedCommerical = 12706,

        BuildingTypeStart = 12800,
        BuildingindustryWarehouse = 12801,
        BuildingIndustryFactory = 12802,
        BuildingIndustryCommerical = 12803,

        BuildingFishStart = 12900,
        BuildingFishHatchery = 12901,
        BuildingFishTanks = 12902,
        BuildingFishWarehouse = 12903,
        BuildingFishCommercial = 12904,

        BuildingAllStart = 13000,
        BuildingAllCottage = 13001,
        BuildingAllTrailer = 13002,
        BuildingAllResidential = 13003,
        BuildingAllWarehouse = 13004,
        BuildingAllHotelMotel = 13005,
        BuildingAllCommerical = 13006,

        CountNumberStart = 13100,
        CountNumberEqualTo1 = 13101,
        CountNumberBetween1and5 = 13102,
        CountNumberbBetween5and10 = 13103,
        CountNumberbBetween10and25 = 13104,
        CountNumberbBetween25and40 = 13105,
        CountNumberGreaterThan40 = 13106,

        AreaSizeStart = 13200,
        AreaSizeSmall = 13201,
        AreaSizeLarge = 13202,

        FecalSourceStart = 13300,
        FecalSourceLivestock = 13301,
        FecalSourcePeople = 13302,
        FecalSourceWildlife = 13303,
        FecalSourceAbsent = 13304,
        FecalSourceDrainagewater = 13305,

        MajorIssueSourceStart = 13400,
        MajorIssueSourceManurePile = 13401,
        MajorIssueAbsent1 = 13402,
        MajorIssueRunoff = 13403,

        LandfillTypeStart = 13500,
        LandfillTypeResidental = 13501,
        LandfillTypeIndustrial = 13502,
        LandfillTypeWoodwaste = 13503,

        NumberPresentStart = 13600,
        NumberPresentLessThan5 = 13601,
        NumberPresentBetween5and10 = 13602,
        NumberPresentBetween10and25 = 13603,
        NumberPresentGreaterThan25 = 13604,

        TypesOfLivestockStart = 13700,
        TypesEqualLargeDomestic = 13701,
        TypesEqualSmallDomestic = 13702,
        TypesEqualDomesticBirds = 13703,
        TypesEqualFurFarms = 13704,
        TypesEqualDomesticMixture = 13705,

        TypesOfWildlifeStart = 13800,
        TypesEqualSmallWildAnimals = 13801,
        TypesEqualLargeWildAnimals = 13802,
        TypesEqualLargeBirds = 13803,
        TypesEqualMediumBirds = 13804,
        TypesEqualSmallBirds = 13805,

        AnimalNumberPresentStart = 13900,
        NumberAnimalPresentLessThan5 = 13901,
        NumberAnimalPresentBetween5and10 = 13902,
        NumberAnimalPresentBetween10and25 = 13903,
        NumberAnimalPresentBetween25and100 = 13904,
        NumberAnimalPresentGreaterThan100 = 13905,

        PointSourceWildlifeStart = 16600,
        SourceDirectInputToMarine = 16601,

        BoatStart = 14000,
        BoatCountEquals1 = 14001,
        BoatCountLessThan5 = 14002,
        BoatCountBetween5and25 = 14003,
        BoatCountBetween25and50 = 14004,
        BoatCountBetween50and100 = 14005,
        BoatCountBetweenMoreThan100 = 14006,

        OilDumpingFacilityStart = 14100,
        OilDumpingFacilityPresent = 14101,
        OilDumpingFacilityAbsent = 14102,

        SewageDumpingStationStart = 14200,
        SewageDumpingStationPresent = 14201,
        SewageDumpingStationAbsent = 14202,

        PointSourceStart = 14300,
        SourceTypeLandCulvert = 14301,
        SourceTypeLandPipe = 14302,
        SourceTypeLandWaterCourse = 14303,
        SourceTypeLandDitch = 14304,
        SourceTypeLandDrainage = 14305,
        SourceTypeDirectInputToMarine = 14306,

        PointSourceManureStart = 14400,
        SourceManureLandDrainage = 14401,
        SourceManureDitch = 14402,

        DiameterInCentimetersStart = 14500,
        DiameterInCentimetersLessThan30 = 14501,
        DiameterInCentimetersBetween30and100cm = 14502,
        DiameterInCentimetersBetween100and200cm = 14503,
        DiameterInCentimetersMoreThan200cm = 14504,

        FlowLevelStart = 14600,
        FlowLevelHigh = 14601,
        FlowLevelMedium = 14602,
        FlowLevelLow = 14603,

        OuthouseStart = 14700,
        OuthouseCementHoldingTank = 14701,
        OuthouseSittingOnGround = 14702,

        WidthInMetersStart = 14800,
        WidthInMetersLessThan1 = 14801,
        WidthInMetersBetween1And5 = 14802,
        WidthInMetersBetween5And25 = 14803,
        WidthInMetersMoreThan25 = 14804,

        DitchStart = 14900,
        DitchAlongRoad = 14901,
        DitchBetweenAcrossProperties = 14902,

        DrainageStart = 15000,
        DrainagePavedSurfaces = 15001,
        DrainageVegetatedSurfaces = 15002,
        DrainageDirect = 15003,
        DrainageBareSoilSurfaces = 15004,

        ManurePileSizeStart = 15100,
        ManurePileSmall = 15101,
        ManurePileLarge = 15102,

        SourceTypeWaterStart = 15200,
        SourceTypeWaterAquacultureSite = 15201,
        SourceTypeWaterAnchorageMooringSite = 15202,
        SourceTypeWaterDisposalAtSea = 15203,
        SourceTypeWaterMarinePark = 15204,
        SourceTypeWaterSeaport = 15205,
        SourceSandBar = 15206,

        WaterAquacultureStart = 15300,
        WaterAquacultureSiteActive = 15301,
        WaterAquacultureSiteFallow = 15302,

        WaterAquacultureTypeStart = 15400,
        AquacultureCages = 15401,
        AquacultureFloatingBags = 15402,
        AquacultureSubmergedLines = 15403,

        WaterStructureSiteStart = 15500,
        WaterStructureVessel = 15501,
        WaterStructureBarge = 15502,
        WaterStructureResidental = 15503,
        WaterStructureCommercial = 15504,
        WaterStructureNotActive = 15505,

        WaterDisposalAtSeaStart = 15600,
        WaterDumpSiteActive = 15601,
        WaterDumpSiteNotActive = 15602,

        WaterSeaportStart = 15700,
        SeaportRecreational = 15701,
        SeaportCommercial = 15702,

        WaterSizeStart = 15800,
        AquacultureSmall = 15801,
        AquacultureLarge = 15802,

        WaterTypeStart = 15900,
        WaterTypeSalt = 15901,
        WaterTypeBrachish = 15902,
        WaterTypeFresh = 15903,

        WaterAreaSizeStart = 16000,
        WaterAreaSizeSmall = 16001,
        WaterAreaSizeLarge = 16002,

        WaterFecalSourceStart = 16100,
        WaterFecalSourcePeople = 16101,
        WaterFecalSourceWildlife = 16102,
        WaterFecalSourceAbsent = 16103,

        WaterCountNumberStart = 16200,
        WaterCountNumberLessThan5 = 16201,
        WaterCountNumberBetween5and10 = 16202,
        WaterCountNumberBetween10and25 = 16203,
        WaterCountNumberGreaterThan25 = 16204,

        WaterSewageStart = 16300,
        WaterSewageDirectDischarge = 16301,
        WaterSepticSystemFullRention = 16302,

        WaterNumberPresentStart = 16400,
        WaterNumberPresentLessThan5 = 16401,
        WaterNumberPresentBetween5and10 = 16402,
        WaterNumberPresentBetween10and25 = 16403,
        WaterNumberPresentGreaterThan25 = 16404,

        WaterTypesOfMarineLifeStart = 16500,
        WaterTypesEqualSmallMammals = 16501,
        WaterTypesEqualLargeMammals = 16502,
        WaterTypesEqualLargeBirds = 16503,
        WaterTypesEqualMediumBirds = 16504,
        WaterTypesEqualSmallBirds = 16505,

        ShorelineStart = 17000,
        ShorelineSandy = 17001,
        ShorelineRocky = 17002,

        ShorelineIssueStart = 17100,
        ShorelineBuildings = 17101,
        ShorelineWildlife = 17102,
        ShorelineLandFill = 17103,
        ShorelineSlipway = 17104,
        ShorelineDayuse = 17105,

        SlipwayStart = 18000,
        SlipwayPaved = 18001,
        SlipwayRocks = 18002,

        SourceTypeShoreStart = 19000,
        SourceTypeShoreline = 19001,
        SourceTypeMarine = 19002,

        StatusStart = 90000,
        StatusDefinite = 90001,
        StatusPotential = 90002,
        StatusNonPollutionSource = 90003,

        RiskAStart = 91000,
        RiskLow = 91001,

        RiskBStart = 92000,
        RiskModerate = 92001,
        RiskHighP = 92002,

        RiskCStart = 93000,
        RiskHigh = 93001,
    }
}
