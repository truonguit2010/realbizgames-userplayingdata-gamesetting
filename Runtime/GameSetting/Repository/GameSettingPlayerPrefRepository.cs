using System.Collections;

public class GameSettingPlayerPrefRepository : GenericPlayerPrefRepository<GameSettingEntity>
{
    public const string KEY_IN_PLAYER_PREF = "GameSetting";

    public GameSettingPlayerPrefRepository() : base(KEY_IN_PLAYER_PREF) {}
}
