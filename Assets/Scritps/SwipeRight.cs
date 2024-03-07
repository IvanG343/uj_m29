using UnityEngine;

public class SwipeRight : MonoBehaviour
{
    private Vector2 startPos;
    private Vector2 endPos;

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //Фиксируем начало тапа
            if(touch.phase == TouchPhase.Began) startPos = touch.position;
            //Фиксируем конец тапа
            if(touch.phase == TouchPhase.Ended) endPos = touch.position;

            DetectSwipeRigth();
        }
    }

    private void DetectSwipeRigth()
    {
        Vector2 delta = endPos - startPos;
        if (delta.x >= 100 && Mathf.Abs(delta.y) <= 50)
        {
            Debug.Log($"Success, Start {startPos}; End {endPos}");
            Debug.Log($"Delta X {delta.x}; Delta Y {delta.y}");

            //Если не сбросить значения, то консоль детектит лишние касания, возможно сравнивает позицию текущего тапа с предыдущим и считает как за свайп.
            startPos = new Vector2();
            endPos = new Vector2();
        }
    }

}
