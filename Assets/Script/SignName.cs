using UnityEngine;
using TMPro;

public class SignName : MonoBehaviour
{
    public TextMeshProUGUI _inputField;
    public TextMeshProUGUI _inputFieldExampleText;
    public TextMeshProUGUI _textArea;

    [SerializeField] private SignatureData _signatureData;

    void Start()
    {
        if (_signatureData != null && _textArea != null)
        {
            _textArea.text = string.Join(", ", _signatureData.signatures);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            PasteInputToTextArea();
    }
    public void OnSelect()
    {
        _inputFieldExampleText.text = string.Empty;
        _inputField.text = string.Empty;
    }

    public void PasteInputToTextArea()
    {
        if (_inputField != null && _textArea != null && _signatureData != null)
        {
            if (!string.IsNullOrWhiteSpace(_inputField.text))
            {
                _signatureData.signatures.Add(_inputField.text);
                _textArea.text = string.Join(", ", _signatureData.signatures);
                _inputField.text = string.Empty;

#if UNITY_EDITOR
                UnityEditor.EditorUtility.SetDirty(_signatureData);
#endif
            }
        }
    }
}
