﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour {
    public Text scoreText;

	void Start () {
        scoreText.text = Game.timeScore.ToString();
	}
}
