namespace HomeCenter.Mobil.Interfaces;
public interface IDataService
{
    Task Save(Holiday holiday);

    Task<IReadOnlyCollection<Holiday>> GetAll();
}
