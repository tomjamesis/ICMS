using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    public class Enums
    {
        public enum KnownIpmsComponentArea
        {
            A_VerticalPenetration,
            A1_VerticalCircularPenetrations,
            A2_VerticalTechnicalPenetrations,
            B_StructuralElements,
            B1_ExternalWall,
            B2_InternalStructuralElements,
            B3_InternalNonStructuralElements,
            C_TechnicalServices,
            D_HygeneAreas,
            E_CirculationAreas,
            E1_CirculationAreas,
            E2_CirculationAreas,
            F_Amenities,
            G_WorkspaceLivingSpaceRetailSpace,
            H_OtherAreas
        }
        public enum KnownIpmsComponentUsage
        {
            Private,
            Shared
        }
        public enum KnownUnitOfMeasurement
        {
            MTK,
            KMK,
            H30,
            H59,
            DAA,
            CMK,
            DMK,
            H16,
            H18,
            MMK,
            ARE,
            HAR,
            INK,
            FTK,
            YDK,
            MIK,
            M48,
            ACR,
            M47,
            C62,
            MTR,
            E96,
            H27,
            M55,
            DMT,
            CMT,
            _4H,
            MMT,
            HMT,
            KTM,
            KMT,
            C45,
            C52,
            A71,
            A45,
            NMI,
            A11,
            A12,
            C63,
            F52,
            F50,
            F51,
            G06,
            H84,
            G04,
            G05,
            H79,
            AK,
            X1,
            INH,
            M7,
            FOT,
            YRD,
            SMI,
            _77,
            B57,
            F49,
            MAM,
            K13,
            K17,
            K45,
            K46,
            L98,
            L99,
            M49,
            M50,
            M51,
            M52,
            HM,
            KHM,
            MTQ,
            MAL,
            LTR,
            MMQ,
            CMQ,
            DMQ,
            MLT,
            HLT,
            CLT,
            DMA,
            H19,
            H20,
            M71,
            DLT,
            _4G,
            K6,
            A44,
            G94,
            G95,
            G96,
            G97,
            _5I,
            INQ,
            FTQ,
            YDQ,
            GLI,
            GLL,
            PT,
            PTI,
            QTI,
            PTL,
            QTL,
            PTD,
            OZI,
            QT,
            J57,
            K21,
            K23,
            L43,
            L61,
            L62,
            L84,
            L86,
            M11,
            M14,
            OZA,
            BUI,
            BUA,
            BLL,
            BLD,
            GLD,
            QTD,
            G26,
            G21,
            G24,
            G25,
            G23,
            M67,
            M68,
            M69,
            M70
        }
        public enum KnownMeasurement
        {
            volume,
            area,
            width,
            maxWidth,
            minWidth,
            avgWidth,
            length,
            minLength,
            avgLength,
            maxLength,
            height,
            maxHeight,
            avgHeight,
            minHeight
        }
        public enum KnownFileExtension
        {
            dwg,
            dxf,
            dgn,
            prw,
            prp,
            _3ds,
            ifc,
            prj,
            rvt,
            rte,
            rar,
            ta,
            zip,
            csv,
            dat,
            xml,
            bin,
            bmp,
            gif,
            jpeg,
            jpg,
            png,
            ps,
            psd,
            svg,
            htm,
            html,
            xhtml,
            xls,
            xlsx,
            avi,
            mp4,
            mpg,
            mpeg,
            doc,
            docx,
            odt,
            pdf,
            rtf,
            tex,
            txt
        }
        public enum KnownIpms3Measurement
        {
            _3,
            _3A,
            _3B,
            _3C
        }
        public enum KnownAccuracyMm
        {
            _5,
            _10,
            _25,
            _50
        }
        public enum KnownLimitedUseCategory
        {
            Other,
            AreaDifferenceFromInternalDominantFace,
            AreaWithLimitedHeight,
            AreaWithLimitedNaturalLight,
            AboveGround,
            BelowGround,
            AreaDifferenceFromCoveredArea,
            InternalStructureWallsColumns
        }
        public enum KnownSeparateAreaCategory
        {
            Other,
            ExternalBalconies,
            CoveredGalleries,
            AccessibleRooftopTerraces,
            PatiosAndDecksAtGroundLevelNotPartOfBuildingStructure,
            ExternalVehicleParking,
            EquipmentYards,
            CoolingEquipment,
            RefuseAreas,
            GroundLevelAreasNotFullyEnclosed,
            OpenLightWells,
            UpperLevelVoidsOfAnAntrium,
            StandardFacilities,
            OpenExternalStairwaysNotPartOfBuildingStructure,
            SharedCirculationAreas,
            EnclosedWalkwaysOrPassages,
            Verandas,
            InternalCatwalks,
            ExternalCatwalks,
            ShelteredAreas,
            InternalPermanentMezzanines,
            PermanentMezzanines,
            TemporaryMezzanines,
            VehicleCirculation,
            InternalLoadingBays,
            ExternalLoadingBays,
            VerticalPenetrationsAsPartOfCommonFacilities,
            Garages,
            EnclosedGarages,
            Patios,
            UnenclosedVehicleParkingAreas,
            StaircaseOpenings,
            StaircaseOpeningsAboveLevel0,
            Voids,
            Attics,
            Basements,
            Cellars,
            BalconiesInExclusiveUse,
            VerandasInExclusiveUse,
            Mezzanines,
            Balconies,
            LoadingBays,
            TemporaryStructures,
            StructuresBeyondTheCoveredArea,
            AncilliaryAreas
        }
        public enum KnownBuildingUse
        {
            Residential,
            Industrial,
            Retail,
            Office,
            MixedUse
        }
        public enum KnownFileCategory
        {
            FloorPlan,
            Concept,
            BimModel,
            ScaleDiagram,
            Photograph,
            Video
        }
        public enum VerificationType
        {
            MeasuredOnSite,
            ExistingVerifiedOnSite
        }
        public enum Funding
        {
            _private,
            _public,
            privateAndPublicInPartnership
        }
        public enum KnownModeOfProcurement
        {
            designBidBuild,
            designAndBuildTurnkey,
            buildOperateAndTransfer,
            publicPrivatePartnership,
            managementContracting,
            constructionManagement,
            engineerProcureConstruct,
            target
        }
        public enum KnownBuildingFunctional
        {
            noOfOccupants,
            noOfBedrooms,
            noOfHospitalBeds,
            noOfHotelRooms,
            noOfCarParkingSpaces,
            noOfClassrooms,
            noOfStudents,
            noOfPassengers,
            noOfBoardingGates
        }
        public enum RoadAndMotorwayFunctionalUnits
        {
            vehiclesPerHour
        }
        public enum ChemicalPlantFunctional
        {
            outputOfProduct
        }
        public enum RefineryFunctional
        {
            inputOfCrudeOil,
            outputOfProduct
        }
        public enum RailwayFunctional
        {
            weightOfTraffic,
            passengerJourneys
        }
        public enum BridgeTunnelFunctionalUnits
        {
            vehiclesPerHour,
            litresPerHour,
            gallonsPerHour,
            tonnesPerHour,
            tonsPerHour
        }
        public enum TreatmentFunctionalUnits
        {
            litresPerDay,
            gallonsPerDay
        }
        public enum LocalForeign
        {
            local,
            foreign
        }
        public enum KnownPricingMethod
        {
            lumpSumStipulatedPrice,
            remeasurement,
            costReimbursement
        }
        public enum StoreyQualitativeDescription
        {
            house,
            lowRise,
            mediumRise,
            highRise
        }
        public enum SiteStateOfUse
        {
            greenfield,
            brownfield
        }
        public enum SiteTypeOfUse
        {
            urban,
            rural,
            agricultural
        }
        public enum AboveBelow
        {
            above,
            below
        }
        public enum KnownSiteLegalStatus
        {
            freehold,
            leasehold,
            jointVenture,
            notOwned
        }
        public enum GroundConditions
        {
            soft,
            rocky,
            reclaimed
        }
        public enum DifficultyRating
        {
            difficult,
            average,
            easy
        }
        public enum KnownTopography
        {
            principallyFlat,
            principallyHilly,
            mountainous,
            offshore
        }
        public enum CostReportStatus
        {
            preConstructionForecast,
            atTender,
            duringConstruction,
            actualCostsOfConstructionPostCompletion
        }
        public enum ReportPriceBasis
        {

            _fixed,
            fluctuating
        }
        public enum KnownProjectDescription
        {
            building,
            roadsAndMotorway,
            railway,
            bridge,
            tunnel,
            wasteWaterTreatmentWorks,
            waterTreatmentWorks,
            pipeline,
            chemicalPlant,
            refinery,
            common
        }
        public enum ProjectStatus
        {
            initiationAndConcept,
            design,
            constructionAndCommissioning,
            complete
        }
        public enum KnownBuildingFunction
        {
            residential,
            office,
            commercial,
            shoppingCentre,
            industrial,
            hotel,
            carPark,
            warehouse,
            educational,
            hospital,
            airportTerminal,
            railwayStation,
            ferryTerminal,
            plantFacility
        }
        public enum BuildNature
        {
            newBuild,
            majorRefurbishment,
            temporary
        }
        public enum RoadAndMotorwayFunction
        {
            motorway,
            highway,
            freeway,
            expressway,
            road,
            lane
        }
        public enum KnownRailwayFunction
        {
            highSpeed,
            express,
            lightRail,
            tram,
            freight,
            mixedTraffic
        }
        public enum KnownTreatmentFunction
        {
            screening,
            preOzonation,
            coagulation,
            flocculation,
            clarification,
            filtration,
            pHCorrection,
            chemicalDosing,
            chlorination
        }
        public enum KnownBridgeTunnelFunction
        {
            road,
            rail,
            conveyor,
            pipeline,
            canal,
            pedestrian
        }
        public enum PipelineFunction
        {
            liquid,
            gas,
            powder
        }
        public enum KnownWellAndBoreholeFunction
        {
            water,
            gas,
            oil
        }
        public enum KnownPowerGeneratingPlantCoolant
        {
            water,
            gas
        }
        public enum KnownPowerGeneratingPlantFunction
        {
            nuclear,
            wind,
            solar,
            hydroelectric,
            geothermal,
            biomass,
            gas,
            coal,
            oil
        }
        public enum KnownRefineryFunction
        {
            oil,
            petrol
        }
        public enum KnownBridgeSupport
        {
            arch,
            postAndBeam,
            cantilever,
            suspension,
            cableStayed
        }
        public enum KnownBridgeObstacleCrossed
        {
            riverAndCanal,
            roadAndMotorway,
            railway
        }
        public enum BridgeMobiliyt
        {
            _fixed,
            moved,
            temporary
        }
        public enum BuildGrade
        {
            ordinary,
            medium,
            high
        }
        public enum GradeStatus
        {
            targeted,
            acheived,
            none
        }
        public enum KnownBuildingStructure
        {
            timber,
            concrete,
            steel,
            loadBearingMasonry
        }
        public enum KnownWallDesign
        {
            stone,
            brick_block,
            render_block,
            curtainWalling
        }
        public enum KnownConstructionToState
        {
            completionOfCommissioning
        }
        public enum EnvironmentalControl
        {
            nonAirConditioning,
            airConditioning
        }
        public enum PrefabricationDegree
        {
            _25,
            _50,
            _75,
            _100
        }
        public enum Shape
        {
            circluarEllipticalOrSimilar,
            squareRectangularOrSimilar,
            complex
        }
        public enum DesignComplexity
        {
            simple,
            bespoke,
            complex
        }
        public enum KnownWorkingMethod
        {
            sectionalCompletion,
            outOfHours,
            confinedWorking
        }
        public enum RoadAndMotorwayPosition
        {
            atGrade,
            inCutting,
            inTunnel,
            onEmbankment,
            elevated
        }
        public enum KnownRailwayPosition
        {
            atGrade,
            inTunnel,
            elevated
        }
        public enum RoadAndMotorwaySurface
        {
            flexibleConstruction,
            concretePavement
        }
        public enum RoadAndMotorwayVerticalProfile
        {
            switchbacks,
            undulating,
            flat
        }
        public enum RoadAndMotorwayPlanProfile
        {
            straight,
            winding
        }
        public enum Curvature
        {
            straight,
            curved
        }
        public enum KnownPowerGeneratingCoolingSystem
        {
            wind,
            water
        }
        public enum KnownTrainPowerSystem
        {
            overheadAC,
            overheadDC,
            thirdOrContactRailDC,
            dieselElectric
        }
        public enum KnownConstructionDateDefinedBy
        {
            startOfDemolitionAndSitePreparation
        }
        public enum RailwayConstructionRigidity
        {
            flexible,
            rigid
        }
        public enum RailwayRailJoints
        {
            fishPlated,
            welded
        }
        public enum KnownRailwayControlSystem
        {
            europeanControlSystem,
            inCab,
            blockSignalling,
            centralizedTrafficControl
        }
        public enum RailwaySignallingSystem
        {
            europeanRailwayTrafficManagementSystem,
            semaphore,
            colouredLight
        }
        public enum KnownMaterial
        {
            naturalMaterials,
            wood,
            concrete,
            steel,
            advancedMaterials
        }
        public enum KnownTunnellingMethod
        {
            cutAndFill,
            tunnellBoringMachine,
            drillAndBlast,
            immersed
        }
        public enum TunnelLining
        {
            iron,
            steel,
            concrete,
            notLined
        }
        public enum HorizontalProfile
        {
            flat,
            undulating
        }
        public enum KnownCrossSectionalShape
        {
            circular,
            oval,
            rectangular
        }
        public enum XDimensionDescriptor
        {
            widthXHeight,
            lengthXWidthXHeight,
            diameter
        }
        public enum Level
        {
            primary,
            secondary,
            tertiary,
            quaternary,
            quinary,
            senary,
            septenary,
            octonary,
            nonary,
            denary
        }
        public enum KnownPipelineMaterial
        {
            steel,
            castIron,
            precastConcrete,
            uPvc
        }
        public enum LandUnderwater
        {
            onLand,
            underwater
        }
        public enum CapacityFunctional
        {
            capacity
        }
        public enum CapacityFunctionalUnits
        {
            litresPerHour,
            gallonsPerHour,
            tonnesPerHour,
            tonsPerHour,
            vehiclesPerHour,
            m3PerHour,
            ft3PerHour,
            litresPerDay,
            gallonsPerDay,
            tonnesPerDay,
            tonsPerDay,
            m3PerDay,
            ft3PerDay,
            barrelsPerDay,
            megaWatts
        }
        public enum RailwayFunctionalUnits
        {
            mTonnesPerYear,
            mTonsPerYear,
            millionJourneysPerYear
        }
        public enum PipelineDrillingBoringMethod
        {
            cutCover,
            directional
        }
        public enum OnshoreOffshore
        {
            onshore,
            offshore
        }
        public enum Directional
        {
            vertical,
            directional
        }
        public enum OpenClose
        {
            open,
            close
        }
        public enum RefineryProcess
        {
            upstream,
            downstream
        }
        public enum KnownChemicalPlantProcess
        {
            oxidation,
            reduction,
            hydrogenation,
            dehydrogenation,
            hydrolysis,
            hydration,
            dehydration,
            halogenation,
            nitrification,
            sulphonation,
            ammoniation,
            alkalineFusion,
            alkylation,
            dealkylation,
            esterification,
            polmerization,
            polycondensation,
            catalysis
        }
        public enum KnownReactorMaterial
        {
            mildSteel,
            stainlessSteel,
            concrete
        }
        public enum KnownProjectClassificationStandardName
        {
            ISO12006_2,
            ISICRev4
        }
    }
}
