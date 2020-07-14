using UnityEngine;
using UnityEngine.UI;

namespace GamestureTest
{
    public class SoundToggle : MonoBehaviour
    {
        #region variables

        [Header("[ Components references ]")]
        [SerializeField] private Toggle toggle;
        [SerializeField] private RandomSoundPlayer randomSoundPlayer;

        [Space]
        [SerializeField] private AudioClip audioClip;

        #endregion variables

        #region constructor & inits

        private void Awake()
        {
            toggle.SetIsOnWithoutNotify(false);
        }

        #endregion constructor & inits

        #region public methods

        public void ToggleSoundInPlayer(bool isAddedToPlayer)
        {
            if (isAddedToPlayer)
            {
                randomSoundPlayer.AddSound(audioClip);
            }
            else
            {
                randomSoundPlayer.RemoveSound(audioClip);
            }
        }

        #endregion public methods
    }
}