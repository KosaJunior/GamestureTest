using System.Collections.Generic;
using UnityEngine;

namespace GamestureTest
{
    [RequireComponent(typeof(AudioSource))]
    public class RandomSoundPlayer : MonoBehaviour
    {
        #region variables

        [Header("[ Components references ]")]
        [SerializeField] private AudioSource audioSource;

        private List<AudioClip> selectedSounds = new List<AudioClip>();

        #endregion variables

        #region public methods

        public void PlayRandomSound() // inspector method
        {
            if (CanGetRandomAudioClip() == false) return;

            audioSource.PlayOneShot(GetRandomAudioClip());
        }

        public void AddSound(AudioClip audioClip)
        {
            selectedSounds.Add(audioClip);
        }

        public void RemoveSound(AudioClip audioClip)
        {
            selectedSounds.Remove(audioClip);
        }

        #endregion public methods

        #region private methods

        private AudioClip GetRandomAudioClip()
        {
            var randomClip = selectedSounds[new System.Random().Next(0, selectedSounds.Count)];
            return randomClip;
        }

        private bool CanGetRandomAudioClip()
        {
            return selectedSounds.Count > 0;
        }

        #endregion private methods
    }
}