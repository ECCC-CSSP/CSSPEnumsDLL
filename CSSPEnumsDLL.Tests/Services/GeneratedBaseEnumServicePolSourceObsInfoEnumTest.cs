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
                        case PolSourceObsInfoEnum.PathwayRouteMarineStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayRouteMarineStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayRouteMarineStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalityDataStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalityDataStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalityDataStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.RiskAnalysesWaterDepthStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskAnalysesWaterDepthStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskAnalysesWaterDepthStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalAmplitudeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalAmplitudeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalAmplitudeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FetchStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFetchStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFetchStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclosedTidalLargeDeepDefinStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalLargeDeepDefinStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalLargeDeepDefinStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLargeDeepDefinStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepDefinStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepDefinStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclosedTidalSmallDeepDefinStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalSmallDeepDefinStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalSmallDeepDefinStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalSmallDeepDefinStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepDefinStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepDefinStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclosedTidalLgShallowDefinStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalLgShallowDefinStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalLgShallowDefinStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShallowDefinStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowDefinStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowDefinStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclosedTidalSmallShallowDefinStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalSmallShallowDefinStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalSmallShallowDefinStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalSmallShallowDefinStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowDefinStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowDefinStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.EnclosedTidalLargeDeepPotentialStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalLargeDeepPotentialStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalLargeDeepPotentialStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLargeDeepPotentialStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepPotentialStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepPotentialStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclosedTidalSmallDeepPotentialStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalSmallDeepPotentialStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalSmallDeepPotentialStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalSmallDeepPotentialStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepPotentialStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepPotentialStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclosedTidalLgShallowPotentialStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalLgShallowPotentialStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalLgShallowPotentialStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShallowPotentialStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowPotentialStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowPotentialStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclosedTidalSmallShallowPotentialStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalSmallShallowPotentialStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclosedTidalSmallShallowPotentialStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalSmallShallowPotentialStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowPotentialStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowPotentialStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan40Text, retStrText);
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
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween11and25M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and25M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and25MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween11and25MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberBetween26and40M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween26and40M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween26and40MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberBetween26and40MText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanPollutionCountNumberGreaterThan40M:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan40M, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan40MReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionCountNumberGreaterThan40MText, retStrText);
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
                        case PolSourceObsInfoEnum.IndustrialEffluentMarinePark:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentMarinePark, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentMarineParkReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentMarineParkText, retStrText);
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
                        case PolSourceObsInfoEnum.ShorelineSourceSlipway:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceSlipway, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceSlipwayReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSourceSlipwayText, retStrText);
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
                        case PolSourceObsInfoEnum.WharfPrivate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfPrivate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfPrivateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfPrivateText, retStrText);
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
                        case PolSourceObsInfoEnum.UrbanStormWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWaterText, retStrText);
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
                        case PolSourceObsInfoEnum.AnimalBldgSingleWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgSingleWarehouseText, retStrText);
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
                        case PolSourceObsInfoEnum.AnimalBldgMultipleWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalBldgMultipleBarn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleBarn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleBarnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalBldgMultipleBarnText, retStrText);
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
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleCages:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleCages, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleCagesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleCagesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleFloatingBags:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleFloatingBags, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleFloatingBagsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleFloatingBagsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleSubmergedLines:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleSubmergedLines, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleSubmergedLinesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleSubmergedLinesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleLosterPound:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleLosterPound, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleLosterPoundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleLosterPoundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeSingleBarges:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBarges, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBargesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeSingleBargesText, retStrText);
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
                        case PolSourceObsInfoEnum.PathwayLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayInActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayInActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayInActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayInActiveText, retStrText);
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
                        case PolSourceObsInfoEnum.AreaSlopeLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeNA:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNA, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNAReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeLowVegetated:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowVegetated, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowVegetatedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeMediumVegetated:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumVegetated, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumVegetatedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeHighVegetated:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighVegetated, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighVegetatedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeNAVegetated:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNAVegetated, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeNAVegetatedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeLowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeMediumReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeHighReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCourseAreaSlopeNA:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNA, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCourseAreaSlopeNAReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZonePresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfo:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfo, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZonePresentVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZonePresentVegReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneAbsentVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneAbsentVegReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfoVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparianZoneNoInfoVegReport, retStrReport);
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
                        case PolSourceObsInfoEnum.FlowThroughStructureCulvertVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertVegReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureCulvertVegText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructurePipeVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeVegReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructurePipeVegText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBridgeVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeVegReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBridgeVegText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureBermVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermVegReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureBermVegText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowThroughStructureWetlandVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandVegReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowThroughStructureWetlandVegText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StructureInRoadNoStructureVeg:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureVeg, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureVegReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStructureInRoadNoStructureVegText, retStrText);
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
                        case PolSourceObsInfoEnum.FlowLevelHighVegetate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighVegetate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighVegetateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighVegetateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMediumVegetate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumVegetate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumVegetateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumVegetateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLowVegetate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowVegetate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowVegetateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowVegetateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelRainfallVegetate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallVegetate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallVegetateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelRainfallVegetateText, retStrText);
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
                        case PolSourceObsInfoEnum.PipeFlowNA:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNA, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPipeFlowNAReport, retStrReport);
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
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters0Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters0VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters5Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters5VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters10Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters10VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters20Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters20VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters30Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters30VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters40Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters40VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters50Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters50VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters75Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters75VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters100Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters100VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters150Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters150VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters200Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters200VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters300Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters300VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters400Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters400VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters600Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters600VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters800Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters800VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMeters1000Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMeters1000VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000Vegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000Vegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetGrThan1000VegetationReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqVegetation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqVegetation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqVegetationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToWaterInMetInfoReqVegetationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceMarineDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarineDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarineDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarineDirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceMarinePipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarinePipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarinePipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarinePipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceMarineLandDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarineLandDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarineLandDisposalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceMarineLandDisposalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingDirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingindirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingindirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ImpactRatingNone:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingNone, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingNoneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumImpactRatingNoneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusNonPollutionSource:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSource, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSourceReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSourceText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DepthDeepDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthDeepDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthDeepDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthDeepDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DepthShallowDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthShallowDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthShallowDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthShallowDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DepthDeepPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthDeepPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthDeepPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthDeepPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DepthShallowPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthShallowPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthShallowPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthShallowPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DepthUnknown:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthUnknown, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthUnknownReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDepthUnknownText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalLargeDeepDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeDeepDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeDeepDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeDeepDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalSmallDeepDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallDeepDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallDeepDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallDeepDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalLargeShallowDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeShallowDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeShallowDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeShallowDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalSmallShallowDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallShallowDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallShallowDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallShallowDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalLargeDeepPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeDeepPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeDeepPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeDeepPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalSmallDeepPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallDeepPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallDeepPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallDeepPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalLargeShallowPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeShallowPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeShallowPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalLargeShallowPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalSmallShallowPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallShallowPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallShallowPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalSmallShallowPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TidalUnknown:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalUnknown, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalUnknownReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTidalUnknownText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelteredTidalLargeDeepDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLargeDeepDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLargeDeepDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLargeDeepDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLargeDeepDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelteredTidalSmallDeepDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallDeepDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallDeepDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallDeepDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalSmallDeepDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelteredTidalLgShallowDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLgShallowDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLgShallowDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLgShallowDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShallowDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelteredTidalSmallShallowDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallShallowDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallShallowDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallShallowDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalSmallShallowDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelteresTidalLargeDeepPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteresTidalLargeDeepPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteresTidalLargeDeepPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteresTidalLargeDeepPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLargeDeepPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLargeDeepPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelteredTidalSmallDeepPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallDeepPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallDeepPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallDeepPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalSmallDeepPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallDeepPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelteredTidalLgShallowPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLgShallowPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLgShallowPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalLgShallowPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShallowPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShallowPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelteredTidalSmallShallowPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallShallowPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallShallowPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelteredTidalSmallShallowPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalSmallShallowPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalSmallShallowPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShelterUnknown:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelterUnknown, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelterUnknownReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShelterUnknownText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters700:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters700, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters700Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters900:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters900, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters900Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMetGrThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetGrThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetGrThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMetInfoReq:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetInfoReq, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetInfoReqReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetInfoReqText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet700:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet700, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet700Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet900:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet900, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet900Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDistToGrowAreaInMetGrThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetGrThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetGrThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDistToGrowAreaInMetInfoReq:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetInfoReq, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetInfoReqReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetInfoReqText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet700:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet700, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet700Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet900:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet900, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet900Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMetGrThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMetGrThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMetGrThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrAreaInMetInfoReq:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrAreaInMetInfoReq, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrAreaInMetInfoReqReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrAreaInMetInfoReqText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet700:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet700, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet700Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet900:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet900, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet900Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMetGrThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMetGrThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMetGrThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrAreaInMetInfoReq:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrAreaInMetInfoReq, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrAreaInMetInfoReqReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrAreaInMetInfoReqText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet700:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet700, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet700Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet900:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet900, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet900Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrAreaInMetGrThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetGrThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetGrThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrAreaInMetnfoReq:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetnfoReq, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetnfoReqReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetnfoReqText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet700:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet700, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet700Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet900:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet900, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet900Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMetGrThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMetGrThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMetGrThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrAreaInMetInfoReq:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrAreaInMetInfoReq, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrAreaInMetInfoReqReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrAreaInMetInfoReqText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet700:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet700, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet700Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet900:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet900, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet900Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMetGreTh1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetGreTh1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetGreTh1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMetInfoReq:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetInfoReq, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetInfoReqReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetInfoReqText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet700:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet700, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet700Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet900:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet900, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet900Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrAreaInMetGrTh1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetGrTh1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetGrTh1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrAreaInMetInfoReq:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetInfoReq, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetInfoReqReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetInfoReqText, retStrText);
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
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters50Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters50Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters50PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters100Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters100Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters100PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters200Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters200Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters200PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters300Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters300Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters300PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters400Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters400Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters400PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters500Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters500Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters500PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters600Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters600Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters600PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters700Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters700Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters700PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters800Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters800Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters800PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters900Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters900Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters900PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMeters1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMetGrThan1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetGrThan1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetGrThan1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMetInfoReqPot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetInfoReqPot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetInfoReqPotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncTidalLarDeDistToGrowAreaInMetInfoReqPotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet50Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet50Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet50PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet100Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet100Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet100PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet200Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet200Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet200PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet300Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet300Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet300PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet400Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet400Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet400PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet500Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet500Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet500PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet600Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet600Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet600PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet700Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet700Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet700PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet800Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet800Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet800PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet900Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet900Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet900PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDisToGrowAreaInMet1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDistToGrowAreaInMetGrThan1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetGrThan1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetGrThan1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLarDeDistToGrowAreaInMetInfoReqPot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetInfoReqPot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetInfoReqPotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLarDeDistToGrowAreaInMetInfoReqPotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet50Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet50Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet50PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet100Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet100Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet100PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet200Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet200Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet200PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet300Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet300Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet300PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet400Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet400Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet400PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet500Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet500Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet500PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet600Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet600Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet600PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet700Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet700Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet700PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet800Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet800Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet800PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet900Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet900Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet900PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMet1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMetGrThan1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMetGrThan1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrowAreaInMetGrThan1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EncloTidalSmDeDistToGrAreaInMetInfoReqPot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrAreaInMetInfoReqPot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrAreaInMetInfoReqPotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEncloTidalSmDeDistToGrAreaInMetInfoReqPotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet50Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet50Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet50PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet100Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet100Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet100PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet200Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet200Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet200PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet300Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet300Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet300PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet400Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet400Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet400PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet500Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet500Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet500PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet600Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet600Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet600PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet700Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet700Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet700PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet800Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet800Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet800PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet900Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet900Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet900PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMet1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMetGrThan1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMetGrThan1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrowAreaInMetGrThan1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidSmDeDistToGrAreaInMetInfoReqPot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrAreaInMetInfoReqPot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrAreaInMetInfoReqPotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidSmDeDistToGrAreaInMetInfoReqPotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet50Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet50Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet50PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet100Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet100Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet100PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet200Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet200Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet200PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet300Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet300Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet300PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet400Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet400Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet400PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet500Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet500Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet500PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet600Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet600Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet600PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet700Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet700Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet700PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet800Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet800Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet800PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet900Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet900Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet900PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrowAreaInMet1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrAreaInMetGrThan1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetGrThan1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetGrThan1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalLgShalDistToGrAreaInMetnfoReqPot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetnfoReqPot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetnfoReqPotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalLgShalDistToGrAreaInMetnfoReqPotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet50Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet50Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet50PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet100Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet100Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet100PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet200Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet200Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet200PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet300Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet300Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet300PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet400Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet400Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet400PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet500Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet500Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet500PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet600Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet600Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet600PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet700Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet700Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet700PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet800Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet800Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet800PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet900Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet900Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet900PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMet1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMetGrThan1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMetGrThan1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrowAreaInMetGrThan1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrAreaInMetInfoReqPot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrAreaInMetInfoReqPot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrAreaInMetInfoReqPotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpenTidalLgShalSeaDistToGrAreaInMetInfoReqPotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet50Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet50Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet50PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet100Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet100Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet100PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet200Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet200Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet200PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet300Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet300Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet300PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet400Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet400Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet400PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet500Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet500Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet500PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet600Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet600Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet600PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet700Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet700Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet700PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet800Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet800Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet800PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet900Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet900Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet900PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMet1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMetGreTh1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetGreTh1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetGreTh1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMetInfoReqPot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetInfoReqPot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetInfoReqPotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumEnclTidalSmShalSeaDistToGrAreaInMetInfoReqPotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet50Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet50Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet50PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet100Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet100Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet100PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet200Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet200Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet200PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet300Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet300Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet300PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet400Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet400Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet400PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet500Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet500Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet500PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet600Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet600Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet600PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet700Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet700Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet700PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet800Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet800Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet800PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet900Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet900Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet900PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrowAreaInMet1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrAreaInMetGrTh1000Pot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetGrTh1000Pot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetGrTh1000PotReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OpTidalSmShalDistToGrAreaInMetInfoReqPot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetInfoReqPot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetInfoReqPotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOpTidalSmShalDistToGrAreaInMetInfoReqPotText, retStrText);
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
