// Code originally developed by Richard Gubb (aka BoredMormon)
// To see this code in its original context visit:
// https://www.youtube.com/watch?v=Av8fL2PO2KQ

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MakeUIElement : MonoBehaviour, IPointerClickHandler {
	#region IPointerClickHandler implementation

	[SerializeField] GameObject uiToInstantiate;

	public void OnPointerClick (PointerEventData eventData)
	{
		Vector3 screenPosition = new Vector3(eventData.position.x, eventData.position.y,eventData.pointerPressRaycast.distance);
		Vector3 instantiatePosition = eventData.pressEventCamera.ScreenToWorldPoint(screenPosition);
		GameObject clone = (GameObject)Instantiate (uiToInstantiate, instantiatePosition,eventData.pressEventCamera.transform.rotation);
		clone.transform.SetParent (transform);
	}

	#endregion
}
