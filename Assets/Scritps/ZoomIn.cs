using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    private float initDistance;
    private float newDistance;

    private void Update()
    {
        if(Input.touchCount > 1)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if(touch1.phase == TouchPhase.Began || touch2.phase == TouchPhase.Began)
                initDistance = Vector2.Distance(touch1.position, touch2.position);

            if(touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
            {
                newDistance = Vector2.Distance(touch1.position, touch2.position);

                if(newDistance > initDistance)
                {
                    Debug.Log("Zoom IN");
                }
            }
        }
    }
}
