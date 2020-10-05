using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public static int Collectibles;
    public static int selectedCharacterIndex;
    private Color desiredColor;
    private readonly string selectedCharacter = "SelectedCharacter";



    [Header("List of characters")]
    [SerializeField] private List<CharacterSelectObject> characterList = new List<CharacterSelectObject>();


    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] private Image characterSplash;
    [SerializeField] private Image backgroundColor;
    [SerializeField] private TextMeshProUGUI description;

    [Header("Sounds")]
    [SerializeField] private AudioClip arrowClicksFX;
    [SerializeField] private AudioClip characterSelectMusic;

    private void Start()
    {
        UpdateCharacterSelectionUI();
        Debug.Log(string.Format("Collecionables en select {0}", Win.Collectibles));
    }

    public void LeftArrow()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
            selectedCharacterIndex = characterList.Count - 1;
        UpdateCharacterSelectionUI();
        PlayerPrefs.SetInt(selectedCharacter, selectedCharacterIndex);
    }

    public void Right()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == characterList.Count)
            selectedCharacterIndex = 0;
        UpdateCharacterSelectionUI();
        PlayerPrefs.SetInt(selectedCharacter, selectedCharacterIndex);
    }

    public void Confirm()
    {
        Debug.Log(string.Format("Character{0}:{1}:{2}: has been chosen", selectedCharacterIndex, characterList[selectedCharacterIndex].characterName));
    }

    private void UpdateCharacterSelectionUI()
    {
        //Splash, name, desired color
        characterSplash.sprite = characterList[selectedCharacterIndex].splash;
        characterName.text = characterList[selectedCharacterIndex].characterName;
        desiredColor = characterList[selectedCharacterIndex].characterColor;
        description.text = characterList[selectedCharacterIndex].description;


    }

    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public string characterName;
        public string description;
        public Color characterColor;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
