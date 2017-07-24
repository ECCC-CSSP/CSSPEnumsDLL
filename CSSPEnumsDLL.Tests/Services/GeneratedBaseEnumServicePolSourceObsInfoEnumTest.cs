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
                        case PolSourceObsInfoEnum.Start:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.FarmStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypeOfFishStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfFishStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfFishStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundFacilitiesStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundFacilitiesStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundFacilitiesStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeeMunicipalityInfrastructureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeeMunicipalityInfrastructureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalSystemStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAgricultureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAgricultureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAgricultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.AnimalNumberPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalNumberPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceWildlifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointSourceWildlifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointSourceWildlifeStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.PointSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceManureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointSourceManureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointSourceManureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.ManurePileSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManurePileSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManurePileSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureSiteStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureSiteStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureSiteStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDisposalAtSeaStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterDisposalAtSeaStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterDisposalAtSeaStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSeaportStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSeaportStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSeaportStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSewageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineIssueStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineIssueStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineIssueStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSlipwayStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShoreStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStatusStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskAStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskAStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskAStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskBStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskBStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskBStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskCStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskCStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskCStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandBased:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandBased, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLandBasedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterBased:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterBased, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterBasedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersOnShore:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersOnShore, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersOnShoreReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersLessThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersLessThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersLessThan100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween100And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween100And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween100And250Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween250And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween250And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween250And500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween500And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween500And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween500And1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersMoreThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersMoreThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersMoreThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersLessThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersLessThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersLessThan100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween100And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween100And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween100And250Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween250And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween250And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween250And500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween500And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween500And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween500And1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersMoreThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersMoreThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersMoreThan1000Report, retStrReport);
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
                        case PolSourceObsInfoEnum.SourceTypeLandAgriculture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandAgriculture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandAgricultureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandAgricultureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandForested:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandForested, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandForestedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandForestedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandIndustry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandRecreation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandRecreation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandRecreationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandRecreationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandUrban:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandUrban, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandUrbanReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandUrbanText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShore:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShore, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureCrop:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureCrop, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureCropReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureCropText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgriculturePasture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturePasture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturePastureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgriculturePastureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureFeedlot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFeedlot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFeedlotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFeedlotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureBuilding:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureBuilding, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureBuildingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgricultureBuildingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropFood:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropFood, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropFoodReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropFoodText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropHay:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropHay, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropHayReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropHayText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropPeatMoss:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropPeatMoss, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropPeatMossReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCropPeatMossText, retStrText);
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
                        case PolSourceObsInfoEnum.FarmHobby:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmHobby, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmHobbyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmHobbyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedLoggingActivity:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedLoggingActivity, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedLoggingActivityReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedLoggingActivityText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedClearcut:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedClearcut, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedClearcutReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedClearcutText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedRegrowth:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedRegrowth, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedRegrowthReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedRegrowthText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedBuilding:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedBuilding, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedBuildingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedBuildingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryAirport:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryAirport, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryAirportReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryAirportText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryLandfill:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryLandfill, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryLandfillReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryLandfillText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryFisheriesRelated:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryFisheriesRelated, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryFisheriesRelatedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryFisheriesRelatedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryWaste:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryWaste, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryWasteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryWasteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryStorageTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryStorageTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryStorageTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryStorageTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingShellfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingShellfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingShellfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingShellfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingFinfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFinfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFinfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFinfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingFishMeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFishMeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFishMealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFishMealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineWharf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineWharf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineWharfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineWharfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSeaWall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSeaWall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSeaWallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineSeaWallText, retStrText);
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
                        case PolSourceObsInfoEnum.TransportationCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationFerry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerryText, retStrText);
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
                        case PolSourceObsInfoEnum.RecreationRecreationaltArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationRecreationaltArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationRecreationaltAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationRecreationaltAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCommunityCentre:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCommunityCentre, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCommunityCentreReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationCommunityCentreText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationGolfCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundNoDumpStn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundwithDumpStn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundwithDumpStn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundwithDumpStnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundwithDumpStnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageCesspool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDirectDischarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewagePrivyOuthouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageMunicipalSystem:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystem, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystemReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystemText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemDrainageField:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemDrainageField, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemDrainageFieldReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemDrainageFieldText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemFullRention:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRention, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRentionText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemLagoon:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoon, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoonReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoonText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticNoStructure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoStructure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoStructureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoStructureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanStormWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanSurfaceRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanSurfaceRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanSurfaceRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanSurfaceRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanDumpStation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeLandMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeLandMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeLandMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeLandMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeMarineMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeMarineMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeMarineMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWildlifeMarineMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MuncipialSystemConnected:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMuncipialSystemConnected, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMuncipialSystemConnectedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMuncipialSystemConnectedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalSystemNotConnected:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemNotConnected, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemNotConnectedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemNotConnectedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankFuel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankFuel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankFuelReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankFuelText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankPropane:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankPropane, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankPropaneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankPropaneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankChemicals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankChemicals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankChemicalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumStorageTankChemicalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingResidentialFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingWarehouseFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingCommericalFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingBarnFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedResidential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedFactory:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactory, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactoryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactoryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingindustryWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryFactory:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactory, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactoryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactoryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishHatchery:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatchery, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcheryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcheryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishTanks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCottage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllResidential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllHotelMotel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotelReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotelText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberBetween1and5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween1and5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween1and5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween1and5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween25and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween25and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween25and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween25and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceLivestock:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestock, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestockReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestockText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourcePeople:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeople, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeopleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceDrainagewater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceManurePile:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePile, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePileReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePileText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueAbsent1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAbsent1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAbsent1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAbsent1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueRunoffText, retStrText);
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
                        case PolSourceObsInfoEnum.NumberPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeDomestic:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeDomestic, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeDomesticReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeDomesticText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallDomestic:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallDomestic, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallDomesticReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallDomesticText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualFurFarms:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarms, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarmsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarmsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticMixture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallWildAnimals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallWildAnimals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeWildAnimals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeWildAnimals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualMediumBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMediumBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMediumBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMediumBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween25and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceDirectInputToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceDirectInputToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceDirectInputToMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween5and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween5and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween5and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween5and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween25and50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween25and50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween25and50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween25and50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween50and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween50and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween50and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween50and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetweenMoreThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetweenMoreThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Text, retStrText);
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
                        case PolSourceObsInfoEnum.SourceTypeLandCulvert:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvert, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvertReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvertText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandPipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeDirectInputToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeDirectInputToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeDirectInputToMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceManureLandDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceManureLandDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceManureLandDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceManureLandDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceManureDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceManureDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceManureDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceManureDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersLessThan30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween30and100cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween100and200cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersMoreThan200cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmText, retStrText);
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
                        case PolSourceObsInfoEnum.OuthouseCementHoldingTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseCementHoldingTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseCementHoldingTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseCementHoldingTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseSittingOnGround:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseSittingOnGround, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseSittingOnGroundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOuthouseSittingOnGroundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersLessThan1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersLessThan1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersLessThan1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersLessThan1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween1And5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween1And5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween1And5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween1And5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween5And25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween5And25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween5And25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween5And25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersMoreThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersMoreThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersMoreThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersMoreThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAlongRoad:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoad, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchBetweenAcrossProperties:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchBetweenAcrossProperties, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesText, retStrText);
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
                        case PolSourceObsInfoEnum.DrainageDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageDirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageBareSoilSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManurePileSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManurePileSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManurePileSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManurePileLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManurePileLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManurePileLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterAquacultureSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAquacultureSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterAnchorageMooringSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterDisposalAtSea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterMarinePark:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterMarinePark, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterMarineParkReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterMarineParkText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterSeaport:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterSeaport, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterSeaportReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterSeaportText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceSandBar:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceSandBar, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceSandBarReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceSandBarText, retStrText);
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
                        case PolSourceObsInfoEnum.AquacultureCages:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCages, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCagesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCagesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureFloatingBags:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBags, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBagsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBagsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSubmergedLines:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLines, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLinesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLinesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureVessel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVessel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVesselReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVesselText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureResidental:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidental, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidentalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidentalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDumpSiteActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDumpSiteNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaportRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaportRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaportRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaportRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaportCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaportCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaportCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaportCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeSalt:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeSalt, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeSaltReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeSaltText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeBrachish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeBrachish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeBrachishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeBrachishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeFresh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeFresh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeFreshReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeFreshText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourcePeople:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourcePeople, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourcePeopleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSewageDirectDischarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageDirectDischarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageDirectDischargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSepticSystemFullRention:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSepticSystemFullRention, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSepticSystemFullRentionText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualSmallMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualLargeMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualLargeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualMediumBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualMediumBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualSmallBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSandy:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSandy, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSandyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSandyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRocky:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRocky, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRockyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRockyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineLandFill:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineLandFill, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineLandFillReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineLandFillText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSlipway:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSlipway, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSlipwayReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineSlipwayText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineDayuse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineDayuse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineDayuseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineDayuseText, retStrText);
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
                        case PolSourceObsInfoEnum.SourceTypeShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShorelineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeMarineText, retStrText);
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
                        case PolSourceObsInfoEnum.RiskHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRiskHighText, retStrText);
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
