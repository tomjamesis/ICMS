using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class IpmsMeta : Meta
    {
        public List<AreaUnitOfMeasurementWithScaleFactor> AreaUnitOfMeasurement { get; set; }
        public List<LinearUnitOfMeasurementWithScaleFactor> LinearUnitOfMeasurement { get; set; }
        public List<VolumeUnitOfMeasurementWithScaleFactor> VolumeUnitOfMeasurement { get; set; }
        public List<AccuracyMm> AccuracyInMm { get; set; }
        public List<SpaceMeasurementProfessional> MeasuredBy { get; set; }
        public List<FloorPlan> FloorPlans { get; set; }
        public List<DateTime> InstructedMeasurementDate { get; set; }
        public List<DateTime> MeasurementDate { get; set; }

        public IpmsMeta()
        {
            AreaUnitOfMeasurement = new List<AreaUnitOfMeasurementWithScaleFactor>();
            LinearUnitOfMeasurement = new List<LinearUnitOfMeasurementWithScaleFactor>();
            VolumeUnitOfMeasurement = new List<VolumeUnitOfMeasurementWithScaleFactor>();
            AccuracyInMm = new List<AccuracyMm>();
            MeasuredBy = new List<SpaceMeasurementProfessional>();
            FloorPlans = new List<FloorPlan>();
            InstructedMeasurementDate = new List<DateTime>();
            MeasurementDate = new List<DateTime>();
        }
    }
}
