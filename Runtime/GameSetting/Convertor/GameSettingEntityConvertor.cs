using System.Collections;

public class GameSettingEntityConvertor
{
    public static GameSettingEntity From(GameSettingDTO dto) {
        GameSettingEntity entity = new GameSettingEntity();

        entity.sound = dto.Sound;
        entity.music = dto.Music;
        entity.vibration = dto.Vibration;

        return entity;
    }
}
