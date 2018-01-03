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
                        case PolSourceObsInfoEnum.ShorelineRiparionZoneStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparionZoneStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineRiparionZoneStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.AgrAreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForestedStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypeOfFishStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfFishStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypeOfFishStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishOperationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishOperationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FISCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFISCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineStructureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineStructureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineStructureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaWallSourceSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaWallSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.MarBldCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.RecTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundFacilitiesStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundFacilitiesStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumCampgroundFacilitiesStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECFecalSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECFecalSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECFecalSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecSewageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.BuildingAgricultureSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAgricultureSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAgricultureSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAgricultureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAgricultureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAgricultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingTypeSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingTypeSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingTypeSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllSingleStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.TypesLandBIrdsStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLandBIrdsStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLandBIrdsStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesLargeWildAnimalsStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesSmallWildAnimalsStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalNumberPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalNumberPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnimalNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WasteSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FieldLocationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFieldLocationStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.PointCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointSourceSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointSourceSingleStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.ManureAreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSiteStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSiteStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSiteStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnchorageMooringSiteStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnchorageMooringSiteStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnchorageMooringSiteStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DisposalAtSeaStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDisposalAtSeaStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDisposalAtSeaStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineParkStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineParkStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineParkStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OutcropStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.WatStructActiveStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructActiveStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructActiveStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureSiteSingleStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureSiteSingleStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureSiteSingleStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureSiteStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureSiteStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureSiteStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.HumanSewageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanSewageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanSewageStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.ShorelineBirdsStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaBirdsStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.LargeMarineMammalStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SmallMarineanimalStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarinePointSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarinePointSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarinePointSourceStartDesc, retStrDesc);
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
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters5Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters10Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters20Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters30Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters50Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters200Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters400Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters800:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters800, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters800Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMeters1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMeters1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistancetoSaltWaterInMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDistancetoSaltWaterInMetersGreaterThan1000Report, retStrReport);
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
                        case PolSourceObsInfoEnum.SourceTypeLandFisheries:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandFisheries, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandFisheriesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandFisheriesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandIndustry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandMarineStructure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarineStructure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarineStructureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarineStructureText, retStrText);
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
                        case PolSourceObsInfoEnum.FarmCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFarmCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersequals10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersequals20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersequals40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersequals60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersequals80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersequals100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersequals100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersbetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersbetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersbetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersbetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersBetween251And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersBetween251And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersBetween251And500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersBetween251And500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersBetween501And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersBetween501And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersBetween501And1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersBetween501And1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgrAreaMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersGreaterThan1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAgrAreaMetersGreaterThan1000Text, retStrText);
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
                        case PolSourceObsInfoEnum.ForAreaMetersequals10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersequals20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersequals40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersequals60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersequals80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersequals100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersequals100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersbetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersbetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersbetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersbetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersBetween251And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersBetween251And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersBetween251And500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersBetween251And500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersBetween501And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersBetween501And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersBetween501And1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersBetween501And1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForAreaMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersGreaterThan1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumForAreaMetersGreaterThan1000Text, retStrText);
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
                        case PolSourceObsInfoEnum.IndustryBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumIndustryBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberBetween25and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberBetween25and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberBetween25and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberBetween25and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.INDCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumINDCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishShellfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishShellfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishShellfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishShellfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishFinfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishFinfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishFinfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishFinfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishLobster:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishLobster, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishLobsterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishLobsterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishFishMeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishFishMeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishFishMealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishFishMealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessing:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessing, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishHeldAlive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishHeldAlive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishHeldAliveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishHeldAliveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishPackaging:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishPackaging, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishPackagingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishPackagingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishingRearing:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishingRearing, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishingRearingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFishingRearingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishHatcherySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcherySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcherySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcherySingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishTanksSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanksSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanksSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanksSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishPondsSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishPondsSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishPondsSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishPondsSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishWarehouseSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouseSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouseSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouseSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishCommercialSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercialSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercialSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercialSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishHatchery:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatchery, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcheryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcheryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishInsideTanks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishInsideTanks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishInsideTanksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishInsideTanksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishPounds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishPounds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishPoundsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishPoundsText, retStrText);
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
                        case PolSourceObsInfoEnum.MarNumPresentEqual1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentEqual10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentEqual10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentBetween25and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentBetween25and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentBetween25and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentBetween25and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarNumPresentGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarNumPresentGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaWallSourceSingleCulvert:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceSingleCulvert, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceSingleCulvertReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceSingleCulvertText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaWallSourceSinglePipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceSinglePipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceSinglePipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceSinglePipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaWallSourceCulvert:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceCulvert, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceCulvertReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourceCulvertText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaWallSourcePipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourcePipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourcePipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaWallSourcePipeText, retStrText);
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
                        case PolSourceObsInfoEnum.WharfBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWharfBuildingsText, retStrText);
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
                        case PolSourceObsInfoEnum.TransportationCommericalSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommericalSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommericalSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommericalSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationFerrySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerrySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerrySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerrySingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationPleasureCraftSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationPleasureCraftSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationPleasureCraftSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationPleasureCraftSingleText, retStrText);
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
                        case PolSourceObsInfoEnum.TransportationPleasureCraft:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationPleasureCraft, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationPleasureCraftReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTransportationPleasureCraftText, retStrText);
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
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarBldCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarBldCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllCottageSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCottageSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCottageSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCottageSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllTrailerSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllTrailerSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllTrailerSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllTrailerSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllResidentialSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllResidentialSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllResidentialSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllResidentialSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllWarehouseSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllWarehouseSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllWarehouseSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllWarehouseSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllHotelMotelSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllHotelMotelSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllHotelMotelSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllHotelMotelSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllCommericalSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCommericalSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCommericalSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCommericalSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllSchoolSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllSchoolSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllSchoolSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllSchoolSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllChurchSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllChurchSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllChurchSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllChurchSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllmedicalFacilitySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllmedicalFacilitySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllmedicalFacilitySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllmedicalFacilitySingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllCottage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCottage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCottageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCottageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllResidential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllResidential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllResidentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllResidentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllHotelMotel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllHotelMotel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllHotelMotelReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllHotelMotelText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllSchool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllSchool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllSchoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllSchoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllChurch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllChurch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllChurchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllChurchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MARBuildingAllmedicalFacility:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllmedicalFacility, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllmedicalFacilityReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMARBuildingAllmedicalFacilityText, retStrText);
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
                        case PolSourceObsInfoEnum.RECcampgrdLotsapprox10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECcampgrdLotsapprox30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECcampgrdLotsapprox50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECcampgrdLotsapprox100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECcampgrdLotsapprox200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox200Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox200Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECcampgrdLotsapprox300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox300Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox300Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RECcampgrdLotsapprox500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRECcampgrdLotsapprox500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecTents:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTents, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTentsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTentsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecTrailersandTents:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTrailersandTents, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTrailersandTentsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecTrailersandTentsText, retStrText);
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
                        case PolSourceObsInfoEnum.RecFecalSourcePeople:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourcePeople, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourcePeopleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecFecalSourceWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourceWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourceWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecFecalSourceDrainagewater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourceDrainagewater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourceDrainagewaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourceDrainagewaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecFecalSourcePets:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourcePets, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourcePetsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecFecalSourcePetsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecSewageCesspool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewageCesspool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewageCesspoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewageCesspoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecSewagePrivyOuthouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewagePrivyOuthouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewagePrivyOuthouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewagePrivyOuthouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecSewageMunicipalSystem:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewageMunicipalSystem, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewageMunicipalSystemReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSewageMunicipalSystemText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecSepticSystemDrainageField:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemDrainageField, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemDrainageFieldReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemDrainageFieldText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecSepticSystemLagoon:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemLagoon, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemLagoonReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemLagoonText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecSepticSystemConstructedWetland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemConstructedWetland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemConstructedWetlandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticSystemConstructedWetlandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecSepticFreeFlow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticFreeFlow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticFreeFlowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecSepticFreeFlowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecNumPresentGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumRecNumPresentGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDirectDischarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageFlowStructure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageFlowStructure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageFlowStructureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageFlowStructureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewagePrivyOuthouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemLeachateField:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLeachateField, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLeachateFieldReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLeachateFieldText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemFullRention:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRention, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRentionText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageCesspool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemLagoon:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoon, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoonReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoonText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageSystemConstructedWetland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSystemConstructedWetland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSystemConstructedWetlandReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageSystemConstructedWetlandText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageMunicipalSystem:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystem, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystemReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystemText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticNoINformation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoINformation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoINformationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSepticNoINformationText, retStrText);
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
                        case PolSourceObsInfoEnum.TankSize100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSize500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSize1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSize2000plus:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize2000plus, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize2000plusReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTankSize2000plusText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingResidentialFarmSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarmSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarmSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarmSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingWarehouseFarmSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarmSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarmSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarmSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingCommericalFarmSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarmSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarmSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarmSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingBarnFarmSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarmSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarmSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarmSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingRecreationalFarmSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalFarmSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalFarmSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalFarmSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingSchoolFarmSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingSchoolFarmSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingSchoolFarmSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingSchoolFarmSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingChurchFarmSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingChurchFarmSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingChurchFarmSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingChurchFarmSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingMedicalFacilityFarmSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingMedicalFacilityFarmSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingMedicalFacilityFarmSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingMedicalFacilityFarmSingleText, retStrText);
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
                        case PolSourceObsInfoEnum.BuildingRecreationalFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingSchoolFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingSchoolFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingSchoolFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingSchoolFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingChurchFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingChurchFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingChurchFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingChurchFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingMedicalFacilityFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingMedicalFacilityFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingMedicalFacilityFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingMedicalFacilityFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AGRCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAGRCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FORCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFORCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedResidentialSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidentialSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidentialSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidentialSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedWarehouseSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouseSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouseSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouseSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedRecreationalSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreationalSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreationalSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreationalSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedTrailerSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailerSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailerSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailerSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedFactorySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactorySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactorySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactorySingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedCommericalSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommericalSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommericalSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommericalSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedSchoolSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedSchoolSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedSchoolSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedSchoolSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedChurchSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedChurchSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedChurchSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedChurchSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedMedicalFacilitySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedMedicalFacilitySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedMedicalFacilitySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedMedicalFacilitySingleText, retStrText);
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
                        case PolSourceObsInfoEnum.BuildingForestedSchool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedSchool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedSchoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedSchoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedChurch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedChurch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedChurchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedChurchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedMedicalFacility:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedMedicalFacility, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedMedicalFacilityReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedMedicalFacilityText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingindustryWarehouseSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouseSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouseSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouseSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryFactorySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactorySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactorySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactorySingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryCommericalSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommericalSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommericalSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommericalSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustrySchoolSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustrySchoolSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustrySchoolSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustrySchoolSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryChurchSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryChurchSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryChurchSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryChurchSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryMedicalFacilitySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryMedicalFacilitySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryMedicalFacilitySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryMedicalFacilitySingleText, retStrText);
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
                        case PolSourceObsInfoEnum.BuildingIndustrySchool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustrySchool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustrySchoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustrySchoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryChurch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryChurch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryChurchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryChurchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryMedicalFacility:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryMedicalFacility, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryMedicalFacilityReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryMedicalFacilityText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCottageSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottageSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottageSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottageSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllTrailerSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailerSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailerSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailerSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllResidentialSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidentialSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidentialSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidentialSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllWarehouseSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouseSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouseSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouseSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllHotelMotelSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotelSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotelSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotelSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCommericalSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommericalSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommericalSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommericalSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllSchoolSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllSchoolSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllSchoolSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllSchoolSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllChurchSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllChurchSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllChurchSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllChurchSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllmedicalFacilitySingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllmedicalFacilitySingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllmedicalFacilitySingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllmedicalFacilitySingleText, retStrText);
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
                        case PolSourceObsInfoEnum.BuildingAllSchool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllSchool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllSchoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllSchoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllChurch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllChurch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllChurchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllChurchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllmedicalFacility:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllmedicalFacility, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllmedicalFacilityReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllmedicalFacilityText, retStrText);
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
                        case PolSourceObsInfoEnum.AreaMetersEquals5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersEquals10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersEquals20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersEquals40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersEquals60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersEquals80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersEquals100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersEquals100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersBetween101And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween101And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween101And250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween101And250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersBetween251And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween251And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween251And500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween251And500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersBetween501And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween501And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween501And1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersBetween501And1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaMetersgreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersgreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersgreaterThan1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAreaMetersgreaterThan1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourcePeople:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeople, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeopleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourcePets:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePets, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePetsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePetsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceLivestock:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestock, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestockReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestockText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceDrainagewater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalProcessWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalProcessWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalProcessWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalProcessWaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalPotentialContamination:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalPotentialContamination, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalPotentialContaminationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalPotentialContaminationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsentText, retStrText);
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
                        case PolSourceObsInfoEnum.MajorIssueAccumulatedRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAccumulatedRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAccumulatedRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAccumulatedRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSurfaceRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSurfaceRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSurfaceRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSurfaceRunoffText, retStrText);
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
                        case PolSourceObsInfoEnum.TypesEqualHorses:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualHorses, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualHorsesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualHorsesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualCows:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualCows, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualCowsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualCowsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSheep:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSheep, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSheepReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSheepText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualPigs:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualPigs, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualPigsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualPigsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticMixtureLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualChickens:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualChickens, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualChickensReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualChickensText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualTurkeys:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualTurkeys, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualTurkeysReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualTurkeysText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDucks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDucks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDucksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDucksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualGeese:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualGeese, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualGeeseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualGeeseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticMixtureSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualFurFarms:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarms, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarmsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarmsText, retStrText);
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
                        case PolSourceObsInfoEnum.TypesEquallandBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEquallandBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEquallandBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEquallandBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualMarinebirdsSeals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMarinebirdsSeals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMarinebirdsSealsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMarinebirdsSealsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesLandBirdsCrows:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLandBirdsCrows, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLandBirdsCrowsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLandBirdsCrowsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesLandBirdsEagle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLandBirdsEagle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLandBirdsEagleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLandBirdsEagleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesLargeWildAnimalsMoose:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsMoose, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsMooseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsMooseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesLargeWildAnimalsDeer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsDeer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsDeerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsDeerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesLargeWildAnimalsCoyote:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsCoyote, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsCoyoteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesLargeWildAnimalsCoyoteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesSmallWildAnimalsFoxes:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsFoxes, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsFoxesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsFoxesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesSmallWildAnimalsGroundHogs:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsGroundHogs, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsGroundHogsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsGroundHogsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesSmallWildAnimalsSkunks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsSkunks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsSkunksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumTypesSmallWildAnimalsSkunksText, retStrText);
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
                        case PolSourceObsInfoEnum.WasteSourceTypeLandCulvert:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandCulvert, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandCulvertReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandCulvertText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WasteSourceTypeLandPipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandPipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandPipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandPipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WasteSourceTypeLandWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WasteSourceTypeLandDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WasteSourceTypeLandDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeLandDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WasteSourceTypeDirectInputToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeDirectInputToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypeDirectInputToMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WasteSourceTypetoField:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypetoField, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypetoFieldReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWasteSourceTypetoFieldText, retStrText);
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
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumPointCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandCulvertSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvertSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvertSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvertSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandPipeSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipeSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipeSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipeSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandWaterCourseSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourseSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourseSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourseSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDitchSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitchSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitchSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitchSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDrainageSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainageSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainageSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainageSingleText, retStrText);
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
                        case PolSourceObsInfoEnum.DitchDirectlytoWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchDirectlytoWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchDirectlytoWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDitchDirectlytoWaterText, retStrText);
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
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately70:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately70, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately70Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately70Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately90:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately90, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately90Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately90Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersapproximately100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersapproximately100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManureAreaMetersMoreThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersMoreThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersMoreThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumManureAreaMetersMoreThan100Text, retStrText);
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
                        case PolSourceObsInfoEnum.SourceLandOutcrop:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceLandOutcrop, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceLandOutcropReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSourceLandOutcropText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnchorageMooringSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnchorageMooringSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnchorageMooringSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAnchorageMooringSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DisposalAtSea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDisposalAtSea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDisposalAtSeaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumDisposalAtSeaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarinePark:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarinePark, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineParkReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineParkText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OutcropSandBar:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropSandBar, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropSandBarReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropSandBarText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OutcropRock:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropRock, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropRockReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.OutcropIsland:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropIsland, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumOutcropIslandReport, retStrReport);
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
                        case PolSourceObsInfoEnum.AquacultureCagesSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCagesSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCagesSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCagesSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureFloatingBagsSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBagsSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBagsSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBagsSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSubmergedLinesSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLinesSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLinesSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLinesSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureLosterPoundCageSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLosterPoundCageSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLosterPoundCageSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLosterPoundCageSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureBargesSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureBargesSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureBargesSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureBargesSingleText, retStrText);
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
                        case PolSourceObsInfoEnum.AquacultureLosterPoundCage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLosterPoundCage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLosterPoundCageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLosterPoundCageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureBarges:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureBarges, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureBargesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumAquacultureBargesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructInactive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructInactive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructInactiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructInactiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureVesselSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVesselSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVesselSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVesselSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureBargeSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBargeSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBargeSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBargeSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureResidentalSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidentalSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidentalSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidentalSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureCommercialSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercialSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercialSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercialSingleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureNotActiveSingle:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActiveSingle, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActiveSingleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActiveSingleText, retStrText);
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
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatStructCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatStructCountNumberGreaterThan40Text, retStrText);
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
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual20:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual20, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual20Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual20Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual60:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual60, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual60Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual60Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual80:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual80, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual80Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual80Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual150:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual150, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual150Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual150Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual200:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual200, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual200Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual200Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual250Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual250Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual300:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual300, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual300Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual300Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual400:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual400, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual400Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual400Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual750:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual750, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual750Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual750Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersEqual1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersEqual1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeMetersGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersGreaterThan1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeMetersGreaterThan1000Text, retStrText);
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
                        case PolSourceObsInfoEnum.WaterTypeSalt:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeSalt, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeSaltReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeBrachish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeBrachish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeBrachishReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeFresh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeFresh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeFreshReport, retStrReport);
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
                        case PolSourceObsInfoEnum.WaterFecalProcessWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalProcessWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalProcessWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalProcessWaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatCountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanSewageWashroom:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanSewageWashroom, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanSewageWashroomReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanSewageWashroomText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.HumanSewageWashroomAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanSewageWashroomAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanSewageWashroomAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumHumanSewageWashroomAbsentText, retStrText);
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
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo2:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo2, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo2Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo2Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo3:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo3, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo3Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo3Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo4:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo4, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo4Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo4Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo6:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo6, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo6Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo6Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo7:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo7, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo7Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo7Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo8:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo8, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo8Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo8Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo9:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo9, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo9Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo9Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentEqualTo10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentEqualTo10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentBetween26and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentBetween26and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentBetween26and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentBetween26and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WatNumberPresentGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWatNumberPresentGreaterThan40Text, retStrText);
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
                        case PolSourceObsInfoEnum.WaterTypesEqualSeaBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSeaBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSeaBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSeaBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualShorelineBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualShorelineBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualShorelineBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualShorelineBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBirdsPloversandSandpipers:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsPloversandSandpipers, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsPloversandSandpipersReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsPloversandSandpipersText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBirdsBlackBackedGulls:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsBlackBackedGulls, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsBlackBackedGullsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsBlackBackedGullsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBirdsHerringGulls:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsHerringGulls, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsHerringGullsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsHerringGullsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBirdsGreaterYellowlegs:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsGreaterYellowlegs, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsGreaterYellowlegsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsGreaterYellowlegsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBirdsSurfScoter:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsSurfScoter, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsSurfScoterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsSurfScoterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBirdsBrownPelican:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsBrownPelican, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsBrownPelicanReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsBrownPelicanText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBirdsOthers:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsOthers, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsOthersReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumShorelineBirdsOthersText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaBirdsCormorants:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsCormorants, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsCormorantsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsCormorantsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaBirdsDucks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsDucks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsDucksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsDucksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaBirdsGeese:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsGeese, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsGeeseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsGeeseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaBirdsBlackBlackGulls:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsBlackBlackGulls, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsBlackBlackGullsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsBlackBlackGullsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaBirdsLoons:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsLoons, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsLoonsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsLoonsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaBirdsSeaducks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsSeaducks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsSeaducksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsSeaducksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaBirdsOther:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsOther, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsOtherReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSeaBirdsOtherText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LargeMarineMammaGreySeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammaGreySeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammaGreySealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammaGreySealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LargeMarineMammalHoodedSeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalHoodedSeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalHoodedSealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalHoodedSealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LargeMarineMammalBeardSeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalBeardSeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalBeardSealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalBeardSealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LargeMarineMammalStellarSeaLion:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalStellarSeaLion, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalStellarSeaLionReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalStellarSeaLionText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LargeMarineMammalAtlanticWalrus:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalAtlanticWalrus, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalAtlanticWalrusReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalAtlanticWalrusText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LargeMarineMammalNorthernFurSeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalNorthernFurSeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalNorthernFurSealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumLargeMarineMammalNorthernFurSealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SmallMarineanimalHarpSeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalHarpSeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalHarpSealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalHarpSealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SmallMarineanimalHarbourSeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalHarbourSeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalHarbourSealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalHarbourSealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SmallMarineanimalSeaOtter:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalSeaOtter, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalSeaOtterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumSmallMarineanimalSeaOtterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentBetween6and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween6and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween6and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween6and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentBetween11and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween11and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween11and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween11and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentBetween26and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween26and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween26and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentBetween26and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan500Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan500Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan1000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan1000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan10000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan10000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan10000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan10000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan20000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan20000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan20000Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarineAnimalPresentGreaterThan20000Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarinePointSourceInputToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarinePointSourceInputToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarinePointSourceInputToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumRes.PolSourceInfoEnumMarinePointSourceInputToMarineText, retStrText);
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
