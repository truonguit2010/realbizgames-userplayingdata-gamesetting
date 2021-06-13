using UnityEngine;
using ChainPattern;

namespace RealbizGames.Data
{
    public class GameSettingValidationPiece : IAsynPieceExecutor
    {
        const string TAG = "GameSettingValidationPiece";

        private IGameSettingService _service;

        private GameSettingValidationPieceResult _response;

        public GameSettingValidationPiece(IGameSettingService service)
        {
            _service = service;
        }

        public bool IsDone => _response != null;

        public IAsynPieceResult Result => _response;

        public void Execute(IAsynChainResult data)
        {
            #if UNITY_EDITOR
            Debug.LogFormat("{0} - Execute", TAG);

            GameSettingDTO dto = _service.Get();

            Debug.LogFormat("{0} - {1}", TAG, dto.ToString());

            Debug.LogFormat("{0} - End", TAG);
            #endif

            _response = new GameSettingValidationPieceResult(success: true);
        }
    }
}