using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class HudImageChange : MonoBehaviour
{
    // public Image HudTester;
    public Image oldImage;
    public Sprite image0;
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public List<Sprite> batterySprites = new List<Sprite>();
    public int batteryLevel = 0;
    public int lastBatteryLevel = 0;
    public GameObject testingHudCanvas;
    // Start is called before the first frame update
    public void Start()
    {
        
        
        batterySprites.Add(image0);
        batterySprites.Add(image1);
        batterySprites.Add(image2);
        batterySprites.Add(image3);
        batterySprites.Add(image4);     

    }
    public void batteryLevelChanger(int changeValue)
    {
        batteryLevel = changeValue;
    }
    private void ImageChange(Sprite changeTo)
    {
        //tempImage = oldImage.sprite;
        oldImage.sprite = changeTo;
        //newImage = tempImage;
    }

    public void Update()
    {
        ImageChange(batterySprites.ElementAt(batteryLevel));
        batteryLevel++;
        if (batteryLevel > 4) batteryLevel = 0;
    }
    
}
