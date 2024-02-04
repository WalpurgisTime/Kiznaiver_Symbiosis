using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Newtonsoft.Json;
using System;
using TMPro;

[System.Serializable]
public class InputData
{
    public float Temps;
    public string Arrow;
    public bool IsClicked;
}

[System.Serializable]
public class InputDataList
{
    public List<InputData> inputList;
}

public class SaveFile : MonoBehaviour
{
    [HideInInspector]
    public float Temps;
    [HideInInspector]
    public string Arrow;
    [HideInInspector]
    public bool IsClicked;
    public float DurationTime = 0f;
    public Button IsStarted;
    public Button IsEnded;

    private bool IsStartedMusic;
    public AudioSource audioSource;

    [HideInInspector]
    public List<InputData> inputList = new List<InputData>();

    public bool IsStratedbool;
    public InputField monInputField;

    public string valeurInput;

    [HideInInspector]
    public int Index;
    public TextMeshProUGUI InputText;

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioSource audioSource5;
    public AudioSource audioSource6;
    public AudioSource audioSource7;
    public AudioSource audioSource8;


    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;

    void Start()
    {
        IsStratedbool = false;
        IsStartedMusic = true;
    }

    void Update()
    {
        if (IsStratedbool)
        {
            DurationTime += Time.deltaTime;
        }

        if(IsStratedbool && IsStartedMusic)
        {
            IsStartedMusic = false;
            //audioSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) && IsStratedbool)
        {
            Index++;
            Arrow = "Left";
            Temps = DurationTime;
            IsClicked = false;
            inputList.Add(new InputData { Temps = Temps, Arrow = Arrow, IsClicked = IsClicked });
            InputText.text += "\n La touche" + Index.ToString() + "est " + Arrow + ": " + Temps.ToString();
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) && IsStratedbool)
        {
            Index++;
            Arrow = "Up";
            Temps = DurationTime;
            IsClicked = false;
            inputList.Add(new InputData { Temps = Temps, Arrow = Arrow, IsClicked = IsClicked });
            InputText.text += "\n La touche" + Index.ToString() + "est " + Arrow + ": " + Temps.ToString();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && IsStratedbool)
        {
            Index++;
            Arrow = "Right";
            Temps = DurationTime;
            IsClicked = false;
            inputList.Add(new InputData { Temps = Temps, Arrow = Arrow, IsClicked = IsClicked });
            InputText.text += "\n La touche" + Index.ToString() + "est " + Arrow + ": " + Temps.ToString();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) && IsStratedbool)
        {
            Index++;
            Arrow = "Down";
            Temps = DurationTime;
            IsClicked = false;
            inputList.Add(new InputData { Temps = Temps, Arrow = Arrow, IsClicked = IsClicked });
            InputText.text += "\n La touche" + Index.ToString() + "est " + Arrow + ": " + Temps.ToString();
        }
        if (Input.GetKeyUp(KeyCode.L) && IsStratedbool)
        {
            // Press 'L' to debug the list
            DebugInputList();
        }
    }

    void SaveDataToJson(string filePath)
    {
        InputDataList inputDataList = new InputDataList { inputList = inputList };
        
        string jsonData = JsonConvert.SerializeObject(inputDataList, Formatting.Indented);

        try
        {
            // Check if the directory exists, if not, create it
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Write the JSON file
            File.WriteAllText(filePath, jsonData);
            //Debug.Log($"Input List saved to {filePath}");
        }
        catch (Exception e)
        {
            Debug.LogError($"Error saving JSON: {e.Message}");
        }
    }

    public void OnClickStarted()
    {
        if (IsStarted.interactable && valeurInput != "")
        {
            IsStratedbool = true;
            AudioSource[] audioSources43 = FindObjectsOfType<AudioSource>();

            foreach (AudioSource audioSource43 in audioSources43)
            {
                audioSource43.Stop();
            }

            if(valeurInput == "Fromage")
            {
                audioSource1.Play();
            }
            if(valeurInput == "Carioca")
            {
                audioSource2.Play();
            }
            if(valeurInput == "Gadji")
            {
                audioSource3.Play();
            }
            if(valeurInput == "Paqueta")
            {
                audioSource4.Play();
            }
            if(valeurInput == "XdRipBozo")
            {
                audioSource5.Play();
            }
            if(valeurInput == "WeWindows")
            {
                audioSource6.Play();
            }
            if(valeurInput == "cRAPS")
            {
                audioSource7.Play();
            }
            if(valeurInput == "fEUR")
            {
                audioSource8.Play();
            }
            
            
        }
        else
        {
            Debug.Log("Peux Pas");
        }
    }

    public void OnClickEnd()
    {
        if (IsEnded.interactable && valeurInput != "")
        {
             AudioSource[] audioSources43 = FindObjectsOfType<AudioSource>();

            foreach (AudioSource audioSource43 in audioSources43)
            {
                audioSource43.Stop();
            }
            IsStratedbool = true;
            DebugInputList();
        }
    }

    public void DebugInputList()
    {
        
        //Debug.Log("Input List Content:");
        foreach (var inputData in inputList)
        {
            Debug.Log($"Temps: {inputData.Temps}, Arrow: {inputData.Arrow}, IsClicked: {inputData.IsClicked}");
        }

        // Change the file path as needed
        string buildpath = Path.GetDirectoryName(Application.persistentDataPath);
        string filePath = Path.Combine(buildpath, valeurInput + ".json");
        Debug.Log(filePath + " Save");
        SaveDataToJson(filePath);
        //Debug.Log($"Input List saved to {filePath}");
    }

    public void LoadDataFromJson(string fileName)
    {
        try
        {
            string buildpath = Path.GetDirectoryName(Application.persistentDataPath);
            string filePath = Path.Combine(buildpath, fileName);
            Debug.Log(filePath + " Load");

            if (File.Exists(filePath))
            {
                
                string jsonData = File.ReadAllText(filePath);
                
                InputDataList loadedData = JsonConvert.DeserializeObject<InputDataList>(jsonData);

                if (loadedData != null)
                {
                    inputList = loadedData.inputList;

                    //Debug.Log($"Input List loaded from {filePath}");
                }
                else
                {
                    Debug.LogWarning($"Failed to deserialize JSON from {filePath}");
                }
            }
            else
            {
                Debug.LogWarning($"JSON file not found at {filePath}");
            }
        }
        catch (Exception e)
        {
            Debug.LogError($"Error loading JSON: {e.Message}");
        }
    }

     public void OnClick1()
    {
        if(button5.interactable)
        {
            valeurInput = "Carioca";
        }
    }
    public void OnClick2()
    {
        if(button5.interactable)
        {
            valeurInput = "Fromage";
        }
    }
    public void OnClick3()
    {
        if(button5.interactable)
        {
            valeurInput = "Gadji";
        }
    }
    public void OnClick4()
    {
        if(button5.interactable)
        {
            valeurInput = "Paqueta";
        }
    }
        public void OnClick5()
    {
        if(button5.interactable)
        {
            valeurInput = "XdRipBozo";
        }
    }
        public void OnClick6()
    {
        if(button5.interactable)
        {
            valeurInput = "WeWindows";
            Debug.Log("Cliqué");
        }
    }
        public void OnClick7()
    {
        if(button5.interactable)
        {
            valeurInput = "cRAPS";
        }
    }
        public void OnClick8()
    {
        if(button5.interactable)
        {
            valeurInput = "fEUR";
        }
    }

    

}
