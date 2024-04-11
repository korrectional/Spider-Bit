using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public GameObject StartUI;
    public GameObject StartT;
    private TextMeshProUGUI StartIUI;
    public GameObject Panel;
    private Image PanelI;
    public GameObject Button;
    private Transform ButtonI;


    private bool ClearOut = false;
    private int cleaning = 0;
    private Color Target_Opacity;
    private Color Target_OpacityB;

    // Start is called before the first frame update
    void Start()
    {
        PanelI = Panel.GetComponent<Image>();
        ButtonI = Button.GetComponent<Transform>();
        Target_Opacity = PanelI.color;
        Target_Opacity.a = 1;
        Target_OpacityB.a = 0;
        StartIUI = StartT.GetComponent<TextMeshProUGUI>();
                

        
    }

    // Update is called once per frame
    void Update()
    {
        if (ClearOut)
        {
            cleaning+=2;
            if (cleaning > 200)
            {
                cleaning = 0;
                ClearOut = false;
                StartUI.SetActive(false);
                Button.SetActive(false);
            }
            else
            {
                PanelI.color = Color.Lerp(PanelI.color, Target_Opacity, 0.04f);
                
                ButtonI.position = new Vector2(ButtonI.position.x, ButtonI.position.y - 2);

                StartIUI.color = Color.Lerp(PanelI.color, Target_OpacityB, 0.01f);
            }

        }

    }

    public void OpenMenu()
    {
        ClearOut = true;
    }
}
