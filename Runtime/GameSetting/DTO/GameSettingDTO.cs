

public class GameSettingDTO
{

    public static GameSettingDTO defaultValue {
        get {
            GameSettingDTO dto = new GameSettingDTO();

            dto.Sound = true;
            dto.Music = true;
            dto.Vibration = true;
            
            return dto;
        }
    }

    private bool _sound;

    private bool _music;

    private bool _vibration;

    public bool Sound { get => _sound; set => _sound = value; }
    public bool Music { get => _music; set => _music = value; }
    public bool Vibration { get => _vibration; set => _vibration = value; }

    public override string ToString()
    {
        return ToStringUtils.ToStringFor(this);
    }
}
