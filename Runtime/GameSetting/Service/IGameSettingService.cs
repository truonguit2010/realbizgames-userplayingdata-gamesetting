using System.Collections;

public interface IGameSettingService : IService
{
    GameSettingDTO Get();

    void Save(GameSettingDTO dto);
}
