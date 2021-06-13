using ChainPattern;

namespace RealbizGames.Data
{
    public class GameSettingValidationPieceResult : IAsynPieceResult
    {
        public const string PUBLIC_KEY = "GameSettingValidationPieceResult";

        private bool _success;

        public GameSettingValidationPieceResult(bool success)
        {
            _success = success;
        }

        public bool Success { get => _success; set => _success = value; }

        public string GetKey()
        {
            return PUBLIC_KEY;
        }
    }


}
