using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour 
{
	private Ray m_Ray;
	private RaycastHit m_RayCastHit;
	private TouchableObject m_CurrentTouchableObject;

	void Update () 
	{
		if(Input.touches.Length == 1)
		{
			Touch touchedFinger = Input.touches[0];

			switch(touchedFinger.phase)
			{
			case TouchPhase.Ended: 
				m_Ray = Camera.main.ScreenPointToRay(touchedFinger.position);
				if(Physics.Raycast(m_Ray.origin, m_Ray.direction, out m_RayCastHit, Mathf.Infinity))
				{
					TouchableObject touchableObj = m_RayCastHit.collider.gameObject.GetComponent<TouchableObject>();
					if(touchableObj)
					{
						m_CurrentTouchableObject = touchableObj;
						//a TouchableObject selected, so set the text in here...
					}
					else //nothing is selected
					{
						if(m_CurrentTouchableObject)   
						{
							m_CurrentTouchableObject = null;
							// reset the text back... 
						}
					}

				}
				break;
			default:
				break;
			}
		}
	}
}