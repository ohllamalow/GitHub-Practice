using System;
using UnityEngine;
using TMPro;

public class SignName : MonoBehaviour
{
    public TextMeshProUGUI inputField;
    public TextMeshProUGUI inputFieldExampleText;
    public TextMeshProUGUI textArea;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            PasteInputToTextArea();
    }

    void Start()
    {
        if (textArea != null)
            textArea.text = PlayerPrefs.GetString("SavedTextArea", "");
    }

    public void OnSelect()
    {
        inputFieldExampleText.text = String.Empty;
        inputField.text = String.Empty;
    }

    public void PasteInputToTextArea()
    {
        if (inputField != null && textArea != null)
        {
            if (!string.IsNullOrEmpty(textArea.text))
                textArea.text += ", ";
            textArea.text += inputField.text;

            inputField.text = string.Empty;

            PlayerPrefs.SetString("SavedTextArea", textArea.text);
            PlayerPrefs.Save();
        }
    }
}
