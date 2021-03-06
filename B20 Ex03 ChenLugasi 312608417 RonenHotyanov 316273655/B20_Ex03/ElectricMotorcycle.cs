﻿using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : ElectricVehicle
    {
        private const int k_NumberOfWheels = (int)Wheel.eNumberOfWheels.Motorcycle;
        private const float k_MaxWheelAirPressure = (float)Wheel.eMaximumAirPressure.Motorcycle;
        private const float k_MaximumBatteryTime = 1.2f;
        private readonly Motorcycle r_MotorcycleData = new Motorcycle();

        public ElectricMotorcycle(string i_VehicleLicenseNumber)
            : base(i_VehicleLicenseNumber, k_MaximumBatteryTime)
        {
        }

        public override Dictionary<string, string> GetSpecificInfo()
        {
           return r_MotorcycleData.GetSpecificInfo();
        }

        public override void SetSpecificInfo(string i_OutputMember, string i_UserInput)
        {
            r_MotorcycleData.SetSpecificInfo(i_OutputMember, i_UserInput);
        }

        protected override void InitializeVehicleWheels(List<Wheel> i_Wheels)
        {
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                i_Wheels.Add(new Wheel(k_MaxWheelAirPressure));
            }
        }

        public override string ToString()
        {
            StringBuilder vehicleData = new StringBuilder();
            vehicleData.Append(base.ToString());
            vehicleData.Append(r_MotorcycleData.ToString());
            return vehicleData.ToString();
        }
    }
}
