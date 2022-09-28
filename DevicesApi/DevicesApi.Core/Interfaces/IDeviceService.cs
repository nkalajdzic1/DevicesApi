using DevicesApi.Core.Dtos;
using DevicesApi.Core.Responses;

namespace DevicesApi.Core.Interfaces
{
    public interface IDeviceService
    {
        /// <summary>
        ///  Method to return list of devices from the dabase based on the filter query parameters
        /// </summary>
        /// <param name="filterDevicesDto"> Devices filter dto, contains the page number, page size etc. </param>
        /// <returns> List of devices </returns>
        Task<Response<List<GetDeviceDto>>> Get(FilterDevicesDto filterDevicesDto);

        /// <summary>
        /// Method to return a device by id, with the full information about the device
        /// </summary>
        /// <param name="deviceId"> Id of the device </param>
        /// <returns> Device for the corresponding device id </returns>
        Task<Response<GetDeviceFullInfoDto>> GetById(int deviceId);

        /// <summary>
        /// Method to create a device
        /// </summary>
        /// <param name="createDeviceDto"> Create Device dto, containing all the properties for creating a device </param>
        /// <returns> The created device with the device id </returns>
        Task<Response<GetDeviceFullInfoDto>> Create(CreateDeviceDto createDeviceDto);

        /// <summary>
        /// Method to update device by id
        /// </summary>
        /// <param name="deviceId"> Id of the given device </param>
        /// <param name="updateDeviceDto"> data to update the given device </param>
        /// <returns> The updated device </returns>
        /// <exception cref="Exception"> Throws not found exception if an invalid id is given (item does not exist for the given id) </exception>
        Task<Response<GetDeviceFullInfoDto>> UpdateById(int deviceId, UpdateDeviceDto updateDeviceDto);

        /// <summary>
        /// Method to delete device by id
        /// </summary>
        /// <param name="deviceId"> Id of the given device </param>
        /// <returns> 204 status code if the device is deleted </returns>
        /// <exception cref="Exception"> Throws not found exception if an invalid id is given (item does not exist for the given id) </exception>
        Task<Response<bool>> DeleteById(int deviceId);
    }
}
