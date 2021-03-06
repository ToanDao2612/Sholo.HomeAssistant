using JetBrains.Annotations;
using Sholo.HomeAssistant.DeviceClasses;

namespace Sholo.HomeAssistant.Mqtt.EntityDefinitions.Sensor
{
    [PublicAPI]
    public interface ISensorEntityDefinition : ICoreSensorEntityDefinition
    {
        /// <summary>
        /// The type/class of the sensor to set the icon in the frontend.
        /// </summary>
        SensorDeviceClass? DeviceClass { get; }

        /// <summary>
        /// The icon for the sensor.
        /// </summary>
        string Icon { get; }

        /// <summary>
        /// Defines the units of measurement of the sensor, if any.
        /// </summary>
        string UnitOfMeasurement { get; }
    }
}
