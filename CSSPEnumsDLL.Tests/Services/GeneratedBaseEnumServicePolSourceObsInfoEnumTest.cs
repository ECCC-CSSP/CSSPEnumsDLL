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
                        case PolSourceObsInfoEnum.CountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.AreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgriculturalSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturalSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturalSourceStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.VesselStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumVesselStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.MarWhfWharfCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfWharfCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarWhfWharfCountNumberStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.TypesOfAnimalStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesOfAnimalStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.SewageDumpingStationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FieldLocationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.StatusStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceFirstStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRiparionZoneStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparionZoneStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparionZoneStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalityDataStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalityDataStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalityDataStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.PathwaySourceWaterStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FollowupStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceHuman:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceHuman, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceHumanReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceAnimal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceAnimal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceAnimalReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceIndustrial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceIndustrial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceIndustrialReport, retStrReport);
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
                        case PolSourceObsInfoEnum.HumanPollutionSinglePublic:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglePublic, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglePublicReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSinglePublicText, retStrText);
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
                        case PolSourceObsInfoEnum.HumanPollutionSingleBoatOrBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBoatOrBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBoatOrBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionSingleBoatOrBargeText, retStrText);
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
                        case PolSourceObsInfoEnum.HumanPollutionMultiplePublic:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultiplePublic, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultiplePublicReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultiplePublicText, retStrText);
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
                        case PolSourceObsInfoEnum.HumanPollutionMultipleBoatsOrBarges:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBoatsOrBarges, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBoatsOrBargesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanPollutionMultipleBoatsOrBargesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationRural:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRural, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRuralReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRuralText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationUrban:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationUrban, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationUrbanReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationUrbanText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationForested:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationForested, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationForestedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationForestedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationAgricultural:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationAgricultural, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationAgriculturalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationAgriculturalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationShorelineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationWharf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWharf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWharfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWharfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationBargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationIsland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationIsland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationIslandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationIslandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationRecreationalArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRecreationalArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRecreationalAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRecreationalAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationCottageLot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationCottageLot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationCottageLotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationCottageLotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationWetland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWetland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWetlandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWetlandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationSandBar:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationSandBar, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationSandBarReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationSandBarText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationRock:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRock, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRockReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationRockText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationAquacultureSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationAquacultureSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationAquacultureSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationAquacultureSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.GeneralLocationOffShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationOffShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationOffShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumGeneralLocationOffShorelineText, retStrText);
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
                        case PolSourceObsInfoEnum.IndustrialEffluentAgriculture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAgriculture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAgricultureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentAgricultureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentFisheries:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentFisheries, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentFisheriesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentFisheriesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentShorelineStructures:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShorelineStructures, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShorelineStructuresReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentShorelineStructuresText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustrialEffluentIndustrial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentIndustrial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentIndustrialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustrialEffluentIndustrialText, retStrText);
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
                        case PolSourceObsInfoEnum.AreaSizeMetersEquals10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersEquals20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersEquals40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersEquals60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersEquals80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersEquals100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersEquals100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersBetween251And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween251And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween251And500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween251And500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersBetween501And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween501And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween501And1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersBetween501And1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersGreaterThan1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeMetersGreaterThan1000Text, retStrText);
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
                        case PolSourceObsInfoEnum.PastureActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureActiveWithManurePIle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveWithManurePIle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveWithManurePIleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveWithManurePIleText, retStrText);
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
                        case PolSourceObsInfoEnum.WharfMarina:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfMarina, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfMarinaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfMarinaText, retStrText);
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
                        case PolSourceObsInfoEnum.UrbanDumpStation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStationText, retStrText);
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
                        case PolSourceObsInfoEnum.SewageDumpingStationPresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationPresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationPresentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationPresentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationNotObserved:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationNotObserved, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationNotObservedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationNotObservedText, retStrText);
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
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatAquaCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatAquaCountNumberGreaterThan40Text, retStrText);
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
                        case PolSourceObsInfoEnum.MajorIssueSourceManurePile:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePile, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePileReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePileText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceLiqSpread:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceLiqSpread, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceLiqSpreadReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceLiqSpreadText, retStrText);
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
                        case PolSourceObsInfoEnum.SourcesOfContaminantRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantRunoffFromManure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffFromManure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffFromManureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantRunoffFromManureText, retStrText);
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
                        case PolSourceObsInfoEnum.SourcesOfContaminantWashrooms:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantWashrooms, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantWashroomsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantWashroomsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantEffluent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantEffluentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourcesOfContaminantExcrement:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantExcrement, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantExcrementReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourcesOfContaminantExcrementText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDirectDischarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischargeText, retStrText);
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
                        case PolSourceObsInfoEnum.PathwayLand:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLand, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwayLandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathWayWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathWayWaterText, retStrText);
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
                        case PolSourceObsInfoEnum.PathwaySourceFirstDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceFirstDirectText, retStrText);
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
                        case PolSourceObsInfoEnum.PathwaySourceSecondPipeDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondPipeDirectText, retStrText);
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
                        case PolSourceObsInfoEnum.PathwaySourceSecondCulvertDirectInput:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectInput, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectInputReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceSecondCulvertDirectInputText, retStrText);
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
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersOnShore:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersOnShore, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersOnShoreReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters10Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters20Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters30Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters40Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters75:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters75, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters75Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters150:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters150, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters150Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMeters1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMeters1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersGreaterThan1000Report, retStrReport);
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
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters10Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters20Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters30Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMeters1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMeters1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceToSaltWaterInMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceToSaltWaterInMetersGreaterThan1000Report, retStrReport);
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
                        case PolSourceObsInfoEnum.DiameterInCentimetersLessThan30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Text, retStrText);
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
                        case PolSourceObsInfoEnum.FlowLevelHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowText, retStrText);
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
                        case PolSourceObsInfoEnum.PathwaySourceWaterDirectToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterDirectToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterDirectToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterDirectToMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceWaterPipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterPipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterPipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterPipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PathwaySourceWaterLandDisposal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterLandDisposal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterLandDisposalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPathwaySourceWaterLandDisposalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual10Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual20Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual30Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual40Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual75:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual75, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual75Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual150:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual150, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual150Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual300Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual600:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual600, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual600Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersEqual1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersEqual1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersGreaterThan1000Report, retStrReport);
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
                        case PolSourceObsInfoEnum.RiskHighP:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighP, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighPReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighPText, retStrText);
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
                        case PolSourceObsInfoEnum.FollowupNotRequired:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupNotRequired, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupNotRequiredReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFollowupNotRequiredText, retStrText);
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
