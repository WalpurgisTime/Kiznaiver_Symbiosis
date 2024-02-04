using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.Collections;

public class OtherScript : MonoBehaviour
{
    public SaveFile saveFileScript; // Assurez-vous de faire glisser votre objet SaveFile ici dans l'éditeur Unity
    public GameObject ArrowLeft;
    public GameObject ArrowDown;
    public GameObject ArrowUp;
    public GameObject ArrowRight;

    public GameObject[] Tenga;
    public GameObject[] Tenga2;

    public Button StartGame1;
    public Button StartGame2;
    public Button StartGame3;
    public Button StartGame4;
    public Button StartGame5;
    public Button StartGame6;
    public Button StartGame7;
    public Button StartGame8;

    public bool StartGameBool;
    public string jsonValue;

    public GameObject Canvas;
    public GameObject CanvasUI;

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioSource audioSource5;
    public AudioSource audioSource6;
    public AudioSource audioSource7;
    public AudioSource audioSource8;

    public Animator animator2;
    public AnimationClip clip2;

    private bool boolAudioSource;
    private int Score;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI ComboText;
    private int Combo; 


    public float DurationTime;
    public int Index;

    public TextMeshProUGUI InputText;

    private bool BoolDuration;
    private bool BoolDuration2;
    private int IntDuration;
    private int IntDuration2;

    public TextMeshProUGUI WinOrNot;
    public TextMeshProUGUI Now;
    public TextMeshProUGUI MissText;
    
    public int LastIndex;
    private bool LastIndexbool;

    private bool Fait;
    private bool Maintenant;
    public int Miss;

    public Image imageColor;
    public Slider progressBarImage;


    
    public Slider progressBar;




    void Start()
    {
        StartGameBool = false;
        BoolDuration = true;
        BoolDuration2 = true;
        boolAudioSource = true;
        Fait = false;




    }

