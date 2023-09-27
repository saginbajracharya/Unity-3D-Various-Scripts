using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class DialogController : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed = 0.02f;

    // public Animator textDisplayAnim;

    public GameObject continueButton;

    public void Start() 
    {
        continueButton.SetActive(false);
        if(sentences == null){
            Debug.LogError("You forgot to populate the Sentences field before running!");
        }else{
            StartCoroutine(FirstType());
        }
    }

    public void Update() {
        if(textDisplay.text == sentences[index]){
            continueButton.SetActive(true);
        }    
    }

    public IEnumerator FirstType()
    {   
        foreach (char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        continueButton.SetActive(true);
    }

    public IEnumerator Type()
    {   
        foreach (char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence(){
        // textDisplayAnim.SetTrigger("Change");
        continueButton.SetActive(false);
        if(index < sentences.Length - 1){
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else{
            // textDisplay.text = "";
            index = 0;
            SceneManager.LoadScene("level1");
        }
    }

    public void skipScene(){
        continueButton.SetActive(false);
        SceneManager.LoadScene("level1");
    }
}
