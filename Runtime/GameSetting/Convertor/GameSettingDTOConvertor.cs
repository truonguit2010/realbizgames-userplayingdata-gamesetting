using System.Collections;

public class GameSettingDTOConvertor
{
    public static GameSettingDTO From(GameSettingEntity entity) {
        GameSettingDTO dto = new GameSettingDTO();

        dto.Sound = entity.sound;
        dto.Music = entity.music;
        dto.Vibration = entity.vibration;

        return dto;
    }
}
