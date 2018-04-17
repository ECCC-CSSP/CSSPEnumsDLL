using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSPEnumsDLL.Tests.SetupInfo;
using System.Globalization;
using System.Threading;
using CSSPEnumsDLL.Services;
using CSSPEnumsDLL.Services.Resources;
using CSSPEnumsDLL.Enums;

namespace CSSPEnumsDLL.Tests.Services
{
    public partial class BaseEnumServiceTest
    {
        [TestMethod]
        public void BaseService_GetEnumText_PolSourceObsInfoEnum_Test()
        {
            foreach (CultureInfo culture in setupData.cultureListGood)
            {
                SetupTest(culture);

                string retStr = baseEnumService.GetEnumText_PolSourceObsInfoEnum(null);
                Assert.AreEqual(BaseEnumServiceRes.Empty, retStr);
                string retStrDesc = baseEnumService.GetEnumText_PolSourceObsInfoDescEnum(null);
                Assert.AreEqual(BaseEnumServiceRes.Empty, retStrDesc);
                string retStrReport = baseEnumService.GetEnumText_PolSourceObsInfoReportEnum(null);
                Assert.AreEqual(BaseEnumServiceRes.Empty, retStrReport);
                string retStrText = baseEnumService.GetEnumText_PolSourceObsInfoTextEnum(null);
                Assert.AreEqual(BaseEnumServiceRes.Empty, retStrText);

                foreach (int i in Enum.GetValues(typeof(PolSourceObsInfoEnum)))
                {
                    retStr = baseEnumService.GetEnumText_PolSourceObsInfoEnum((PolSourceObsInfoEnum)i);
                    retStrDesc = baseEnumService.GetEnumText_PolSourceObsInfoDescEnum((PolSourceObsInfoEnum)i);
                    retStrReport = baseEnumService.GetEnumText_PolSourceObsInfoReportEnum((PolSourceObsInfoEnum)i);
                    retStrText = baseEnumService.GetEnumText_PolSourceObsInfoTextEnum((PolSourceObsInfoEnum)i);

                    switch ((PolSourceObsInfoEnum)i)
                    {
                        case PolSourceObsInfoEnum.Error:
                        {
                            Assert.AreEqual(BaseEnumServiceRes.Error, retStr);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgriculturalSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturalSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturalSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureManagementStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FieldLocationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFeedlotStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFeedlotStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FisheriesSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishOperationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeMultipleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundFacilitiesStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundFacilitiesStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundFacilitiesStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfAnimalStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgSingleTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalNumberPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalNumberPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WastewaterDumpingStationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSourcesOfContaminantStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazardousLevelStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwayRouteFirstStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayRouteFirstStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayRouteFirstStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwayRouteSecondPipeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayRouteSecondPipeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayRouteSecondPipeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayRouteSecondCulvertStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayRouteSecondCulvertStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparionZoneStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparionZoneStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparionZoneStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughWaterCourseStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughWaterCourseStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughWaterCourseStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseDistStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseDistStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseDistStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SecondaryHazardousLevelStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SuggestedRiskStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FollowUpStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowUpStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowUpStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypeOfSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterwayWidthInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StreamVolSqMeterStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat10mStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat10mStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat10mStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14Start, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureDiameterStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameterStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameterStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEIStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEIStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEIStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthTideStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthTideStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthTideStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthTideStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthTideStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthTideStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthTideStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthTideStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthTideStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthTideStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthTideStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthTideStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAreaWidthTideStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAreaWidthTideStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAreaWidthTideStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactZoneStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceHumanLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceHumanLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceHumanLandReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceHumanMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceHumanMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceHumanMarineReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceAnimal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceAnimal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceAnimalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceEffluentLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceEffluentLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceEffluentLandReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceEffluentMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceEffluentMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceEffluentMarineReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleResidential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleResidential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleResidentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleResidentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleCottage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCottage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCottageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCottageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleBarn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBarn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBarnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBarnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSinglePublicBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglePublicBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglePublicBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglePublicBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleSchool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleSchool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleSchoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleSchoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleChurch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleChurch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleChurchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleChurchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleMedicalFacility:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleMedicalFacility, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleMedicalFacilityReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleMedicalFacilityText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleOuthouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleOuthouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleOuthouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleOuthouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSinglehotelMotel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglehotelMotel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglehotelMotelReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglehotelMotelText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleBoatM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBoatM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBoatMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBoatMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleBargeM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBargeM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBargeMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBargeMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSinglehotelMotelM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglehotelMotelM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglehotelMotelMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglehotelMotelMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleResidentialM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleResidentialM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleResidentialMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleResidentialMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleCottageM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCottageM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCottageMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCottageMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleWarehouseM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleWarehouseM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleWarehouseMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleWarehouseMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleCommericalM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCommericalM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCommericalMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleCommericalMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleFishPlant:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleFishPlant, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleFishPlantReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleFishPlantText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleResidences:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleResidences, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleResidencesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleResidencesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleCottages:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCottages, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCottagesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCottagesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleTrailers:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleTrailers, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleTrailersReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleTrailersText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleWarehouses:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleWarehouses, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleWarehousesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleWarehousesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleCommericals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCommericals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCommericalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCommericalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleBarns:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBarns, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBarnsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBarnsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultiplePublicBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultiplePublicBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultiplePublicBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultiplePublicBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleSchools:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleSchools, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleSchoolsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleSchoolsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleChurches:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleChurches, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleChurchesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleChurchesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleMedicalFacilities:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleMedicalFacilities, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleMedicalFacilitiesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleMedicalFacilitiesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleOuthouses:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleOuthouses, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleOuthousesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleOuthousesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleHotelsMotels:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleHotelsMotels, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleHotelsMotelsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleHotelsMotelsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleBoatsM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBoatsM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBoatsMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBoatsMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleBargesM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBargesM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBargesMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBargesMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleHotelsMotelsM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleHotelsMotelsM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleHotelsMotelsMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleHotelsMotelsMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleResidencesM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleResidencesM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleResidencesMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleResidencesMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleCottagesM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCottagesM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCottagesMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCottagesMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleWarehousesM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleWarehousesM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleWarehousesMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleWarehousesMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionMultipleCommericalsM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCommericalsM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCommericalsMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleCommericalsMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionSingleFishPlants:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleFishPlants, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleFishPlantsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleFishPlantsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween11and20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween21and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween21and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween21and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween21and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween41and60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween41and60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween41and60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween41and60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween61and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween61and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween61and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween61and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween101and200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween101and200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween101and200Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween101and200Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween201and400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween201and400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween201and400Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween201and400Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberGreaterThan400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan400Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan400Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo1M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo1M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo1MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo1MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo2M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo2M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo2MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo2MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo3M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo3M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo3MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo3MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo4M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo4M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo4MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo4MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo5M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo5M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo5MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo5MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo6M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo6M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo6MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo6MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo7M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo7M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo7MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo7MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo8M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo8M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo8MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo8MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo9M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo9M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo9MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo9MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo10M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo10M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo10MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberEqualTo10MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween11and20M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and20M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and20MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and20MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween21and40M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween21and40M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween21and40MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween21and40MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween41and60M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween41and60M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween41and60MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween41and60MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween61and100M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween61and100M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween61and100MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween61and100MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween101and200M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween101and200M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween101and200MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween101and200MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween201and400M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween201and400M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween201and400MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween201and400MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberGreaterThan400M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan400M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan400MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan400MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationRural:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationRural, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationRuralReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationRuralText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationUrban:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationUrban, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationUrbanReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationUrbanText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationForested:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationForested, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationForestedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationForestedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationAgricultural:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAgricultural, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAgriculturalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAgriculturalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationShorelineMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationShorelineMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationShorelineMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationShorelineMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationWharfMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWharfMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWharfMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWharfMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationBargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationIsland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationIsland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationIslandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationIslandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationRecreationalArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationRecreationalArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationRecreationalAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationRecreationalAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationSeasonalCottageLot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationSeasonalCottageLot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationSeasonalCottageLotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationSeasonalCottageLotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationWetland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWetland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWetlandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWetlandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationFishPlant:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFishPlant, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFishPlantReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFishPlantText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationAquacultureSiteMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAquacultureSiteMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAquacultureSiteMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAquacultureSiteMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationAnchorageMooringSiteMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAnchorageMooringSiteMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAnchorageMooringSiteMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationAnchorageMooringSiteMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationDisposalAtSeaMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationDisposalAtSeaMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationDisposalAtSeaMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationDisposalAtSeaMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationMarineParkMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarineParkMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarineParkMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarineParkMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationMarinaMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarinaMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarinaMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarinaMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationFloatHomeCommunityMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFloatHomeCommunityMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFloatHomeCommunityMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationFloatHomeCommunityMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationMarinaLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarinaLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarinaLandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationMarinaLandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationShorelineLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationShorelineLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationShorelineLandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationShorelineLandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanLocationWharfLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWharfLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWharfLandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanLocationWharfLandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersEquals100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersBetween251And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween251And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween251And500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween251And500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersBetween501And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween501And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween501And1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersBetween501And1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersGreaterThan1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersGreaterThan1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialAreaSizeMetersInFoRequired:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersInFoRequired, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersInFoRequiredReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialAreaSizeMetersInFoRequiredText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseConcreteTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseConcreteTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseConcreteTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseConcreteTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseOnGround:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseOnGround, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseOnGroundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseOnGroundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentForestry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentForestry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentForestryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentForestryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentAgricultureFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAgricultureFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAgricultureFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAgricultureFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentFisheryLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentFisheryLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentFisheryLandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentFisheryLandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentShorelineStructures:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShorelineStructures, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShorelineStructuresReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShorelineStructuresText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentIndustrialTreatment:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentIndustrialTreatment, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentIndustrialTreatmentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentIndustrialTreatmentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentStorageTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentStorageTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentStorageTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentStorageTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentAirport:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAirport, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAirportReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAirportText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentLandfill:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentLandfill, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentLandfillReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentLandfillText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentUrbanRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentUrbanRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentUrbanRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentUrbanRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentRecreation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentRecreation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentRecreationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentRecreationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentAquacultureSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAquacultureSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAquacultureSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAquacultureSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentAnchorageMooringSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAnchorageMooringSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAnchorageMooringSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAnchorageMooringSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentDisposalAtSea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentDisposalAtSea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentDisposalAtSeaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentDisposalAtSeaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentMarina:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentMarina, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentMarinaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentMarinaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentRural:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentRural, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentRuralReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentRuralText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShorelineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgriculturalSourceCrop:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturalSourceCrop, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturalSourceCropReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturalSourceCropText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureSourcePasture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureSourcePasture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureSourcePastureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureSourcePastureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgriculturesourceFeedlot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturesourceFeedlot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturesourceFeedlotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturesourceFeedlotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AriculturalSourcePeatMoss:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAriculturalSourcePeatMoss, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAriculturalSourcePeatMossReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAriculturalSourcePeatMossText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureSourceManure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureSourceManure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureSourceManureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureSourceManureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureManagementPileSpread:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementPileSpread, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementPileSpreadReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementPileSpreadText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureManagementLiqSpread:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementLiqSpread, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementLiqSpreadReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementLiqSpreadText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureManagementBoth:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementBoth, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementBothReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureManagementBothText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FieldLocationOnFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationOnFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationOnFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationOnFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FieldLocationOffFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationOffFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationOffFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationOffFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FieldLocationBoth:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationBoth, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationBothReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationBothText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureFallow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureFallow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureFallowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureFallowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFeedlotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFeedlotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFeedlotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFeedlotNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFeedlotNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFeedlotNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FisheriesSourceShellfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceShellfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceShellfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceShellfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FisheriesSourceFinfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceFinfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceFinfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceFinfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FisheriesSourceLobster:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceLobster, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceLobsterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFisheriesSourceLobsterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishOperationProcessing:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationProcessing, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationProcessingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationProcessingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishOperationHoldingTanks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationHoldingTanks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationHoldingTanksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationHoldingTanksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishOperationPackaging:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationPackaging, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationPackagingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationPackagingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishOperationRearing:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationRearing, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationRearingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationRearingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishOperationFishMeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationFishMeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationFishMealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationFishMealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeSingleProcessingPlant:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleProcessingPlant, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleProcessingPlantReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleProcessingPlantText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeSingleHatchery:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleHatchery, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleHatcheryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleHatcheryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeSinglePond:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSinglePond, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSinglePondReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSinglePondText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeSingleTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeSinglePound:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSinglePound, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSinglePoundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSinglePoundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeSingleAbandoned:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleAbandoned, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleAbandonedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleAbandonedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeSingleWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeSingleWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeMultipleProcessingPlants:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleProcessingPlants, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleProcessingPlantsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleProcessingPlantsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeMultipleHatcheries:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleHatcheries, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleHatcheriesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleHatcheriesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeMultiplePonds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultiplePonds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultiplePondsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultiplePondsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeMultipleTanks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleTanks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleTanksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleTanksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeMultiplePounds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultiplePounds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultiplePoundsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultiplePoundsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeMultipleAbandoned:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleAbandoned, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleAbandonedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleAbandonedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishBuildingTypeMultipleWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishBuildingTypeMultipleWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberBetween25and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberBetween25and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberBetween25and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberBetween25and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSourceWharf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceWharf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceWharfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceWharfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSourceSeaWall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceSeaWall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceSeaWallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceSeaWallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSourceBoatRamp:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceBoatRamp, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceBoatRampReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceBoatRampText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayPaved:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayPaved, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayPavedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayPavedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayRocks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayRocks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayRocksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayRocksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfCommercialTransportation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfCommercialTransportation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfCommercialTransportationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfCommercialTransportationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfFishing:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfFishing, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfFishingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfFishingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfAbandoned:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfAbandoned, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfAbandonedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfAbandonedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountEquals10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountEquals10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountBetwee11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetwee11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetwee11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetwee11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountBetween26and50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetween26and50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetween26and50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetween26and50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountBetween51and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetween51and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetween51and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountBetween51and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountGreaterThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountGreaterThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountGreaterThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountGreaterThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VesselCountNotApplicable:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountNotApplicable, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountNotApplicableReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselCountNotApplicableText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationCommericalSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationCommericalSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationCommericalSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationCommericalSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationFerrySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationFerrySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationFerrySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationFerrySingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationBoatSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBoatSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBoatSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBoatSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationBargeSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBargeSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBargeSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBargeSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationFerry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationFerry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationFerryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationFerryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationPleasureCraft:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationPleasureCraft, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationPleasureCraftReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationPleasureCraftText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationBarges:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBarges, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBargesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationBargesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationRecreation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationRecreation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationRecreationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationRecreationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarWhfCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCampground:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampground, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampgroundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampgroundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationDayUseArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationSwimmingArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationGolfCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCampgroundSewage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampgroundSewage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampgroundSewageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampgroundSewageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationDayUseAreaSewage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseAreaSewage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseAreaSewageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseAreaSewageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationSwimmingAreaSewage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingAreaSewage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingAreaSewageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingAreaSewageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationGolfCourseSewage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseSewage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseSewageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseSewageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECCountNumber10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECCountNumber30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECCountNumber50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECCountNumber100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECCountNumber200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber200Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber200Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECCountNumber300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber300Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber300Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECCountNumber500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECCountNumber500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundNoDumpStn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundWithDumpStn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundWithDumpStn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundWithDumpStnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundWithDumpStnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundNoDumpStnSewage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnSewage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnSewageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnSewageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundWithDumpStnSewage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundWithDumpStnSewage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundWithDumpStnSewageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundWithDumpStnSewageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanAccumulatedFlow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanAccumulatedFlow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanAccumulatedFlowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanAccumulatedFlowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanWastewaterDumpStation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanWastewaterDumpStation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanWastewaterDumpStationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanWastewaterDumpStationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSize400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize400Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize400Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSize2000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize2000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize2000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize2000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSize4000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize4000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize4000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize4000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSize8000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize8000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize8000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize8000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeResidental:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeResidental, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeResidentalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeResidentalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeIndustrial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeIndustrial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeIndustrialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeIndustrialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeWoodwaste:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeWoodwaste, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeWoodwasteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeWoodwasteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfAnimalLivestock:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalLivestock, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalLivestockReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalLivestockText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfAnimalWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfAnimalMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockHorses:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockHorses, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockHorsesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockHorsesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockCows:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockCows, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockCowsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockCowsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockSheep:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockSheep, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockSheepReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockSheepText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockPigs:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockPigs, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockPigsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockPigsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockMixtureLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockMixtureLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockMixtureLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockMixtureLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockChickens:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockChickens, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockChickensReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockChickensText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockTurkeys:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockTurkeys, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockTurkeysReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockTurkeysText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockDucks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockDucks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockDucksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockDucksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockMixtureSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockMixtureSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockMixtureSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockMixtureSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockFurFarms:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockFurFarms, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockFurFarmsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockFurFarmsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeCrows:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeCrows, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeCrowsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeCrowsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeGulls:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeGulls, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeGullsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeGullsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeEagle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeEagle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeEagleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeEagleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeUngulate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeUngulate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeUngulateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeUngulateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeCoyote:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeCoyote, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeCoyoteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeCoyoteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeGeneral:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeGeneral, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeGeneralReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeGeneralText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeBeaver:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeBeaver, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeBeaverReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeBeaverText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeMuskrat:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeMuskrat, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeMuskratReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeMuskratText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationRuralDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRuralDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRuralDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRuralDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationUrbanDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationUrbanDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationUrbanDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationUrbanDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationForestedDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationForestedDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationForestedDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationForestedDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationAgriculturalDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationAgriculturalDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationAgriculturalDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationAgriculturalDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationFarmDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFarmDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFarmDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFarmDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationShorelineDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationShorelineDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationShorelineDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationShorelineDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationWharfDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWharfDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWharfDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWharfDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationBargeDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationBargeDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationBargeDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationBargeDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationIslandDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationIslandDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationIslandDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationIslandDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationRecreationalAreaDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRecreationalAreaDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRecreationalAreaDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRecreationalAreaDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationCottageLotDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationCottageLotDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationCottageLotDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationCottageLotDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationWetlandDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWetlandDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWetlandDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWetlandDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationWaterCourseDom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWaterCourseDom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWaterCourseDomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWaterCourseDomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationFishPlant:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFishPlant, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFishPlantReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFishPlantText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationRural:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRural, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRuralReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRuralText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationUrban:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationUrban, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationUrbanReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationUrbanText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationForested:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationForested, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationForestedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationForestedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationAgricultural:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationAgricultural, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationAgriculturalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationAgriculturalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationShorelineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationWharf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWharf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWharfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWharfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationBargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationIsland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationIsland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationIslandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationIslandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationRecreationalArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRecreationalArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRecreationalAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationRecreationalAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationCottageLot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationCottageLot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationCottageLotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationCottageLotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationWetland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWetland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWetlandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWetlandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalLocationWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalLocationWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEquals10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEquals10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgEqualsNotApplicable:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEqualsNotApplicable, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEqualsNotApplicableReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgEqualsNotApplicableText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgSingleCages:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleCages, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleCagesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleCagesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgSingleBarn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleBarn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleBarnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleBarnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgSingleBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgMultipleCages:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleCages, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleCagesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleCagesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgMultipleBarns:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleBarns, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleBarnsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleBarnsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgMultipleOtherBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleOtherBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleOtherBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleOtherBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentapprox5000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox5000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox5000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentapprox5000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan10000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan10000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan10000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan10000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan20000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan20000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan20000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan20000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentUnknown:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentUnknown, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentUnknownReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentUnknownText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween11to25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween11to25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween11to25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween11to25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween26to50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween26to50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween26to50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween26to50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween51to75:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween51to75, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween51to75Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween51to75Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween76to100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween76to100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween76to100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween76to100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountGreaterThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountGreaterThan150:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan150, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan150Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan150Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountGreaterThan250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountGreaterThan250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityPresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityPresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityPresentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityPresentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityNotObserved:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityNotObserved, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityNotObservedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityNotObservedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityNotApplicable:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityNotApplicable, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityNotApplicableReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityNotApplicableText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WastewaterDumpingStationPresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationPresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationPresentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationPresentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WastewaterDumpingStationAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WastewaterDumpingStationNotObserved:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationNotObserved, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationNotObservedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWastewaterDumpingStationNotObservedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureSiteActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureSiteFallow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteFallow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteFallowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteFallowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo70:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo70, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo70Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo70Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo90:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo90, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo90Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo90Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberGreaterThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberGreaterThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberGreaterThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberGreaterThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleCage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleCage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleCageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleCageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleFloatingBag:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleFloatingBag, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleFloatingBagReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleFloatingBagText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleSubmergedLine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleSubmergedLine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleSubmergedLineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleSubmergedLineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleLosterPound:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleLosterPound, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleLosterPoundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleLosterPoundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleBoat:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBoat, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBoatReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBoatText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeCages:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeCages, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeCagesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeCagesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeFloatingBags:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeFloatingBags, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeFloatingBagsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeFloatingBagsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSubmergedLines:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSubmergedLines, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSubmergedLinesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSubmergedLinesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeLosterPounds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeLosterPounds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeLosterPoundsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeLosterPoundsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeBarges:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeBarges, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeBargesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeBargesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeBoats:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeBoats, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeBoatsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeBoatsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationShorelineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationWharf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationWharf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationWharfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationWharfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationBargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationIsland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationIsland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationIslandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationIslandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationWetland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationWetland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationWetlandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationWetlandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationSandBar:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationSandBar, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationSandBarReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationSandBarText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationRockOutcrop:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationRockOutcrop, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationRockOutcropReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationRockOutcropText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationAquacultureSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationAquacultureSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationAquacultureSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationAquacultureSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineLocationOffShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationOffShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationOffShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineLocationOffShorelineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeShorelineBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeShorelineBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeShorelineBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeShorelineBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeGulls:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeGulls, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeGullsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeGullsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeCormorants:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeCormorants, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeCormorantsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeCormorantsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeDucksGeese:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeDucksGeese, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeDucksGeeseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeDucksGeeseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeLoons:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeLoons, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeLoonsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeLoonsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeSeaducks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSeaducks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSeaducksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSeaducksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeOther:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeOther, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeOtherReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeOtherText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeSeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeSeaOtter:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSeaOtter, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSeaOtterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeSeaOtterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSourcesOfContaminantRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSourcesOfContaminantExcrement:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantExcrement, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantExcrementReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantExcrementText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSourcesOfContaminantEffluent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantEffluent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantEffluentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantEffluentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSourcesOfContaminantEffluentMultiple:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantEffluentMultiple, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantEffluentMultipleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminantEffluentMultipleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSourcesOfContaminanMixedMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminanMixedMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminanMixedMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSourcesOfContaminanMixedMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantRunoffFromField:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffFromField, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffFromFieldReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffFromFieldText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantProcessingWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantProcessingWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantProcessingWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantProcessingWaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantTankWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantTankWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantTankWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantTankWaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantSewage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantSewage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantSewageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantSewageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantEffluent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantDomesticExcrement:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantDomesticExcrement, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantDomesticExcrementReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantDomesticExcrementText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantMarineWashrooms:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantMarineWashrooms, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantMarineWashroomsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantMarineWashroomsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantLandMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantLandMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantLandMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantLandMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantSpills:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantSpills, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantSpillsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantSpillsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantWilldExcrement:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantWilldExcrement, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantWilldExcrementReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantWilldExcrementText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantEffluentMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantEffluentLocation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentLocation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentLocationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentLocationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageRunoffLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRunoffLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRunoffLandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRunoffLandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageThruConduit:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageThruConduit, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageThruConduitReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageThruConduitText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageSepticSystemLeachateField:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSepticSystemLeachateField, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSepticSystemLeachateFieldReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSepticSystemLeachateFieldText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageRetentionTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRetentionTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRetentionTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRetentionTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageOpenTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOpenTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOpenTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOpenTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageSystemConstructedWetland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSystemConstructedWetland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSystemConstructedWetlandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSystemConstructedWetlandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageOnSiteSystem:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOnSiteSystem, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOnSiteSystemReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOnSiteSystemText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageOffSiteSystem:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOffSiteSystem, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOffSiteSystemReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageOffSiteSystemText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticNoInformation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoInformation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoInformationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoInformationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageAnimalWasteStorage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageAnimalWasteStorage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageAnimalWasteStorageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageAnimalWasteStorageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageAnimalExcrement:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageAnimalExcrement, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageAnimalExcrementReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageAnimalExcrementText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageRunoffMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRunoffMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRunoffMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRunoffMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageThruConduitMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageThruConduitMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageThruConduitMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageThruConduitMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageRetentionTankMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRetentionTankMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRetentionTankMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageRetentionTankMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageMixedMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMixedMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMixedMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMixedMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazardousLevelHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazardousLevelMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazardousLevelLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazardousLevelHighMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelHighMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelHighMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelHighMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazardousLevelMedMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelMedMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelMedMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelMedMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazardousLevelLowMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelLowMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelLowMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazardousLevelLowMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonVisualH:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualH, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualHReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualHText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonNumbersH:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersH, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersHReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersHText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonDiscussH:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussH, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussHReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussHText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonRainfallH:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallH, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallHReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallHText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonVisualM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonNumbersM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonDiscussM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonRainfallM:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallM, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallMReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallMText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonVisualHMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualHMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualHMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualHMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonNumbersHMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersHMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersHMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersHMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonDiscussHMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussHMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussHMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussHMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonRainfallHMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallHMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallHMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallHMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonVisualMMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualMMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualMMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonVisualMMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonNumbersMMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersMMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersMMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonNumbersMMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonDiscussMMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussMMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussMMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonDiscussMMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ObservationHazReasonRainfallMMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallMMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallMMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumObservationHazReasonRainfallMMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwayLandHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwayLandMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwayLandLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayMarineHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayMarineMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayMarineLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayInActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayInActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayInActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayInActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayNotDetermined:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayNotDetermined, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayNotDeterminedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayNotDeterminedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstCulvert:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvert, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvertReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvertText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstPipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstStream:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStream, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStreamReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStreamText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstSurfaceDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstSubSurfaceDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstDirectFlow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstCulvertMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvertMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvertMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvertMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstPipeMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstStreamMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStreamMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStreamMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStreamMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstDitchMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitchMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitchMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitchMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstSurfaceDrainageMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainageMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainageMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainageMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstSubSurfaceDrainageMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainageMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainageMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainageMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstDirectFlowMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlowMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlowMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlowMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstCulvertLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvertLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvertLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstCulvertLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstPipeLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstStreamLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStreamLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStreamLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStreamLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstDitchLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitchLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitchLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDitchLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstSurfaceDrainageLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainageLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainageLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSurfaceDrainageLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstSubSurfaceDrainageLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainageLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainageLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstSubSurfaceDrainageLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstDirectFlowLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlowLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlowLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectFlowLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstInActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstInActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstInActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstInActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstNotDetermined:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstNotDetermined, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstNotDeterminedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstNotDeterminedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstMunicipalityONSITE:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMunicipalityONSITE, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMunicipalityONSITEReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMunicipalityONSITEText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstDirectMARINE:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectMARINE, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectMARINEReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectMARINEText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstPipeMARINE:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeMARINE, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeMARINEReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstPipeMARINEText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstLandDisposalMARINE:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstLandDisposalMARINE, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstLandDisposalMARINEReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstLandDisposalMARINEText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstMunicipalityOFFSITE:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMunicipalityOFFSITE, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMunicipalityOFFSITEReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMunicipalityOFFSITEText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstMixesMARINE:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMixesMARINE, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMixesMARINEReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstMixesMARINEText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeStream:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStream, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStreamReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStreamText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeSurfaceDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeSubSurfaceDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeDirectflow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeStreamMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStreamMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStreamMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStreamMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeDitchMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitchMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitchMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitchMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeSurfaceDrainageMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainageMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainageMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainageMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeSubSurfaceDrainageMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainageMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainageMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainageMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeDirectflowMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflowMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflowMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflowMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeStreamLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStreamLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStreamLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStreamLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeDitchLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitchLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitchLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDitchLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeSurfaceDrainageLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainageLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainageLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSurfaceDrainageLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeSubSurfaceDrainageLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainageLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainageLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeSubSurfaceDrainageLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeDirectflowLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflowLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflowLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectflowLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertStream:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStream, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStreamReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStreamText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertSurfaceDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertSubSurfaceDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertDirectFlow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertStreamMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStreamMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStreamMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStreamMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertDitchMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitchMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitchMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitchMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertSurfaceDrainageMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainageMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainageMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainageMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertSubSurfaceDrainageMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainageMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainageMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainageMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertDirectFlowMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlowMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlowMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlowMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertStreamLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStreamLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStreamLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStreamLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertDitchLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitchLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitchLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDitchLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertSurfaceDrainageLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainageLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainageLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSurfaceDrainageLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertSubSurfaceDrainageLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainageLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainageLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertSubSurfaceDrainageLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertDirectFlowLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlowLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlowLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectFlowLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween11And25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween26And40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox1Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox2Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox3Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox4Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox5Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox6Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox7Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox8Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox9Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox10Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween11And25Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween26And40Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersGreaterThan40Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox1Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox1LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox2Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox2LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox3Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox3LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox4Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox4LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox5Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox5LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox6Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox6LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox7Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox7LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox8Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox8LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox9Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox9LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersApprox10Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersApprox10LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween11And25Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween11And25LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween26And40Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween26And40LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersGreaterThan40Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersGreaterThan40LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeNA:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNA, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNAReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNAText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeLowMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeMediumMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeHighMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeNAMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNAMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNAMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNAMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeLowLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeMediumLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeHighLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeNALow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNALow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNALowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNALowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeNA:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNA, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNAReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNAText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeLowMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeMediumMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeHighMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeNAMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNAMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNAMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNAMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeLowLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeMediumLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeHighLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeNALow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNALow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNALowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNALowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZonePresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZonePresentMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneAbsentMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfoMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZonePresentLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneAbsentLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfoLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureCulvert:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvert, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructurePipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBridge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBerm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBerm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureWetland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureInRoadNoStructure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureCulvertMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructurePipeMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBridgeMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBermMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureWetlandMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureInRoadNoStructureMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureCulvertLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructurePipeLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBridgeLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBermLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureWetlandLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureInRoadNoStructureLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureCulvertWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBridgeWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBermWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureWetlandWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureInRoadNoStructureWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureCulvertWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBridgeWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBermWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureWetlandWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureInRoadNoStructureWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureCulvertWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBridgeWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBermWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureWetlandWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureInRoadNoStructureWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters0W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters5W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters10W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters20W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters30W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters40W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters50W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters75W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters100W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters150W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters200W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters300W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters400W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters600W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters800W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters1000W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetersGreaterThan1000W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersGreaterThan1000W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersGreaterThan1000WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetersInfoRequiredW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersInfoRequiredW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersInfoRequiredWReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersInfoRequiredWText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters0MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters5MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters10MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters20MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters30MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters40MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters50MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters75MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters100MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters150MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters200MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters300MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters400MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters600MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters800MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters1000MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000MedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000MedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000MedWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqMedW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqMedW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqMedWReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqMedWText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters0LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters5LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters10LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters20LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters30LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters40LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters50LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters75LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters100LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters150LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters200LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters300LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters400LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters600LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters800LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters1000LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000LowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000LowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000LowWReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqLowW:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqLowW, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqLowWReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqLowWText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo1Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo2Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo3Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo4Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo5Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo6Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo7Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo8Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo9Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo10Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo1Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo1LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo2Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo2LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo3Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo3LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo4Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo4LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo5Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo5LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo6Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo6LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo7Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo7LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo8Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo8LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo9Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo9LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumberEqualTo10Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumberEqualTo10LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeCountNumbeNoInformation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumbeNoInformation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumbeNoInformationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeCountNumbeNoInformationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersEqual15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersEqual30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween31and50cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween51and100cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween101and200cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween201and300cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween301and400cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween401and500cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersGreaterThan500cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterNoInformation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersEqual15Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersEqual30Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30MedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30MedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween31and50cmMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cmMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cmMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cmMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween51and100cmMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cmMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cmMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cmMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween101and200cmMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cmMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cmMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cmMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween201and300cmMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cmMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cmMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cmMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween301and400cmMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cmMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cmMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cmMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween401and500cmMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cmMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cmMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cmMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersGreaterThan500cmMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cmMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cmMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cmMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterNoInformationMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformationMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformationMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformationMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersEqual15Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual15LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersEqual30Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30LowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersEqual30LowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween31and50cmLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cmLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cmLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween31and50cmLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween51and100cmLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cmLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cmLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween51and100cmLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween101and200cmLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cmLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cmLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween101and200cmLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween201and300cmLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cmLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cmLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween201and300cmLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween301and400cmLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cmLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cmLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween301and400cmLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween401and500cmLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cmLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cmLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween401and500cmLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersGreaterThan500cmLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cmLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cmLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersGreaterThan500cmLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterNoInformationLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformationLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformationLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterNoInformationLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAlongRoad:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoad, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAcrossProperties:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossProperties, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossPropertiesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossPropertiesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAlongRoadMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAcrossPropertiesMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossPropertiesMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossPropertiesMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossPropertiesMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAlongRoadLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAcrossPropertiesLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossPropertiesLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossPropertiesLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAcrossPropertiesLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainagePavedSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageVegetatedSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageBareSoilSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainagePavedSurfacesMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageVegetatedSurfacesMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageBareSoilSurfacesMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainagePavedSurfacesLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageVegetatedSurfacesLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageBareSoilSurfacesLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHi:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHi, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHiReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHiText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelRain:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRain, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHighMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMediumMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLowMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelRainfallMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHighLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMediumLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLowLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelRainfallLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHighWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMediumWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLowWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelRainfallWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHighWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMediumWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLowWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelRainfallWaterCourseMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourseMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourseMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourseMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHighWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMediumWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLowWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelRainfallWaterCourseLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourseLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourseLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallWaterCourseLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowlHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMediumReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMediumText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowRainfall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowNA:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNA, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNAReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNAText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowlHighMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHighMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHighMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHighMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowMediumMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMediumMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMediumMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMediumMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowLowMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLowMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLowMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLowMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowRainfallMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfallMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfallMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfallMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowNAMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNAMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNAMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNAMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowlHighLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHighLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHighLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowlHighLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowMediumLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMediumLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMediumLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowMediumLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowLowLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLowLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLowLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowLowLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowRainfallLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfallLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfallLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowRainfallLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PipeFlowNALow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNALow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNALowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNALowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters0:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters75:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters150:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersGreaterThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetersInfoRequired:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersInfoRequired, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersInfoRequiredReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetersInfoRequiredText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters0Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters5Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters10Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters20Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters30Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters40Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters50Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters75Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters100Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters150Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters200Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters300Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters400Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters600Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters800Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters1000Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000Med:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000Med, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000MedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters0Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters5Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters10Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters20Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters30Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters40Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters50Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters75Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters100Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters150Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters200Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters300Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters400Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters600Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters800Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters1000Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000Low:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000Low, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000LowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SecondaryHazardousLevelHighIndirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelHighIndirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelHighIndirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelHighIndirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SecondaryHazardousLevelMedIndirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelMedIndirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelMedIndirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelMedIndirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SecondaryHazardousLevelLowIndirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelLowIndirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelLowIndirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelLowIndirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SecondaryHazardousLevelHighDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelHighDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelHighDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelHighDirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SecondaryHazardousLevelMedDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelMedDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelMedDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelMedDirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SecondaryHazardousLevelLowDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelLowDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelLowDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSecondaryHazardousLevelLowDirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingDirectHighHaz:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectHighHaz, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectHighHazReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectHighHazText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingindirectHighHaz:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectHighHaz, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectHighHazReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectHighHazText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingDirectMedHaz:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectMedHaz, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectMedHazReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectMedHazText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingindirectMedHaz:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectMedHaz, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectMedHazReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectMedHazText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingDirectLowHaz:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectLowHaz, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectLowHazReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectLowHazText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingindirectLowHaz:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectLowHaz, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectLowHazReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectLowHazText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingNone:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingNone, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingNoneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingNoneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusDefiniteHi:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteHi, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteHiReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteHiText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusPotentialHi:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialHi, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialHiReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialHiText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusDefiniteMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusPotentialMed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialMed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialMedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialMedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusDefiniteLo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteLo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteLoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteLoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusPotentialLo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialLo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialLoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialLoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusNonPollutionSource:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSource, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSourceReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSourceText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusNotDetermined:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNotDetermined, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNotDeterminedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNotDeterminedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesDirectHighYes:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectHighYes, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectHighYesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectHighYesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesDirectHighNo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectHighNo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectHighNoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectHighNoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesIndirectHighYes:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectHighYes, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectHighYesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectHighYesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesIndirectHighNo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectHighNo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectHighNoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectHighNoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesDirectMedYes:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectMedYes, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectMedYesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectMedYesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesDirectMedNo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectMedNo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectMedNoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesDirectMedNoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesIndirectMedYes:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectMedYes, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectMedYesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectMedYesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ConductDilutionAnalysesIndirectMedNo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectMedNo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectMedNoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumConductDilutionAnalysesIndirectMedNoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SuggestedRiskLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SuggestedRiskModerate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskModerate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskModerateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskModerateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SuggestedRiskHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SuggestedRiskInfoRequired:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskInfoRequired, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskInfoRequiredReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSuggestedRiskInfoRequiredText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskModerate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskModerate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskModerateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskModerateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskHighNotConfirmed:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighNotConfirmed, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighNotConfirmedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighNotConfirmedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskHighConfirmedVisual:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighConfirmedVisual, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighConfirmedVisualReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighConfirmedVisualText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RishHighConfirmedWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRishHighConfirmedWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRishHighConfirmedWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRishHighConfirmedWaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskNotDetermined:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskNotDetermined, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskNotDeterminedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskNotDeterminedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FollowupRequired:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupRequired, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupRequiredReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupRequiredText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FollowupCompleted:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupCompleted, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupCompletedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupCompletedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypeOfSourceCircular:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfSourceCircular, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfSourceCircularReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfSourceCircularText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypeOfSourceWaterWays:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfSourceWaterWays, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfSourceWaterWaysReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfSourceWaterWaysText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterwayWidthInMetersApprox1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterwayWidthInMetersApprox2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterwayWidthInMetersApprox3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterwayWidthInMetersApprox5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterwayWidthInMetersApprox10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterwayWidthInMetersApprox10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox50cm1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox1m1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox2m1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox3m1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox50cm2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox1m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox2m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox3m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox50cm3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox1m3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox2m3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox3m3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox50cm5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox1m5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox2m5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox3m5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox50cm10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox50cm10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox1m10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox1m10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox2m10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox2m10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AverageDepthApprox3m10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAverageDepthApprox3m10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StreamVolSqMeterEquals05m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals05m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals05m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals05m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StreamVolSqMeterEquals1m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals1m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals1m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals1m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StreamVolSqMeterEquals3m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals3m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals3m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals3m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StreamVolSqMeterEquals6m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals6m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals6m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals6m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StreamVolSqMeterEquals9m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals9m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals9m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals9m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StreamVolSqMeterEquals15m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals15m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals15m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals15m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StreamVolSqMeterEquals30m2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals30m2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals30m2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStreamVolSqMeterEquals30m2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat30SecondsHalf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsHalf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsHalfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsHalfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat1MinuteHalf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteHalf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteHalfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteHalfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat2MinutesHalf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesHalf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesHalfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesHalfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat3MinutesHalf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesHalf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesHalfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesHalfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat30SecondsOne:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsOne, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsOneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsOneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat1MinuteOne:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteOne, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteOneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteOneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat2MinutesOne:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesOne, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesOneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesOneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat3MinutesOne:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesOne, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesOneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesOneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat30SecondsThree:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsThree, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsThreeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsThreeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat1MinuteThree:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteThree, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteThreeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteThreeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat2MinutesThree:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesThree, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesThreeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesThreeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat3MinutesThree:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesThree, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesThreeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesThreeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat30SecondsSix:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsSix, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsSixReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsSixText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat1MinuteSix:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteSix, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteSixReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteSixText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat2MinutesSix:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesSix, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesSixReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesSixText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat3MinutesSix:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesSix, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesSixReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesSixText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat30SecondsNine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsNine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsNineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsNineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat1MinuteNine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteNine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteNineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteNineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat2MinutesNine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesNine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesNineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesNineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat3MinutesNine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesNine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesNineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesNineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat30SecondsFifteen:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsFifteen, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsFifteenReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsFifteenText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat1MinuteFifteen:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteFifteen, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteFifteenReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteFifteenText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat2MinutesFifteen:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesFifteen, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesFifteenReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesFifteenText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat3MinutesFifteen:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesFifteen, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesFifteenReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesFifteenText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat30SecondsThirty:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsThirty, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsThirtyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat30SecondsThirtyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat1MinuteThirty:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteThirty, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteThirtyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat1MinuteThirtyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat2MinutesThirty:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesThirty, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesThirtyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat2MinutesThirtyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TimeToFloat3MinutesThirty:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesThirty, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesThirtyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTimeToFloat3MinutesThirtyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500a:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500a, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500aReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500aText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000a:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000a, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000aReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000aText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700a:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700a, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700aReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700aText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500b:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500b, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500bReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500bText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000b:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000b, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000bReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000bText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700b:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700b, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700bReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700bText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500c:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500c, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500cReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500cText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000c:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000c, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000cReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000cText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700c:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700c, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700cReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700cText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500d:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500d, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500dReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500dText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000d:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000d, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000dReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000dText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700d:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700d, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700dReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700dText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500e:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500e, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500eReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500eText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000e:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000e, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000eReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000eText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700e:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700e, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700eReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700eText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500f:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500f, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500fReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500fText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000f:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000f, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000fReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000fText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700f:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700f, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700fReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700fText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500g:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500g, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500gReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500gText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000g:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000g, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000gReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000gText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700g:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700g, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700gReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700gText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500h:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500h, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500hReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500hText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000h:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000h, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000hReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000hText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700h:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700h, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700hReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700hText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500i:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500i, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500iReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500iText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000i:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000i, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000iReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000iText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700i:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700i, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700iReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700iText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500j:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500j, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500jReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500jText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000j:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000j, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000jReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000jText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700j:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700j, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700jReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700jText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo500k:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500k, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500kReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo500kText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1000k:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000k, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000kReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1000kText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalCountNumberApproxTo1700k:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700k, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700kReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalCountNumberApproxTo1700kText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Starta:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14Starta, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Startb:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14Startb, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartbReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartbText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Startc:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14Startc, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartcReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartcText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Startd:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14Startd, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartdReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartdText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StarteGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarteGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarteGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarteGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartfGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartfGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartfGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartfGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartgGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartgGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartgGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartgGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StarthGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarthGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarthGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarthGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartiGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartiGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartiGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartiGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartjGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartjGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartjGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartjGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartkGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartkGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartkGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartkGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartlGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartlGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartlGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartlGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartmGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartmGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartmGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartmGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartnGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartnGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartnGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartnGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartoGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartoGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartoGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartoGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartpGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartpGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartpGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartpGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartqGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartqGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartqGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartqGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartrGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartrGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartrGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartrGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartsGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartsGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartsGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartsGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StarttGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarttGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarttGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StarttGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartuGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartuGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartuGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartuGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartvGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartvGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartvGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartvGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartwGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartwGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartwGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartwGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartxGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartxGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartxGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartxGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartyGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartyGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartyGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartyGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartzGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartzGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartzGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCubicMeterToDiluteToMPN14StartzGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureDiameter30cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter30cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter30cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter30cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureDiameter50cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter50cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter50cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter50cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureDiameter75cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter75cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter75cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter75cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureDiameter1m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter1m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter1mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter1mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureDiameter2m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter2m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter2mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter2mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureDiameter3m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter3m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter3mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureDiameter3mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent300cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent300cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent300cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent300cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent300cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent300cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent300cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent300cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent300cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent300cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent300cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent300cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent500cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent500cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent500cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent500cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent500cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent500cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent500cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent500cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent500cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent500cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent500cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent500cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent750cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent750cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent750cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent750cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent750cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent750cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent750cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent750cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent750cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent750cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent750cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent750cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent1m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent1m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent1mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent1mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent1m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent1m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent1mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent1mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent1m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent1m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent1mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent1mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent2m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent2m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent2mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent2mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent2m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent2m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent2mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent2mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent2m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent2m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent2mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent2mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent3m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent3m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent3mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox25Percent3mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent3m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent3m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent3mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox50Percent3mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent3m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent3m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent3mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHeigthOfFlowApprox75Percent3mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual005:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual005, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual005Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual005Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual01:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual01, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual01Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual01Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual02:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual02, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual02Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual02Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual03:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual03, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual03Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual03Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual05:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual05, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual05Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual05Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual075:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual075, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual075Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual075Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual11:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual11, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual11Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual11Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual28:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual28, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual28Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual28Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual33:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual33, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual33Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual33Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual52:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual52, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual52Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual52Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual89:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual89, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual89Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual89Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.VolumeCubicMeterSecEqual152:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual152, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual152Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVolumeCubicMeterSecEqual152Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewBrunswickBetween14And100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween14And100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween14And100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween14And100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNovaScotiaBetween14And100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween14And100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween14And100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween14And100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionPEIBetween14And100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween14And100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween14And100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween14And100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewfoundlandBetween14And100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween14And100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween14And100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween14And100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionQuebecBetween14And100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween14And100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween14And100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween14And100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionBritishCBetween14And100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween14And100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween14And100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween14And100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewBrunswickBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNovaScotiaBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionPEIBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewfoundlandBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionQuebecBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionBritishCBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewBrunswickBetween251And600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween251And600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween251And600Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween251And600Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNovaScotiaBetween251And600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween251And600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween251And600Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween251And600Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionPEIBetween251And600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween251And600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween251And600Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween251And600Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewfoundlandBetween251And600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween251And600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween251And600Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween251And600Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionQuebecBetween251And600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween251And600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween251And600Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween251And600Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionBritishCBetween251And600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween251And600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween251And600Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween251And600Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewBrunswickBetween601and1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween601and1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween601and1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween601and1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNovaScotiaBetween601and1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween601and1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween601and1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween601and1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionPEIBetween601and1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween601and1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween601and1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween601and1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewfoundlandBetween601and1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween601and1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween601and1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween601and1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionQuebecBetween601and1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween601and1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween601and1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween601and1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionBritishCBetween601and1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween601and1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween601and1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween601and1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewBrunswickBetween1001And2000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween1001And2000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween1001And2000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween1001And2000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNovaScotiaBetween1001And2000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween1001And2000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween1001And2000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween1001And2000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionPEIBetween1001And2000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween1001And2000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween1001And2000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween1001And2000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewfoundlandBetween1001And2000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween1001And2000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween1001And2000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween1001And2000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionQuebecBetween1001And2000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween1001And2000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween1001And2000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween1001And2000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionBritishCBetween1001And2000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween1001And2000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween1001And2000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween1001And2000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewBrunswickBetween2001And5500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween2001And5500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween2001And5500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween2001And5500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNovaScotiaBetween2001And5500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween2001And5500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween2001And5500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween2001And5500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionPEIBetween2001And5500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween2001And5500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween2001And5500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween2001And5500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewfoundlandBetween2001And5500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween2001And5500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween2001And5500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween2001And5500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionQuebecBetween2001And5500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween2001And5500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween2001And5500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween2001And5500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionBritishCBetween2001And5500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween2001And5500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween2001And5500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween2001And5500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewBrunswickBetween5501And11000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween5501And11000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween5501And11000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween5501And11000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNovaScotiaBetween5501And11000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween5501And11000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween5501And11000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween5501And11000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionPEIBetween5501And11000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween5501And11000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween5501And11000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween5501And11000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewfoundlandBetween5501And11000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween5501And11000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween5501And11000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween5501And11000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionQuebecBetween5501And11000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween5501And11000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween5501And11000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween5501And11000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionBritishCBetween5501And11000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween5501And11000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween5501And11000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween5501And11000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewBrunswickBetween11001And20000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween11001And20000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween11001And20000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewBrunswickBetween11001And20000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNovaScotiaBetween11001And20000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween11001And20000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween11001And20000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNovaScotiaBetween11001And20000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionPEIBetween11001And20000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween11001And20000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween11001And20000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionPEIBetween11001And20000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionNewfoundlandBetween11001And20000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween11001And20000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween11001And20000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionNewfoundlandBetween11001And20000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionQuebecBetween11001And20000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween11001And20000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween11001And20000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionQuebecBetween11001And20000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RegionBritishCBetween11001And20000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween11001And20000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween11001And20000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRegionBritishCBetween11001And20000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB1To2GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB3To4GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB5To7GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB9To12GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB13To15GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals16GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB17To18GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals19GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB1To2GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB3To4GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB5To7GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB9To12GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB13To15GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals16GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB17To18GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals19GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB1To2GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB3To4GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB5To7GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB9To12GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB13To15GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals16GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB17To18GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals19GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB1To2GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB3To4GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB5To7GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB9To12GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB13To15GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals16GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB17To18GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals19GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB1To2GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB3To4GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB5To7GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB9To12GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB13To15GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals16GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB17To18GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals19GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB1To2GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB3To4GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB5To7GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB9To12GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB13To15GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals16GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB17To18GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals19GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB1To2GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB3To4GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB5To7GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB9To12GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB13To15GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals16GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB17To18GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals19GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB1To2GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB1To2GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB3To4GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB3To4GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB5To7GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB5To7GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB9To12GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB9To12GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB13To15GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB13To15GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals16GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals16GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNB17To18GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNB17To18GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNBEquals19GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNBEquals19GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals1GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS2To3GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS4To6GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals7GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS8To14GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNEquals15GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals16GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals18GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals20GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals1GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS2To3GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS4To6GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals7GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS8To14GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNEquals15GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals16GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals18GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals20GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals1GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS2To3GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS4To6GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals7GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS8To14GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNEquals15GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals16GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals18GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals20GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals1GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS2To3GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS4To6GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals7GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS8To14GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNEquals15GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals16GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals18GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals20GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals1GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS2To3GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS4To6GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals7GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS8To14GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNEquals15GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals16GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals18GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals20GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals1GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS2To3GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS4To6GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals7GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS8To14GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNEquals15GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals16GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals18GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals20GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals1GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS2To3GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS4To6GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals7GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS8To14GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNEquals15GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals16GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals18GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals20GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals1GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals1GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS2To3GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS2To3GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS4To6GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS4To6GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals7GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals7GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNS8To14GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNS8To14GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNEquals15GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNEquals15GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals16GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals16GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals18GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals18GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNSEquals20GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNSEquals20GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI5To6GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI7To8GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI5To6GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI7To8GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI5To6GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI7To8GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI5To6GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI7To8GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI5To6GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI7To8GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI5To6GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI7To8GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI5To6GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI7To8GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI1To4Plus9GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI5To6GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI5To6GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInPEI7To8GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInPEI7To8GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual2GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfld6To7GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual15GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual29GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual30GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual35GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual43GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual2GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfld6To7GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual15GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual29GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual30GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual35GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual43GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual2GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfld6To7GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual15GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual29GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual30GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual35GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual43GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual2GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfld6To7GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual15GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual29GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual30GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual35GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual43GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual2GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfld6To7GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual15GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual29GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual30GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual35GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual43GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual2GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfld6To7GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual15GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual29GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual30GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual35GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual43GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual2GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfld6To7GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual15GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual29GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual30GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual35GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual43GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual2GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual2GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfld6To7G8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7G8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7G8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfld6To7G8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual15G8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15G8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15G8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual15G8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual29G8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29G8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29G8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual29G8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual30GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual30GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual35GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual35GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInNfldEqual43GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInNfldEqual43GP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualAGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualGGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualBGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualAGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualGGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualBGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualAGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualGGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualBGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualAGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualGGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualBGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualAGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualGGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualBGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualAGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualGGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualBGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualAGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualAGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualGGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualGGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecTandPandNGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecLandKandSandPGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualBGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualBGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ01GP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ02GP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ03GP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInQuebecEqualZ04GP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP1Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP2Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP3Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP4Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP6Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP7Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox50cmGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox1mGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox2mGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox5mGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumQuebecTidalAmplitudeApprox8mGP8Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBEGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBWGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBEGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBWGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBEGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBWGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBEGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBWGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBEGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBWGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBEGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBWGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBEGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBEGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualGBWGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualGBWGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualNCQCGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSectorsInBCEqualWCVIGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox4mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox4mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox4mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox4mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox4mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox4mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox4mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox1mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BCTidalAmplitudeApprox4mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBCTidalAmplitudeApprox4mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox4mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox4mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox4mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox4mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox1mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldTidalAmplitudeApprox2mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt15m2Wide15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt15m2Wide15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt15m2Wide15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt15m2Wide15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt30m2Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m2Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m2Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m2Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt30m5Wide60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m5Wide60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m5Wide60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m5Wide60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt60m5Wide30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m5Wide30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m5Wide30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m5Wide30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt60m5Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m5Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m5Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m5Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt60m10Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m10Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m10Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m10Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide40a:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide40a, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide40aReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide40aText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide70:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide70, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide70Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide70Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt15m2Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt15m2Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt15m2Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt15m2Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt30m05Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m05Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m05Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m05Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt30m05Wide120:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m05Wide120, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m05Wide120Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt30m05Wide120Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt60m05Wide15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m05Wide15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m05Wide15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m05Wide15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt60m05Wide30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m05Wide30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m05Wide30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt60m05Wide30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAverageDepthAt100m10Wide80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals5m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals5m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals5mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals5mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals10m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals10m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals10mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals10mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals15m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals15m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals15mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals15mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals20m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals20m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals20mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals20mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals30m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals30m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals30mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals30mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals40m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals40m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals40mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals40mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals60m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals60m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals60mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals60mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals70m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals70m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals70mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals70mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals80m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals80m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals80mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals80mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NfldAreaWidthEquals120m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals120m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals120mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNfldAreaWidthEquals120mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox50cmGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox1mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPEITidalAmplitudeApprox2mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt100m105Wide15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt100m105Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt100m105Wide40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt100m105Wide100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt100m105Wide100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt150m205Wide90:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt150m205Wide90, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt150m205Wide90Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt150m205Wide90Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt150m205Wide150:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt150m205Wide150, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt150m205Wide150Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt150m205Wide150Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt500m1Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt500m1Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt500m1Wide30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt500m1Wide65:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide65, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide65Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt500m1Wide65Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt1500m4Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt1500m4Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt1500m4Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt1500m4Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAverageDepthAt1500m4Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt1500m4Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt1500m4Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAverageDepthAt1500m4Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals5m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals5m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals5mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals5mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals10m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals10m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals10mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals10mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals15m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals15m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals15mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals15mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals20m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals20m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals20mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals20mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals30m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals30m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals30mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals30mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals40m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals40m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals40mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals40mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals65m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals65m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals65mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals65mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals90m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals90m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals90mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals90mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals100m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals100m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals100mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals100mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PrinceEAreaWidthEquals150m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals150m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals150mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPrinceEAreaWidthEquals150mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox50cmGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox1mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox2mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox5mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox6mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBTidalAmplitudeApprox7mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide200Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt60m05Wide200Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt100m2Wide15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt100m2Wide30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt100m2Wide80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt100m2Wide80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide200Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m05Wide200Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide110:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide110, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide110Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide110Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide200Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m2Wide200Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide75:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide75, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide75Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide75Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt150m5Wide80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m05Wide150:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m05Wide150, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m05Wide150Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m05Wide150Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m05Wide250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m05Wide250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m05Wide250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m05Wide250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m205Wide25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m205Wide25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m205Wide25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m205Wide25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m205Wide45:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m205Wide45, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m205Wide45Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m205Wide45Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m6Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m6Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m6Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m6Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m20Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m20Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m20Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m20Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NewBAverageDepthAt500m30Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m30Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m30Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNewBAverageDepthAt500m30Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals5m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals5m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals5mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals5mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals10m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals10m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals10mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals10mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals15m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals15m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals15mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals15mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals20m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals20m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals20mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals20mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals25m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals25m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals25mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals25mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals30m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals30m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals30mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals30mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals40m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals40m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals40mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals40mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals45m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals45m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals45mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals45mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals50m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals50m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals50mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals50mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals60m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals60m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals60mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals60mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals70m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals70m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals70mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals70mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals75m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals75m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals75mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals75mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals80m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals80m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals80mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals80mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals100m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals100m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals100mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals100mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals110m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals110m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals110mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals110mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals150m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals150m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals150mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals150mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals200m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals200m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals200mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals200mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NBAreaWidthEquals250m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals250m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals250mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNBAreaWidthEquals250mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox50cmGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox1mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox2mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox3mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox5mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox8mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSTidalAmplitudeApprox14mGP8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt30m1Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt30m1Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt30m1Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt30m1Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt30m1Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt30m1Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt30m1Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt30m1Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt60m1Wide30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt60m1Wide50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt60m1Wide100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt60m1Wide100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt100m1Wide150:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt100m1Wide150, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt100m1Wide150Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt100m1Wide150Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide110:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide110, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide110Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide110Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide200Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide200Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide400Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m1Wide400Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m2Wide50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m2Wide50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m2Wide50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m2Wide50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m2Wide100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m2Wide100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m2Wide100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m2Wide100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m3Wide15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m3Wide15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m3Wide15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m3Wide15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m5Wide40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m5Wide40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m5Wide40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m5Wide40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt150m5Wide70:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m5Wide70, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m5Wide70Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt150m5Wide70Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m2Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m2Wide15:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide15, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide15Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide15Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m2Wide30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m2Wide65:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide65, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide65Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m2Wide65Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m3Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m3Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m3Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m3Wide35:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide35, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide35Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m3Wide35Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt500m10Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m10Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m10Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt500m10Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt1500m1Wide5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt1500m1Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt1500m1Wide25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt1500m1Wide40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m1Wide40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt1500m2Wide10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m2Wide10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m2Wide10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m2Wide10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NovaSAverageDepthAt1500m2Wide20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m2Wide20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m2Wide20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNovaSAverageDepthAt1500m2Wide20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals5m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals5m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals5mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals5mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals10m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals10m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals10mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals10mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals15m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals15m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals15mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals15mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals20m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals20m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals20mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals20mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals25m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals25m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals25mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals25mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals30m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals30m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals30mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals30mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals35m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals35m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals35mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals35mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals40m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals40m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals40mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals40mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals50m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals50m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals50mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals50mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals60m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals60m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals60mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals60mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals70m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals70m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals70mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals70mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals100m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals100m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals100mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals100mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals110m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals110m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals110mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals110mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals150m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals150m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals150mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals150mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals200m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals200m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals200mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals200mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NSAreaWidthEquals400m:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals400m, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals400mReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNSAreaWidthEquals400mText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactZoneYes:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneYes, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneYesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneYesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactZonePotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZonePotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZonePotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZonePotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactZoneNo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneNo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneNoReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneNoText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactZoneNotSure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneNotSure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneNotSureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactZoneNotSureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters0W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters0W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters0WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters5W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters5W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters5WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters10W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters10W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters10WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters20W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters20W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters20WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters30W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters30W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters30WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters40W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters40W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters40WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters50W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters50W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters50WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters75W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters75W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters75WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters100W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters100W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters100WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters150W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters150W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters150WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters200W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters200W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters200WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters300W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters300W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters300WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters400W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters400W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters400WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters600W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters600W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters600WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters800W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters800W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters800WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters1000W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters1000W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters1000WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMetersGreaterThan1000W:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMetersGreaterThan1000W, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMetersGreaterThan1000WReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters5WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters5WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters5WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters10WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters10WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters10WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters20WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters20WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters20WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters30WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters30WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters30WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters40WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters40WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters40WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters50WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters50WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters50WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters75WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters75WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters75WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters100WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters100WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters100WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters150WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters150WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters150WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters200WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters200WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters200WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters300WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters300WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters300WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters400WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters400WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters400WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters600WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters600WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters600WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters800WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters800WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters800WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters1000WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters1000WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters1000WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMetersGreaterThan1000WAnchor:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMetersGreaterThan1000WAnchor, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMetersGreaterThan1000WAnchorReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters5WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters5WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters5WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters10WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters10WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters10WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters20WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters20WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters20WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters30WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters30WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters30WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters40WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters40WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters40WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters50WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters50WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters50WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters75WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters75WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters75WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters100WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters100WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters100WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters150WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters150WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters150WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters200WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters200WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters200WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters300WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters300WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters300WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters400WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters400WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters400WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters600WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters600WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters600WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters800WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters800WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters800WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMeters1000WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters1000WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMeters1000WDisposalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToShoreInMetersGreaterThan1000WDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMetersGreaterThan1000WDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToShoreInMetersGreaterThan1000WDisposalReport, retStrReport);
                        }
                        break;
                        default:
                        {
                            Assert.AreEqual("", ((PolSourceObsInfoEnum)i).ToString() + "[" + i.ToString() + "]");
                        }
                        break;
                    }
                }
            }
        }
    }
}
