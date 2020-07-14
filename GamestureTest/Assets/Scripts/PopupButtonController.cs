using UnityEngine;

namespace GamestureTest
{
	public class PopupButtonController : MonoBehaviour
	{
		#region variables

		[Header("[ Components references ]")]
		[SerializeField] private GameObject popupGameObject;
		[SerializeField] private Animator popupAnimatorController;

		[Header("[ Settings  ]")]
		[SerializeField] private string popupTriggerParamName = "RunAnimation";

		#endregion variables

		#region properties

		private int PopupTriggerParamId => Animator.StringToHash(popupTriggerParamName);

		#endregion properties

		#region public methods

		public void ShowPopup() // inspector method
		{
			popupGameObject.SetActive(true);
			SetPopupTrigger();
		}

		public void HidePopup() // inspector method
		{
			SetPopupTrigger();
		}

		#endregion public methods

		#region private methods

		private void SetPopupTrigger()
		{
			popupAnimatorController.SetTrigger(PopupTriggerParamId);
		}

		#endregion private methods
	}
}