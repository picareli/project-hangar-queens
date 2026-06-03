using System;

namespace ProjectHangarQueens
{
    /// <summary> List of possible model descriptors for an Aircraft. </summary>
    [Serializable]
    public enum Descriptors
    {
        LandPlane = 1,
        Seaplane,
        Amphibian,
        Helicopter
    }

    /// <summary> List of possible types for the engines of an Aircraft. </summary>
    [Serializable]
    public enum EngineTypes
    {
        Piston = 1,
        Turboprop,
        Jet,
        Rocket,
        Electric
    }

    /// <summary> List of possible fuels to be used by a AircraftModel. </summary>
    [Serializable]
    public enum FuelTypes
    {
        AvGas = 1,
        JetA
    }

    /// <summary> List of possible weight categories for an AircraftModel. </summary>
    [Serializable]
    public enum WeightCategories
    {
        Light = 1,
        Medium,
        Heavy,
        Super
    }

    /// <summary> List of possible approach speed categories for an AircraftModel. </summary>
    [Serializable]
    public enum ApproachCategories
    {
        A = 1,
        B,
        C,
        D,
        E
    }

    /// <summary> List of possible Runway types. </summary>
    [Serializable]
    public enum RunwayTypes
    {
        Soft = 1,
        Hard
    }

    /// <summary> List of possible Cargo types. </summary>
    [Serializable]
    public enum CargoTypes
    {
        GeneralGoods = 1,
        Mail,
        Electronics,
        Foodstuff,
        Live,
        Medical,
        BuildingMaterials,
        IndustrialEquipment,
        Vehicle,
        Aircraft,
        MechanicalParts,
        Chemical,
        Dangerous,
        Illegal
    }

    /// <summary> List of possible Passenger types. </summary>
    [Serializable]
    public enum PassengerTypes
    {
        Child = 1,
        Male,
        Female
    }
}