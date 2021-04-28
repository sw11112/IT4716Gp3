using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDown : MonoBehaviour
{
    public static bool canNormalS;
    public static bool canQATK;
    public static bool canLBeam;
    public int magicPowerAmount = 6;
    public int LargeBeamAmount = 1;
    public int QAtkAmount = 1;
    public float Timer = 0;
    public Text normalAmount;
    public Text qatkAmount;
    public Text largeAmount;
    //public Text playerHP;
    public Slider normalSli;
    public Slider QATKSli;
    public Slider LargeSli;
    public Slider DragonHPSli;
    public float normalCool = 18;
    public float qatkCool = 8;
    public float largeCool = 10;


    // Start is called before the first frame update
    void Start()
    {
        normalSli.maxValue = normalCool;
        normalSli.minValue = 0;

        QATKSli.maxValue = qatkCool;
        QATKSli.minValue = 0;

        LargeSli.maxValue = largeCool;
        LargeSli.minValue = 0;

        DragonHPSli.maxValue = DragonCol.DraHP;
        DragonHPSli.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        normalAmount.text=magicPowerAmount.ToString();
        qatkAmount.text = QAtkAmount.ToString();
        largeAmount.text = LargeBeamAmount.ToString();

    }
}
