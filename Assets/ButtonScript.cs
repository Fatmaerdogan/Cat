using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
    public GameObject ıdle;
    public GameObject walk;
    public GameObject sound;
    public GameObject eat;
    public GameObject jump;
    private void Start()
    {
        sound.SetActive(false);
        walk.SetActive(false);
        eat.SetActive(false);
        jump.SetActive(false);
    }
    public void Jump()
    {
        ıdle.SetActive(false);
        sound.SetActive(false);
        walk.SetActive(false);
        eat.SetActive(false);
        jump.SetActive(true);
    }
    public void Sound()
    {
        ıdle.SetActive(false);
        sound.SetActive(true);
        walk.SetActive(false);
        eat.SetActive(false);
        jump.SetActive(false);
    }
    public void Walk()
    {
        ıdle.SetActive(false);
        sound.SetActive(false);
        walk.SetActive(true);
        eat.SetActive(false);
        jump.SetActive(false);
    }
    public void Idle()
    {
        ıdle.SetActive(true);
        sound.SetActive(false);
        walk.SetActive(false);
        eat.SetActive(false);
        jump.SetActive(false);
    }
    public void Eat()
    {
        ıdle.SetActive(false);
        sound.SetActive(false);
        walk.SetActive(false);
        eat.SetActive(true);
        jump.SetActive(false);
    }
}
