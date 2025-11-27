namespace CleanArchitectureBlazor.Application
{
    public record CreateEventCommand(string Name, DateTime Date, int Capacity, string Description);
}