    void Update()
    {
        if(StartGameBool)
        {
            DurationTime += Time.deltaTime;

            if(DurationTime>1 && boolAudioSource)
            {
                boolAudioSource = false;
                progressBar.minValue = 0f;
                progressBar.value = 0f;
                progressBarImage.maxValue = 10f;

                progressBarImage.minValue = 0f;
                progressBarImage.value = 0f;
                //Debug.Log("lu");
                if(jsonValue == "Fromage.json")
                {
                    audioSource1.Play();
                    progressBar.maxValue = audioSource1.clip.length;
                    StartCoroutine(UpdateProgressBar(audioSource1));
                }
                if(jsonValue == "Carioca.json")
                {
                    audioSource2.Play();
                    progressBar.maxValue = audioSource2.clip.length;
                    StartCoroutine(UpdateProgressBar(audioSource2));
                }
                if(jsonValue == "Gadji.json")
                {
                    audioSource3.Play();
                    progressBar.maxValue = audioSource3.clip.length;
                    StartCoroutine(UpdateProgressBar(audioSource3));
                }
                if(jsonValue == "Paqueta.json")
                {
                    audioSource4.Play();
                    progressBar.maxValue = audioSource4.clip.length;
                    StartCoroutine(UpdateProgressBar(audioSource4));
                }
                if(jsonValue == "XdRipBozo.json")
                {
                    audioSource5.Play();
                    progressBar.maxValue = audioSource5.clip.length;
                    StartCoroutine(UpdateProgressBar(audioSource5));
                }
                if(jsonValue == "WeWindows.json")
                {
                    audioSource6.Play();
                    progressBar.maxValue = audioSource6.clip.length;
                    StartCoroutine(UpdateProgressBar(audioSource6));
                }
                if(jsonValue == "cRAPS.json")
                {
                    audioSource7.Play();
                    progressBar.maxValue = audioSource7.clip.length;
                    StartCoroutine(UpdateProgressBar(audioSource7));
                }
                if(jsonValue == "fEUR.json")
                {
                    audioSource8.Play();
                    progressBar.maxValue = audioSource8.clip.length;
                    StartCoroutine(UpdateProgressBar(audioSource8));
                }
                
                //Debug.Log("Played");
            }

            saveFileScript.LoadDataFromJson(jsonValue);
            //Debug.Log(saveFileScript.inputList.Count);
            if(Index < saveFileScript.inputList.Count-1);
            {


                //Debug.Log(Math.Round(DurationTime, 1).ToString()+"l'autre valeur " +  Math.Round(saveFileScript.inputList[Index].Temps - 1f, 1).ToString());
                if (Math.Round(DurationTime, 1) == Math.Round(saveFileScript.inputList[Index].Temps + 1f, 1))
                {
    
                    if(saveFileScript.inputList[Index].Arrow == "Left")
                    {
                        GameObject Arrow = Instantiate(ArrowLeft, new Vector3(3000f, 200f, transform.position.z),transform.rotation);
                        Arrow.name = "Arrow" + Index.ToString();
                    }
                    if(saveFileScript.inputList[Index].Arrow == "Right")
                    {
                        GameObject Arrow = Instantiate(ArrowRight, new Vector3(3000f,200f, transform.position.z),transform.rotation);
                        Arrow.name = "Arrow" + Index.ToString();
                    }
                    if(saveFileScript.inputList[Index].Arrow == "Up")
                    {
                        GameObject Arrow = Instantiate(ArrowUp, new Vector3(3000f, 200f, transform.position.z),transform.rotation);
                        Arrow.name = "Arrow" + Index.ToString();
                    }
                    if(saveFileScript.inputList[Index].Arrow == "Down")
                    {
                        GameObject Arrow = Instantiate(ArrowDown, new Vector3(3000f, 200f, transform.position.z),transform.rotation);
                        Arrow.name = "Arrow" + Index.ToString();
                    }

                    
                    //Debug.Log(Index.ToString()+ "  " + (saveFileScript.inputList.Count-1).ToString());
                    if(Index < saveFileScript.inputList.Count-1)
                    {
                        Index++;
                    }
                    
                }

                
                 if ((Math.Round(DurationTime, 1) > Math.Round(saveFileScript.inputList[LastIndex].Temps + 0.5f, 1)) &&
                            (Math.Round(DurationTime, 1) < Math.Round(saveFileScript.inputList[LastIndex].Temps + 2.1f, 1)))
                {
                    GameObject arrow0 = GameObject.Find("Arrow" + LastIndex.ToString());
 
                    arrow0.transform.localScale = new Vector3((float)53.98, (float)43.55, 1.00f) * 4.00f;

                    imageColor.color = Color.green;
                    Now.text = "Now";
                    

                }
                else
                {
                    imageColor.color = Color.red;

                    Now.text = "Not yet";

                    
                }

                if (Math.Round(DurationTime, 1) == Math.Round(saveFileScript.inputList[LastIndex].Temps + 2f, 1))
                {
                    InputText.text = saveFileScript.inputList[LastIndex].Arrow + " Touche : " + (LastIndex+1).ToString();
                    if(LastIndex < saveFileScript.inputList.Count-1)
                    {
                        LastIndex++;
                        Fait = false;
                        
                        if(Maintenant == false)
                        {
                            Miss++;
                            Combo = 0;

                            ComboText.text = "X"+Combo.ToString();
                            MissText.text = Miss.ToString() + " Miss";
                            float currentvalue = Miss;
                            if(Miss>10)
                            {
                                currentvalue = 10f;
                            }
                            if(Miss<0)
                            {
                                currentvalue = 0f;
                            }
                            
                            
                            progressBarImage.value = currentvalue;
                        
                        }
                        else
                        {
                            Combo += 1;
                            Score+=10*Combo;

                            ComboText.text = "X"+Combo.ToString();
                            Miss -= 2;
                        }
                        Maintenant = false;
                        ScoreText.text = Score.ToString();
                        
                    }
                }


                if(Math.Round(saveFileScript.inputList[Index].Temps + 1f, 1)<Math.Round(DurationTime, 1))
                {
                    if(Index < saveFileScript.inputList.Count-1)
                    {
                        Index++;
                    }
                }

                if (Input.GetKeyUp(KeyCode.LeftArrow))
                {
                    string CurrentClickedArrow = "Left";
                    
                    if (saveFileScript.inputList[LastIndex].Arrow == CurrentClickedArrow && Fait)
                    {
                        if ((Math.Round(DurationTime, 1) > Math.Round(saveFileScript.inputList[LastIndex].Temps + 0.5f, 1)) &&
                            (Math.Round(DurationTime, 1) < Math.Round(saveFileScript.inputList[LastIndex].Temps + 2.1f, 1)))
                        {
                            WinOrNot.text = "Bien";
                            Maintenant = true;
                        }
                        else
                        {
                            WinOrNot.text = "Pas juste";
                        }
                        Fait = true;
                    }
                    else
                    {
                        WinOrNot.text = "Pas bien";
                        Fait = true;
                    }
                }



                
                if (Input.GetKeyUp(KeyCode.RightArrow))
                {
                    string CurrentClickedArrow = "Right";

                    if (saveFileScript.inputList[LastIndex].Arrow == CurrentClickedArrow && Fait)
                    {
                        if ((Math.Round(DurationTime, 1) > Math.Round(saveFileScript.inputList[LastIndex].Temps + 0.5f, 1)) &&
                            (Math.Round(DurationTime, 1) < Math.Round(saveFileScript.inputList[LastIndex].Temps + 2.1f, 1)))
                        {
                            
                            WinOrNot.color = Color.green;
                            animator2.Play(clip2.name,0,0);
                            WinOrNot.text = "Bien";
                            
                            Maintenant = true;
                        }
                        else
                        {
                            WinOrNot.color = Color.red;
                            animator2.Play(clip2.name,0,0);
                            WinOrNot.text = "Pas juste";
                            
                        }
                        Fait = true;
                    }
                    else
                    {
                        WinOrNot.color = Color.red;
                        animator2.Play(clip2.name,0,0);
                        WinOrNot.text = "Pas bien";
                        
                        Fait = true;
                    }
                }
                
                if (Input.GetKeyUp(KeyCode.UpArrow))
                {
                    string CurrentClickedArrow = "Up";

                    if (saveFileScript.inputList[LastIndex].Arrow == CurrentClickedArrow && Fait)
                    {
                        if ((Math.Round(DurationTime, 1) > Math.Round(saveFileScript.inputList[LastIndex].Temps + 0.5f, 1)) &&
                            (Math.Round(DurationTime, 1) < Math.Round(saveFileScript.inputList[LastIndex].Temps + 2.1f, 1)))
                        {
                            WinOrNot.text = "Bien";
                            Maintenant = true;
                            
                        }
                        else
                        {
                            WinOrNot.text = "Pas juste";
                        }
                        Fait = true;
                    }
                    else
                    {
                        WinOrNot.text = "Pas bien";
                        Fait = true;
                    }
                }

                if (Input.GetKeyUp(KeyCode.DownArrow))
                {
                    string CurrentClickedArrow = "Down";

                    if (saveFileScript.inputList[LastIndex].Arrow == CurrentClickedArrow && Fait)
                    {
                        if ((Math.Round(DurationTime, 1) > Math.Round(saveFileScript.inputList[LastIndex].Temps + 0.5f, 1)) &&
                            (Math.Round(DurationTime, 1) < Math.Round(saveFileScript.inputList[LastIndex].Temps + 2.1f, 1)))
                        {
                            WinOrNot.text = "Bien";
                            Maintenant = true;
                        }
                        else
                        {
                            WinOrNot.text = "Pas juste";
                        }
                        Fait = true;
                    }
                    else
                    {
                        WinOrNot.text = "Pas bien";
                        Fait = true;
                    }
                }


            
            }
            Tengafunction();
            Tengafunction2();

            

        }
    }

