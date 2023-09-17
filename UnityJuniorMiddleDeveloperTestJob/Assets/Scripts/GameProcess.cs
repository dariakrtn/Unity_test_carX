using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameProcess : MonoBehaviour
{
    // если снаряд или шар касается врага, враг исчезает и пуля или шар тоже
    // на лайбе менятся текст +2 очка
    // когда игрок набирает 100 очков игра заканчивается

    [SerializeField]
    private TMP_Text _title;

    public GameObject cannon;
    public GameObject crystal;
    public GameObject monster;

    void Start()
    {
        _title.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (cannon != null || crystal != null || monster != null)
            return;

        
    }
}
