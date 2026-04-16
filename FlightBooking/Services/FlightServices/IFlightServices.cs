using FlightBooking.Dtos.FlightDtos;

namespace FlightBooking.Services.FlightServices
{
    public interface IFlightServices
    {
        Task<List<ResultFlightDto>> GetAllFlightsAsync();
        Task<GetFlightByIdDto> GetFlightByIdAsync(string id);
        Task CreateFlightAsync(CreateFlightDto createFlightDto);
        Task DeleteFlightAsync(string id);
        Task UpdateFlightAsync(UpdateFlightDto updateFlightDto);
    }
}
