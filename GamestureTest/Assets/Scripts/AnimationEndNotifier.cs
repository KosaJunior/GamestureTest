using UnityEngine;
using UnityEngine.Events;

namespace GamestureTest
{
    public class AnimationEndNotifier : MonoBehaviour
    {
        public UnityEvent OnAnimationEnd;

        public void NotifyAnimationEnd()
        {
            OnAnimationEnd?.Invoke();
        }
    }
}