    public void OnClickStart1()
    {
        if(StartGame1.interactable)
        {
            StartGameBool = true;
            Canvas.SetActive(false);
            jsonValue = "Fromage.json";
            CanvasUI.SetActive(true);
            
            
            
        }
    }

    public void OnClickStart2()
    {
        if(StartGame2.interactable)
        {
            StartGameBool = true;
            Canvas.SetActive(false);
            jsonValue = "Carioca.json";
            CanvasUI.SetActive(true);
        }
    }

    public void OnClickStart3()
    {
        if(StartGame3.interactable)
        {
            StartGameBool = true;
            Canvas.SetActive(false);
            jsonValue = "Gadji.json";
            CanvasUI.SetActive(true);
        }
    }
    public void OnClickStart4()
    {
        if(StartGame4.interactable)
        {
            StartGameBool = true;
            Canvas.SetActive(false);
            jsonValue = "Paqueta.json";
            CanvasUI.SetActive(true);
        }
    }
    public void OnClickStart5()
    {
        if(StartGame5.interactable)
        {
            StartGameBool = true;
            Canvas.SetActive(false);
            jsonValue = "XdRipBozo.json";
            CanvasUI.SetActive(true);
        }
    }
    public void OnClickStart6()
    {
        if(StartGame6.interactable)
        {
            StartGameBool = true;
            Canvas.SetActive(false);
            jsonValue = "WeWindows.json";
            CanvasUI.SetActive(true);
        }
    }
    public void OnClickStart7()
    {
        if(StartGame7.interactable)
        {
            StartGameBool = true;
            Canvas.SetActive(false);
            jsonValue = "cRAPS.json";
            CanvasUI.SetActive(true);
        }
    }
    public void OnClickStart8()
    {
        if(StartGame8.interactable)
        {
            StartGameBool = true;
            Canvas.SetActive(false);
            jsonValue = "Feur.json";
            CanvasUI.SetActive(true);
        }
    }


