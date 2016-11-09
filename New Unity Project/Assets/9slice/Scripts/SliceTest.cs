using UnityEngine;
using UnityEngine.UI;

public class SliceTest : MonoBehaviour {

    [SerializeField]
    Image _image;

    float x = 0;
    float y = 0;

    int xMax = 0;
    int xMin = 0;
    int yMax = 0;
    int yMin = 0;

    bool isX = false;
    bool isY = false;

	// Use this for initialization
	void Start () {
        x = _image.rectTransform.sizeDelta.x;
        y = _image.rectTransform.sizeDelta.y;

        xMax = Random.Range (40, 200);
        xMin = Random.Range (0, 20);
        yMax = Random.Range (40, 200);
        yMin = Random.Range (0, 20);
	}
	
	// Update is called once per frame
	void Update () {

        if (isX && x > xMax) 
        {
            isX = false;
        } 
        else if (!isX && x < xMin)
        {
            isX = true;
        }

        if (isY && y > yMax) 
        {
            isY = false;
        } 
        else if (!isY && y < yMin)
        {
            isY = true;
        }

        if(isX)
        {
            x++;
        }
        else
        {
            x--;
        }

        if(isY)
        {
            y++;
        }
        else
        {
            y--;
        }

        _image.rectTransform.sizeDelta = new Vector2 (x, y);
	}
}
