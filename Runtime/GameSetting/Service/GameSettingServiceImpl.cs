using System.Collections;

public class GameSettingServiceImpl : IGameSettingService
{

    private IPlayerPrefRepository<GameSettingEntity> Repository = new GameSettingPlayerPrefRepository();
    public GameSettingDTO Get()
    {
        GameSettingEntity entity = Repository.GetT();
        if (entity == null) {
            return GameSettingDTO.defaultValue;
        } else {
            return GameSettingDTOConvertor.From(entity);
        }
    }

    public void init()
    {
        Repository.init();
    }

    public void lazyInit()
    {
        Repository.lazyInit();
    }

    public void refresh()
    {
        Repository.refresh();
    }

    public void Save(GameSettingDTO dto)
    {
        GameSettingEntity entity = GameSettingEntityConvertor.From(dto);
        Repository.Save(entity);
    }
}