    private void Tengafunction2()
    {
        
        if(BoolDuration2)
        {
            BoolDuration2 = false;
            if(IntDuration2==48)
            {
                IntDuration2 = 0;
            }
            
            foreach(var element in Tenga2)
            {
                if(element == Tenga2[IntDuration2])
                {
                    Tenga2[IntDuration2].SetActive(true);
                }
                else
                {
                    element.SetActive(false);
                }
            }
            IntDuration2++;
            Invoke("BoolTime2",0.2f);
        }
    }

    private void Tengafunction()
    {
        
        if(BoolDuration)
        {
            BoolDuration = false;
            if(IntDuration==48)
            {
                IntDuration = 0;
            }
            //Debug.Log("C'est activé");
            foreach(var element in Tenga)
            {
                if(element == Tenga[IntDuration])
                {
                    Tenga[IntDuration].SetActive(true);
                    
                }
                else
                {
                    element.SetActive(false);
                }
            }
            IntDuration++;
            Invoke("BoolTime",0.2f);
        }
    }

    private void BoolTime()
    {
        BoolDuration = true;
    }

    private void BoolTime2()
    {
        BoolDuration2 = true;
    }

    private void GetTime()
    {
        InputText.text = saveFileScript.inputList[LastIndex].Arrow + " Touche : " + (LastIndex+1).ToString();
        Debug.Log("Index " + Index.ToString());
        Debug.Log("Index2 " + LastIndex.ToString());
    }
    


    

    public IEnumerator UpdateProgressBar(AudioSource ui)
    {
        while (ui.isPlaying)
        {
            Debug.Log("On y est ");
            progressBar.value = ui.time;
            yield return new WaitForSeconds(0.1f);
        }
        progressBar.value = ui.clip.length;
    }





}