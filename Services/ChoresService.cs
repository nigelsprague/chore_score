namespace chore_score.Services;

public class ChoresService
{
  public ChoresService(ChoresRepository choresRepository)
  {
    _choresRepository = choresRepository;
  }

  private readonly ChoresRepository _choresRepository;

  internal List<Chore> GetAllChores()
  {
    List<Chore> chores = _choresRepository.getAllChores();
    return chores;
  }
}