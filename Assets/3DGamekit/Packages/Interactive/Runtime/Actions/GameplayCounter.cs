using UnityEngine;

namespace Gamekit3D.GameCommands
{

    public class GameplayCounter : GameCommandHandler
    {
        public int currentCount = 0;
        public int targetCount = 3;

        [SerializeField] private AK.Wwise.RTPC ProgressionRTPC;

        [Space]
        [Tooltip("Send a command when increment is performed. (optional)")]
        public SendGameCommand onIncrementSendCommand;
        [Tooltip("Perform an action when increment is performed. (optional)")]
        public GameCommandHandler onIncrementPerformAction;
        [Space]
        [Tooltip("Send a command when target count is reacted. (optional)")]
        public SendGameCommand onTargetReachedSendCommand;
        [Tooltip("Perform an action when target count is reacted. (optional)")]
        public GameCommandHandler onTargetReachedPerformAction;


        public override void PerformInteraction()
        {
            currentCount += 1;
            if (currentCount >= targetCount)
            {
                if (onTargetReachedPerformAction != null) onTargetReachedPerformAction.PerformInteraction();
                if (onTargetReachedSendCommand != null) onTargetReachedSendCommand.Send();
                isTriggered = true;
            }
            else
            {
                if (onIncrementPerformAction != null) onIncrementPerformAction.PerformInteraction();
                if (onIncrementSendCommand != null) onIncrementSendCommand.Send();
                isTriggered = false;
            }

            if (currentCount == 1)
            {
                AkSoundEngine.SetRTPCValue(ProgressionRTPC.Name, 1);
            }
            else if (currentCount == 2)
            {
                AkSoundEngine.SetRTPCValue(ProgressionRTPC.Name, 2);
            }
            else if (currentCount == 3)
            {
                AkSoundEngine.SetRTPCValue(ProgressionRTPC.Name, 3);
            }

            if (currentCount == 2)
            {
                AkSoundEngine.PostEvent("Play_SFX_Door_Open_04", this.gameObject);

            }
        }

    }

}
