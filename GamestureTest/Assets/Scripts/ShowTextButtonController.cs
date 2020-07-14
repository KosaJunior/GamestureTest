using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace GamestureTest
{
	public class ShowTextButtonController : MonoBehaviour
	{
		#region variables

		[Header("[ Components references ]")]
		[SerializeField] private Button showTextButton;
		[SerializeField] private GameObject textToShow;

		[Header("[ Settings  ]")]
		[SerializeField] private float displayTime = 3.0f;

		#endregion variables

		#region public methods

		public void ShowText() // inspector method
		{
			StartCoroutine(ShowTextCoroutine());
			SetTextVisibility(true);
		}

		#endregion public methods

		#region private methods

		private IEnumerator ShowTextCoroutine()
		{
			yield return new WaitForSeconds(displayTime);

			SetTextVisibility(false);
		}

		private void SetTextVisibility(bool isVisible)
		{
			showTextButton.interactable = !isVisible;
			textToShow.SetActive(isVisible);
		}

		#endregion private methods
	}
}